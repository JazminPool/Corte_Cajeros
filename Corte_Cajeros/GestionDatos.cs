using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Corte_Cajeros
{
    
    /*Clase para conectar a la base de datos, cuenta con 2 métodos:
    Abrir: es la que abre la conexion a la bd
    Cerrar: Cierra la conexion a la bd*/
    class GestionDatos
    {
        public string datos = "server=localhost; database=cortes_estacionamiento; Uid=root; pwd=; SslMode=none";
        public MySqlConnection conexion;
        public void abrir()
        {
            try
            {
                conexion = new MySqlConnection(datos);
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Conexion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cerrar()
        {
            try
            {
                conexion = new MySqlConnection(datos);
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Conexion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





    }
}
