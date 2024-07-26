using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prj_Capa_Entidad;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;



namespace Prj_Capa_Datos
{
 public class BD_Asistencia : Cls_Conexion
    {
        public static bool Entrada = false;
      public void BD_registrar_Entrada(EN_Asistencia asi)
        {
            MySqlConnection cn = new MySqlConnection(Conectar());
            MySqlCommand cmd = new MySqlCommand("Sp_Registro_Entrada", cn);


            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Sp_Registro_Entrada",cn);
                cmd.Parameters.AddWithValue("xId_asis", asi.IdAsistencia);
                cmd.Parameters.AddWithValue("xId_pern1", asi.Id_Personal);
                cmd.Parameters.AddWithValue("xNombre_dia", asi.Nombre_Dia);
                cmd.Parameters.AddWithValue("xHoIngreso", asi.HoraIngre);
                cmd.Parameters.AddWithValue("xJustificacion", asi.Justificacion);
                cmd.Parameters.AddWithValue("xTardanzas", asi.Tardanza);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                Entrada = true;
            }
            catch(Exception ex)
            {
                Entrada = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al registrar entrada: " + ex.Message, "Error Registros");
            }

        }

        public static bool salida = false;

        public void BD_registrar_Salida(EN_Asistencia asi)
        {
            MySqlConnection cn = new MySqlConnection(Conectar());
            MySqlCommand cmd = new MySqlCommand("sp_registrar_salida", cn);


            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Sp_Registro_Entrada", cn);
                cmd.Parameters.AddWithValue("xId_asis", asi.IdAsistencia);
                cmd.Parameters.AddWithValue("xId_pern1", asi.Id_Personal);
                cmd.Parameters.AddWithValue("xhorasalida", asi.HoraSalida);
                cmd.Parameters.AddWithValue("xtlho_traba", asi.TotalHoras);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                salida = true;
            }
            catch (Exception ex)
            {
                salida = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al registrar salida: " + ex.Message, "Error Registrar salida");
            }

        }


        public bool BD_verificarsi_yaMarco_su_asistencia(string idper)
        {
            bool retornoCarro = false;
            Int32 resultado = 0;

            MySqlConnection cn = new MySqlConnection();
            MySqlCommand cmdsuperamanetnerog = new MySqlCommand();

            cn.ConnectionString = Conectar();

            var cm = cmdsuperamanetnerog;

            cm.CommandText = "Sp_verificarsiMarco";
            cm.Connection = cn;
            cm.CommandTimeout = 20;
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("xidper", idper);


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
                Entrada = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al verificar si marco asistencia: " + ex.Message, "Error al verificar");
            }
            return retornoCarro;

        }


        //SP VERIFICAR SI YA MARCO SU FALTA
        public bool BD_verificarsiMarcoFalta(string idper)
        {
            bool retornoCarro = false;
            Int32 resultado = 0;

            MySqlConnection cn = new MySqlConnection();
            MySqlCommand cmdsuperamanetnerog = new MySqlCommand();

            cn.ConnectionString = Conectar();

            var cm = cmdsuperamanetnerog;

            cm.CommandText = "Sp_verificarsiMarcofalta";
            cm.Connection = cn;
            cm.CommandTimeout = 20;
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("xidper", idper);


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
                Entrada = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al verificar si marco falta: " + ex.Message, "Error Verificar Falta");
            }
            return retornoCarro;

        }


        public bool Sp_verificarsiMarcoEntrada(string idper)
        {
            bool retornoCarro = false;
            Int32 resultado = 0;

            MySqlConnection cn = new MySqlConnection();
            MySqlCommand cmdsuperamanetnerog = new MySqlCommand();

            cn.ConnectionString = Conectar();

            var cm = cmdsuperamanetnerog;

            cm.CommandText = "Sp_verificarsiMarcoEntrada";
            cm.Connection = cn;
            cm.CommandTimeout = 20;
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("xidper", idper);


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
                Entrada = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al verificar si marco entrada " + ex.Message, "Error Marco Entrada");
            }
            return retornoCarro;

        }



        public void BD_registrar_Falta(string idasis,string idper, string justi, string nomdia)
        {
            MySqlConnection cn = new MySqlConnection(Conectar());
            MySqlCommand cmd = new MySqlCommand("Sp_verificarsiMarcofalta", cn);
            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Sp_Registro_Falta", cn);
                cmd.Parameters.AddWithValue("_idAsis",idasis);
                cmd.Parameters.AddWithValue("_Id_personal", idper);
                cmd.Parameters.AddWithValue("_justificacion", justi);
                cmd.Parameters.AddWithValue("_nomdia", nomdia);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                Entrada = true;
            }
            catch (Exception ex)
            {
                Entrada = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error verificar Falta: " + ex.Message, "Error Registros");
            }

        }



        public DataTable BD_listar_Todas_Asistencias()
        {
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                MySqlDataAdapter da = new MySqlDataAdapter("Sp_Listar_Todas_Asistencias", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dato = new DataTable();


                da.Fill(dato);
                da = null;
                return dato;
            }
            catch(Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                    throw new Exception("error" + ex.Message, ex);

                }
                return null;
            }
            
        }


        public DataTable BD_Buscado_Todas_Lasasistencias(string xvalor)
        {
            MySqlConnection cn = new MySqlConnection();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("Sp_Buscardor_Asistencias", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("xvalor", xvalor);
                DataTable dato = new DataTable();


                da.Fill(dato);
                da = null;
                return dato;
            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                    throw new Exception("error" + ex.Message, ex);

                }
                return null;
            }

        }


        public DataTable BD_Buscar_Asistencia_deEntrada(string idperso)
        {
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                MySqlDataAdapter da = new MySqlDataAdapter("Sp_Listar_Asistencia_Reciencreada", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("xidper", idperso);

                DataTable dato = new DataTable();
                da.Fill(dato);
                da = null;
                return dato;




            }catch(Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo malo paso" + ex.Message);
            }
            return null;
        }


        public void BD_Eliminar_Salida(EN_Asistencia idasis)
        {
            MySqlConnection cn = new MySqlConnection(Conectar());
            MySqlCommand cmd = new MySqlCommand("sp_Eliminar_Asistencia", cn);


            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_idasis",idasis);


                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                salida = true;
            }
            catch (Exception ex)
            {
                salida = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al eliminar Asistencia: " + ex.Message, "Error Eliminar Asistencia");
            }

        }




        public DataTable BD_Buscar_Asistencia_delDia(DateTime xdia)
        {
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                MySqlDataAdapter da = new MySqlDataAdapter("Sp_Listar_Asistencia_Deldia", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("_fechahoy", xdia);

                DataTable dato = new DataTable();
                da.Fill(dato);
                da = null;
                return dato;




            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo malo paso" + ex.Message);
            }
            return null;
        }

    }
}
