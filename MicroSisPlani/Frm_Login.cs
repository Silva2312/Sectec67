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
using Prj_Capa_Negocio;
using Prj_Capa_Entidad;
using MicroSisPlani.Msm_Forms;


namespace MicroSisPlani
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            Verificar_Acceso();



        }
        private void Verificar_Acceso()
        {

            RN_Usuario obj = new RN_Usuario();
            DataTable dt = new DataTable();
            int veces = 0;
            if (ValidarTextbox() == false) return;
            string usu, pass;
            usu = txt_usu.Text;
            pass = txt_pass.Text;
            if (obj.RN_Verificar_Acceso(usu, pass) == true)
            {
                Cls_Libreria.Usuario = usu;
                dt = obj.RN_Leer_Datos_Usuario(usu);
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    Cls_Libreria.IdRol = Convert.ToString(dr["Id_Usu"]);
                    Cls_Libreria.Apellidos = Convert.ToString(dr["Nombre_Completo"]);
                    Cls_Libreria.IdRol = Convert.ToString(dr["Id_Rol"]);
                    Cls_Libreria.Rol = Convert.ToString(dr["NomRol"]);
                    Cls_Libreria.Foto = Convert.ToString(dr["Avatar"]);
                }
                this.Hide();
                Frm_Principal pri = new Frm_Principal();
                pri.Show();
                pri.cargar_datos_Usuario();
                pri.VerificarRobotFalatas();
            }
            else
            {
                txt_pass.Text = "";
                txt_usu.Text = "";

                MessageBox.Show("Usuario o contrasena invalidos", "Advertencia Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txt_usu.Focus();
                veces += 1;


                if(veces == 3)
                {
                    MessageBox.Show("El numero maximo fue superado", "Advertencia Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                }



            }
        }//verifiacion del acceso

        private bool ValidarTextbox()
        {
            //Frm_Filtro fil = new Frm_Filtro();
            if (txt_usu.Text.Trim().Length == 0)
            {
                //fil.Show();
                MessageBox.Show("Ingrese Un Usuario", "Advertencia Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //fil.Hide();
                txt_usu.Focus();
                return false;
            }
            if (txt_pass.Text.Trim().Length == 0)
            {
                //fil.Show();
                MessageBox.Show("Ingrese Una Contraseña", "Advertencia Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //fil.Hide();
                txt_pass.Focus();
                return false;
            }
            return true;
        }//validacion de los campos vacios o incorrectos

        private void txt_usu_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txt_pass.Focus();
            }
        }

        private void txt_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Aceptar_Click(sender, e);
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnl_titulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_titulo_MouseMove(object sender, MouseEventArgs e)
        {
            Utilitarios UI = new Utilitarios();
            if (e.Button == MouseButtons.Left)
            {
                UI.Mover_formulario(this);
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
