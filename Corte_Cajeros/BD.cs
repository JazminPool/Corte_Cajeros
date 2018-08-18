using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Corte_Cajeros
{
    class BD
    {
        public static string nombre_completo;
       
         GestionDatos b_d = new GestionDatos();
       
        public static string turno_descripcion;
        public static int id_empleado;
        public Boolean Login(string usuario, string pass)
        {
            string turno_cajero = " ";
            b_d.abrir();

            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = b_d.conexion;

            codigo.CommandText = ("SELECT * FROM empledos_cajeros WHERE usuario_caje= '" + usuario + "' AND password_caje='" + pass + "'");

            MySqlDataReader leer = codigo.ExecuteReader();

            if (leer.Read())
            {
                id_empleado = int.Parse(leer["idempledos_cajeros"].ToString());
                nombre_completo = leer["Nombre_cajero"].ToString();
                turno_cajero = leer["turnos_caje_idturnos_caje"].ToString();
            }
            leer.Close();
            Trae_turno(turno_cajero);
        
            if (String.IsNullOrEmpty(nombre_completo))
            {
                return false;
            }
            else { return true; }
            b_d.cerrar();
        }

        #region metodo para traer el idturno actual
        //se pasa de parametro tipo string el id del turno y se almacena en una variable global
        public void Trae_turno(string turno)
        {
            try
            {
               
                int turno_cajero = Convert.ToInt32(turno);

                b_d.abrir();

                MySqlCommand consulta_turno = new MySqlCommand();
            consulta_turno.Connection = b_d.conexion;
                consulta_turno.CommandText = ("SELECT descripcion FROM turnos_caje WHERE idturnos_caje='" + turno_cajero + "'");
            MySqlDataReader trae = consulta_turno.ExecuteReader();
            if (trae.Read())
            {
                turno_descripcion = trae["descripcion"].ToString();
            }

                b_d.cerrar();
            } catch(Exception e) { }
        }
        #endregion

        #region Método para la bitacora general
        public int agregar_reporte(Reportes nuevo, int id)
        {   
            b_d.abrir();
            int retorno = 0;
             DateTime theDate = DateTime.Now;
            string resultado = string.Format("{0:u}", theDate);


            MySqlCommand myCommand = b_d.conexion.CreateCommand();
            MySqlTransaction trans;
            trans = b_d.conexion.BeginTransaction();

            myCommand.Connection = b_d.conexion;
            myCommand.Transaction = trans;
         
            try
            {
                /* Consultas para ingresar datos a cada tabla*/
                myCommand.CommandText = "INSERT INTO folios_rojos (idfolios_rojos,folio_entrada,folio_salida,diferencia_folio) VALUES ('" + nuevo.folios_rojos + "','" + nuevo.folios_rojos + "','" + null + "','" + null + "')";
                retorno=myCommand.ExecuteNonQuery();
                myCommand.CommandText = "INSERT INTO folio_emisor (idfolio_emisor, emisor_entrada, emisor_salida, diferencia_emisor) VALUES('"+ nuevo.folios_rojos + "', '"+nuevo.folio_emisor+"', '"+null+ "', '" + null + "')";
                retorno = myCommand.ExecuteNonQuery();
                myCommand.CommandText = "INSERT INTO coches_dentro (idcoches_dentro, coches_incio, coches_salida, diferencia_coches) VALUES('"+ nuevo.folios_rojos + "', '"+nuevo.coches_dentro+"', '"+null+"', '"+null+"')";
                retorno = myCommand.ExecuteNonQuery();
                myCommand.CommandText= "INSERT INTO contador_est (idcontador_est, inicio_contador, salida_contador, diferencia_contador ) VALUES('"+ nuevo.folios_rojos + "', '"+nuevo.contador+"', '"+null+"', '"+null+"')";
                retorno = myCommand.ExecuteNonQuery();
                myCommand.CommandText= "INSERT INTO tarjetas_control (idtarjetas_control, entrada_tarjeta, salidas_tarjeta) VALUES('"+ nuevo.folios_rojos + "', '"+nuevo.entradas_tarjeta+"','"+nuevo.salidas_tarjeta+"')";
                retorno = myCommand.ExecuteNonQuery();
                myCommand.CommandText = "INSERT INTO boletos_tipos (idboletos_tipos,boletos_cobrados,boletos_tolerancia,boletos_guada,boletos_cortesia,boletos_perdidos,boletos_totales) VALUES ('" + nuevo.folios_rojos + "','" + nuevo.boletos_cobrados + "','" + nuevo.boletos_tolerancia + "','" + nuevo.boletos_guada + "','" + nuevo.boletos_cortesia + "','"+nuevo.boletos_perdidos+"','"+nuevo.total_boletos+"')";
                retorno = myCommand.ExecuteNonQuery();
                
                //QUERY PARAA INSERTAR EN LA BITACORA_GENERAL
                myCommand.CommandText = "INSERT INTO reportes_cortes (idreportes_cortes,fecha_corte,idcajeros,idrojos,id_contador,emisor_idfolio,coches_idcoches,boletos_idboletos,tarjetas_idtarjetas,total_salidas ) VALUES ('" + nuevo.folios_rojos + "','"+resultado+"','"+id_empleado+"','" + nuevo.folios_rojos + "','" + nuevo.folios_rojos + "','" + nuevo.folios_rojos + "','" + nuevo.folios_rojos + "','" + nuevo.folios_rojos + "','" + nuevo.folios_rojos + "','" + nuevo.total_salidas + "')";
                retorno = myCommand.ExecuteNonQuery();
                trans.Commit();
                Console.WriteLine("Se inserto correctamente");
            }
            catch (Exception e)
            {
                try
                {
                    trans.Rollback();
                }
                catch (MySqlException ex)
                {
                    if (trans.Connection != null)
                    {
                        MessageBox.Show("Error al ingresar datos" + ex);
                    }
                }
                Console.WriteLine("An exception of type " + e.GetType() +
                " was encountered while inserting the data.");
                Console.WriteLine("No se ingreso ni un dato a la bd");
            }
            finally
            {
                b_d.cerrar();
            }
            return retorno;
        }
        #endregion

    }
        
    }

