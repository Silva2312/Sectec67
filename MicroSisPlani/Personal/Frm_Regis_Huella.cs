using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPFP;
using Prj_Capa_Datos;
using Prj_Capa_Entidad;
using Prj_Capa_Negocio;



namespace MicroSisPlani.Personal
{
    public partial class Frm_Regis_Huella : Form
    {
        public Frm_Regis_Huella()
        {
            InitializeComponent();
        }

        private void Frm_Regis_Huella_Load(object sender, EventArgs e)
        {
            Buscar_Personal_paraEditar(this.Tag.ToString());
        }

        private void pnl_titulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button ==MouseButtons.Left )
            {
                Utilitarios u = new Utilitarios();
                u.Mover_formulario(this);
            }
        }


        private void Buscar_Personal_paraEditar(string idper)
        {
            RN_Personal obj = new RN_Personal();
            DataTable data = new DataTable();
            string sex = "";
            string xfoto = "";

            data = obj.RN_Buscar_Personal_porValor(idper);

            if (data.Rows.Count > 0)
            {
               lbl_idperso.Text = Convert.ToString(data.Rows[0]["Id_pernl"]);
                lbl_nroDni.Text = Convert.ToString(data.Rows[0]["Dni"]);
                lbl_nomPersona.Text = Convert.ToString(data.Rows[0]["Nombre_Completo"]);
               

                xfoto = Convert.ToString(data.Rows[0]["Foto"]);

                if (File.Exists(xfoto) == false)
                {
                    xfoto = Application.StartupPath + @"\user.png";
                    picFoto.Load(Application.StartupPath + @"\user.png");

                }
                else
                {
                    picFoto.Load(xfoto);
                }
            }
        }

        private void EnrollmentControl_OnComplete(object Control, string ReaderSerialNumber, int Finger)
        {
           
                

        }

        private void EnrollmentControl_OnEnroll(object Control, int FingerMask, DPFP.Template Template, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            /* */
            byte[] bytes = null;
            RN_Personal obj = new RN_Personal();

            if (Template is null)
            {
                Template.Serialize(ref bytes);
                MessageBox.Show("No se pudo capturar la huella", "Advertencia Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbl_idperso.Text = "";
                lbl_nomPersona.Text = "";
                lbl_nroDni.Text = "";
                this.Tag = "";
                this.Close();
            }
            else
            {
                Template.Serialize(ref bytes);
                if (BD_Personal.xhuella == true)
                {
                    MessageBox.Show("la huella dactilar del personas fue registrado exitosamente", "Advertencia Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    this.Tag = "A";
                    this.Close();
                }
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }
    }
}
