namespace Tut_Darel_Martinez_Caballero
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExaminar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnDestino = new System.Windows.Forms.Button();
            this.btnRenombrar = new System.Windows.Forms.Button();
            this.lbElementos = new System.Windows.Forms.ListBox();
            this.cbEnviar = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnMover = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.rdBtnFichero = new System.Windows.Forms.RadioButton();
            this.rdBtnCarpeta = new System.Windows.Forms.RadioButton();
            this.btnListar = new System.Windows.Forms.Button();
            this.txtRutaExaminar = new System.Windows.Forms.TextBox();
            this.txtRutaDestino = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtRenombrar = new System.Windows.Forms.TextBox();
            this.chkLongitud = new System.Windows.Forms.CheckBox();
            this.chkUltimoAcceso = new System.Windows.Forms.CheckBox();
            this.chkGuardar = new System.Windows.Forms.CheckBox();
            this.richTextDocumentos = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(59, 39);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(75, 23);
            this.btnExaminar.TabIndex = 0;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(59, 145);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnDestino
            // 
            this.btnDestino.Location = new System.Drawing.Point(59, 84);
            this.btnDestino.Name = "btnDestino";
            this.btnDestino.Size = new System.Drawing.Size(75, 23);
            this.btnDestino.TabIndex = 2;
            this.btnDestino.Text = "Destino";
            this.btnDestino.UseVisualStyleBackColor = true;
            this.btnDestino.Click += new System.EventHandler(this.btnDestino_Click);
            // 
            // btnRenombrar
            // 
            this.btnRenombrar.Location = new System.Drawing.Point(14, 214);
            this.btnRenombrar.Name = "btnRenombrar";
            this.btnRenombrar.Size = new System.Drawing.Size(100, 23);
            this.btnRenombrar.TabIndex = 3;
            this.btnRenombrar.Text = "Renombrar";
            this.btnRenombrar.UseVisualStyleBackColor = true;
            this.btnRenombrar.Click += new System.EventHandler(this.btnRenombrar_Click);
            // 
            // lbElementos
            // 
            this.lbElementos.FormattingEnabled = true;
            this.lbElementos.ItemHeight = 16;
            this.lbElementos.Location = new System.Drawing.Point(120, 214);
            this.lbElementos.Name = "lbElementos";
            this.lbElementos.Size = new System.Drawing.Size(169, 148);
            this.lbElementos.TabIndex = 4;
            this.lbElementos.SelectedIndexChanged += new System.EventHandler(this.lbElementos_SelectedIndexChanged);
            this.lbElementos.DoubleClick += new System.EventHandler(this.doublClickSelectItem);
            // 
            // cbEnviar
            // 
            this.cbEnviar.FormattingEnabled = true;
            this.cbEnviar.Location = new System.Drawing.Point(153, 145);
            this.cbEnviar.Name = "cbEnviar";
            this.cbEnviar.Size = new System.Drawing.Size(121, 24);
            this.cbEnviar.TabIndex = 5;
            this.cbEnviar.SelectedIndexChanged += new System.EventHandler(this.cbEnviar_SelectedIndexChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(214, 185);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnMover
            // 
            this.btnMover.Location = new System.Drawing.Point(120, 185);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(75, 23);
            this.btnMover.TabIndex = 7;
            this.btnMover.Text = "Mover";
            this.btnMover.UseVisualStyleBackColor = true;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(444, 64);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // rdBtnFichero
            // 
            this.rdBtnFichero.AutoSize = true;
            this.rdBtnFichero.Location = new System.Drawing.Point(525, 53);
            this.rdBtnFichero.Name = "rdBtnFichero";
            this.rdBtnFichero.Size = new System.Drawing.Size(73, 20);
            this.rdBtnFichero.TabIndex = 9;
            this.rdBtnFichero.TabStop = true;
            this.rdBtnFichero.Text = "Fichero";
            this.rdBtnFichero.UseVisualStyleBackColor = true;
            // 
            // rdBtnCarpeta
            // 
            this.rdBtnCarpeta.AutoSize = true;
            this.rdBtnCarpeta.Location = new System.Drawing.Point(525, 79);
            this.rdBtnCarpeta.Name = "rdBtnCarpeta";
            this.rdBtnCarpeta.Size = new System.Drawing.Size(76, 20);
            this.rdBtnCarpeta.TabIndex = 10;
            this.rdBtnCarpeta.TabStop = true;
            this.rdBtnCarpeta.Text = "Carpeta";
            this.rdBtnCarpeta.UseVisualStyleBackColor = true;
            this.rdBtnCarpeta.CheckedChanged += new System.EventHandler(this.rdBtnCarpeta_CheckedChanged);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(183, 13);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 12;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtRutaExaminar
            // 
            this.txtRutaExaminar.Location = new System.Drawing.Point(153, 43);
            this.txtRutaExaminar.Name = "txtRutaExaminar";
            this.txtRutaExaminar.Size = new System.Drawing.Size(285, 22);
            this.txtRutaExaminar.TabIndex = 13;
            // 
            // txtRutaDestino
            // 
            this.txtRutaDestino.Location = new System.Drawing.Point(153, 84);
            this.txtRutaDestino.Name = "txtRutaDestino";
            this.txtRutaDestino.Size = new System.Drawing.Size(285, 22);
            this.txtRutaDestino.TabIndex = 14;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(525, 368);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(224, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtRenombrar
            // 
            this.txtRenombrar.Location = new System.Drawing.Point(14, 243);
            this.txtRenombrar.Name = "txtRenombrar";
            this.txtRenombrar.Size = new System.Drawing.Size(100, 22);
            this.txtRenombrar.TabIndex = 16;
            // 
            // chkLongitud
            // 
            this.chkLongitud.AutoSize = true;
            this.chkLongitud.Checked = true;
            this.chkLongitud.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLongitud.Location = new System.Drawing.Point(632, 15);
            this.chkLongitud.Name = "chkLongitud";
            this.chkLongitud.Size = new System.Drawing.Size(149, 20);
            this.chkLongitud.TabIndex = 17;
            this.chkLongitud.Text = "Longitud del archivo";
            this.chkLongitud.UseVisualStyleBackColor = true;
            // 
            // chkUltimoAcceso
            // 
            this.chkUltimoAcceso.AutoSize = true;
            this.chkUltimoAcceso.Checked = true;
            this.chkUltimoAcceso.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUltimoAcceso.Location = new System.Drawing.Point(632, 45);
            this.chkUltimoAcceso.Name = "chkUltimoAcceso";
            this.chkUltimoAcceso.Size = new System.Drawing.Size(167, 20);
            this.chkUltimoAcceso.TabIndex = 18;
            this.chkUltimoAcceso.Text = "Hora del último acceso";
            this.chkUltimoAcceso.UseVisualStyleBackColor = true;
            // 
            // chkGuardar
            // 
            this.chkGuardar.AutoSize = true;
            this.chkGuardar.Location = new System.Drawing.Point(632, 79);
            this.chkGuardar.Name = "chkGuardar";
            this.chkGuardar.Size = new System.Drawing.Size(150, 20);
            this.chkGuardar.TabIndex = 19;
            this.chkGuardar.Text = "Guardar Resultados";
            this.chkGuardar.UseVisualStyleBackColor = true;
            // 
            // richTextDocumentos
            // 
            this.richTextDocumentos.Location = new System.Drawing.Point(444, 145);
            this.richTextDocumentos.Name = "richTextDocumentos";
            this.richTextDocumentos.Size = new System.Drawing.Size(337, 217);
            this.richTextDocumentos.TabIndex = 21;
            this.richTextDocumentos.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextDocumentos);
            this.Controls.Add(this.chkGuardar);
            this.Controls.Add(this.chkUltimoAcceso);
            this.Controls.Add(this.chkLongitud);
            this.Controls.Add(this.txtRenombrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtRutaDestino);
            this.Controls.Add(this.txtRutaExaminar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.rdBtnCarpeta);
            this.Controls.Add(this.rdBtnFichero);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnMover);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.cbEnviar);
            this.Controls.Add(this.lbElementos);
            this.Controls.Add(this.btnRenombrar);
            this.Controls.Add(this.btnDestino);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnExaminar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnDestino;
        private System.Windows.Forms.Button btnRenombrar;
        private System.Windows.Forms.ListBox lbElementos;
        private System.Windows.Forms.ComboBox cbEnviar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.RadioButton rdBtnFichero;
        private System.Windows.Forms.RadioButton rdBtnCarpeta;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtRutaExaminar;
        private System.Windows.Forms.TextBox txtRutaDestino;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtRenombrar;
        private System.Windows.Forms.CheckBox chkLongitud;
        private System.Windows.Forms.CheckBox chkUltimoAcceso;
        private System.Windows.Forms.CheckBox chkGuardar;
        private System.Windows.Forms.RichTextBox richTextDocumentos;
    }
}

