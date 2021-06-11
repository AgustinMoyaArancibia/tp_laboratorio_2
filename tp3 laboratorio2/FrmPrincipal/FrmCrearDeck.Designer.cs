
namespace FrmPrincipal
{
    partial class FrmCrearDeck
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrearDeck));
            this.dtgCartas = new System.Windows.Forms.DataGridView();
            this.dtvMiDeck = new System.Windows.Forms.DataGridView();
            this.btnMostrarCarta = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbImage = new System.Windows.Forms.Label();
            this.rtbInfoCartas = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCartas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvMiDeck)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCartas
            // 
            this.dtgCartas.AllowUserToAddRows = false;
            this.dtgCartas.AllowUserToDeleteRows = false;
            this.dtgCartas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCartas.Location = new System.Drawing.Point(24, 34);
            this.dtgCartas.Name = "dtgCartas";
            this.dtgCartas.ReadOnly = true;
            this.dtgCartas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCartas.Size = new System.Drawing.Size(467, 174);
            this.dtgCartas.TabIndex = 0;
            // 
            // dtvMiDeck
            // 
            this.dtvMiDeck.AllowUserToAddRows = false;
            this.dtvMiDeck.AllowUserToDeleteRows = false;
            this.dtvMiDeck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvMiDeck.Location = new System.Drawing.Point(24, 260);
            this.dtvMiDeck.Name = "dtvMiDeck";
            this.dtvMiDeck.ReadOnly = true;
            this.dtvMiDeck.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtvMiDeck.Size = new System.Drawing.Size(467, 178);
            this.dtvMiDeck.TabIndex = 1;
            // 
            // btnMostrarCarta
            // 
            this.btnMostrarCarta.Location = new System.Drawing.Point(519, 133);
            this.btnMostrarCarta.Name = "btnMostrarCarta";
            this.btnMostrarCarta.Size = new System.Drawing.Size(188, 58);
            this.btnMostrarCarta.TabIndex = 2;
            this.btnMostrarCarta.Text = "Mostrar Carta";
            this.btnMostrarCarta.UseVisualStyleBackColor = true;
            this.btnMostrarCarta.Click += new System.EventHandler(this.btnMostrarCarta_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(519, 211);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(188, 58);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar a Mi Deck";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(519, 361);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(188, 58);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir y Guardar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "mago oscuro.jpg");
            this.imageList1.Images.SetKeyName(1, "Foto_h%3Froe_elemental_neos.jpg");
            this.imageList1.Images.SetKeyName(2, "Foto_caballero_sin_cabeza.jpg");
            this.imageList1.Images.SetKeyName(3, "Foto_drag%3Fn_fantasma_espiral.jpg");
            this.imageList1.Images.SetKeyName(4, "Foto_chica_maga_oscura.jpg");
            this.imageList1.Images.SetKeyName(5, "Foto_drag%3Fn_blanco_de_ojos_azules.jpg");
            this.imageList1.Images.SetKeyName(6, "Foto_ciber_drag%3Fn.jpg");
            this.imageList1.Images.SetKeyName(7, "Foto_yubel.jpg");
            this.imageList1.Images.SetKeyName(8, "Foto_drag%3Fn_ciber_final.jpg");
            this.imageList1.Images.SetKeyName(9, "Foto_dragoon_oscuro_de_ojos_rojos.jpg");
            this.imageList1.Images.SetKeyName(10, "agujero trampa.jpg");
            this.imageList1.Images.SetKeyName(11, "montruo renacido.jpg");
            // 
            // lbImage
            // 
            this.lbImage.ImageList = this.imageList1;
            this.lbImage.Location = new System.Drawing.Point(539, 16);
            this.lbImage.Name = "lbImage";
            this.lbImage.Size = new System.Drawing.Size(156, 97);
            this.lbImage.TabIndex = 5;
            // 
            // rtbInfoCartas
            // 
            this.rtbInfoCartas.Location = new System.Drawing.Point(748, 13);
            this.rtbInfoCartas.Name = "rtbInfoCartas";
            this.rtbInfoCartas.Size = new System.Drawing.Size(226, 392);
            this.rtbInfoCartas.TabIndex = 6;
            this.rtbInfoCartas.Text = "";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cartas disponibles";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(21, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mi deck";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 58);
            this.button1.TabIndex = 9;
            this.button1.Text = "Eliminar carta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCrearDeck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FrmPrincipal.Properties.Resources.Tablero_de_juego_v4;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbInfoCartas);
            this.Controls.Add(this.lbImage);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnMostrarCarta);
            this.Controls.Add(this.dtvMiDeck);
            this.Controls.Add(this.dtgCartas);
            this.Name = "FrmCrearDeck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCrearDeck";
            this.Load += new System.EventHandler(this.FrmCrearDeck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCartas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvMiDeck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCartas;
        private System.Windows.Forms.DataGridView dtvMiDeck;
        private System.Windows.Forms.Button btnMostrarCarta;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lbImage;
        private System.Windows.Forms.RichTextBox rtbInfoCartas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}