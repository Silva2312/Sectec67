using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prj_Capa_Datos;
using Prj_Capa_Entidad;
using System.Data;

namespace Prj_Capa_Negocio
{
   public class RN_Asistencia
    {
        public bool RN_verificarsi_yaMarco_su_asistencia(string idper)
        {
            BD_Asistencia obj = new BD_Asistencia();
            return obj.BD_verificarsi_yaMarco_su_asistencia(idper);
        }
        public bool RN_verificarsiMarcoFalta(string idper)
        {
            BD_Asistencia obj = new BD_Asistencia();
            return obj.BD_verificarsiMarcoFalta(idper);
        }
        public bool RN_verificarsiMarcoEntrada(string idper)
        {
            BD_Asistencia obj = new BD_Asistencia();
            return obj.BD_verificarsiMarcoFalta(idper);
        }
        public void RN_registrar_Entrada(EN_Asistencia asi)
        {
            BD_Asistencia obj = new BD_Asistencia();
            obj.BD_registrar_Entrada(asi);
        }
        public void RN_registrar_Falta(string idasis, string idper, string justi, string nomdia)
        {
            BD_Asistencia obj = new BD_Asistencia();
            obj.BD_registrar_Falta(idasis,idper,justi,nomdia);
        }
        public DataTable RN_listar_Todas_Lasasistencias()
        {
            BD_Asistencia obj = new BD_Asistencia();
            return obj.BD_listar_Todas_Asistencias();
        }


        public DataTable RN_Buscado_Todas_Lasasistencias(string xvalor)
        {
            BD_Asistencia obj = new BD_Asistencia();
            return obj.BD_Buscado_Todas_Lasasistencias(xvalor);

        }
        public DataTable RN_Buscar_Asistencia_deEntrada(string idperso)
        {
            BD_Asistencia obj = new BD_Asistencia();
            return obj.BD_Buscar_Asistencia_deEntrada(idperso);
        }


        public void RN_registrar_Salida(string text, EN_Asistencia asis)
        {
            BD_Asistencia obj = new BD_Asistencia();
            obj.BD_registrar_Salida(asis);
        }

        public void RN_registrar_Salida(EN_Asistencia asis)
        {
            throw new NotImplementedException();
        }
        public void RN_Eliminar_Salida(EN_Asistencia idasis)
        {
            BD_Asistencia obj = new BD_Asistencia();
            obj.BD_Eliminar_Salida(idasis);
        }


        public DataTable RN_Buscar_Asistencia_delDia(DateTime xdia)
        {
            BD_Asistencia obj = new BD_Asistencia();
            return obj.BD_Buscar_Asistencia_delDia(xdia);
        }



    }
}
