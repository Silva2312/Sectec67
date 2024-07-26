
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
using System.IO;




namespace MicroSisPlani.Personal
{
    public partial class frm_Editpersonal : Form
    {
        public frm_Editpersonal()
        {
            InitializeComponent();
        }



        private void frm_Editpersonal_Load(object sender, EventArgs e)
        {


            Listar_Roles();
            Listar_Distrito();
            Buscar_Personal_paraEditar(this.Tag.ToString());


        }

        private void Listar_Roles()
        {
            RN_Rol obj = new RN_Rol();
            DataTable dato = new DataTable();


            dato = obj.RN_Listar_todos_Roles();

            if (dato.Rows.Count > 0)
            {
                var cbo = cbo_rol;
                cbo.DataSource = dato;
                cbo.DisplayMember = "NomRol";
                cbo.ValueMember = "Id_Rol";
                cbo.SelectedIndex = -1;
            }

        }
        #region "Listas grupos"
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
        #endregion


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

        #region "Editar personal alumnos"
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
                }
                else if (cbo_sexo.SelectedIndex == 1)
                {
                    per.Sexo = "F";
                }
                per.Direccion = txt_direccion.Text;
                per.Correo = txt_correo.Text;
                per.Celular = Convert.ToInt32(txt_NroCelular.Text);

                per.IdRol = cbo_rol.SelectedValue.ToString();
                per.xImagen = xfoto;
                per.IdDistrito = cbo_Distrito.SelectedValue.ToString();

                obj.RN_Actualizar_Personal(per);
                MessageBox.Show("Datos Actualizados", "Advertencia Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.Tag = "A";
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        #endregion//Editar a lumnso o personas a modificar

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
            catch (Exception)//en caso de error agregar esta imagen por defecto
            {
               
                xfoto = Application.StartupPath + @"\user.png";
                Pic_persona.Load(Application.StartupPath + @"\user.png");
               
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Registrar_Personal();
        }
        #region "Busqueda y editacion de personas alumnos"
        private void Buscar_Personal_paraEditar(string idper)
        {
            RN_Personal obj = new RN_Personal();
            DataTable data = new DataTable();
            string sex = "";


            data = obj.RN_Buscar_Personal_porValor(idper);

            if (data.Rows.Count > 0)
            {
                txt_IdPersona.Text = Convert.ToString(data.Rows[0]["Id_pernl"]);
                txt_Dni.Text = Convert.ToString(data.Rows[0]["Dni"]);
                txt_nombres.Text = Convert.ToString(data.Rows[0]["Nombre_Completo"]);
                txt_direccion.Text = Convert.ToString(data.Rows[0]["Domicilio"]);
                txt_correo.Text = Convert.ToString(data.Rows[0]["Correo"]);
                txt_NroCelular.Text = Convert.ToString(data.Rows[0]["Celular"]);
                dtp_fechaNaci.Value = Convert.ToDateTime(data.Rows[0]["Fec_Nac"]);

                sex = Convert.ToString(data.Rows[0]["Sexo"]);
                if (sex == "M")
                {
                    cbo_sexo.SelectedIndex = 0;
                }
                else if (sex == "F")
                {
                    cbo_sexo.SelectedIndex = 1;
                }
                //posible cambio de error
                cbo_rol.SelectedValue = data.Rows[0]["Id_rol"];
                cbo_Distrito.SelectedValue = data.Rows[0]["Id_Grupo"];
                txt_IdPersona.Text = Convert.ToString(data.Rows[0]["Id_pernl"]);

                xfoto = Convert.ToString(data.Rows[0]["Foto"]);

                if (File.Exists(xfoto) == false)
                {
                    xfoto = Application.StartupPath + @"\user.png";
                    Pic_persona.Load(Application.StartupPath + @"\user.png");

                }
                else
                {
                    Pic_persona.Load(xfoto);
                }
            }
            #endregion
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
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Introduce Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Introduce Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
