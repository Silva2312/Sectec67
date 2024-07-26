using MicroSisPlani.Msm_Forms;//a cambiar
using MicroSisPlani.Personal;
using Prj_Capa_Datos;
using Prj_Capa_Entidad;
using Prj_Capa_Negocio;
using System;
using System.Data;
using System.Windows.Forms;
using System.IO;



namespace MicroSisPlani
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            Configura_ListView_per();
            configuracionListView();

            P_Cargar_Todos_Personas();
            configuracionListView_Asis();

            J_Cargar_Todas_Justificaciones();
            //cargar_todas_las_Asistencias();

            cargar_horarios();
            
            configuracionListView();
            //cargar_todas_las_Asistencias();

        }

        public void cargar_datos_Usuario()
        {
            try
            {
                Frm_Filtro fil = new Frm_Filtro();
                fil.Show();
                MessageBox.Show("Bienvenido Sr(a) " +Cls_Libreria.Apellidos,"Bienvenido Al Sistema");
                lbl_rolNom.Text = Cls_Libreria.Rol;


                if (Cls_Libreria.Foto.Trim().Length == 0 | Cls_Libreria.Foto == null) return;

                if (File.Exists(Cls_Libreria.Foto) == true)
                {
                    pic_user.Load(Cls_Libreria.Foto);
                }
                else
                {
                    pic_user.Image = Properties.Resources.user;
                }

            }catch(Exception )
            {

            }
        }







        public void VerificarRobotFalatas()
        {
            string tipoRobot = "";

            tipoRobot = RN_Utilitario.RN_Listar_tipoRobot(4);

            if (tipoRobot.Trim() == "Si")
            {
                rdb_ActivarRobot.Checked = true;
                pnl_falta.Visible = true;
                timerTempo.Start();

            }

            else if (tipoRobot.Trim() == "No")
            {
                rdb_Desact_Robot.Checked = true;
                timerTempo.Stop();
                timerFalta.Stop();
            }
        }
        public void cargar_horarios()
        {
            RN_Horario obj = new RN_Horario();
            DataTable data = new DataTable();

            data = obj.RN_Leer_Horarios();

            if (data.Rows.Count == 0) return;
            lbl_idHorario.Text = Convert.ToString(data.Rows[0]["Id_Hor"]);
            dtp_horaIngre.Value = Convert.ToDateTime(data.Rows[0]["HoEntrada"]);
            dtp_horaSalida.Value = Convert.ToDateTime(data.Rows[0]["HoSalida"]);
            dtp_hora_tolercia.Value = Convert.ToDateTime(data.Rows[0]["MiTolermcia"]);
            Dtp_Hora_Limite.Value = Convert.ToDateTime(data.Rows[0]["HoLimite"]);
        }

        private void pnl_titu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Utilitarios u = new Utilitarios();
                u.Mover_formulario(this);
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btn_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        #region "configuracion de la ListView"


        private void Configura_ListView_per()
        {
            var lis = lsv_person;
            lis.Columns.Clear();
            lis.Items.Clear();
            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;

            //a cambiar otientacion
            lis.Columns.Add("Id Persona", 0, HorizontalAlignment.Left);
            lis.Columns.Add("Codigo", 95, HorizontalAlignment.Left);
            lis.Columns.Add("Nombres", 316, HorizontalAlignment.Left);
            lis.Columns.Add("Direccion", 10, HorizontalAlignment.Left);
            lis.Columns.Add("Correo", 110, HorizontalAlignment.Left);
            lis.Columns.Add("Sexo", 0, HorizontalAlignment.Left);
            lis.Columns.Add("Fecha Nacimiento", 10, HorizontalAlignment.Left);
            lis.Columns.Add("Nro Celular", 120, HorizontalAlignment.Left);
            lis.Columns.Add("Rol", 100, HorizontalAlignment.Left);
            lis.Columns.Add("Grupo", 0, HorizontalAlignment.Left);
            lis.Columns.Add("Estado", 100, HorizontalAlignment.Left);

        }
        #endregion


        #region "LLenar la ListView Principal"
        private void Llenar_ListView(DataTable data)
        {
            lsv_person.Items.Clear();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                ListViewItem list = new ListViewItem(dr["Id_pernl"].ToString());
                list.SubItems.Add(dr["Dni"].ToString());
                list.SubItems.Add(dr["Nombre_Completo"].ToString());
                list.SubItems.Add(dr["Fec_Nac"].ToString());
                list.SubItems.Add(dr["Sexo"].ToString());
                list.SubItems.Add(dr["Domicilio"].ToString());
                list.SubItems.Add(dr["Correo"].ToString());
                list.SubItems.Add(dr["Celular"].ToString());
                list.SubItems.Add(dr["NomRol"].ToString());
                list.SubItems.Add(dr["Grupo"].ToString());
                list.SubItems.Add(dr["Estado_Per"].ToString());
                lsv_person.Items.Add(list);
            }
            Lbl_total.Text = Convert.ToString(lsv_person.Items.Count);
        }

        #endregion



        #region "CARGAR TODAS LAS PERSONAS EN LA LISTVIEW"

        

        private void P_Cargar_Todos_Personas()
        {
            RN_Personal obj = new RN_Personal();
            DataTable dato = new DataTable();

            dato = obj.RN_Lista_Todo_Personal();

            if (dato.Rows.Count > 0)
            {
                Llenar_ListView(dato);
            }
            else
            {
                lsv_person.Items.Clear();
            }

        }

#endregion

        #region "busqueda de personal por valores"
        private void P_Buscar_Personal_porValor(string valor)
        {
            RN_Personal obj = new RN_Personal();
            DataTable dato = new DataTable();

            dato = obj.RN_Buscar_Personal_porValor(valor);

            if (dato.Rows.Count > 0)
            {
                Llenar_ListView(dato);
            }
            else
            {
                lsv_person.Items.Clear();
            }

        }

        #endregion



        private void bt_personal_Click(object sender, EventArgs e)
        {
            elTab1.SelectedTabPageIndex = 1;
            elTabPage2.Visible = true;
            P_Cargar_Todos_Personas();
        }

        private void txt_Buscar_OnValueChanged(object sender, EventArgs e)
        {
            if (txt_Buscar.Text.Length > 2)
            {
                P_Buscar_Personal_porValor(txt_Buscar.Text);
            }
        }

        private void txt_Buscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_Buscar.Text.Length > 2)
                {
                    P_Buscar_Personal_porValor(txt_Buscar.Text);
                }
                else
                {
                    P_Cargar_Todos_Personas();
                }
            }
        }

        private void Bt_NewPerso_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Registro_Personal per = new Frm_Registro_Personal();

            fil.Show();
            per.ShowDialog();
            fil.Hide();

            if (per.Tag.ToString() == "A")
            {
                P_Cargar_Todos_Personas();
            }


        }

        private void Btn_EditPerso_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia ver = new Frm_Advertencia();
            frm_Editpersonal per = new frm_Editpersonal();
            string idper = "";

            if (lsv_person.SelectedItems.Count == 0)
            {
                fil.Show();
                ver.Lbl_Msm1.Text = "Por favor, Selecciona el personal que quieras editar";
                ver.ShowDialog();
                fil.Hide();
                return;
            }
            else
            {
                var lis = lsv_person.SelectedItems[0];
                idper = lis.SubItems[0].Text;

                fil.Show();
                per.Tag = idper;
                per.ShowDialog();
                fil.Hide();

                if (per.Tag.ToString() == "A")
                {
                    P_Cargar_Todos_Personas();
                }
            }
        }

        private void btn_VerTodoPerso_Click(object sender, EventArgs e)
        {
            P_Cargar_Todos_Personas();
        }

        private void bt_nuevoPersonal_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Registro_Personal per = new Frm_Registro_Personal();
            fil.Show();
            per.ShowDialog();
            fil.Hide();

            if (per.Tag.ToString() == "A")
            {
                P_Cargar_Todos_Personas();
            }


        }

        private void bt_editarPersonal_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia ver = new Frm_Advertencia();
            frm_Editpersonal per = new frm_Editpersonal();
            string idper = "";

            if (lsv_person.SelectedItems.Count == 0)
            {
                fil.Show();
                ver.Lbl_Msm1.Text = "Por favor, Selecciona el personal que quieras editar";
                ver.ShowDialog();
                fil.Hide();
                return;
            }
            else
            {
                var lis = lsv_person.SelectedItems[0];
                idper = lis.SubItems[0].Text;

                fil.Show();
                per.Tag = idper;
                per.ShowDialog();
                fil.Hide();

                if (per.Tag.ToString() == "A")
                {
                    P_Cargar_Todos_Personas();
                }
            }
        }

        private void bt_eliminarPersonal_Click(object sender, EventArgs e)
        {

        }

        private void elinimarPermanenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia ver = new Frm_Advertencia();
            Frm_Sino sino = new Frm_Sino();
            Frm_Msm_Bueno ok = new Frm_Msm_Bueno();
            if (lsv_person.SelectedItems.Count == 0)
            {
                fil.Show();
                ver.Lbl_Msm1.Text = "Por favor, Selecciona el personal que quieras Eliminar";
                ver.ShowDialog();
                fil.Hide();
                return;
            }
            else
            {
                string idper = "";
                var lis = lsv_person.SelectedItems[0];
                idper = lis.SubItems[0].Text;
                fil.Show();
                sino.Lbl_msm1.Text = "Estas seguro de Eliminar A la Persona";
                sino.ShowDialog();
                fil.Hide();

                if (sino.Tag.ToString() == "Si")
                {
                    RN_Personal obj = new RN_Personal();
                    obj.RN_EliminarPersona(idper);

                    if (BD_Personal.sequito == true)
                    {
                        fil.Show();
                        ok.Lbl_msm1.Text = "El personas fue eliminado de forma permanente";
                        ok.ShowDialog();
                        fil.Hide();

                    }
                }
            }
        }

        private void darDeBajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia ver = new Frm_Advertencia();
            Frm_Sino sino = new Frm_Sino();
            Frm_Msm_Bueno ok = new Frm_Msm_Bueno();
            if (lsv_person.SelectedItems.Count == 0)
            {
                fil.Show();
                ver.Lbl_Msm1.Text = "Por favor, Selecciona el personal que desea dar de baja";
                ver.ShowDialog();
                fil.Hide();
                return;
            }
            else
            {
                string idper = "";
                var lis = lsv_person.SelectedItems[0];
                idper = lis.SubItems[0].Text;
                fil.Show();
                sino.Lbl_msm1.Text = "Estas seguro dar de baja A la persona";
                sino.ShowDialog();
                fil.Hide();

                if (sino.Tag.ToString() == "Si")
                {
                    RN_Personal obj = new RN_Personal();
                    obj.RN_DardeBaja_Persona(idper);

                    if (BD_Personal.sequito == true)
                    {
                        fil.Show();
                        ok.Lbl_msm1.Text = "El personas fue eliminado de forma permanente";
                        ok.ShowDialog();
                        fil.Hide();
                    }
                }
            }
        }

        private void bt_mostrarTodoElPersonal_Click(object sender, EventArgs e)
        {
            P_Cargar_Todos_Personas();
        }

        private void bt_copiarNroDNI_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia ver = new Frm_Advertencia();

            if (lsv_person.SelectedItems.Count == 0)
            {

                fil.Show();
                ver.Lbl_Msm1.Text = "Seleccione el Item a copiar";
                ver.ShowDialog();
                fil.Hide();
                return;
            }
            else
            {
                var Lsv = lsv_person.SelectedItems[0];
                String xdni = Lsv.SubItems[1].Text;

                Clipboard.Clear();
                Clipboard.SetText(xdni.Trim());



            }
        }

        private void Btn_Cerrar_TabPers_Click(object sender, EventArgs e)
        {
            elTab1.SelectedTabPageIndex = 0;
            elTabPage2.Visible = false;
            txt_Buscar.Text = "";
            P_Cargar_Todos_Personas();
        }

        private void bt_solicitarJustificacion_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia ver = new Frm_Advertencia();
            Frm_Reg_Justificacion jus = new Frm_Reg_Justificacion();
            if (lsv_person.SelectedItems.Count == 0)
            {

                fil.Show();
                ver.Lbl_Msm1.Text = "Seleccione el personas para solicitar su justificacion";
                ver.ShowDialog();
                fil.Hide();
                return;
            }
            else
            {
                var lsv = lsv_person.SelectedItems[0];
                string xidpersonal = lsv.SubItems[0].Text;
                string xnombre = lsv.SubItems[2].Text;


                fil.Show();
                jus.txt_IdPersona.Text = xidpersonal;
                jus.txt_nompersona.Text = xnombre;
                jus.ShowDialog();
                fil.Hide();

            }

        }

        private void timerFalta_Tick(object sender, EventArgs e)
        {

        }

        private void elTabPage5_Click(object sender, EventArgs e)
        {

        }
        #region "Configuracion de la ListView De Justificaciones"
        private void configuracionListView()
        {
            var lis = lsv_justifi;
            lis.Columns.Clear();
            lis.Items.Clear();
            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;

            lis.Columns.Add("IdJusti", 0, HorizontalAlignment.Left);
            lis.Columns.Add("Idperso", 0, HorizontalAlignment.Left);
            lis.Columns.Add("Nombre Personal", 316, HorizontalAlignment.Left);
            lis.Columns.Add("Motivo", 110, HorizontalAlignment.Left);
            lis.Columns.Add("Fecha EMITIDO", 120, HorizontalAlignment.Left);
            lis.Columns.Add("Fecha ", 120, HorizontalAlignment.Left);
            lis.Columns.Add("Estado", 120, HorizontalAlignment.Left);
            lis.Columns.Add("Detalles Justificacin", 0, HorizontalAlignment.Left);
        }

        #endregion


        #region "LLENA LOS DATOS DE LAS JUSTIFICACIONES"
        private void llenar_datajusti(DataTable dato)
        {
            lsv_justifi.Items.Clear();

            for (int i = 0; i < dato.Rows.Count; i++)
            {
                DataRow dr = dato.Rows[i];

                ListViewItem list = new ListViewItem(dr["Id_Justi"].ToString());
                list.SubItems.Add(dr["Id_Pernl"].ToString());
                list.SubItems.Add(dr["Nombre_Completo"].ToString());
                list.SubItems.Add(dr["PrincipalMotivo"].ToString());
                list.SubItems.Add(dr["FechaEmi"].ToString());
                list.SubItems.Add(dr["FechaJusti"].ToString());
                list.SubItems.Add(dr["EstadoJus"].ToString());
                list.SubItems.Add(dr["Detalle_Justi"].ToString());
                lsv_justifi.Items.Add(list);
            }
            lbl_totaljusti.Text = lsv_justifi.Items.Count.ToString();
        }
        #endregion


        #region "carga todas las justificaciones"
        private void J_Cargar_Todas_Justificaciones()
        {
            RN_Justificacion obj = new RN_Justificacion();
            DataTable dt = new DataTable();

            dt = obj.RN_Cargar_todos_Justificacion();
            if (dt.Rows.Count > 0)
            {
                llenar_datajusti(dt);
            }
            else
            {
                lsv_justifi.Items.Clear();
            }
        }
        #endregion



        #region "BUSCA LAS JUSTIFICACIONES"
        private void J_Buscar_Justificaciones(string xvalor)
        {
            RN_Justificacion obj = new RN_Justificacion();
            DataTable dt = new DataTable();

            dt = obj.RN_BuscarJustificacion_porValor(xvalor);
            if (dt.Rows.Count > 0)
            {
                llenar_datajusti(dt);
            }
            else
            {
                lsv_justifi.Items.Clear();
            }

        }
        #endregion

        private void bt_exploJusti_Click(object sender, EventArgs e)
        {
            elTab1.SelectedTabPageIndex = 4;
            elTabPage5.Visible = true;
            txt_buscarjusti.Focus();
            J_Cargar_Todas_Justificaciones();
        }

        private void bt_cerrarjusti_Click(object sender, EventArgs e)
        {
            elTab1.SelectedTabPageIndex = 0;
            elTabPage5.Visible = false;
            txt_buscarjusti.Text = "";
        }

        private void lsv_justifi_MouseClick(object sender, MouseEventArgs e)
        {
            var lsv = lsv_justifi.SelectedItems[0];
            string detallejust = lsv.SubItems[7].Text;


            lbl_Detalle.Text = detallejust.Trim();
        }

        private void bt_Explo_Asis_Click(object sender, EventArgs e)
        {
            elTab1.SelectedTabPageIndex = 2;
            elTabPage2.Visible = true;
        }

        private void lsv_justifi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_editJusti_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia ver = new Frm_Advertencia();
            Frm_Reg_Justificacion jus = new Frm_Reg_Justificacion();


            if (lsv_justifi.SelectedItems.Count == 0)
            {

                fil.Show();
                MessageBox.Show("Seleccione algun dato para modificar");
                fil.Hide();

            }
            else
            {
                var lsv = lsv_justifi.SelectedItems[0];
                string xidjusti = lsv.SubItems[0].Text;

                fil.Show();
                jus.Buscar_Justificacion_editar(xidjusti);
                jus.ShowDialog();
                fil.Hide();
            }
            if (jus.Tag.ToString() == "A")
            {
                J_Cargar_Todas_Justificaciones();
            }
        }

        private void bt_mostrarJusti_Click(object sender, EventArgs e)
        {
            J_Cargar_Todas_Justificaciones();
        }

        private void bt_ElimiJusti_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia ver = new Frm_Advertencia();
            Frm_Sino sino = new Frm_Sino();
            RN_Justificacion obj = new RN_Justificacion();
            if (lsv_justifi.SelectedItems.Count == 0)
            {
                fil.Show();
                MessageBox.Show("Seleccione algun dato para Eliminar");
                fil.Hide();

            }
            else
            {
                var lsv = lsv_justifi.SelectedItems[0];
                string xidjusti = lsv.SubItems[0].Text;

                fil.Show();
                sino.Lbl_msm1.Text = "Estas seguro de eliminarlo";
                sino.ShowDialog();
                fil.Hide();
                if (sino.Tag.ToString() == "Si")
                {//AQUI NOS QUEDAMOS

                    obj.RN_Eliminar_justificacion(xidjusti);
                    if (BD_Justificacion.elimino == true)
                    {
                        J_Cargar_Todas_Justificaciones();
                    }
                }
            }
        }

        private void bt_aprobarJustificacion_Click(object sender, EventArgs ezmvxzz)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia ver = new Frm_Advertencia();
            Frm_Sino sino = new Frm_Sino();
            RN_Justificacion obj = new RN_Justificacion();

            string xestadojusti = "";

            if (lsv_justifi.SelectedItems.Count == 0)
            {
                fil.Show();
                MessageBox.Show("Seleccione Una Justificacion");
                fil.Hide();
            }
            else
            {
                var lsv = lsv_justifi.SelectedItems[0];
                string xidjusti = lsv.SubItems[0].Text;
                xestadojusti = lsv.SubItems[6].Text;

                if (xestadojusti.Trim() == "Aprobado")
                {
                    fil.Show();
                    ver.Lbl_Msm1.Text = "La Justificacion Seleccionada, Ya Esta Aprobada";
                    ver.ShowDialog();
                    fil.Hide();
                    return;


                }
                fil.Show();
                sino.Lbl_msm1.Text = "Estas Seguro De Aprobar La Justificacion";
                sino.ShowDialog();
                fil.Hide();
                if (sino.Tag.ToString() == "Si")
                {//AQUI NOS QUEDAMOS

                    obj.RN_Aprobar_Desaprobar_justificacion(xidjusti, "Aprobado");
                    if (BD_Justificacion.elimino == true)
                    {
                        J_Cargar_Todas_Justificaciones();
                    }
                }
            }
        }

        private void bt_desaprobarJustificacion_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia ver = new Frm_Advertencia();
            Frm_Sino sino = new Frm_Sino();
            RN_Justificacion obj = new RN_Justificacion();

            string xestadojusti = "";

            if (lsv_justifi.SelectedItems.Count == 0)
            {

                fil.Show();
                MessageBox.Show("Seleccione Una Justificacion a Desaprobar");
                fil.Hide();

            }
            else
            {
                var lsv = lsv_justifi.SelectedItems[0];
                string xidjusti = lsv.SubItems[0].Text;
                xestadojusti = lsv.SubItems[6].Text;

                if (xestadojusti.Trim() == "Pendiente")
                {
                    fil.Show();
                    ver.Lbl_Msm1.Text = "La justificacion seleccionada, aun no fue aprobada";
                    ver.ShowDialog();
                    fil.Hide();
                    return;


                }
                fil.Show();
                sino.Lbl_msm1.Text = "Estas seguro de restablecer la justificacion a pendiente";
                sino.ShowDialog();
                fil.Hide();
                if (sino.Tag.ToString() == "Si")
                {//AQUI NOS QUEDAMOS

                    obj.RN_Aprobar_Desaprobar_justificacion(xidjusti, "Pendiente");
                    if (BD_Justificacion.elimino == true)
                    {
                        J_Cargar_Todas_Justificaciones();
                    }
                }
            }
        }

        private void txt_buscarjusti_OnValueChanged(object sender, EventArgs e)
        {
            if (txt_buscarjusti.Text.Trim().Length > 2)
            {
                J_Buscar_Justificaciones(txt_buscarjusti.Text);
            }
        }

        private void txt_buscarjusti_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_buscarjusti.Text.Trim().Length > 2)
                {
                    J_Buscar_Justificaciones(txt_buscarjusti.Text);
                }
                else
                {
                    J_Cargar_Todas_Justificaciones();
                }
            }
        }

        private void bt_Config_Click(object sender, EventArgs e)
        {
            elTab1.SelectedTabPageIndex = 3;
            elTabPage4.Visible = true;
        }

        private void btn_SaveHorario_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Msm_Bueno ok = new Frm_Msm_Bueno();
            Frm_Advertencia adver = new Frm_Advertencia();
            try
            {
                RN_Horario hor = new RN_Horario();
                EN_Horario por = new EN_Horario();
                //POSIBLE CAMBIO A Hor 
                por.Idhora = lbl_idHorario.Text;
                por.HoEntrada = dtp_horaIngre.Value;
                por.HoTole = dtp_hora_tolercia.Value;
                hor.RN_actualizarHorario(por);
                if (BD_Horario.seguardo == true)
                {
                    fil.Show();
                    ok.Lbl_msm1.Text = "El Horario fue Actualizar";
                    ok.ShowDialog();
                    fil.Hide();
                    elTab1.SelectedTabPageIndex = 0;
                    elTabPage4.Visible = false;
                }

            }
            catch (Exception ex)
            {
                fil.Show();
                adver.Lbl_Msm1.Text = "Ay problemas: " + ex.Message;
                adver.ShowDialog();
                fil.Hide();
            }

        }

        private void btn_Savedrobot_Click(object sender, EventArgs e)
        {
            RN_Utilitario uti = new RN_Utilitario();
            if (rdb_ActivarRobot.Checked == true)
            {
                uti.RN_Actualizar_TipoRobot(4, "Si");
                if (BD_Utilitario.falta == true)
                {
                    Frm_Msm_Bueno ok = new Frm_Msm_Bueno();
                    ok.Lbl_msm1.Text = "El robot fue Actualizado";
                    ok.ShowDialog();

                    elTab1.SelectedTabPageIndex = 0;
                    elTabPage4.Visible = false;
                }
            }
            else if (rdb_Desact_Robot.Checked == true)
            {
                uti.RN_Actualizar_TipoRobot(4, "No");
                if (BD_Utilitario.falta == true)
                {
                    Frm_Msm_Bueno ok = new Frm_Msm_Bueno();
                    ok.Lbl_msm1.Text = "El robot fue Desactivado";
                    ok.ShowDialog();

                    elTab1.SelectedTabPageIndex = 0;
                    elTabPage4.Visible = false;
                }


            }
        }

        private void bt_registrarHuellaDigital_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia ver = new Frm_Advertencia();
            Frm_Regis_Huella per = new Frm_Regis_Huella();
            string idper = "";

            if (lsv_person.SelectedItems.Count == 0)
            {
                fil.Show();
                ver.Lbl_Msm1.Text = "Por favor, Selecciona el personal que quieras Agregar Huella";
                ver.ShowDialog();
                fil.Hide();
                return;
            }
            else
            {
                var lis = lsv_person.SelectedItems[0];
                idper = lis.SubItems[0].Text;

                fil.Show();
                per.Tag = idper;
                per.ShowDialog();
                fil.Hide();

                if (per.Tag.ToString() == "A")
                {
                    P_Cargar_Todos_Personas();
                }
            }
        }

        private void btn_Asis_With_Huella_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();

            Frm_Marcar_Asistencia asi = new Frm_Marcar_Asistencia();
            fil.Show();
            asi.ShowDialog();
            fil.Hide();
        }



        private int temp1 = 0;
        private int segun1 = 0;

        private void timerTempo_Tick(object sender, EventArgs e)
        {
            temp1 += 1;
            lbl_temp.Text = segun1.ToString().PadLeft(2, Convert.ToChar("0")) + ":";
            lbl_temp.Text += temp1.ToString().PadLeft(2, Convert.ToChar("0"));
            lbl_temp.Refresh();


            if (temp1 == 30)
            {
                timerTempo.Stop();
                temp1 = 0;
                Empezar_RegistroFaltas();
            }


        }


        private void Empezar_RegistroFaltas()
        {

            RN_Asistencia objasis = new RN_Asistencia();
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia adver = new Frm_Advertencia();
            Frm_Msm_Bueno ok = new Frm_Msm_Bueno();
            DataTable dataper = new DataTable();
            RN_Personal objper = new RN_Personal();
            RN_Justificacion objus = new RN_Justificacion();


            int HoraLimite = Dtp_Hora_Limite.Value.Hour;
            int MilIMITE = Dtp_Hora_Limite.Value.Minute;

            int Horacaptu = DateTime.Now.Hour;
            int minucaptu = DateTime.Now.Minute;

            string Dnper = "";
            int cant = 0;
            int totalItem = 0;
            string xidPersona = "";
            string IdAsistencia = "";
            string xjustifi = "";
            string xnomDia = "";

            if (Horacaptu < HoraLimite)
            {
                lbl_temp.Text = "Robot Activo, AUn es temprano";
                return;
            }
            if (Horacaptu == HoraLimite && minucaptu > HoraLimite)
            {
                //super tarde fuera de tiempo
                dataper = objper.RN_Lista_Todo_Personal();

                if (dataper.Rows.Count <= 0)
                {
                    return;
                }
                totalItem = dataper.Rows.Count;

                foreach (DataRow reg in dataper.Rows)
                {
                    Dnper = Convert.ToString(reg["Dni"]);
                    xidPersona = Convert.ToString(reg["Id_pern1"]);

                    if (objasis.RN_verificarsiMarcoFalta(xidPersona) == false)
                    {
                        RN_Asistencia objA = new RN_Asistencia();
                        EN_Asistencia asi = new EN_Asistencia();
                        IdAsistencia = RN_Utilitario.RN_NroDoc(1);

                        if (objus.RN_verificar_SI_PERSONAS_TIENE_JUSTIFICACION(xidPersona) == true)
                        {
                            xjustifi = "La falta est Justificada";
                        }
                        else
                        {
                            xjustifi = "Flata no Justificada";
                        }

                        xnomDia = DateTime.Now.ToString("dddd");
                        objasis.RN_registrar_Falta(IdAsistencia, xidPersona, xjustifi, xnomDia);

                        if (BD_Asistencia.Entrada == true)
                        {
                            Actualizar_SiguienteNumero(1);
                            cant += 1;
                        }
                    }
                }//FIN DEL FOREECHA

                if (cant > 1)
                {
                    timerFalta.Stop();
                    fil.Show();
                    ok.Lbl_msm1.Text = "Un total de: " + cant.ToString() + "/" + totalItem.ToString() + "faltas se han registrado";
                    ok.ShowDialog();
                    fil.Hide();
                    pnl_falta.Visible = false;
                }
                else
                {
                    timerFalta.Stop();
                    fil.Show();
                    ok.Lbl_msm1.Text = "El dia de hoy no falto nadie al trabajo";
                    ok.ShowDialog();
                    fil.Hide();
                    pnl_falta.Visible = false;
                }
            }

            else
            {
                lbl_temp.Text = "Robot activo, aun es temprano para marcar en:"; timerTempo.Start();
            }

        }

        private double Generar_NextId(string numero)
        {
            double newnum = Convert.ToDouble(numero) + 1;
            return newnum;
        }
        private void Actualizar_SiguienteNumero(int idtipo)
        {
            string xnum = BD_Utilitario.BD_Leer_Solo_Numero(idtipo);
            string xnuevonum = Convert.ToString(Generar_NextId(xnum));
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



        #region "Asistencia"
        private void configuracionListView_Asis()
        {
            var lis = lsv_asis;

            lis.Columns.Clear();
            lis.Items.Clear();
            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;

            //columnas

            lis.Columns.Add("Id asis", 0, HorizontalAlignment.Left);
            lis.Columns.Add("codigo", 80, HorizontalAlignment.Left);
            lis.Columns.Add("Nombre del personas", 316, HorizontalAlignment.Left);
            lis.Columns.Add("Fecha", 90, HorizontalAlignment.Left);
            lis.Columns.Add("Dia", 80, HorizontalAlignment.Left);
            lis.Columns.Add("Ho ingreso", 90, HorizontalAlignment.Left);
            lis.Columns.Add("Tardanza", 70, HorizontalAlignment.Left);
            lis.Columns.Add("Ho salido", 90, HorizontalAlignment.Left);
            lis.Columns.Add("Justificacion", 0, HorizontalAlignment.Left);
            lis.Columns.Add("Estado", 100, HorizontalAlignment.Left);

        }


        private void llenar_Listview_Asistencia(DataTable dato)
        {
            lsv_asis.Items.Clear();
            for (int i = 0; i < dato.Rows.Count; i++)
            {
                DataRow dr = dato.Rows[i];
                ListViewItem list = new ListViewItem(dr["Id_asis"].ToString());
                list.SubItems.Add(dr["Dni"].ToString());
                list.SubItems.Add(dr["Nombre_Completo"].ToString());
                list.SubItems.Add(dr["FechaAsis"].ToString());
                list.SubItems.Add(dr["Nombre_dia"].ToString());
                list.SubItems.Add(dr["HoIngreso"].ToString());
                list.SubItems.Add(dr["Tardanzas"].ToString());
                list.SubItems.Add(dr["Justificacion"].ToString());
                list.SubItems.Add(dr["EstadoAsis"].ToString());

                lsv_asis.Items.Add(list);
            }
        }



        //private void cargar_todas_las_Asistencias()
        //{
        //    RN_Asistencia obj = new RN_Asistencia();
        //    DataTable dato = new DataTable();

        //    dato = obj.RN_listar_Todas_Lasasistencias();
        //    if (dato.Rows.Count > 0)
        //    {
        //        llenar_Listview_Asistencia(dato);
        //    }
        //    else
        //    {
        //        lsv_asis.Items.Clear();
        //    }
        //}



        private void A_buscador_Asistencias_deldia(DateTime xdia)
        {
            RN_Asistencia obj = new RN_Asistencia();
            DataTable dato = new DataTable();

            dato = obj.RN_Buscar_Asistencia_delDia(xdia);
            if (dato.Rows.Count > 0)
            {
                llenar_Listview_Asistencia(dato);
            }
            else
            {
                lsv_asis.Items.Clear();
            }
        }

        #endregion

        private void buscador_Asistencias(string xvalor)
        {
            RN_Asistencia obj = new RN_Asistencia();
            DataTable dato = new DataTable();

            dato = obj.RN_Buscado_Todas_Lasasistencias(xvalor);
            if (dato.Rows.Count > 0)
            {
                llenar_Listview_Asistencia(dato);
            }
            else
            {
                lsv_asis.Items.Clear();
            }
        }

        private void txt_buscarAsis_OnValueChanged(object sender, EventArgs e)
        {
            if (txt_buscarAsis.Text.Trim().Length > 2)
            {
                buscador_Asistencias(txt_buscarAsis.Text);
            }
        }

        private void txt_buscarAsis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_buscarAsis.Text.Trim().Length > 2)
                {
                    buscador_Asistencias(txt_buscarAsis.Text);
                }
                else
                {
                    //cargar_todas_las_Asistencias();
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();

            Frm_Marcar_Asistencia asi = new Frm_Marcar_Asistencia();
            fil.Show();
            asi.ShowDialog();
            fil.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Frm_Advertencia adver = new Frm_Advertencia();
            Frm_Sino sino = new Frm_Sino();
            Frm_Msm_Bueno ok = new Frm_Msm_Bueno();
            Frm_Filtro fis = new Frm_Filtro();
            RN_Justificacion obj = new RN_Justificacion();

            if (lsv_asis.SelectedItems.Count == 0)
            {
                fis.Show();
                adver.Lbl_Msm1.Text = "Seleccione el item que desea eliminar";
                adver.ShowDialog();
                fis.Hide();
            }
            else
            {
                var lsv = lsv_asis.SelectedItems[0];
                string xidasis = lsv.SubItems[0].Text;

                sino.Lbl_msm1.Text = "Estas seguro que deseas eliminar la asistencia";
                fis.Show();
                sino.ShowDialog();
                fis.Hide();

                if (Convert.ToString(sino.Tag) == "Si")
                {
                    
                }

            }



        }

        private void bt_vertodasasistencia_Click(object sender, EventArgs e)
        {
            //cargar_todas_las_Asistencias();
        }

        private void bt_copiarnrodnitoo_Click(object sender, EventArgs e)
        {
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia ver = new Frm_Advertencia();

            if (lsv_asis.SelectedItems.Count == 0)
            {

                fil.Show();
                ver.Lbl_Msm1.Text = "Seleccione el Item a copiar";
                ver.ShowDialog();
                fil.Hide();
                return;
            }
            else
            {
                var Lsv = lsv_asis.SelectedItems[0];
                String xdni = Lsv.SubItems[1].Text;

                Clipboard.Clear();
                Clipboard.SetText(xdni.Trim());



            }
        }

        private void bt_verAsistenciasDelDiaT_Click(object sender, EventArgs e)
        {
            A_buscador_Asistencias_deldia(dtp_fechadeldia.Value);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

