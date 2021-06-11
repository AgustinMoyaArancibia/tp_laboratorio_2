
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
            this.rtbInfoMateriales.Location = new System.Drawing.Point(835, 12);
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
            this.btnComprarMateriales.Text = "Comprar materias";
            this.btnComprarMateriales.UseVisualStyleBackColor = true;
            this.btnComprarMateriales.Click += new System.EventHandler(this.btnComprarMateriales_Click);
            // 
            // btnReponerStock
            // 
            this.btnReponerStock.Location = new System.Drawing.Point(289, 79);
            this.btnReponerStock.Name = "btnReponerStock";
            this.btnReponerStock.Size = new System.Drawing.Size(179, 48);
            this.btnReponerStock.TabIndex = 3;
            this.btnReponerStock.Text = "Reponer Stock";
            this.btnReponerStock.UseVisualStyleBackColor = true;
            this.btnReponerStock.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(289, 133);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(179, 48);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver al menu";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmCrearCartas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnReponerStock);
            this.Controls.Add(this.btnComprarMateriales);
            this.Controls.Add(this.rtbInfoMateriales);
            this.Controls.Add(this.gdvCartasPorCrear);
            this.Name = "FrmCrearCartas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCrearCartas";
            this.Load += new System.EventHandler(this.FrmCrearCartas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvCartasPorCrear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gdvCartasPorCrear;
        private System.Windows.Forms.RichTextBox rtbInfoMateriales;
        private System.Windows.Forms.Button btnComprarMateriales;
        private System.Windows.Forms.Button btnReponerStock;
        private System.Windows.Forms.Button btnVolver;
    }
}