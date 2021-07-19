
namespace FrmPrincipal
{
    partial class FrmCrearCartas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrearCartas));
            this.gdvCartasPorCrear = new System.Windows.Forms.DataGridView();
            this.rtbInfoMateriales = new System.Windows.Forms.RichTextBox();
            this.btnComprarMateriales = new System.Windows.Forms.Button();
            this.btnReponerStock = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.rtbInfoCompras = new System.Windows.Forms.RichTextBox();
            this.lblMateriales = new System.Windows.Forms.Label();
            this.lblnfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCartasPorCrear)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvCartasPorCrear
            // 
            this.gdvCartasPorCrear.AllowUserToAddRows = false;
            this.gdvCartasPorCrear.AllowUserToDeleteRows = false;
            this.gdvCartasPorCrear.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvCartasPorCrear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvCartasPorCrear.Location = new System.Drawing.Point(31, 203);
            this.gdvCartasPorCrear.Name = "gdvCartasPorCrear";
            this.gdvCartasPorCrear.ReadOnly = true;
            this.gdvCartasPorCrear.Size = new System.Drawing.Size(1028, 246);
            this.gdvCartasPorCrear.TabIndex = 0;
            // 
            // rtbInfoMateriales
            // 
            this.rtbInfoMateriales.Location = new System.Drawing.Point(590, 41);
            this.rtbInfoMateriales.Name = "rtbInfoMateriales";
            this.rtbInfoMateriales.Size = new System.Drawing.Size(160, 156);
            this.rtbInfoMateriales.TabIndex = 1;
            this.rtbInfoMateriales.Text = " ";
            // 
            // btnComprarMateriales
            // 
            this.btnComprarMateriales.Location = new System.Drawing.Point(289, 12);
            this.btnComprarMateriales.Name = "btnComprarMateriales";
            this.btnComprarMateriales.Size = new System.Drawing.Size(179, 48);
            this.btnComprarMateriales.TabIndex = 2;
            this.btnComprarMateriales.Text = "Mandar a comprar materiales";
            this.btnComprarMateriales.UseVisualStyleBackColor = true;
            this.btnComprarMateriales.Click += new System.EventHandler(this.btnComprarMateriales_Click);
            // 
            // btnReponerStock
            // 
            this.btnReponerStock.Location = new System.Drawing.Point(289, 66);
            this.btnReponerStock.Name = "btnReponerStock";
            this.btnReponerStock.Size = new System.Drawing.Size(179, 48);
            this.btnReponerStock.TabIndex = 3;
            this.btnReponerStock.Text = "Reponer Stock";
            this.btnReponerStock.UseVisualStyleBackColor = true;
            this.btnReponerStock.Click += new System.EventHandler(this.btnReponesStock_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(289, 133);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(179, 48);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver al menu";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnSalirguardar_Click);
            // 
            // rtbInfoCompras
            // 
            this.rtbInfoCompras.Location = new System.Drawing.Point(825, 42);
            this.rtbInfoCompras.Name = "rtbInfoCompras";
            this.rtbInfoCompras.Size = new System.Drawing.Size(234, 155);
            this.rtbInfoCompras.TabIndex = 5;
            this.rtbInfoCompras.Text = "";
            // 
            // lblMateriales
            // 
            this.lblMateriales.AutoSize = true;
            this.lblMateriales.Location = new System.Drawing.Point(644, 12);
            this.lblMateriales.Name = "lblMateriales";
            this.lblMateriales.Size = new System.Drawing.Size(55, 13);
            this.lblMateriales.TabIndex = 6;
            this.lblMateriales.Text = "Materiales";
            this.lblMateriales.Click += new System.EventHandler(this.lblMateriales_Click);
            // 
            // lblnfo
            // 
            this.lblnfo.AutoSize = true;
            this.lblnfo.Location = new System.Drawing.Point(890, 9);
            this.lblnfo.Name = "lblnfo";
            this.lblnfo.Size = new System.Drawing.Size(112, 13);
            this.lblnfo.TabIndex = 7;
            this.lblnfo.Text = "Historial de materiales ";
            // 
            // FrmCrearCartas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.lblnfo);
            this.Controls.Add(this.lblMateriales);
            this.Controls.Add(this.rtbInfoCompras);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnReponerStock);
            this.Controls.Add(this.btnComprarMateriales);
            this.Controls.Add(this.rtbInfoMateriales);
            this.Controls.Add(this.gdvCartasPorCrear);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCrearCartas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCrearCartas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCrearCartas_FormClosing);
            this.Load += new System.EventHandler(this.FrmCrearCartas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvCartasPorCrear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gdvCartasPorCrear;
        private System.Windows.Forms.RichTextBox rtbInfoMateriales;
        private System.Windows.Forms.Button btnComprarMateriales;
        private System.Windows.Forms.Button btnReponerStock;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.RichTextBox rtbInfoCompras;
        private System.Windows.Forms.Label lblMateriales;
        private System.Windows.Forms.Label lblnfo;
    }
}