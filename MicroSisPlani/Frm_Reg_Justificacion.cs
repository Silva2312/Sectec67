using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prj_Capa_Datos;
using Prj_Capa_Entidad;
using Prj_Capa_Negocio;
using MicroSisPlani.Msm_Forms;



namespace MicroSisPlani
{
    public partial class Frm_Reg_Justificacion : Form
    {
        public Frm_Reg_Justificacion()
        {
            InitializeComponent();
        }

        private void Frm_Reg_Justificacion_Load(object sender, EventArgs e)
        {
            //txt_idjusti.Text = RN_Utilitario.RN_NroDoc(3);
        }

        private void Frm_Reg_Justificacion_MouseMove(object sender, MouseEventArgs e)
        {
            Utilitarios ui = new Utilitarios();
            if (e.Button == MouseButtons.Left)
            {
                ui.Mover_formulario(this);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }


        private bool ValidarCampos()
        {
            Frm_Advertencia ver = new Msm_Forms.Frm_Advertencia();
            Frm_Filtro fil = new Msm_Forms.Frm_Filtro();

            if (txt_IdPersona.Text.Trim().Length<2){fil.Show();ver.Lbl_Msm1.Text = "Falta id personal";ver.ShowDialog();fil.Hide();txt_IdPersona.Focus();return false;}
            if (cbo_motivJusti.SelectedIndex==-1){fil.Show(); ver.Lbl_Msm1.Text = "Falta Motivo De Justificacion";ver.ShowDialog();fil.Hide();cbo_motivJusti.Focus();return false;}
            if (txt_DetalleJusti.Text.Trim().Length < 0){fil.Show();ver.Lbl_Msm1.Text = "Falta Los Detalles";ver.ShowDialog();fil.Hide();txt_DetalleJusti.Focus();return false;}return true;
        }


        private void RegistararJustificacion()
        {
            RN_Justificacion obj = new  RN_Justificacion();
            EN_Justificacion jus = new EN_Justificacion();

            Frm_Advertencia ver = new Msm_Forms.Frm_Advertencia();
            Frm_Filtro fil = new Msm_Forms.Frm_Filtro();

            Frm_Msm_Bueno ok = new Frm_Msm_Bueno();
            try
            {
                jus.IdJusti = txt_idjusti.Text;
                jus.Id_Personal = txt_IdPersona.Text;
                jus.PrincipalMotivo = cbo_motivJusti.Text;
                jus.Detalle = txt_DetalleJusti.Text;
                jus.Fecha = Dtp_FechaJusti.Value;

                obj.RN_registrar_justificacion(jus);
                if (BD_Justificacion.seguardo == true)
                {
                    Actualizar_SiguienteNumero(3);

                    fil.Show();
                    ok.Lbl_msm1.Text=("La solicitud fue registrada espere la, aprobacion");
                    ok.ShowDialog();
                    fil.Hide();


                    this.Tag = "A";
                    this.Close();
                }

            }
            catch(Exception ex)
            {
                fil.Show();
                MessageBox.Show("Error al registrar Justificacion" + ex.Message, "Error Registro Justificacion");
                fil.Hide();
            }


        }


        private void ActualizarJustificacion()
        {
            RN_Justificacion obj = new RN_Justificacion();
            EN_Justificacion jus = new EN_Justificacion();

            Frm_Advertencia ver = new Msm_Forms.Frm_Advertencia();
            Frm_Filtro fil = new Msm_Forms.Frm_Filtro();
            Frm_Msm_Bueno ok = new Frm_Msm_Bueno();
            try
            {
                jus.IdJusti = txt_idjusti.Text;
                jus.PrincipalMotivo = cbo_motivJusti.Text;
                jus.Detalle = txt_DetalleJusti.Text;
                jus.Fecha = Dtp_FechaJusti.Value;

                obj.RN_Actualizar_justificacion(jus);
                if (BD_Justificacion.edito == true)
                {
                    Actualizar_SiguienteNumero(3);

                    fil.Show();
                    ok.Lbl_msm1.Text = ("La solicitud fue actualizada correctamente");
                    ok.ShowDialog();
                    fil.Hide();


                    this.Tag = "A";
                    this.Close();
                }
                
            }
            catch (Exception ex)
            {
                fil.Show();
                MessageBox.Show("Revisa el error error de las 7 :18" + ex.Message, "Advertencia de seguridad"); 
                fil.Hide();
            }


        }






        private double GenerarNextID(string numero)
        {
            double newnum = Convert.ToDouble(numero) + 1;
            return newnum;
        }
        private void Actualizar_SiguienteNumero(int idtipo)
        {
            string xnum = BD_Utilitario.BD_Leer_Solo_Numero(idtipo);
            string xnuevonum = Convert.ToString(GenerarNextID(xnum));
            int td = xnuevonum.Length;
            string nuevocorrelativo = "";
            if (xnuevonum.Length < 5)
            {
                if (td == 1)
                {
                    nuevocorrelativo = "0000" + xnuevonum;
                }
                if (td == 2)
                {
                    nuevocorrelativo = "000" + xnuevonum;
                }
                if (td == 3)
                {
                    nuevocorrelativo = "00" + xnuevonum;
                }
                if (td == 4)
                {
                    nuevocorrelativo = "0" + xnuevonum;
                }
            }
            BD_Utilitario.BD_ActualizarNro(idtipo, nuevocorrelativo);
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() == true)
            {
                if (editar == true)
                {
                    ActualizarJustificacion();
                }
                else
                {
                    RegistararJustificacion();
                }
                
            }




            
        }
        bool editar = false;

        public void Buscar_Justificacion_editar(string idjusti)
        {
            try
            {
                RN_Justificacion obj = new RN_Justificacion();
                DataTable dato = new DataTable();

                dato = obj.RN_BuscarJustificacion_porValor(idjusti);

                if (dato.Rows.Count > 0)
                {
                    txt_idjusti.Text =Convert.ToString( dato.Rows[0]["Id_justi"]);
                    txt_IdPersona.Text = Convert.ToString(dato.Rows[0]["Id_pern1"]);
                    txt_nompersona.Text = Convert.ToString(dato.Rows[0]["Nombre_Completo"]);
                    cbo_motivJusti.Text = Convert.ToString(dato.Rows[0]["PrincipalMotivo"]);
                    txt_DetalleJusti.Text=Convert.ToString(dato.Rows[0]["Detalle_Justi"]);
                    Dtp_FechaJusti.Value = Convert.ToDateTime(dato.Rows[0]["FechaJusti"]);
                    editar = true;
                    btn_aceptar.Enabled = true;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error al buscar datos" + ex.Message, "Advertencia de seguridad");
            }
        }
    }
}
