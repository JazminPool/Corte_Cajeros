namespace Corte_Cajeros
{
    partial class WFrmCambioBoleto
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
            this.Container_Cambio_boletos = new System.Windows.Forms.Panel();
            this.txfSobrantes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txfHasta = new System.Windows.Forms.TextBox();
            this.txfDe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Container_Cambio_boletos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Container_Cambio_boletos
            // 
            this.Container_Cambio_boletos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Container_Cambio_boletos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Container_Cambio_boletos.Controls.Add(this.txfSobrantes);
            this.Container_Cambio_boletos.Controls.Add(this.label4);
            this.Container_Cambio_boletos.Controls.Add(this.btnRegresar);
            this.Container_Cambio_boletos.Controls.Add(this.btnGuardar);
            this.Container_Cambio_boletos.Controls.Add(this.txfHasta);
            this.Container_Cambio_boletos.Controls.Add(this.txfDe);
            this.Container_Cambio_boletos.Controls.Add(this.label3);
            this.Container_Cambio_boletos.Controls.Add(this.label2);
            this.Container_Cambio_boletos.Controls.Add(this.label1);
            this.Container_Cambio_boletos.Location = new System.Drawing.Point(-1, 0);
            this.Container_Cambio_boletos.Name = "Container_Cambio_boletos";
            this.Container_Cambio_boletos.Size = new System.Drawing.Size(284, 191);
            this.Container_Cambio_boletos.TabIndex = 8;
            // 
            // txfSobrantes
            // 
            this.txfSobrantes.ForeColor = System.Drawing.Color.Red;
            this.txfSobrantes.Location = new System.Drawing.Point(133, 110);
            this.txfSobrantes.Name = "txfSobrantes";
            this.txfSobrantes.Size = new System.Drawing.Size(108, 20);
            this.txfSobrantes.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sobrantes físicos";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Maroon;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegresar.Image = global::Corte_Cajeros.Properties.Resources.left_arrow;
            this.btnRegresar.Location = new System.Drawing.Point(133, 144);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(113, 34);
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.Text = "    Regresar";
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Location = new System.Drawing.Point(14, 142);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(113, 34);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "   Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txfHasta
            // 
            this.txfHasta.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txfHasta.ForeColor = System.Drawing.Color.Red;
            this.txfHasta.Location = new System.Drawing.Point(189, 64);
            this.txfHasta.MaxLength = 6;
            this.txfHasta.Name = "txfHasta";
            this.txfHasta.Size = new System.Drawing.Size(63, 27);
            this.txfHasta.TabIndex = 4;
            // 
            // txfDe
            // 
            this.txfDe.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txfDe.ForeColor = System.Drawing.Color.Red;
            this.txfDe.Location = new System.Drawing.Point(64, 64);
            this.txfDe.MaxLength = 6;
            this.txfDe.Name = "txfDe";
            this.txfDe.Size = new System.Drawing.Size(63, 27);
            this.txfDe.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(19)))), ((int)(((byte)(22)))));
            this.label3.Location = new System.Drawing.Point(133, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(19)))), ((int)(((byte)(22)))));
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desde:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(19)))), ((int)(((byte)(22)))));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevos boletos";
            // 
            // WFrmCambioBoleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 190);
            this.Controls.Add(this.Container_Cambio_boletos);
            this.Name = "WFrmCambioBoleto";
            this.Text = "WFrmCambioBoleto";
            this.Container_Cambio_boletos.ResumeLayout(false);
            this.Container_Cambio_boletos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Container_Cambio_boletos;
        private System.Windows.Forms.TextBox txfSobrantes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txfHasta;
        private System.Windows.Forms.TextBox txfDe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}