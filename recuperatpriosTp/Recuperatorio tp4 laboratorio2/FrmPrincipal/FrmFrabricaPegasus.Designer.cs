
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
            this.btnComprarCarta = new System.Windows.Forms.Button();
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
            this.btnCreacionCartas.Click += new System.EventHandler(this.btnCreacionCartas_Click_1);
            // 
            // btnComprarCarta
            // 
            this.btnComprarCarta.Location = new System.Drawing.Point(366, 167);
            this.btnComprarCarta.Name = "btnComprarCarta";
            this.btnComprarCarta.Size = new System.Drawing.Size(325, 92);
            this.btnComprarCarta.TabIndex = 1;
            this.btnComprarCarta.Text = "Comprar carta";
            this.btnComprarCarta.UseVisualStyleBackColor = true;
            this.btnComprarCarta.Click += new System.EventHandler(this.btnCreacionDeck_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(366, 322);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(325, 92);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir y Guardar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmFabricaPegasus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnComprarCarta);
            this.Controls.Add(this.btnCreacionCartas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFabricaPegasus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fabrica pegasus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFabricaPegasus_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreacionCartas;
        private System.Windows.Forms.Button btnComprarCarta;
        private System.Windows.Forms.Button btnSalir;
    }
}

