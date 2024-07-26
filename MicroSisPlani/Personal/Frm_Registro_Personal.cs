
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prj_Capa_Negocio;
using Prj_Capa_Entidad;
using Prj_Capa_Datos;



namespace MicroSisPlani.Personal
{
    public partial class Frm_Registro_Personal : Form
    {
        public Frm_Registro_Personal()
        {
            InitializeComponent();
        }

           
      
        private void Frm_Registro_Personal_Load(object sender, EventArgs e)
        {
            txt_IdPersona.Text = RN_Utilitario.RN_NroDoc(2);
           
            Listar_Roles();
            Listar_Distrito();

          
        }

        private void Listar_Roles()
        {
            RN_Rol obj = new RN_Rol();
            DataTable dato = new DataTable();


            dato = obj.RN_Listar_todos_Roles();

            if(dato.Rows.Count > 0)
            {
                var cbo = cbo_rol;
                cbo.DataSource = dato;
                cbo.DisplayMember= "NomRol";
                cbo.ValueMember = "Id_Rol";
                cbo.SelectedIndex = -1;
            }

        }

        private void Listar_Distrito()
        {
            RN_Distrito obj = new RN_Distrito();//posible cambio a rn
            DataTable dato = new DataTable();

            dato = obj.BD_Listar_Distrito();
            if (dato.Rows.Count > 0)
            {
                var cbo = cbo_Distrito;
                cbo.DataSource = dato;
                cbo.DisplayMember = "grupo";
                cbo.ValueMember = "Id_grupo";
                cbo_Distrito.SelectedItem = -1;
            }

        }


        private void pnl_titulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_Dni_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
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


        string xfoto = "";
        private void Registrar_Personal()
        {
            RN_Personal obj = new RN_Personal();
            EN_Personal per = new EN_Personal();
            try
            {
                per.Idpersonal = txt_IdPersona.Text;
                per.Dni = txt_Dni.Text;
                per.Nombres = txt_nombres.Text;
                per.FechaNaci = dtp_fechaNaci.Value;
                if (cbo_sexo.SelectedIndex == 0)
                {
                    per.Sexo = "M";
                }else if(cbo_sexo.SelectedIndex==1){
                    per.Sexo = "F";
                }
                per.Direccion = txt_direccion.Text;
                per.Correo = txt_correo.Text;
                per.Celular =Convert.ToInt32(txt_NroCelular.Text);
                per.IdRol = cbo_rol.SelectedValue.ToString();
                per.xImagen = xfoto;
                per.IdDistrito = cbo_Distrito.SelectedValue.ToString();

                obj.RN_Registrar_Personal(per);//BD no es RN

                Actualizar_SiguienteNumero(2);

                MessageBox.Show("Datos Guardados", "Advertencia Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            catch(Exception)
            {
                MessageBox.Show("Error al registrar Alumno-Personal", "Advertencia Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Pic_persona_Click(object sender, EventArgs e)
        {
            var filepath = string.Empty;
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    xfoto = openFileDialog1.FileName;
                    Pic_persona.Load(xfoto);
                }
                else
                {
                    xfoto = Application.StartupPath + @"\user.png";
                    Pic_persona.Load(Application.StartupPath + @"\user.png");
                }
            }
            catch(Exception )//en caso de error agregar esta imagen por defecto
            {
                xfoto = Application.StartupPath + @"\user.png";
                Pic_persona.Load(Application.StartupPath + @"\user.png");
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Registrar_Personal();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }

        private void txt_NroCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Introduce Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_Dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Introduce Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96)|| (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Introduce Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
