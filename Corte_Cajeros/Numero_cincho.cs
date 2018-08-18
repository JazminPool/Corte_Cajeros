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
    public partial class Numero_cincho : Form
    {
        Validacion val = new Validacion();

        public Numero_cincho()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



        #region "Validacion de numeros"
        private void txfDe_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txfHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }
        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int de = int.Parse(txfDe.Text.ToString());
            int hasta = int.Parse(txfHasta.Text.ToString());

            int resultado = 0;

            resultado = de - hasta;

            txfCincho.Text = resultado.ToString();
        }
    }
}
