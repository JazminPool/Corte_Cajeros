using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corte_Cajeros
{
    public partial class Splahs_Login : Form
    {
        public Splahs_Login()
        {
            InitializeComponent();
            this.Size = new Size(630, 215);
            #region "Inicializando objetos"
            Container_Login.Visible = false;
            img2.Visible = false;
            img3.Visible = false;
            img4.Visible = false;
            #endregion

        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            WFrmPanel_Control pc = new WFrmPanel_Control();
            pc.Show();
        }



        #region "Cerrar ventana"
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region "Tipo hilo del splash"
        private void tiempoSplash_Tick(object sender, EventArgs e)
        {
            try
            {
                if (rectCarga.Width >= 250)
                    img2.Visible = true;
                if (rectCarga.Width >= 350)
                    img3.Visible = true;
                if (rectCarga.Width >= 450)
                    img4.Visible = true;

                rectCarga.Width += 50; //acumulador
                if (rectCarga.Width >= 564)
                {
                    tiempoSplash.Stop(); //se detiene el hilo
                    this.Size = new Size(630, 358); //tamaño del form
                    Container_Login.Visible = true; //se muestra el contenedor del login
                } 
            }catch(Exception)
            {
                return;
            }
        }
        #endregion

        #region "Place holder de Usuario"
        private void txfUser_Enter(object sender, EventArgs e)
        {
            if (txfUser.Text == "Ingrese usuario")
            {
                txfUser.Text = "";
                txfUser.ForeColor = Color.FromArgb(38, 50, 56);
                txfUser.Font = new Font("Open Sans", txfUser.Font.Size + 2);
            }
        }        
        private void txfUser_Leave(object sender, EventArgs e)
        {
            if (txfUser.Text == "")
            {
                txfUser.Text = "Ingrese usuario";
                txfUser.ForeColor = Color.DimGray;
                txfUser.Font = new Font("Open Sans", txfUser.Font.Size -2);
            }
        }
        #endregion
        #region "Place holder de contraseña"
        private void txfPassword_Enter(object sender, EventArgs e)
        {
            if (txfPassword.Text == "Ingrese contraseña")
            {
                txfPassword.Text = "";
                txfPassword.ForeColor = Color.FromArgb(38, 50, 56);
                txfPassword.Font = new Font("Segoe UI", txfPassword.Font.Size + 2);
            }
        }
        private void txfPassword_Leave(object sender, EventArgs e)
        {
            if (txfPassword.Text == "")
            {
                txfPassword.Text = "Ingrese contraseña";
                txfPassword.ForeColor = Color.DimGray;
                txfPassword.Font = new Font("Segoe UI", txfPassword.Font.Size - 2);
            }
        }
        #endregion


        #region "Mover el Container sin el borde"
        int move, valx, valy; //Variables
        private void ContainerSplash_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            valx = e.X;
            valy = e.Y;
        }


        private void ContainerSplash_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void ContainerSplash_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
                this.SetDesktopLocation(MousePosition.X - valx, MousePosition.Y - valy);
        }
        #endregion

    }
}
