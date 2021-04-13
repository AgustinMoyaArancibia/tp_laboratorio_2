
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
            this.CbxOperaciones = new System.Windows.Forms.ComboBox();
            this.txtNumeroUno = new System.Windows.Forms.TextBox();
            this.txtNumeroDos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(200, 134);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(90, 40);
            this.BtnLimpiar.TabIndex = 1;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(360, 134);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(90, 40);
            this.BtnCerrar.TabIndex = 2;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            // 
            // BtnAbinario
            // 
            this.BtnAbinario.Location = new System.Drawing.Point(41, 204);
            this.BtnAbinario.Name = "BtnAbinario";
            this.BtnAbinario.Size = new System.Drawing.Size(193, 40);
            this.BtnAbinario.TabIndex = 3;
            this.BtnAbinario.Text = "Convertir a Binario";
            this.BtnAbinario.UseVisualStyleBackColor = true;
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
            // CbxOperaciones
            // 
            this.CbxOperaciones.FormattingEnabled = true;
            this.CbxOperaciones.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.CbxOperaciones.Location = new System.Drawing.Point(183, 84);
            this.CbxOperaciones.Name = "CbxOperaciones";
            this.CbxOperaciones.Size = new System.Drawing.Size(124, 21);
            this.CbxOperaciones.TabIndex = 5;
            // 
            // txtNumeroUno
            // 
            this.txtNumeroUno.Location = new System.Drawing.Point(41, 85);
            this.txtNumeroUno.Name = "txtNumeroUno";
            this.txtNumeroUno.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroUno.TabIndex = 6;
            this.txtNumeroUno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNumeroDos
            // 
            this.txtNumeroDos.Location = new System.Drawing.Point(350, 85);
            this.txtNumeroDos.Name = "txtNumeroDos";
            this.txtNumeroDos.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroDos.TabIndex = 7;
            this.txtNumeroDos.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 284);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumeroDos);
            this.Controls.Add(this.txtNumeroUno);
            this.Controls.Add(this.CbxOperaciones);
            this.Controls.Add(this.BtnAdecimal);
            this.Controls.Add(this.BtnAbinario);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnOperar);
            this.Name = "calculadora";
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
        private System.Windows.Forms.ComboBox CbxOperaciones;
        private System.Windows.Forms.TextBox txtNumeroUno;
        private System.Windows.Forms.TextBox txtNumeroDos;
        private System.Windows.Forms.Label label1;
    }
}

