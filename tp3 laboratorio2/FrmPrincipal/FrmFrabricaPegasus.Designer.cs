
namespace FrmPrincipal
{
    partial class FrmFabricaPegasus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFabricaPegasus));
            this.btnCreacionCartas = new System.Windows.Forms.Button();
            this.btnCreacionDeck = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreacionCartas
            // 
            this.btnCreacionCartas.Location = new System.Drawing.Point(366, 21);
            this.btnCreacionCartas.Name = "btnCreacionCartas";
            this.btnCreacionCartas.Size = new System.Drawing.Size(325, 92);
            this.btnCreacionCartas.TabIndex = 0;
            this.btnCreacionCartas.Text = "Creacion Cartas";
            this.btnCreacionCartas.UseVisualStyleBackColor = true;
            this.btnCreacionCartas.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCreacionDeck
            // 
            this.btnCreacionDeck.Location = new System.Drawing.Point(366, 167);
            this.btnCreacionDeck.Name = "btnCreacionDeck";
            this.btnCreacionDeck.Size = new System.Drawing.Size(325, 92);
            this.btnCreacionDeck.TabIndex = 1;
            this.btnCreacionDeck.Text = "Creacion mi Deck";
            this.btnCreacionDeck.UseVisualStyleBackColor = true;
            this.btnCreacionDeck.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(366, 322);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(325, 92);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir y Guardar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmFabricaPegasus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCreacionDeck);
            this.Controls.Add(this.btnCreacionCartas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFabricaPegasus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fabrica pegasus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreacionCartas;
        private System.Windows.Forms.Button btnCreacionDeck;
        private System.Windows.Forms.Button btnSalir;
    }
}

