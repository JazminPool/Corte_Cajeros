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
    public partial class WFrmCambioBoleto : Form
    {
        public WFrmCambioBoleto()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int de = int.Parse(txfDe.Text.ToString());
            int hasta = int.Parse(txfHasta.Text.ToString());

            int resultado = 0;

            resultado = de - hasta;

            txfSobrantes.Text = resultado.ToString();

            Numero_cincho vtn_cincho = new Numero_cincho();
            vtn_cincho.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
