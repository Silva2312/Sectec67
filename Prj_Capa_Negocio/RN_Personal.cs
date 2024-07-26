using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prj_Capa_Datos;
using Prj_Capa_Entidad;
using Prj_Capa_Negocio;
using System.Data;




namespace Prj_Capa_Negocio
{
   public  class RN_Personal
    {
        public void RN_Registrar_Personal(EN_Personal per)
        {
            BD_Personal obj = new BD_Personal();
            obj.BD_Registrar_Personal(per);
        }
        public void RN_Actualizar_Personal(EN_Personal per)
        {
            BD_Personal obj = new BD_Personal();
            obj.BD_Actualizar_Personal(per);
        }

        public DataTable RN_Lista_Todo_Personal()
        {
            BD_Personal obj = new BD_Personal();
            return obj.BD_Lista_Todo_Personal();
            

        }

        public DataTable RN_Buscar_Personal_porValor(string valor)
        {
            BD_Personal obj = new BD_Personal();
            return obj.BD_Buscar_Personal_porValor(valor);
        }
        public void RN_EliminarPersona(string idper)
        {
            BD_Personal obj = new BD_Personal();
            obj.BD_EliminarPersona(idper);
        }
        public void RN_DardeBaja_Persona(string idper)
        {
            BD_Personal obj = new BD_Personal();
            obj.BD_DardeBaja_Persona(idper);
        }
        public void RN_Registrar_Huella_Personal(string idper, object huella)
        {
            BD_Personal obj = new BD_Personal();
            obj.BD_Registrar_Huella_Personal(idper, huella);
        }


    }
}
