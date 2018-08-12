namespace Corte_Cajeros
{
    partial class WFrmPanel_Control
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
            this.nav = new System.Windows.Forms.Panel();
            this.lblFecha_dia = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblNombre_Cajero = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txfFolios_Rojos = new System.Windows.Forms.TextBox();
            this.txfContador = new System.Windows.Forms.TextBox();
            this.txfCoches_dentro = new System.Windows.Forms.TextBox();
            this.txfEntradas_tarjeta = new System.Windows.Forms.TextBox();
            this.txfBoletos_tolerancia = new System.Windows.Forms.TextBox();
            this.txfSalidas_tarjeta = new System.Windows.Forms.TextBox();
            this.txfBoletos_totales = new System.Windows.Forms.TextBox();
            this.txfSalidas_totales = new System.Windows.Forms.TextBox();
            this.footer = new System.Windows.Forms.Panel();
            this.txfFolio_emisor = new System.Windows.Forms.TextBox();
            this.txfBoletos_cobrados = new System.Windows.Forms.TextBox();
            this.txfBoletos_cortesia = new System.Windows.Forms.TextBox();
            this.txfBoletos_GUADA = new System.Windows.Forms.TextBox();
            this.txfBoletos_perdidos = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnCerrar_Sesion = new System.Windows.Forms.Button();
            this.btnCambio_boletos = new System.Windows.Forms.Button();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nav
            // 
            this.nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            this.nav.Controls.Add(this.lblFecha_dia);
            this.nav.Controls.Add(this.lblHora);
            this.nav.Controls.Add(this.lblTurno);
            this.nav.Controls.Add(this.lblNombre_Cajero);
            this.nav.Controls.Add(this.pictureBox1);
            this.nav.Controls.Add(this.btnSalir);
            this.nav.Dock = System.Windows.Forms.DockStyle.Top;
            this.nav.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nav.Location = new System.Drawing.Point(0, 0);
            this.nav.Name = "nav";
            this.nav.Size = new System.Drawing.Size(827, 121);
            this.nav.TabIndex = 0;
            this.nav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nav_MouseDown);
            this.nav.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nav_MouseMove);
            this.nav.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nav_MouseUp);
            // 
            // lblFecha_dia
            // 
            this.lblFecha_dia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha_dia.AutoSize = true;
            this.lblFecha_dia.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha_dia.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFecha_dia.Location = new System.Drawing.Point(484, 83);
            this.lblFecha_dia.Name = "lblFecha_dia";
            this.lblFecha_dia.Size = new System.Drawing.Size(287, 22);
            this.lblFecha_dia.TabIndex = 13;
            this.lblFecha_dia.Text = "Miércoles, 13 de Septiembre de 2018";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Open Sans", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHora.Location = new System.Drawing.Point(451, 18);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(340, 65);
            this.lblHora.TabIndex = 12;
            this.lblHora.Text = "00:00:00 p. m.";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTurno.Location = new System.Drawing.Point(119, 82);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(87, 26);
            this.lblTurno.TabIndex = 11;
            this.lblTurno.Text = "Turno 1 ";
            // 
            // lblNombre_Cajero
            // 
            this.lblNombre_Cajero.AutoSize = true;
            this.lblNombre_Cajero.Font = new System.Drawing.Font("Open Sans", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre_Cajero.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre_Cajero.Location = new System.Drawing.Point(111, 18);
            this.lblNombre_Cajero.Name = "lblNombre_Cajero";
            this.lblNombre_Cajero.Size = new System.Drawing.Size(173, 65);
            this.lblNombre_Cajero.TabIndex = 10;
            this.lblNombre_Cajero.Text = "Cajero";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Corte_Cajeros.Properties.Resources.woman1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Maroon;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Location = new System.Drawing.Point(792, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(35, 32);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Boletos Totales";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(484, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "Salidas Totales";
            // 
            // txfFolios_Rojos
            // 
            this.txfFolios_Rojos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txfFolios_Rojos.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txfFolios_Rojos.ForeColor = System.Drawing.Color.Red;
            this.txfFolios_Rojos.Location = new System.Drawing.Point(266, 163);
            this.txfFolios_Rojos.Margin = new System.Windows.Forms.Padding(3, 3, 100, 3);
            this.txfFolios_Rojos.MaxLength = 6;
            this.txfFolios_Rojos.Name = "txfFolios_Rojos";
            this.txfFolios_Rojos.Size = new System.Drawing.Size(131, 29);
            this.txfFolios_Rojos.TabIndex = 9;
            this.txfFolios_Rojos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txfFolios_Rojos_KeyPress);
            // 
            // txfContador
            // 
            this.txfContador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txfContador.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txfContador.Location = new System.Drawing.Point(118, 227);
            this.txfContador.Margin = new System.Windows.Forms.Padding(3, 3, 100, 3);
            this.txfContador.MaxLength = 8;
            this.txfContador.Name = "txfContador";
            this.txfContador.Size = new System.Drawing.Size(280, 29);
            this.txfContador.TabIndex = 10;
            this.txfContador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txfContador_KeyPress);
            // 
            // txfCoches_dentro
            // 
            this.txfCoches_dentro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txfCoches_dentro.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txfCoches_dentro.Location = new System.Drawing.Point(119, 303);
            this.txfCoches_dentro.Margin = new System.Windows.Forms.Padding(3, 3, 100, 3);
            this.txfCoches_dentro.MaxLength = 3;
            this.txfCoches_dentro.Name = "txfCoches_dentro";
            this.txfCoches_dentro.Size = new System.Drawing.Size(280, 29);
            this.txfCoches_dentro.TabIndex = 11;
            this.txfCoches_dentro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txfCoches_dentro_KeyPress);
            // 
            // txfEntradas_tarjeta
            // 
            this.txfEntradas_tarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txfEntradas_tarjeta.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txfEntradas_tarjeta.Location = new System.Drawing.Point(119, 380);
            this.txfEntradas_tarjeta.MaxLength = 3;
            this.txfEntradas_tarjeta.Name = "txfEntradas_tarjeta";
            this.txfEntradas_tarjeta.Size = new System.Drawing.Size(280, 29);
            this.txfEntradas_tarjeta.TabIndex = 12;
            this.txfEntradas_tarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txfEntradas_tarjeta_KeyPress);
            // 
            // txfBoletos_tolerancia
            // 
            this.txfBoletos_tolerancia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txfBoletos_tolerancia.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txfBoletos_tolerancia.Location = new System.Drawing.Point(446, 233);
            this.txfBoletos_tolerancia.MaxLength = 3;
            this.txfBoletos_tolerancia.Name = "txfBoletos_tolerancia";
            this.txfBoletos_tolerancia.Size = new System.Drawing.Size(280, 29);
            this.txfBoletos_tolerancia.TabIndex = 15;
            this.txfBoletos_tolerancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txfBoletos_tolerancia_KeyPress);
            // 
            // txfSalidas_tarjeta
            // 
            this.txfSalidas_tarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txfSalidas_tarjeta.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txfSalidas_tarjeta.Location = new System.Drawing.Point(118, 456);
            this.txfSalidas_tarjeta.MaxLength = 3;
            this.txfSalidas_tarjeta.Name = "txfSalidas_tarjeta";
            this.txfSalidas_tarjeta.Size = new System.Drawing.Size(279, 29);
            this.txfSalidas_tarjeta.TabIndex = 13;
            this.txfSalidas_tarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txfSalidas_tarjeta_KeyPress);
            // 
            // txfBoletos_totales
            // 
            this.txfBoletos_totales.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txfBoletos_totales.Location = new System.Drawing.Point(50, 525);
            this.txfBoletos_totales.MaxLength = 3;
            this.txfBoletos_totales.Name = "txfBoletos_totales";
            this.txfBoletos_totales.ReadOnly = true;
            this.txfBoletos_totales.Size = new System.Drawing.Size(281, 29);
            this.txfBoletos_totales.TabIndex = 19;
            this.txfBoletos_totales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txfBoletos_totales_KeyPress);
            // 
            // txfSalidas_totales
            // 
            this.txfSalidas_totales.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txfSalidas_totales.Location = new System.Drawing.Point(488, 524);
            this.txfSalidas_totales.MaxLength = 3;
            this.txfSalidas_totales.Name = "txfSalidas_totales";
            this.txfSalidas_totales.ReadOnly = true;
            this.txfSalidas_totales.Size = new System.Drawing.Size(280, 29);
            this.txfSalidas_totales.TabIndex = 20;
            this.txfSalidas_totales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txfSalidas_totales_KeyPress);
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(46)))), ((int)(((byte)(60)))));
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 629);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(827, 30);
            this.footer.TabIndex = 30;
            // 
            // txfFolio_emisor
            // 
            this.txfFolio_emisor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txfFolio_emisor.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txfFolio_emisor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txfFolio_emisor.Location = new System.Drawing.Point(118, 163);
            this.txfFolio_emisor.Margin = new System.Windows.Forms.Padding(3, 3, 100, 3);
            this.txfFolio_emisor.MaxLength = 8;
            this.txfFolio_emisor.Name = "txfFolio_emisor";
            this.txfFolio_emisor.ReadOnly = true;
            this.txfFolio_emisor.Size = new System.Drawing.Size(129, 29);
            this.txfFolio_emisor.TabIndex = 19;
            // 
            // txfBoletos_cobrados
            // 
            this.txfBoletos_cobrados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txfBoletos_cobrados.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txfBoletos_cobrados.Location = new System.Drawing.Point(445, 163);
            this.txfBoletos_cobrados.MaxLength = 3;
            this.txfBoletos_cobrados.Name = "txfBoletos_cobrados";
            this.txfBoletos_cobrados.Size = new System.Drawing.Size(280, 29);
            this.txfBoletos_cobrados.TabIndex = 14;
            this.txfBoletos_cobrados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txfBoletos_cobrados_KeyPress);
            // 
            // txfBoletos_cortesia
            // 
            this.txfBoletos_cortesia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txfBoletos_cortesia.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txfBoletos_cortesia.Location = new System.Drawing.Point(447, 302);
            this.txfBoletos_cortesia.MaxLength = 3;
            this.txfBoletos_cortesia.Name = "txfBoletos_cortesia";
            this.txfBoletos_cortesia.Size = new System.Drawing.Size(280, 29);
            this.txfBoletos_cortesia.TabIndex = 16;
            this.txfBoletos_cortesia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txfBoletos_cortesia_KeyPress);
            // 
            // txfBoletos_GUADA
            // 
            this.txfBoletos_GUADA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txfBoletos_GUADA.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txfBoletos_GUADA.Location = new System.Drawing.Point(448, 379);
            this.txfBoletos_GUADA.MaxLength = 3;
            this.txfBoletos_GUADA.Name = "txfBoletos_GUADA";
            this.txfBoletos_GUADA.Size = new System.Drawing.Size(280, 29);
            this.txfBoletos_GUADA.TabIndex = 17;
            this.txfBoletos_GUADA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txfBoletos_GUADA_KeyPress);
            // 
            // txfBoletos_perdidos
            // 
            this.txfBoletos_perdidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txfBoletos_perdidos.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txfBoletos_perdidos.Location = new System.Drawing.Point(445, 456);
            this.txfBoletos_perdidos.MaxLength = 3;
            this.txfBoletos_perdidos.Name = "txfBoletos_perdidos";
            this.txfBoletos_perdidos.Size = new System.Drawing.Size(280, 29);
            this.txfBoletos_perdidos.TabIndex = 18;
            this.txfBoletos_perdidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txfBoletos_perdidos_KeyPress);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.Black;
            this.btnGenerar.Location = new System.Drawing.Point(316, 572);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(195, 39);
            this.btnGenerar.TabIndex = 28;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = false;
            // 
            // btnCerrar_Sesion
            // 
            this.btnCerrar_Sesion.BackColor = System.Drawing.Color.Maroon;
            this.btnCerrar_Sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar_Sesion.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar_Sesion.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCerrar_Sesion.Location = new System.Drawing.Point(573, 572);
            this.btnCerrar_Sesion.Name = "btnCerrar_Sesion";
            this.btnCerrar_Sesion.Size = new System.Drawing.Size(195, 39);
            this.btnCerrar_Sesion.TabIndex = 29;
            this.btnCerrar_Sesion.Text = "Cerrar Sesión";
            this.btnCerrar_Sesion.UseVisualStyleBackColor = false;
            this.btnCerrar_Sesion.Click += new System.EventHandler(this.btnCerrar_Sesion_Click);
            // 
            // btnCambio_boletos
            // 
            this.btnCambio_boletos.BackColor = System.Drawing.Color.Orange;
            this.btnCambio_boletos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambio_boletos.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambio_boletos.ForeColor = System.Drawing.Color.Black;
            this.btnCambio_boletos.Location = new System.Drawing.Point(50, 572);
            this.btnCambio_boletos.Name = "btnCambio_boletos";
            this.btnCambio_boletos.Size = new System.Drawing.Size(195, 39);
            this.btnCambio_boletos.TabIndex = 30;
            this.btnCambio_boletos.Text = "Cambio de boletos";
            this.btnCambio_boletos.UseVisualStyleBackColor = false;
            this.btnCambio_boletos.Click += new System.EventHandler(this.btnCambio_boletos_Click);
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 44;
            this.label1.Text = "Folio emisor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 22);
            this.label2.TabIndex = 45;
            this.label2.Text = "Entradas con tarjeta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 22);
            this.label3.TabIndex = 46;
            this.label3.Text = "Salidas con tarjeta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 22);
            this.label4.TabIndex = 47;
            this.label4.Text = "Boletos perdidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(445, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 22);
            this.label5.TabIndex = 48;
            this.label5.Text = "Boletos cortesía";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(118, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 22);
            this.label6.TabIndex = 49;
            this.label6.Text = "Coches dentro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(263, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 22);
            this.label9.TabIndex = 50;
            this.label9.Text = "Folios Rojo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(445, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 22);
            this.label10.TabIndex = 51;
            this.label10.Text = "Boletos cobrados";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(118, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 22);
            this.label11.TabIndex = 52;
            this.label11.Text = "Contador";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(445, 353);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 22);
            this.label12.TabIndex = 53;
            this.label12.Text = "Boletos GUADA";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(445, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 22);
            this.label13.TabIndex = 54;
            this.label13.Text = "Boletos tolerancia";
            // 
            // WFrmPanel_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(827, 659);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCambio_boletos);
            this.Controls.Add(this.btnCerrar_Sesion);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txfBoletos_perdidos);
            this.Controls.Add(this.txfBoletos_GUADA);
            this.Controls.Add(this.txfBoletos_cortesia);
            this.Controls.Add(this.txfBoletos_cobrados);
            this.Controls.Add(this.txfFolio_emisor);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.txfSalidas_totales);
            this.Controls.Add(this.txfBoletos_totales);
            this.Controls.Add(this.txfSalidas_tarjeta);
            this.Controls.Add(this.txfBoletos_tolerancia);
            this.Controls.Add(this.txfEntradas_tarjeta);
            this.Controls.Add(this.txfCoches_dentro);
            this.Controls.Add(this.txfContador);
            this.Controls.Add(this.txfFolios_Rojos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WFrmPanel_Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de corte de Cajeros";
            this.nav.ResumeLayout(false);
            this.nav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel nav;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblNombre_Cajero;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha_dia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txfFolios_Rojos;
        private System.Windows.Forms.TextBox txfContador;
        private System.Windows.Forms.TextBox txfCoches_dentro;
        private System.Windows.Forms.TextBox txfEntradas_tarjeta;
        private System.Windows.Forms.TextBox txfBoletos_tolerancia;
        private System.Windows.Forms.TextBox txfSalidas_tarjeta;
        private System.Windows.Forms.TextBox txfBoletos_totales;
        private System.Windows.Forms.TextBox txfSalidas_totales;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.TextBox txfFolio_emisor;
        private System.Windows.Forms.TextBox txfBoletos_cobrados;
        private System.Windows.Forms.TextBox txfBoletos_cortesia;
        private System.Windows.Forms.TextBox txfBoletos_GUADA;
        private System.Windows.Forms.TextBox txfBoletos_perdidos;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnCerrar_Sesion;
        private System.Windows.Forms.Button btnCambio_boletos;
        private System.Windows.Forms.Timer HoraFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}