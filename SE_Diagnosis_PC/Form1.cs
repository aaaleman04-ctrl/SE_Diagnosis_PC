using SE_Diagnosis_PC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SE_Diagnosis_PC   // <-- CAMBIA esto por el namespace de tu proyecto
{
    public partial class Form1 : Form
    {
        // Base de conocimientos y registro de lo que hizo el motor
        private List<Regla> reglas;
        private List<string> traza = new List<string>();

        public Form1()
        {
            InitializeComponent();
            InicializarReglas();
        }

        // =====================================================================
        //  BASE DE CONOCIMIENTOS
        //  Los hechos son cadenas; un CheckBox marcado agrega su hecho al HashSet.
        //  "No marcado" se expresa con !h.Contains(...)
        // =====================================================================
        private void InicializarReglas()
        {
            reglas = new List<Regla>
            {
                // ---------- 1. ENERGÍA ----------
                new Regla("E1: No enciende -> Problema de energía",
                    h => !h.Contains("enciende") && !h.Contains("ventiladores_1s"),
                    "Problema:Energia"),

                new Regla("E2: Ventiladores giran 1 s y se apagan -> Problema de energía",
                    h => h.Contains("ventiladores_1s"),
                    "Problema:Energia"),

                new Regla("E3: Energía + cable y regleta bien -> Fuente de poder",
                    h => h.Contains("Problema:Energia") && h.Contains("cable_ok") && !h.Contains("ventiladores_1s"),
                    "Falla:FuentePoder",
                    "Probar con otra fuente de poder que funcione.",
                    prioridad: 5, esDiagnostico: true),

                new Regla("E4: Ventiladores giran 1 s y se apagan -> Placa madre",
                    h => h.Contains("Problema:Energia") && h.Contains("ventiladores_1s"),
                    "Falla:PlacaMadre",
                    "Se revisa en persona.",
                    prioridad: 5, esDiagnostico: true),

                // (Regla añadida por coherencia: cable/regleta en mal estado)
                new Regla("E5: Energía + cable o regleta mal -> Cable/regleta",
                    h => h.Contains("Problema:Energia") && !h.Contains("cable_ok") && !h.Contains("ventiladores_1s"),
                    "Falla:CableRegleta",
                    "Cambiar el cable de corriente o la regleta y volver a probar.",
                    prioridad: 5, esDiagnostico: true),

                // ---------- 2. IMAGEN / VIDEO / MEMORIA ----------
                new Regla("M1: Enciende, sin imagen y con pitidos -> Problema de memoria",
                    h => h.Contains("enciende") && !h.Contains("imagen") && h.Contains("pitidos"),
                    "Problema:Memoria"),

                new Regla("M2: Problema de memoria -> RAM",
                    h => h.Contains("Problema:Memoria"),
                    "Falla:RAM",
                    "Se sacan los módulos, se limpian los contactos y se vuelven a colocar.",
                    prioridad: 3, esDiagnostico: true),

                new Regla("V1: Enciende, sin imagen y sin pitidos -> Problema de video",
                    h => h.Contains("enciende") && !h.Contains("imagen") && !h.Contains("pitidos"),
                    "Problema:Video"),

                new Regla("V2: Problema de video + monitor sin ninguna luz -> Monitor",
                    h => h.Contains("Problema:Video") && !h.Contains("luz_monitor"),
                    "Falla:Monitor",
                    "Se reemplaza o se repara el monitor.",
                    prioridad: 6, esDiagnostico: true),

                new Regla("V3: Monitor con luz 'sin señal' + imagen en placa madre -> Tarjeta de video",
                    h => h.Contains("Problema:Video") && h.Contains("luz_monitor") && h.Contains("sin_senal")
                         && h.Contains("imagen_placa"),
                    "Falla:TarjetaVideo",
                    "Se reemplaza la tarjeta de video dedicada.",
                    prioridad: 6, esDiagnostico: true),

                new Regla("V4: Monitor con luz 'sin señal' + sin imagen en placa madre -> Cable de video",
                    h => h.Contains("Problema:Video") && h.Contains("luz_monitor") && h.Contains("sin_senal")
                         && !h.Contains("imagen_placa"),
                    "Falla:CableVideo",
                    "Se cambia el cable de video.",
                    prioridad: 6, esDiagnostico: true),

                // ---------- 3. TEMPERATURA Y RENDIMIENTO ----------
                new Regla("T1: Se reinicia tras un rato o con programas pesados -> Sobrecalentamiento",
                    h => h.Contains("enciende") && h.Contains("imagen") && h.Contains("reinicia_rato"),
                    "Falla:Sobrecalentamiento",
                    "Se limpian ventiladores y disipador, y se cambia la pasta térmica.",
                    prioridad: 2, esDiagnostico: true),

                new Regla("T2: Lenta y caliente -> Sobrecalentamiento",
                    h => h.Contains("enciende") && h.Contains("imagen") && h.Contains("lenta") && h.Contains("caliente"),
                    "Falla:Sobrecalentamiento",
                    "Se limpian ventiladores y disipador, y se cambia la pasta térmica.",
                    prioridad: 2, esDiagnostico: true),

                new Regla("T3: Se reinicia al azar (incluso recién encendida) -> Fuente de poder",
                    h => h.Contains("enciende") && h.Contains("imagen") && h.Contains("reinicia_azar"),
                    "Falla:FuentePoder",
                    "Probar con otra fuente de poder que funcione.",
                    prioridad: 4, esDiagnostico: true),

                new Regla("T4: Lenta + clics en el disco o archivos que no abren -> Disco duro",
                    h => h.Contains("enciende") && h.Contains("imagen") && h.Contains("lenta")
                         && (h.Contains("disco_clic") || h.Contains("archivos_no_abren")),
                    "Falla:DiscoDuro",
                    "Se respalda la información de inmediato y después se reemplaza el disco, de preferencia por uno de estado sólido.",
                    prioridad: 1, esDiagnostico: true),

                new Regla("T5: Lenta, sin ruidos y sin otros síntomas -> No es falla de hardware",
                    h => h.Contains("enciende") && h.Contains("imagen") && h.Contains("lenta")
                         && !h.Contains("disco_clic") && !h.Contains("archivos_no_abren")
                         && !h.Contains("caliente") && !h.Contains("reinicia_rato") && !h.Contains("reinicia_azar"),
                    "NoEsFallaHardware",
                    "No es falla de hardware: revisar software (virus, programas de inicio, actualizaciones).",
                    prioridad: 99, esDiagnostico: true)
            };
        }

        // =====================================================================
        //  MOTOR DE INFERENCIA (encadenamiento hacia adelante)
        //  1) Recorre las reglas; si una se cumple y no se había disparado, agrega su conclusión a los hechos.
        //  2) Repite hasta que ninguna regla nueva se dispare (punto fijo).
        //  3) Entre los diagnósticos obtenidos, elige el de MENOR número de prioridad.
        //  Devuelve la regla ganadora, o null si no hay diagnóstico.
        // =====================================================================
        private Regla Motor(List<Regla> reglas, HashSet<string> hechos)
        {
            traza.Clear();
            var disparadas = new HashSet<Regla>();
            var diagnosticos = new List<Regla>();
            bool huboCambios;

            do
            {
                huboCambios = false;

                foreach (Regla r in reglas)
                {
                    if (disparadas.Contains(r)) continue;   // cada regla se dispara una sola vez

                    if (r.Condicion(hechos))
                    {
                        disparadas.Add(r);
                        hechos.Add(r.Conclusion);           // nuevo hecho en la memoria de trabajo
                        traza.Add("Se disparó: " + r.Nombre);

                        if (r.EsDiagnostico)
                            diagnosticos.Add(r);

                        huboCambios = true;                 // un hecho nuevo puede activar otras reglas
                    }
                }
            } while (huboCambios);

            if (diagnosticos.Count == 0)
                return null;                                // sin síntomas de hardware: no hay diagnóstico

            // Resolución de conflictos: menor Prioridad = más importante (1 disco, 2 calor, 3 RAM, ...)
            Regla ganadora = diagnosticos.OrderBy(d => d.Prioridad).First();
            traza.Add("Prioridad ganadora: " + ganadora.Nombre + " (prioridad " + ganadora.Prioridad + ")");
            return ganadora;
        }

        // =====================================================================
        //  EVENTOS DE LA INTERFAZ
        // =====================================================================
        private HashSet<string> CapturarHechos()
        {
            var hechos = new HashSet<string>();

            if (chkEnciende.Checked) hechos.Add("enciende");
            if (chkVentiladores1s.Checked) hechos.Add("ventiladores_1s");
            if (chkCableRegletaBien.Checked) hechos.Add("cable_ok");
            if (chkImagen.Checked) hechos.Add("imagen");
            if (chkPitidos.Checked) hechos.Add("pitidos");
            if (chkLuzMonitor.Checked) hechos.Add("luz_monitor");
            if (chkSinSenal.Checked) hechos.Add("sin_senal");
            if (chkImagenPlacaMadre.Checked) hechos.Add("imagen_placa");
            if (chkReiniciaRato.Checked) hechos.Add("reinicia_rato");
            if (chkReiniciaAzar.Checked) hechos.Add("reinicia_azar");
            if (chkLenta.Checked) hechos.Add("lenta");
            if (chkCaliente.Checked) hechos.Add("caliente");
            if (chkDiscoClic.Checked) hechos.Add("disco_clic");
            if (chkArchivosNoAbren.Checked) hechos.Add("archivos_no_abren");

            return hechos;
        }

        private void btnDiagnosticar_Click(object sender, EventArgs e)
        {
            HashSet<string> hechos = CapturarHechos();

            if (hechos.Count == 0)
            {
                MessageBox.Show("Marque al menos un síntoma observado.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Regla resultado = Motor(reglas, hechos);

            if (resultado == null)
            {
                txtDiagnostico.Text = "No hay diagnóstico";
                txtAccion.Text = "No se detectó ningún síntoma de hardware con los datos ingresados.";
            }
            else
            {
                txtDiagnostico.Text = resultado.Conclusion.Replace("Falla:", "");
                txtAccion.Text = resultado.Accion;
            }

            txtTraza.Text = string.Join(Environment.NewLine, traza);

            MessageBox.Show("Diagnóstico: " + txtDiagnostico.Text + Environment.NewLine +
                            "Acción: " + txtAccion.Text,
                            "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is CheckBox) ((CheckBox)c).Checked = false;
            }
            txtDiagnostico.Clear();
            txtAccion.Clear();
            txtTraza.Clear();
        }
    }
}
