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
 public class BD_Personal :Cls_Conexion
    {
        public void BD_Registrar_Personal(EN_Personal per)
        {
            MySqlConnection cn = new MySqlConnection();
            
            try
            {
                cn.ConnectionString = Conectar();
                MySqlCommand cmd = new MySqlCommand("Sp_Registrar_Personal", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_Id_Pernl", per.Idpersonal);
                cmd.Parameters.AddWithValue("_Dni", per.Dni);//CURP O CODIGO
                cmd.Parameters.AddWithValue("_NombreCompleto", per.Nombres);
                cmd.Parameters.AddWithValue("_FechaNacmnto", per.FechaNaci);
                cmd.Parameters.AddWithValue("_Sexo", per.Sexo);
                cmd.Parameters.AddWithValue("_Domicilio", per.Direccion);
                cmd.Parameters.AddWithValue("_Correo", per.Correo);
                cmd.Parameters.AddWithValue("_Celular", per.Celular);
                cmd.Parameters.AddWithValue("_Id_rol", per.IdRol);
                cmd.Parameters.AddWithValue("_Foto", per.xImagen);
                cmd.Parameters.AddWithValue("_Id_Distrito", per.IdDistrito);//id del grupo
                cn.Open();
                cmd.ExecuteNonQuery();

                cn.Close();

            }
            catch(Exception)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }

            }

        }

        public void BD_Actualizar_Personal(EN_Personal per)
        {
            MySqlConnection cn = new MySqlConnection();

            try
            {
                cn.ConnectionString = Conectar();
                MySqlCommand cmd = new MySqlCommand("Sp_Actualizar_Personall", cn);

                cmd.CommandTimeout = 20;

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("_Id_Pernl", per.Idpersonal);
                cmd.Parameters.AddWithValue("_Dni", per.Dni);//CURP O CODIGO
                cmd.Parameters.AddWithValue("_Nombres", per.Nombres);
                cmd.Parameters.AddWithValue("_FechaNacmento", per.FechaNaci);
                cmd.Parameters.AddWithValue("_Sexo", per.Sexo);
                cmd.Parameters.AddWithValue("_Domicilio", per.Direccion);
                cmd.Parameters.AddWithValue("_Correo", per.Correo);
                cmd.Parameters.AddWithValue("_Celular", per.Celular);
                cmd.Parameters.AddWithValue("_Id_rol", per.IdRol);
                cmd.Parameters.AddWithValue("_Foto", per.xImagen);
                cmd.Parameters.AddWithValue("_Id_Grupo", per.IdDistrito);//id del grupo

                cn.Open();
                cmd.ExecuteNonQuery();

                cn.Close();

            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al Actualizar +" + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }


        public static bool xhuella = false;

        public void BD_Registrar_Huella_Personal(string idper, object huella)
        {
            MySqlConnection cn = new MySqlConnection();

            try
            {
                cn.ConnectionString = Conectar();
                MySqlCommand cmd = new MySqlCommand("Sp_RegistrarHuella", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("xidper", idper);
                cmd.Parameters.AddWithValue("huellaper", xhuella);//
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                xhuella = true;
            }
            catch (Exception ex)
            {
                xhuella = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al Actualizar +" + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        public DataTable BD_Lista_Todo_Personal()
        {
            MySqlConnection cn = new MySqlConnection(Conectar());
            try
            {
                cn.ConnectionString = Conectar();
                MySqlDataAdapter da = new MySqlDataAdapter("Sp_Listar_Todo_Personal", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dato = new DataTable();
                da.Fill(dato);
                return dato;
            }
             catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Hay problemas al mostrar todo el personal" + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }

        }
        public DataTable BD_Buscar_Personal_porValor(string valor)
        {
            MySqlConnection cn = new MySqlConnection(Conectar());
            try
            {
                cn.ConnectionString = Conectar();
                MySqlDataAdapter da = new MySqlDataAdapter("Sp_Buscar_Personal_porValor", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("_valor", valor);
                DataTable dato = new DataTable();

                da.Fill(dato);
                return dato;
            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Hay problemas al mostrar todo el personal" + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }

        }
        public static bool sequito = false;
        public void BD_EliminarPersona(string idper)
        {

            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                MySqlCommand cmd = new MySqlCommand("Sp_EliminarPersonal", cn);
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_idper", idper);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                sequito = true;

            }catch(Exception ex)
            {
                sequito = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Hay eliminar personal " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
            }
        }
        public void BD_DardeBaja_Persona(string idper)
        {
            MySqlConnection cn = new MySqlConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand("Sp_Dardebajar_Personal", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_idper", idper);

                cn.Open();

                cmd.ExecuteNonQuery();
                cn.Close();
                sequito = true;

            }
            catch (Exception ex)
            {
                sequito = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Hay eliminar personal " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
