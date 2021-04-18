
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
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAbinario = new System.Windows.Forms.Button();
            this.btnAdecimal = new System.Windows.Forms.Button();
            this.cmbOperaciones = new System.Windows.Forms.ComboBox();
            this.txtNumeroUno = new System.Windows.Forms.TextBox();
            this.txtNumeroDos = new System.Windows.Forms.TextBox();
            this.lblRestultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(41, 134);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(90, 40);
            this.btnOperar.TabIndex = 4;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.BtnOperar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(200, 134);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 40);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(360, 134);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(90, 40);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnAbinario
            // 
            this.btnAbinario.Location = new System.Drawing.Point(41, 204);
            this.btnAbinario.Name = "btnAbinario";
            this.btnAbinario.Size = new System.Drawing.Size(193, 40);
            this.btnAbinario.TabIndex = 7;
            this.btnAbinario.Text = "Convertir a Binario";
            this.btnAbinario.UseVisualStyleBackColor = true;
            this.btnAbinario.Click += new System.EventHandler(this.BtnAbinario_Click);
            // 
            // btnAdecimal
            // 
            this.btnAdecimal.Location = new System.Drawing.Point(250, 204);
            this.btnAdecimal.Name = "btnAdecimal";
            this.btnAdecimal.Size = new System.Drawing.Size(200, 40);
            this.btnAdecimal.TabIndex = 8;
            this.btnAdecimal.Text = "Convertir a Decimal";
            this.btnAdecimal.UseVisualStyleBackColor = true;
            this.btnAdecimal.Click += new System.EventHandler(this.BtnAdecimal_Click);
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
            this.cmbOperaciones.TabIndex = 2;
            // 
            // txtNumeroUno
            // 
            this.txtNumeroUno.Location = new System.Drawing.Point(41, 85);
            this.txtNumeroUno.Name = "txtNumeroUno";
            this.txtNumeroUno.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroUno.TabIndex = 1;
            // 
            // txtNumeroDos
            // 
            this.txtNumeroDos.Location = new System.Drawing.Point(350, 85);
            this.txtNumeroDos.Name = "txtNumeroDos";
            this.txtNumeroDos.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroDos.TabIndex = 3;
            // 
            // lblRestultado
            // 
            this.lblRestultado.AutoSize = true;
            this.lblRestultado.Location = new System.Drawing.Point(415, 40);
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
            this.Controls.Add(this.btnAdecimal);
            this.Controls.Add(this.btnAbinario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.Name = "calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de agustin moya del curso 2°D";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAbinario;
        private System.Windows.Forms.Button btnAdecimal;
        private System.Windows.Forms.ComboBox cmbOperaciones;
        private System.Windows.Forms.TextBox txtNumeroUno;
        private System.Windows.Forms.TextBox txtNumeroDos;
        private System.Windows.Forms.Label lblRestultado;
    }
}

