using System;
using System.Collections.Generic;

namespace SE_Diagnosis_PC
{
    /// <summary>
    /// Representa una regla del sistema experto: SI (Condicion) ENTONCES (Conclusion).
    /// Las propiedades son de solo lectura: se asignan una única vez en el constructor.
    /// </summary>
    public class Regla
    {
        /// <summary>Nombre descriptivo (se usa en la traza de inferencia).</summary>
        public string Nombre { get; }

        /// <summary>Condición: recibe el conjunto de hechos y devuelve true si la regla se cumple.</summary>
        public Func<HashSet<string>, bool> Condicion { get; }

        /// <summary>Hecho nuevo que se agrega a la memoria de trabajo al dispararse la regla.</summary>
        public string Conclusion { get; }

        /// <summary>Acción recomendada (solo para reglas que son un diagnóstico final).</summary>
        public string Accion { get; }

        /// <summary>Prioridad: número MENOR = se atiende primero cuando varias causas coinciden.</summary>
        public int Prioridad { get; }

        /// <summary>true si la regla produce un diagnóstico final; false si solo deriva un hecho intermedio.</summary>
        public bool EsDiagnostico { get; }

        public Regla(string nombre,
                     Func<HashSet<string>, bool> condicion,
                     string conclusion,
                     string accion = null,
                     int prioridad = int.MaxValue,
                     bool esDiagnostico = false)
        {
            // Corrección del error original: se asigna el PARÁMETRO (minúscula) a la propiedad (mayúscula).
            // Antes: condicion = Condicion;  (asignaba la propiedad vacía al parámetro, dejándola en null)
            Nombre = nombre;
            Condicion = condicion;
            Conclusion = conclusion;
            Accion = accion;
            Prioridad = prioridad;
            EsDiagnostico = esDiagnostico;
        }
    }
}