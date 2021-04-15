
namespace MiCalculadora
{
    partial class calculadora
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
            this.BtnOperar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnAbinario = new System.Windows.Forms.Button();
            this.BtnAdecimal = new System.Windows.Forms.Button();
            this.cmbOperaciones = new System.Windows.Forms.ComboBox();
            this.txtNumeroUno = new System.Windows.Forms.TextBox();
            this.txtNumeroDos = new System.Windows.Forms.TextBox();
            this.lblRestultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnOperar
            // 
            this.BtnOperar.Location = new System.Drawing.Point(41, 134);
            this.BtnOperar.Name = "BtnOperar";
            this.BtnOperar.Size = new System.Drawing.Size(90, 40);
            this.BtnOperar.TabIndex = 0;
            this.BtnOperar.Text = "Operar";
            this.BtnOperar.UseVisualStyleBackColor = true;
            this.BtnOperar.Click += new System.EventHandler(this.BtnOperar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(200, 134);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(90, 40);
            this.BtnLimpiar.TabIndex = 1;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(360, 134);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(90, 40);
            this.BtnCerrar.TabIndex = 2;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnAbinario
            // 
            this.BtnAbinario.Location = new System.Drawing.Point(41, 204);
            this.BtnAbinario.Name = "BtnAbinario";
            this.BtnAbinario.Size = new System.Drawing.Size(193, 40);
            this.BtnAbinario.TabIndex = 3;
            this.BtnAbinario.Text = "Convertir a Binario";
            this.BtnAbinario.UseVisualStyleBackColor = true;
            this.BtnAbinario.Click += new System.EventHandler(this.BtnAbinario_Click);
            // 
            // BtnAdecimal
            // 
            this.BtnAdecimal.Location = new System.Drawing.Point(250, 204);
            this.BtnAdecimal.Name = "BtnAdecimal";
            this.BtnAdecimal.Size = new System.Drawing.Size(200, 40);
            this.BtnAdecimal.TabIndex = 4;
            this.BtnAdecimal.Text = "Convertir a Decimal";
            this.BtnAdecimal.UseVisualStyleBackColor = true;
            // 
            // cmbOperaciones
            // 
            this.cmbOperaciones.FormattingEnabled = true;
            this.cmbOperaciones.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.cmbOperaciones.Location = new System.Drawing.Point(183, 84);
            this.cmbOperaciones.Name = "cmbOperaciones";
            this.cmbOperaciones.Size = new System.Drawing.Size(124, 21);
            this.cmbOperaciones.TabIndex = 5;
            // 
            // txtNumeroUno
            // 
            this.txtNumeroUno.Location = new System.Drawing.Point(41, 85);
            this.txtNumeroUno.Name = "txtNumeroUno";
            this.txtNumeroUno.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroUno.TabIndex = 6;
            // 
            // txtNumeroDos
            // 
            this.txtNumeroDos.Location = new System.Drawing.Point(350, 85);
            this.txtNumeroDos.Name = "txtNumeroDos";
            this.txtNumeroDos.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroDos.TabIndex = 7;
            // 
            // lblRestultado
            // 
            this.lblRestultado.AutoSize = true;
            this.lblRestultado.Location = new System.Drawing.Point(415, 41);
            this.lblRestultado.Name = "lblRestultado";
            this.lblRestultado.Size = new System.Drawing.Size(50, 13);
            this.lblRestultado.TabIndex = 8;
            this.lblRestultado.Text = "resultado";
            // 
            // calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 284);
            this.Controls.Add(this.lblRestultado);
            this.Controls.Add(this.txtNumeroDos);
            this.Controls.Add(this.txtNumeroUno);
            this.Controls.Add(this.cmbOperaciones);
            this.Controls.Add(this.BtnAdecimal);
            this.Controls.Add(this.BtnAbinario);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnOperar);
            this.Name = "calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de agustin moya del curso 2°D";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOperar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnAbinario;
        private System.Windows.Forms.Button BtnAdecimal;
        private System.Windows.Forms.ComboBox cmbOperaciones;
        private System.Windows.Forms.TextBox txtNumeroUno;
        private System.Windows.Forms.TextBox txtNumeroDos;
        private System.Windows.Forms.Label lblRestultado;
    }
}

