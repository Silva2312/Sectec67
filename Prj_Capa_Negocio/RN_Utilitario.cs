using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Prj_Capa_Datos;





namespace Prj_Capa_Negocio
{
  public class RN_Utilitario
    {
        public static string RN_NroDoc(int idTipo)
        {
            return BD_Utilitario.BD_NroDoc(idTipo);
        }
        public static void RN_ActualizarNro(int idtipo, string numero)
        {
            BD_Utilitario.BD_ActualizarNro(idtipo, numero);
        }
        public static string RN_Leer_Solo_Numero(int idtipo)
        {
            return BD_Utilitario.BD_Leer_Solo_Numero(idtipo);
        }

        public static string RN_Listar_tipoRobot(int idtipo)
        {
            return BD_Utilitario.BD_Listar_tipoRobot(idtipo);
        }
        public void RN_Actualizar_TipoRobot(int idtipo, string serie)
        {
            BD_Utilitario obj = new BD_Utilitario();
            obj.BD_Actualizar_TipoRobot(idtipo, serie);
        }
    }
}
