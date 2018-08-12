namespace Corte_Cajeros
{
    partial class Splahs_Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splahs_Login));
            this.rectContenedor = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectCarga = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.tiempoSplash = new System.Windows.Forms.Timer(this.components);
            this.ContainerSplash = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.img1 = new System.Windows.Forms.PictureBox();
            this.img4 = new System.Windows.Forms.PictureBox();
            this.img2 = new System.Windows.Forms.PictureBox();
            this.img3 = new System.Windows.Forms.PictureBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.Container_Login = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txfPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txfUser = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.ContainerSplash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).BeginInit();
            this.Container_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rectContenedor
            // 
            this.rectContenedor.BackColor = System.Drawing.Color.White;
            this.rectContenedor.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectContenedor.BorderColor = System.Drawing.Color.White;
            this.rectContenedor.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.rectContenedor.Location = new System.Drawing.Point(27, 172);
            this.rectContenedor.Name = "rectContenedor";
            this.rectContenedor.Size = new System.Drawing.Size(576, 25);
            // 
            // rectCarga
            // 
            this.rectCarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.rectCarga.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectCarga.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.rectCarga.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.rectCarga.Location = new System.Drawing.Point(34, 176);
            this.rectCarga.Name = "rectCarga";
            this.rectCarga.Size = new System.Drawing.Size(32, 17);
            // 
            // tiempoSplash
            // 
            this.tiempoSplash.Enabled = true;
            this.tiempoSplash.Interval = 1;
            this.tiempoSplash.Tick += new System.EventHandler(this.tiempoSplash_Tick);
            // 
            // ContainerSplash
            // 
            this.ContainerSplash.Controls.Add(this.btnSalir);
            this.ContainerSplash.Controls.Add(this.img1);
            this.ContainerSplash.Controls.Add(this.img4);
            this.ContainerSplash.Controls.Add(this.img2);
            this.ContainerSplash.Controls.Add(this.img3);
            this.ContainerSplash.Controls.Add(this.shapeContainer2);
            this.ContainerSplash.Location = new System.Drawing.Point(0, 0);
            this.ContainerSplash.Name = "ContainerSplash";
            this.ContainerSplash.Size = new System.Drawing.Size(630, 215);
            this.ContainerSplash.TabIndex = 5;
            this.ContainerSplash.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContainerSplash_MouseDown);
            this.ContainerSplash.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ContainerSplash_MouseMove);
            this.ContainerSplash.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ContainerSplash_MouseUp);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Maroon;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Location = new System.Drawing.Point(596, -1);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(35, 32);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // img1
            // 
            this.img1.Image = global::Corte_Cajeros.Properties.Resources.man1;
            this.img1.Location = new System.Drawing.Point(31, 21);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(124, 130);
            this.img1.TabIndex = 0;
            this.img1.TabStop = false;
            // 
            // img4
            // 
            this.img4.Image = global::Corte_Cajeros.Properties.Resources.woman2;
            this.img4.Location = new System.Drawing.Point(477, 21);
            this.img4.Name = "img4";
            this.img4.Size = new System.Drawing.Size(124, 130);
            this.img4.TabIndex = 3;
            this.img4.TabStop = false;
            // 
            // img2
            // 
            this.img2.Image = global::Corte_Cajeros.Properties.Resources.woman1;
            this.img2.Location = new System.Drawing.Point(182, 21);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(124, 130);
            this.img2.TabIndex = 1;
            this.img2.TabStop = false;
            // 
            // img3
            // 
            this.img3.Image = global::Corte_Cajeros.Properties.Resources.man2;
            this.img3.Location = new System.Drawing.Point(328, 21);
            this.img3.Name = "img3";
            this.img3.Size = new System.Drawing.Size(124, 130);
            this.img3.TabIndex = 2;
            this.img3.TabStop = false;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectCarga,
            this.rectContenedor});
            this.shapeContainer2.Size = new System.Drawing.Size(630, 215);
            this.shapeContainer2.TabIndex = 4;
            this.shapeContainer2.TabStop = false;
            // 
            // Container_Login
            // 
            this.Container_Login.Controls.Add(this.label1);
            this.Container_Login.Controls.Add(this.btnIngresar);
            this.Container_Login.Controls.Add(this.pictureBox2);
            this.Container_Login.Controls.Add(this.txfPassword);
            this.Container_Login.Controls.Add(this.pictureBox1);
            this.Container_Login.Controls.Add(this.txfUser);
            this.Container_Login.Controls.Add(this.shapeContainer1);
            this.Container_Login.Location = new System.Drawing.Point(0, 172);
            this.Container_Login.Name = "Container_Login";
            this.Container_Login.Size = new System.Drawing.Size(630, 180);
            this.Container_Login.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(247, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "¡Que tenga un buen día!";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIngresar.Location = new System.Drawing.Point(194, 115);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(268, 37);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Acceder";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Corte_Cajeros.Properties.Resources.pass_32;
            this.pictureBox2.Location = new System.Drawing.Point(194, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // txfPassword
            // 
            this.txfPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.txfPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txfPassword.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txfPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txfPassword.Location = new System.Drawing.Point(235, 71);
            this.txfPassword.Name = "txfPassword";
            this.txfPassword.Size = new System.Drawing.Size(227, 22);
            this.txfPassword.TabIndex = 3;
            this.txfPassword.Text = "Ingrese contraseña";
            this.txfPassword.Enter += new System.EventHandler(this.txfPassword_Enter);
            this.txfPassword.Leave += new System.EventHandler(this.txfPassword_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Corte_Cajeros.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(193, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txfUser
            // 
            this.txfUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.txfUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txfUser.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txfUser.ForeColor = System.Drawing.Color.DimGray;
            this.txfUser.Location = new System.Drawing.Point(235, 11);
            this.txfUser.Name = "txfUser";
            this.txfUser.Size = new System.Drawing.Size(227, 22);
            this.txfUser.TabIndex = 1;
            this.txfUser.Text = "Ingrese usuario";
            this.txfUser.Enter += new System.EventHandler(this.txfUser_Enter);
            this.txfUser.Leave += new System.EventHandler(this.txfUser_Leave);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(630, 180);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.lineShape2.BorderWidth = 2;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.lineShape2.X1 = 188;
            this.lineShape2.X2 = 461;
            this.lineShape2.Y1 = 101;
            this.lineShape2.Y2 = 101;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.lineShape1.X1 = 188;
            this.lineShape1.X2 = 461;
            this.lineShape1.Y1 = 42;
            this.lineShape1.Y2 = 42;
            // 
            // Splahs_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(630, 352);
            this.Controls.Add(this.Container_Login);
            this.Controls.Add(this.ContainerSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Splahs_Login";
            this.Opacity = 0.95D;
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de corte de Cajeros";
            this.ContainerSplash.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).EndInit();
            this.Container_Login.ResumeLayout(false);
            this.Container_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox img1;
        private System.Windows.Forms.PictureBox img2;
        private System.Windows.Forms.PictureBox img3;
        private System.Windows.Forms.PictureBox img4;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectContenedor;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectCarga;
        private System.Windows.Forms.Timer tiempoSplash;
        private System.Windows.Forms.Panel ContainerSplash;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private System.Windows.Forms.Panel Container_Login;
        private System.Windows.Forms.TextBox txfUser;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txfPassword;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
    }
}

