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
   public class RN_Justificacion
    {


        public void RN_registrar_justificacion(EN_Justificacion jus)
        {
            BD_Justificacion obj = new BD_Justificacion();
            obj.BD_registrar_justificacion(jus);
        }
        public DataTable RN_Cargar_todos_Justificacion()
        {
            BD_Justificacion obj = new BD_Justificacion();
            return obj.BD_Cargar_todos_Justificacion();
        }
        public DataTable RN_BuscarJustificacion_porValor(string xdato)
        {
            BD_Justificacion obj = new BD_Justificacion();
            return obj.BD_BuscarJustificacion_porValor(xdato);
        }
        public void RN_Actualizar_justificacion(EN_Justificacion jus)
        {
            BD_Justificacion obj = new BD_Justificacion();
            obj.BD_Actualizar_justificacion(jus);
        }
        public void RN_Eliminar_justificacion(string idjusti)
        {
            BD_Justificacion obj = new BD_Justificacion();
            obj.BD_Eliminar_justificacion(idjusti);
        }
        public void RN_Aprobar_Desaprobar_justificacion(string idjusti, string estadojus)
        {
            BD_Justificacion obj = new BD_Justificacion();
            obj.BD_Aprobar_Desaprobar_justificacion( idjusti,  estadojus);
        }
        public bool RN_verificar_SI_PERSONAS_TIENE_JUSTIFICACION(string idper)
        {
            BD_Justificacion obj = new BD_Justificacion();
            return obj.BD_verificar_SI_PERSONAS_TIENE_JUSTIFICACION(idper);


        }
    }
}
