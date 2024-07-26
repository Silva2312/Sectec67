using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Prj_Capa_Datos
{
    public class BD_Utilitario : Cls_Conexion
    {

        public static string BD_NroDoc(int idtipo)
        {
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn.ConnectionString = Conectar2();
                MySqlCommand cmd = new MySqlCommand("Sp_Listado_tipo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_id_tipo", idtipo);//cambiar
                string NroDoc = "";
                cn.Open();
                NroDoc = Convert.ToString(cmd.ExecuteScalar());

                return NroDoc;
            }

            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Clone();
                }
                MessageBox.Show("No se puede leer +" + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
            return "";
        }

        public static void BD_ActualizarNro(int idtipo, string numero)
        {
            MySqlConnection cn = new MySqlConnection(Conectar2());
            MySqlCommand cmd = new MySqlCommand("Sp_Actualiza_Tipo_Doc", cn);


            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_idtipo", idtipo);
                cmd.Parameters.AddWithValue("_numero", numero);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Clone();
                }
                MessageBox.Show("No se puede leer +" + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public static string BD_Leer_Solo_Numero(int idtipo)
        {
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn.ConnectionString = Conectar2();
                MySqlCommand cmd = new MySqlCommand("Sp_Listar_Solo_Numero", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_idtipo", idtipo);

                string xNumero;

                cn.Open();
                xNumero = Convert.ToString(cmd.ExecuteScalar());
                return xNumero;
                //MySqlDataAdapter da = new MySqlDataAdapter("", cn);
            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Clone();
                }
                MessageBox.Show("No se puede leer +" + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return "";
        }


        public static string BD_Listar_tipoRobot(int idtipo)
        {
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn.ConnectionString = Conectar2();
                MySqlCommand cmd = new MySqlCommand("Sp_ListarRobot", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_idtipo", idtipo);

                string tipoRobot;
                cn.Open();
                tipoRobot = Convert.ToString(cmd.ExecuteScalar());
                cn.Close();
                return tipoRobot;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Advertencia de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(cn.State==ConnectionState.Open)cn.Close();
                cn.Dispose();
                cn = null;
                return null;
            }
        }


        public static bool falta = false;
        public void BD_Actualizar_TipoRobot(int idtipo, string serie)
        {

            MySqlConnection cn = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand("Sp_Editar_Robot", cn);

            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_idtipo", idtipo);
                cmd.Parameters.AddWithValue("_tipoRobot", serie);


                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                falta = true;
            }
            catch(Exception ex)
            {
                falta = false;
                MessageBox.Show("Algo solio mal en el robot" + ex.Message, "Advertencia seguridad");
                if (cn.State == ConnectionState.Open) { cn.Close();}
            }
        }
    }
}

