namespace SE_Diagnosis_PC  // <-- CAMBIA esto por el MISMO namespace que Form1.cs
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.lblAccion = new System.Windows.Forms.Label();
            this.lblTraza = new System.Windows.Forms.Label();
            this.chkEnciende = new System.Windows.Forms.CheckBox();
            this.chkVentiladores1s = new System.Windows.Forms.CheckBox();
            this.chkCableRegletaBien = new System.Windows.Forms.CheckBox();
            this.chkImagen = new System.Windows.Forms.CheckBox();
            this.chkPitidos = new System.Windows.Forms.CheckBox();
            this.chkLuzMonitor = new System.Windows.Forms.CheckBox();
            this.chkSinSenal = new System.Windows.Forms.CheckBox();
            this.chkImagenPlacaMadre = new System.Windows.Forms.CheckBox();
            this.chkReiniciaRato = new System.Windows.Forms.CheckBox();
            this.chkReiniciaAzar = new System.Windows.Forms.CheckBox();
            this.chkLenta = new System.Windows.Forms.CheckBox();
            this.chkCaliente = new System.Windows.Forms.CheckBox();
            this.chkDiscoClic = new System.Windows.Forms.CheckBox();
            this.chkArchivosNoAbren = new System.Windows.Forms.CheckBox();
            this.btnDiagnosticar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.txtAccion = new System.Windows.Forms.TextBox();
            this.txtTraza = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Marque los síntomas observados:";
            //
            // lblDiagnostico
            //
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDiagnostico.Location = new System.Drawing.Point(20, 310);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Text = "Falla diagnosticada:";
            //
            // lblAccion
            //
            this.lblAccion.AutoSize = true;
            this.lblAccion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAccion.Location = new System.Drawing.Point(20, 366);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Text = "Acción recomendada:";
            //
            // lblTraza
            //
            this.lblTraza.AutoSize = true;
            this.lblTraza.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTraza.Location = new System.Drawing.Point(20, 448);
            this.lblTraza.Name = "lblTraza";
            this.lblTraza.Text = "Reglas disparadas (traza del motor):";
            //
            // chkEnciende
            //
            this.chkEnciende.AutoSize = true;
            this.chkEnciende.Location = new System.Drawing.Point(20, 40);
            this.chkEnciende.Name = "chkEnciende";
            this.chkEnciende.TabIndex = 1;
            this.chkEnciende.Text = "La computadora enciende";
            this.chkEnciende.UseVisualStyleBackColor = true;
            //
            // chkVentiladores1s
            //
            this.chkVentiladores1s.AutoSize = true;
            this.chkVentiladores1s.Location = new System.Drawing.Point(20, 70);
            this.chkVentiladores1s.Name = "chkVentiladores1s";
            this.chkVentiladores1s.TabIndex = 2;
            this.chkVentiladores1s.Text = "Ventiladores giran 1 segundo y se apagan";
            this.chkVentiladores1s.UseVisualStyleBackColor = true;
            //
            // chkCableRegletaBien
            //
            this.chkCableRegletaBien.AutoSize = true;
            this.chkCableRegletaBien.Location = new System.Drawing.Point(20, 100);
            this.chkCableRegletaBien.Name = "chkCableRegletaBien";
            this.chkCableRegletaBien.TabIndex = 3;
            this.chkCableRegletaBien.Text = "Cable y regleta están bien";
            this.chkCableRegletaBien.UseVisualStyleBackColor = true;
            //
            // chkImagen
            //
            this.chkImagen.AutoSize = true;
            this.chkImagen.Location = new System.Drawing.Point(20, 130);
            this.chkImagen.Name = "chkImagen";
            this.chkImagen.TabIndex = 4;
            this.chkImagen.Text = "Hay imagen en el monitor";
            this.chkImagen.UseVisualStyleBackColor = true;
            //
            // chkPitidos
            //
            this.chkPitidos.AutoSize = true;
            this.chkPitidos.Location = new System.Drawing.Point(20, 160);
            this.chkPitidos.Name = "chkPitidos";
            this.chkPitidos.TabIndex = 5;
            this.chkPitidos.Text = "Hay pitidos al encender";
            this.chkPitidos.UseVisualStyleBackColor = true;
            //
            // chkLuzMonitor
            //
            this.chkLuzMonitor.AutoSize = true;
            this.chkLuzMonitor.Location = new System.Drawing.Point(20, 190);
            this.chkLuzMonitor.Name = "chkLuzMonitor";
            this.chkLuzMonitor.TabIndex = 6;
            this.chkLuzMonitor.Text = "El monitor tiene alguna luz";
            this.chkLuzMonitor.UseVisualStyleBackColor = true;
            //
            // chkSinSenal
            //
            this.chkSinSenal.AutoSize = true;
            this.chkSinSenal.Location = new System.Drawing.Point(20, 220);
            this.chkSinSenal.Name = "chkSinSenal";
            this.chkSinSenal.TabIndex = 7;
            this.chkSinSenal.Text = "El monitor indica \"sin señal\"";
            this.chkSinSenal.UseVisualStyleBackColor = true;
            //
            // chkImagenPlacaMadre
            //
            this.chkImagenPlacaMadre.AutoSize = true;
            this.chkImagenPlacaMadre.Location = new System.Drawing.Point(360, 40);
            this.chkImagenPlacaMadre.Name = "chkImagenPlacaMadre";
            this.chkImagenPlacaMadre.TabIndex = 8;
            this.chkImagenPlacaMadre.Text = "Hay imagen al conectar a la salida de la placa madre";
            this.chkImagenPlacaMadre.UseVisualStyleBackColor = true;
            //
            // chkReiniciaRato
            //
            this.chkReiniciaRato.AutoSize = true;
            this.chkReiniciaRato.Location = new System.Drawing.Point(360, 70);
            this.chkReiniciaRato.Name = "chkReiniciaRato";
            this.chkReiniciaRato.TabIndex = 9;
            this.chkReiniciaRato.Text = "Se reinicia tras un rato o con programas pesados";
            this.chkReiniciaRato.UseVisualStyleBackColor = true;
            //
            // chkReiniciaAzar
            //
            this.chkReiniciaAzar.AutoSize = true;
            this.chkReiniciaAzar.Location = new System.Drawing.Point(360, 100);
            this.chkReiniciaAzar.Name = "chkReiniciaAzar";
            this.chkReiniciaAzar.TabIndex = 10;
            this.chkReiniciaAzar.Text = "Se reinicia al azar (incluso recién encendida)";
            this.chkReiniciaAzar.UseVisualStyleBackColor = true;
            //
            // chkLenta
            //
            this.chkLenta.AutoSize = true;
            this.chkLenta.Location = new System.Drawing.Point(360, 130);
            this.chkLenta.Name = "chkLenta";
            this.chkLenta.TabIndex = 11;
            this.chkLenta.Text = "Está lenta";
            this.chkLenta.UseVisualStyleBackColor = true;
            //
            // chkCaliente
            //
            this.chkCaliente.AutoSize = true;
            this.chkCaliente.Location = new System.Drawing.Point(360, 160);
            this.chkCaliente.Name = "chkCaliente";
            this.chkCaliente.TabIndex = 12;
            this.chkCaliente.Text = "Está caliente";
            this.chkCaliente.UseVisualStyleBackColor = true;
            //
            // chkDiscoClic
            //
            this.chkDiscoClic.AutoSize = true;
            this.chkDiscoClic.Location = new System.Drawing.Point(360, 190);
            this.chkDiscoClic.Name = "chkDiscoClic";
            this.chkDiscoClic.TabIndex = 13;
            this.chkDiscoClic.Text = "El disco hace ruidos de clic";
            this.chkDiscoClic.UseVisualStyleBackColor = true;
            //
            // chkArchivosNoAbren
            //
            this.chkArchivosNoAbren.AutoSize = true;
            this.chkArchivosNoAbren.Location = new System.Drawing.Point(360, 220);
            this.chkArchivosNoAbren.Name = "chkArchivosNoAbren";
            this.chkArchivosNoAbren.TabIndex = 14;
            this.chkArchivosNoAbren.Text = "Hay archivos que no abren";
            this.chkArchivosNoAbren.UseVisualStyleBackColor = true;
            //
            // btnDiagnosticar
            //
            this.btnDiagnosticar.Location = new System.Drawing.Point(20, 260);
            this.btnDiagnosticar.Name = "btnDiagnosticar";
            this.btnDiagnosticar.Size = new System.Drawing.Size(140, 32);
            this.btnDiagnosticar.TabIndex = 15;
            this.btnDiagnosticar.Text = "Diagnosticar";
            this.btnDiagnosticar.UseVisualStyleBackColor = true;
            this.btnDiagnosticar.Click += new System.EventHandler(this.btnDiagnosticar_Click);
            //
            // btnLimpiar
            //
            this.btnLimpiar.Location = new System.Drawing.Point(175, 260);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(140, 32);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            //
            // txtDiagnostico
            //
            this.txtDiagnostico.Location = new System.Drawing.Point(20, 332);
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.ReadOnly = true;
            this.txtDiagnostico.Size = new System.Drawing.Size(680, 23);
            this.txtDiagnostico.TabIndex = 17;
            //
            // txtAccion
            //
            this.txtAccion.Location = new System.Drawing.Point(20, 388);
            this.txtAccion.Multiline = true;
            this.txtAccion.Name = "txtAccion";
            this.txtAccion.ReadOnly = true;
            this.txtAccion.Size = new System.Drawing.Size(680, 50);
            this.txtAccion.TabIndex = 18;
            //
            // txtTraza
            //
            this.txtTraza.Location = new System.Drawing.Point(20, 470);
            this.txtTraza.Multiline = true;
            this.txtTraza.Name = "txtTraza";
            this.txtTraza.ReadOnly = true;
            this.txtTraza.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTraza.Size = new System.Drawing.Size(680, 95);
            this.txtTraza.TabIndex = 19;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 580);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblDiagnostico);
            this.Controls.Add(this.lblAccion);
            this.Controls.Add(this.lblTraza);
            this.Controls.Add(this.chkEnciende);
            this.Controls.Add(this.chkVentiladores1s);
            this.Controls.Add(this.chkCableRegletaBien);
            this.Controls.Add(this.chkImagen);
            this.Controls.Add(this.chkPitidos);
            this.Controls.Add(this.chkLuzMonitor);
            this.Controls.Add(this.chkSinSenal);
            this.Controls.Add(this.chkImagenPlacaMadre);
            this.Controls.Add(this.chkReiniciaRato);
            this.Controls.Add(this.chkReiniciaAzar);
            this.Controls.Add(this.chkLenta);
            this.Controls.Add(this.chkCaliente);
            this.Controls.Add(this.chkDiscoClic);
            this.Controls.Add(this.chkArchivosNoAbren);
            this.Controls.Add(this.btnDiagnosticar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.txtAccion);
            this.Controls.Add(this.txtTraza);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Experto - Soporte Técnico de Computadoras";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.Label lblTraza;
        private System.Windows.Forms.CheckBox chkEnciende;
        private System.Windows.Forms.CheckBox chkVentiladores1s;
        private System.Windows.Forms.CheckBox chkCableRegletaBien;
        private System.Windows.Forms.CheckBox chkImagen;
        private System.Windows.Forms.CheckBox chkPitidos;
        private System.Windows.Forms.CheckBox chkLuzMonitor;
        private System.Windows.Forms.CheckBox chkSinSenal;
        private System.Windows.Forms.CheckBox chkImagenPlacaMadre;
        private System.Windows.Forms.CheckBox chkReiniciaRato;
        private System.Windows.Forms.CheckBox chkReiniciaAzar;
        private System.Windows.Forms.CheckBox chkLenta;
        private System.Windows.Forms.CheckBox chkCaliente;
        private System.Windows.Forms.CheckBox chkDiscoClic;
        private System.Windows.Forms.CheckBox chkArchivosNoAbren;
        private System.Windows.Forms.Button btnDiagnosticar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.TextBox txtAccion;
        private System.Windows.Forms.TextBox txtTraza;
    }
}