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
        int contador = 0;
        int resultado = 0;
        int aux = 0;
        int suma_total = 0;
        BD obj;

        Validacion val = new Validacion();
        public WFrmPanel_Control()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            lblNombre_Cajero.Text = BD.nombre_completo;
            lblTurno.Text = BD.turno_descripcion;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Splahs_Login splash = new Splahs_Login();
            splash.Close();
            this.Close();
        }

        private void btnCerrar_Sesion_Click(object sender, EventArgs e)
        {
            validar(this);
            int resultado = 0;
            int boletos_cobrados = int.Parse(txfBoletos_cobrados.Text.ToString());
            int boletos_tolerancia = int.Parse(txfBoletos_tolerancia.Text.ToString());
            int boletos_cortesia = int.Parse(txfBoletos_cortesia.Text.ToString());
            int boletos_guada = int.Parse(txfBoletos_GUADA.Text.ToString());
            int boletos_perdidos = int.Parse(txfBoletos_perdidos.Text.ToString());
            int salidas_tarjeta = int.Parse(txfSalidas_tarjeta.Text.ToString());
            
            resultado = boletos_cobrados + boletos_tolerancia + boletos_cortesia + boletos_guada + boletos_perdidos;
            suma_total = resultado + salidas_tarjeta;

            txfBoletos_totales.Text = resultado.ToString();
        }

        private void btnCambio_boletos_Click(object sender, EventArgs e)
        {
            WFrmCambioBoleto ver_ventana = new WFrmCambioBoleto();
            ver_ventana.Show();

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

        private void txfBoletos_totales_TextChanged(object sender, EventArgs e)
        {
            
        }

  

        private void txfBoletos_perdidos_TextChanged(object sender, EventArgs e)
        {
           
        }

        public bool vacio; // Variable utilizada para saber si hay algún TextBox vacio.
        private void validar(Form formulario)
        {
            foreach (Control oControls in formulario.Controls) // Buscamos en cada TextBox de nuestro Formulario.
            {
                if (oControls is TextBox & oControls.Text == String.Empty) // Verificamos que no este vacio.
                {
                    vacio = true; // Si esta vacio el TextBox asignamos el valor True a nuestra variable.
                }
            }
            if (vacio == true) MessageBox.Show("Favor de llenar todos los campos."); // Si nuestra variable es verdadera mostramos un mensaje.
            vacio = false; // Devolvemos el valor original a nuestra variable.
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {  
            obj = new BD();

            try
            {
                BD bd = new BD();
                Reportes nuevo_reporte = new Reportes();
                nuevo_reporte.folios_rojos = int.Parse(txfFolios_Rojos.Text.ToString());
                nuevo_reporte.folio_emisor = 23265;
                nuevo_reporte.contador = int.Parse(txfContador.Text.ToString());
                nuevo_reporte.coches_dentro = int.Parse(txfCoches_dentro.Text.ToString());
                nuevo_reporte.entradas_tarjeta = int.Parse(txfEntradas_tarjeta.Text.ToString());
                nuevo_reporte.salidas_tarjeta = int.Parse(txfSalidas_tarjeta.Text.ToString());
                nuevo_reporte.boletos_cobrados = int.Parse(txfBoletos_cobrados.Text.ToString());
                nuevo_reporte.boletos_tolerancia = int.Parse(txfBoletos_tolerancia.Text.ToString());
                nuevo_reporte.boletos_cortesia = int.Parse(txfBoletos_cortesia.Text.ToString());
                nuevo_reporte.boletos_guada = int.Parse(txfBoletos_GUADA.Text.ToString());
                nuevo_reporte.boletos_perdidos = int.Parse(txfBoletos_perdidos.Text.ToString());
                nuevo_reporte.total_boletos = nuevo_reporte.boletos_cobrados + nuevo_reporte.boletos_cortesia + nuevo_reporte.boletos_guada + nuevo_reporte.boletos_perdidos + nuevo_reporte.boletos_tolerancia;
                nuevo_reporte.total_salidas = nuevo_reporte.salidas_tarjeta + nuevo_reporte.total_boletos;


                int resultado = bd.agregar_reporte(nuevo_reporte,BD.id_empleado);

                if (resultado==7)
                {
                    MessageBox.Show("Datos ingresados_correctamente");
                }
                else { MessageBox.Show("ALGO NO LOGRO REGISTRARSE"); }


            }
            catch (Exception ex) { MessageBox.Show("Error" + ex); }
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
