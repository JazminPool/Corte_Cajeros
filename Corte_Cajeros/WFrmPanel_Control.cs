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
    public partial class WFrmPanel_Control : Form
    {
        Validacion val = new Validacion();
        public WFrmPanel_Control()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Splahs_Login splash = new Splahs_Login();
            splash.Close();
            this.Close();
        }

        private void btnCerrar_Sesion_Click(object sender, EventArgs e)
        {

        }

        private void btnCambio_boletos_Click(object sender, EventArgs e)
        {
            
        }

        #region "Validacion de TextBox solo numeros"
        private void txfFolios_Rojos_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }
        private void txfContador_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txfCoches_dentro_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txfEntradas_tarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txfSalidas_tarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txfBoletos_perdidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txfBoletos_GUADA_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txfBoletos_cortesia_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txfBoletos_tolerancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txfBoletos_cobrados_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txfBoletos_totales_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txfSalidas_totales_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }
        #endregion

        #region "Hora y fecha"
        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha_dia.Text = DateTime.Now.ToLongDateString();
        }
        #endregion

        #region "Mover el panel"
        int move, valx, valy; //Variables
        private void nav_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        

        private void WFrmPanel_Control_Load(object sender, EventArgs e)
        {

        }

        private void nav_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
                this.SetDesktopLocation(MousePosition.X - valx, MousePosition.Y - valy);
        }

        private void nav_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            valx = e.X;
            valy = e.Y;
        }
        #endregion
    }
}
