using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using Prj_Capa_Entidad;
using System.Windows.Forms;

namespace Prj_Capa_Datos
{
 public class BD_Horario :Cls_Conexion
    {
        public static bool seguardo = false;
        public void BD_actualizarHorario(EN_Horario hor)
        {
            MySqlConnection cn = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cn.ConnectionString = Conectar();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_actualizas_horario";
                cmd.Connection = cn;
                cmd.CommandTimeout = 20;
                //parametros
                cmd.Parameters.AddWithValue("xId_Hor", hor.Idhora);
                cmd.Parameters.AddWithValue("xHoEntrada", hor.HoEntrada);
                cmd.Parameters.AddWithValue("xMiTolermcia", hor.HoTole);
                cmd.Parameters.AddWithValue("xHolimite", hor.HoLimite);
                cmd.Parameters.AddWithValue("xHoSalida", hor.HoSalida);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                cmd.Dispose();
                cmd = null;
                seguardo = true;

            }

            catch(Exception ex)
            {
                seguardo = false;
                
               MessageBox.Show("Error al actualizar" + ex.Message, "Advertencia");
                if (cn.State == ConnectionState.Open) cn.Close();
                
                cmd.Dispose();
                cmd = null;
                cn.Dispose();
                cn = null;
            }
        }

        public DataTable BD_Leer_Horarios()
        {
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                MySqlDataAdapter Da = new MySqlDataAdapter("sp_listarHorario", cn);
                Da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable Datos = new DataTable();
                Da.Fill(Datos);
                Da = null;
                return Datos;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hay Error al consultar horario" + ex.Message, "Informe del sistema", MessageBoxButtons.OK);
                if (cn.State == ConnectionState.Open) cn.Close();
                cn.Dispose();
                cn = null;
                return null;
            }

          
        }

    }

   
}
