using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prj_Capa_Entidad;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Prj_Capa_Datos
{
   public class BD_Justificacion :Cls_Conexion
    {
        public static bool seguardo = false;
        public static bool edito = false;
        public static bool elimino = false;
        public void BD_registrar_justificacion(EN_Justificacion jus) 
        
        {
            MySqlConnection cn = new MySqlConnection(Conectar());
            MySqlCommand cmd = new MySqlCommand("Sp_registrar_justificacion", cn);
            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("_Id_Justi", jus.IdJusti);
                cmd.Parameters.AddWithValue("_Id_Personal", jus.Id_Personal);
                cmd.Parameters.AddWithValue("_Principalmoti", jus.PrincipalMotivo);
                cmd.Parameters.AddWithValue("_Detalle", jus.Detalle);
                cmd.Parameters.AddWithValue("_FechaJusti", jus.Fecha);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                seguardo = true;
            }
            catch(Exception ex)
            {
                seguardo = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo salio mal  ERROR EN GUARDAR"+ex.Message,"Advertencia");
            }
        }
        public void BD_Actualizar_justificacion(EN_Justificacion jus)
        {
            MySqlConnection cn = new MySqlConnection(Conectar());
            MySqlCommand cmd = new MySqlCommand("Sp_Actualizar_justificacion", cn);
            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_Id_Justi", jus.IdJusti);
                cmd.Parameters.AddWithValue("_Principalmoti", jus.PrincipalMotivo);
                cmd.Parameters.AddWithValue("_Detalle", jus.Detalle);
                cmd.Parameters.AddWithValue("_FechaJusti", jus.Fecha);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                edito = true;
            }
            catch (Exception ex)
            {
                edito = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo salio mal  ERROR EN EDITAR: " + ex.Message, " Advertencia ");
            }
        }
        public DataTable BD_Cargar_todos_Justificacion()
        {
            MySqlConnection xcn = new MySqlConnection();
            try
            {
                xcn.ConnectionString = Conectar();
                MySqlDataAdapter da = new MySqlDataAdapter("Sp_Listar_Justificaciones", xcn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable Dato = new DataTable();
                da.Fill(Dato);
                da = null;
                return Dato;
            }
            catch(Exception ex)
            {
                if (xcn.State == ConnectionState.Open)
                {
                    xcn.Close();
                }
                MessageBox.Show("Algo malo paso ESTE ES EL ERROR : " + ex.Message, " Advertencia de seguridad ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //AQUITAR POSIBLEMENTE POSIBLE ERROR
            return null;
        }
        public DataTable BD_BuscarJustificacion_porValor(string xdato)
        {
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                MySqlDataAdapter da = new MySqlDataAdapter("Sp_Buscador_Justificaciones", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("_valor", xdato);
                DataTable Dato = new DataTable();
                da.Fill(Dato);
                da = null;
                return Dato;
            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo malo paso: " + ex.Message, "Advertencia de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //AQUITAR POSIBLEMENTE POSIBLE ERROR
            return null;
        }


        public void BD_Eliminar_justificacion(string idjusti)
        {
            MySqlConnection cn = new MySqlConnection(Conectar());
            MySqlCommand cmd = new MySqlCommand("Sp_EliminarJustificacion", cn);
            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_idjusti", idjusti);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                elimino = true;
            }
            catch (Exception ex)
            {
                elimino = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al Eliminar: " + ex.Message, " Advertencia ");
            }
            
        }

        public void BD_Aprobar_Desaprobar_justificacion(string idjusti, string estadojus)
        {
            MySqlConnection cn = new MySqlConnection(Conectar());
            MySqlCommand cmd = new MySqlCommand("Sp_AprobarJustificacion", cn);
            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_idjusti", idjusti);
                cmd.Parameters.AddWithValue("_estadoJusti", estadojus);


                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                elimino = true;
            }
            catch (Exception ex)
            {
                elimino = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al Eliminar: " + ex.Message, " Advertencia ");
            }

        }


        public bool BD_verificar_SI_PERSONAS_TIENE_JUSTIFICACION(string idper)
        {
            bool retornoCarro = false;
            Int32 resultado = 0;

            MySqlConnection cn = new MySqlConnection();
            MySqlCommand cmdsuperamanetnerog = new MySqlCommand();

            cn.ConnectionString = Conectar();

            var cm = cmdsuperamanetnerog;

            cm.CommandText = "Sp_VerificarJustificacion_Aprobada";
            cm.Connection = cn;
            cm.CommandTimeout = 20;
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("_Id_Personal", idper);


            try
            {
                cn.Open();
                //si es 0 es igual a falso
                //si es 1 es =verdadero
                resultado = Convert.ToInt32(cm.ExecuteScalar());

                if (resultado > 0)
                {
                    retornoCarro = true;
                }
                else
                {
                    retornoCarro = false;
                }
                cm.Parameters.Clear();
                cm.Dispose();
                cm = null;
                cn.Close();
                cn = null;
            }
            catch (Exception ex)
            {
               
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Hay problemas: ");
            }
            return retornoCarro;

        }





    }
}
