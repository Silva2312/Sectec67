using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Prj_Capa_Datos
{
    public class RN_Distrito :Cls_Conexion
    {

        public DataTable BD_Listar_Distrito()
        {
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                MySqlDataAdapter da = new MySqlDataAdapter("Sp_Listar_Todos_Distritos", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dato = new DataTable();
                da.Fill(dato);
                return dato;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema" + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null; 
        }
       
    }
}
