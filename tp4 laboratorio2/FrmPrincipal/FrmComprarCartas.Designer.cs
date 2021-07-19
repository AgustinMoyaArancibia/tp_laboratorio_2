
namespace FrmPrincipal
{
    partial class FrmComprarCartas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComprarCartas));
            this.dtgCartas = new System.Windows.Forms.DataGridView();
            this.btnMostrarCarta = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbImage = new System.Windows.Forms.Label();
            this.rtbInfoCartas = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMisCartas = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCartas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCartas
            // 
            this.dtgCartas.AllowUserToAddRows = false;
            this.dtgCartas.AllowUserToDeleteRows = false;
            this.dtgCartas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCartas.Location = new System.Drawing.Point(12, 34);
            this.dtgCartas.Name = "dtgCartas";
            this.dtgCartas.ReadOnly = true;
            this.dtgCartas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCartas.Size = new System.Drawing.Size(442, 397);
            this.dtgCartas.TabIndex = 0;
            // 
            // btnMostrarCarta
            // 
            this.btnMostrarCarta.Location = new System.Drawing.Point(475, 184);
            this.btnMostrarCarta.Name = "btnMostrarCarta";
            this.btnMostrarCarta.Size = new System.Drawing.Size(188, 58);
            this.btnMostrarCarta.TabIndex = 2;
            this.btnMostrarCarta.Text = "Mostrar Carta";
            this.btnMostrarCarta.UseVisualStyleBackColor = true;
            this.btnMostrarCarta.Click += new System.EventHandler(this.btnMostrarCarta_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(475, 281);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(188, 58);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Comprar Carta";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregarCarta);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(475, 373);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(188, 58);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir y Guardar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalirGuardar);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "mago oscuro.jpg");
            this.imageList1.Images.SetKeyName(1, "Foto_h%3Froe_elemental_neos.jpg");
            this.imageList1.Images.SetKeyName(2, "Foto_caballero_sin_cabeza.jpg");
            this.imageList1.Images.SetKeyName(3, "Foto_drag%3Fn_fantasma_espiral.jpg");
            this.imageList1.Images.SetKeyName(4, "Foto_drag%3Fn_blanco_de_ojos_azules.jpg");
            this.imageList1.Images.SetKeyName(5, "Foto_chica_maga_oscura.jpg");
            this.imageList1.Images.SetKeyName(6, "Foto_yubel.jpg");
            this.imageList1.Images.SetKeyName(7, "Foto_ciber_drag%3Fn.jpg");
            this.imageList1.Images.SetKeyName(8, "Foto_drag%3Fn_ciber_final.jpg");
            this.imageList1.Images.SetKeyName(9, "Foto_dragoon_oscuro_de_ojos_rojos.jpg");
            this.imageList1.Images.SetKeyName(10, "Foto_slifer_el_drag%3Fn_del_cielo.jpg");
            this.imageList1.Images.SetKeyName(11, "Foto_obelisco_el_atormentador_%28legal%29.jpg");
            this.imageList1.Images.SetKeyName(12, "Foto_el_drag%3Fn_alado_de_ra_%28legal%29.jpg");
            this.imageList1.Images.SetKeyName(13, "Foto_hamon%2C_se%3For_del_trueno_golpeador.jpg");
            this.imageList1.Images.SetKeyName(14, "Foto_uria%2C_se%3For_de_las_llamas_abrasadoras.jpg");
            this.imageList1.Images.SetKeyName(15, "Foto_raviel%2C_se%3For_de_fantasmas.jpg");
            this.imageList1.Images.SetKeyName(16, "Foto_armityle%2C_el_fantasma_del_caos.jpg");
            this.imageList1.Images.SetKeyName(17, "montruo renacido.jpg");
            this.imageList1.Images.SetKeyName(18, "Foto_scapegoat.jpg");
            this.imageList1.Images.SetKeyName(19, "Foto_la_flauta_de_invocaci%3Fn_de_kuriboh.jpg");
            this.imageList1.Images.SetKeyName(20, "Foto_espadas_de_la_luz_reveladora.jpg");
            this.imageList1.Images.SetKeyName(21, "Foto_rascacielos.jpg");
            this.imageList1.Images.SetKeyName(22, "Foto_polimerizaci%3Fn.jpg");
            this.imageList1.Images.SetKeyName(23, "Foto_fusi%3Fn_neos.jpg");
            this.imageList1.Images.SetKeyName(24, "Foto_ritual_del_brillo_negro.jpg");
            this.imageList1.Images.SetKeyName(25, "Foto_espada_de_la_destrucci%3Fn_oscura.jpg");
            this.imageList1.Images.SetKeyName(26, "Foto_de-fusi%3Fn.jpg");
            this.imageList1.Images.SetKeyName(27, "Foto_tablero_del_destino.jpg");
            this.imageList1.Images.SetKeyName(28, "Foto_canadia_paleozoico.jpg");
            this.imageList1.Images.SetKeyName(29, "Foto_encarnaci%3Fn_de_apophis.jpg");
            this.imageList1.Images.SetKeyName(30, "Foto_cilindro_m%3Fgico (1).jpg");
            this.imageList1.Images.SetKeyName(31, "Foto_soborno_oscuro.jpg");
            this.imageList1.Images.SetKeyName(32, "Foto_negar_ataque.jpg");
            this.imageList1.Images.SetKeyName(33, "Foto_llamada_de_los_condenados.jpg");
            this.imageList1.Images.SetKeyName(34, "Foto_tributo_torrencial.jpg");
            this.imageList1.Images.SetKeyName(35, "Foto_camino_de_luz_de_estrellas.jpg");
            this.imageList1.Images.SetKeyName(36, "Foto_trampa_de_inversi%3Fn.jpg");
            this.imageList1.Images.SetKeyName(37, "Foto_cr%3Fneo_convocado.jpg");
            this.imageList1.Images.SetKeyName(38, "Foto_drag%3Fn_negro_de_ojos_rojos.jpg");
            this.imageList1.Images.SetKeyName(39, "Foto_drag%3Fn_de_corte_de_ojos_rojos.jpg");
            // 
            // lbImage
            // 
            this.lbImage.ImageList = this.imageList1;
            this.lbImage.Location = new System.Drawing.Point(504, 42);
            this.lbImage.Name = "lbImage";
            this.lbImage.Size = new System.Drawing.Size(116, 105);
            this.lbImage.TabIndex = 5;
            // 
            // rtbInfoCartas
            // 
            this.rtbInfoCartas.Location = new System.Drawing.Point(669, 39);
            this.rtbInfoCartas.Name = "rtbInfoCartas";
            this.rtbInfoCartas.Size = new System.Drawing.Size(176, 392);
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
            // lblMisCartas
            // 
            this.lblMisCartas.Location = new System.Drawing.Point(911, 8);
            this.lblMisCartas.Name = "lblMisCartas";
            this.lblMisCartas.Size = new System.Drawing.Size(141, 23);
            this.lblMisCartas.TabIndex = 8;
            this.lblMisCartas.Text = "Mis Cartas";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(895, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(167, 392);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // FrmComprarCartas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FrmPrincipal.Properties.Resources.Tablero_de_juego_v4;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblMisCartas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbInfoCartas);
            this.Controls.Add(this.lbImage);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnMostrarCarta);
            this.Controls.Add(this.dtgCartas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmComprarCartas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCrearDeck";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmComprarCartas_FormClosing);
            this.Load += new System.EventHandler(this.FrmComprarCarta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCartas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCartas;
        private System.Windows.Forms.Button btnMostrarCarta;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lbImage;
        private System.Windows.Forms.RichTextBox rtbInfoCartas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMisCartas;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}