
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using Prj_Capa_Datos;
using Prj_Capa_Entidad;
using Prj_Capa_Negocio;
using DPFP;
using System.IO;
using MicroSisPlani.Msm_Forms;


namespace MicroSisPlani
{
    public partial class Frm_Marcar_Asistencia : Form
    {
        public Frm_Marcar_Asistencia()
        {
            InitializeComponent();

        }


        private DPFP.Verification.Verification verificar;
        private DPFP.Verification.Verification.Result resultado;
        private void Frm_Marcar_Asistencia_Load(object sender, EventArgs e)
        {
            verificar = new DPFP.Verification.Verification();
            resultado = new DPFP.Verification.Verification.Result();
            cargar_horarios();

        }
        private void cargar_horarios()
        {
            RN_Horario obj = new RN_Horario();
            DataTable data = new DataTable();

            data = obj.RN_Leer_Horarios();

            if (data.Rows.Count == 0) return;
            //lbl_idHorario.Text = Convert.ToString(data.Rows[0]["Id_Hor"]);
            dtp_horaIngre.Value = Convert.ToDateTime(data.Rows[0]["HoEntrada"]);
            Lbl_HoraEntrada.Text = dtp_horaIngre.Value.Hour.ToString() + ":" + dtp_horaIngre.Value.Minute.ToString();
            dtp_horaSalida.Value = Convert.ToDateTime(data.Rows[0]["HoSalida"]);
            dtp_hora_tolercia.Value = Convert.ToDateTime(data.Rows[0]["MiTolermcia"]);
            Dtp_Hora_Limite.Value = Convert.ToDateTime(data.Rows[0]["HoLimite"]);
        }
        private void calcular_minutos_tarde()
        {
            //variables que contiene minutos y horas
            int horain = dtp_horaIngre.Value.Hour;
            int minuIn = dtp_horaIngre.Value.Minute;
            int minuTole = dtp_hora_tolercia.Value.Minute;
            int HoraTole = dtp_hora_tolercia.Value.Hour;

            //minutos

            int HoraNow = DateTime.Now.Hour;
            int MinuNow = DateTime.Now.Minute;

            int totalminutos = minuTole + minuIn;
            int totalTardanza = 0;

            if(HoraNow==horain & MinuNow>totalminutos)
            {
                totalTardanza = MinuNow - totalminutos;
                lbl_totaltarde.Text = "0";
            }
            else if(HoraNow==horain &MinuNow>totalminutos )
            {
                totalTardanza = MinuNow - totalminutos;
                lbl_totaltarde.Text = totalTardanza.ToString();
            
            }else if(HoraNow > horain )
            {
                int horatarde = 0;

                horatarde = HoraNow - horain;
                int horaenMinuto = 0;
                
                    horaenMinuto = 60 * horatarde;
              
               

                int nuevoMinutoTarde =0;
                nuevoMinutoTarde = horaenMinuto - totalminutos;
                totalTardanza = MinuNow + nuevoMinutoTarde;
                lbl_totaltarde.Text = totalTardanza.ToString();


            }
        }
       private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            calcular_minutos_tarde();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString("hh:mm:ss");
        }
        private void xVerificationControl_OnComplete(object Control, FeatureSet FeatureSet, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            RN_Asistencia objAsis = new RN_Asistencia();
            RN_Personal objper = new RN_Personal();
            DataTable dataper = new DataTable();
            DataTable dataasis = new DataTable();
            Frm_Filtro fil = new Frm_Filtro();
            Frm_Advertencia adver = new Frm_Advertencia();
            EN_Asistencia asis = new EN_Asistencia();
            Frm_Msm_Bueno ok = new Frm_Msm_Bueno();



            byte[] huellapersona;
            string xidepersona = "";
            string xrutaforo = "";
            string xnombrepersona = "";
            string xdnipersona = "";
            bool terminaBucle = false;
            int Nro_Rows_Data = 0;
            int NroVeces = 0;




            //posible cambio de zona al else por probar
            if (VerificarHoraLimite() == false)
            {
                fil.Show();
                adver.Lbl_Msm1.Text = "Tu hora de enetrada ya caduco vuelve a casa";
                adver.ShowDialog();
                fil.Hide();
                return;
                //quitamos
                try
                {
                    dataper = objper.RN_Lista_Todo_Personal();
                    if (dataper.Rows.Count == 0) { return; }
                    Nro_Rows_Data = dataper.Rows.Count;
                    var datoPer = dataper.Rows[0];

                    foreach (DataRow dt in dataper.Rows)
                    {
                        if (terminaBucle == true) { return; }

                        huellapersona = (byte[])dt["FinguerPrint"];
                        xidepersona = Convert.ToString(dt["Id_pern1"]);
                        if (huellapersona.Length > 100)
                        {
                            DPFP.Template TemplateBD = new DPFP.Template();
                            TemplateBD.DeSerialize(huellapersona);
                            verificar.Verify(FeatureSet, TemplateBD, ref resultado);

                            if (resultado.Verified == true)
                            {
                                xrutaforo = Convert.ToString(dt["Foto"]);
                                lbl_nombresocio.Text = Convert.ToString(dt["Nombre_Completo"]);
                                Lbl_Idperso.Text = Convert.ToString(dt["Id_pern1"]);
                                lbl_Dni.Text = Convert.ToString(dt["Dni"]);

                                if (File.Exists(xrutaforo) == true) { picSocio.Load(xrutaforo.Trim()); }
                                else
                                {
                                    picSocio.Load(Application.StartupPath + @"\user.png");
                                }
                                if (objAsis.RN_verificarsi_yaMarco_su_asistencia(Lbl_Idperso.Text) == true)
                                {

                                    fil.Show();
                                    adver.Lbl_Msm1.Text = "El personal ya marco su asistencia";
                                    /*POSIBLE CAMBIP A ver*/
                                    adver.ShowDialog();
                                    fil.Hide();
                                    terminaBucle = true;
                                    return;

                                }
                                if (objAsis.RN_verificarsiMarcoEntrada(Lbl_Idperso.Text) == true)
                                {
                                    //marcara su salda
                                    Frm_Sinox sino = new Frm_Sinox();
                                    terminaBucle = true;
                                    fil.Show();
                                    sino.Lbl_msm1.Text = "El usuario marco salida";
                                    sino.ShowDialog();
                                    fil.Hide();

                                    if (sino.Tag.ToString() == "Si")
                                    {
                                        dataasis = objAsis.RN_Buscar_Asistencia_deEntrada(Lbl_Idperso.Text);

                                        if (dataasis.Rows.Count == 0) return;

                                        lbl_IdAsis.Text =Convert.ToString( dataasis.Rows[0]["Id_asis"]);

                                        asis.IdAsistencia = lbl_IdAsis.Text;
                                        asis.Id_Personal = Lbl_Idperso.Text;
                                        asis.HoraSalida = lbl_hora.Text;
                                        asis.TotalHoras = 7;
                                        //posible error
                                        objAsis.RN_registrar_Salida(asis);

                                        if (BD_Asistencia.salida == true)
                                        {
                                            lbl_msm.BackColor = Color.YellowGreen;
                                            lbl_msm.ForeColor = Color.White;
                                            lbl_msm.Text = "La salida fue exitosa";
                                            
                                            xVerificationControl.Enabled = false;
                                            pnl_Msm.Visible = true;

                                            lbl_Cont.Text = "10";
                                            tmr_Conta.Enabled = true;
                                            terminaBucle = true;


                                        }
                                    }
                                }
                                else
                                {
                                    //toca marcar su entrada

                                    //Datos y condiciones a quitar por posible error y BUG 
                                    //22/11/2022 9:23 PM
                                    if (VerificarHoraLimite() == false)
                                    {
                                        fil.Show(); adver.Lbl_Msm1.Text = "Tu hora de enetrada ya caduco vuelve a casa"; adver.ShowDialog(); fil.Hide(); return;
                                        //calcular la tardanza
                                        calcular_minutos_tarde();
                                        lbl_IdAsis.Text = RN_Utilitario.RN_NroDoc(1);
                                        string Nomdia = DateTime.Now.ToString("dddd");

                                        //registro asistencia
                                        asis.IdAsistencia = lbl_IdAsis.Text;
                                        asis.Id_Personal = Lbl_Idperso.Text;
                                        asis.Nombre_Dia = Nomdia;
                                        asis.HoraIngre = lbl_hora.Text;
                                        asis.Justificacion = "Pendiente";
                                        asis.Tardanza=Convert.ToInt32 (lbl_totaltarde.Text);
                                        objAsis.RN_registrar_Entrada(asis);

                                        if (BD_Asistencia.Entrada == true)
                                        {
                                            Actualizar_SiguienteNumero(1);
                                           
                                            fil.Show();
                                            ok.Lbl_msm1.Text = "La asistencia se guardo correctamente";
                                            tocaraudio();
                                            ok.ShowDialog();
                                            fil.Hide();

                                            terminaBucle = true;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                NroVeces += 1;
                            }

                        }
                        else
                        {
                            NroVeces += 1;
                        }

                    }
                    if (NroVeces == Nro_Rows_Data)
                    {
                        fil.Show();
                        adver.Lbl_Msm1.Text = "La huella no existe en la BD";
                        adver.ShowDialog();
                        fil.Hide();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    string sms = ex.Message;
                }
            }
        }
        private void tocaraudio()
            {

            string ruta;
            ruta = Application.StartupPath;
            System.Media.SoundPlayer son;
              son=new System.Media.SoundPlayer(ruta + @"\timbre.wav");
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

        private bool VerificarHoraLimite() 
        {
            int xhourLimite = Dtp_Hora_Limite.Value.Hour;
            int xminuoLimite = Dtp_Hora_Limite.Value.Minute;
            bool resultado = false;

            int horacaptu = DateTime.Now.Hour;
            int MinutoCaptu = DateTime.Now.Minute;

            if (xhourLimite == horacaptu & xminuoLimite > MinutoCaptu)
            {
                resultado = false;
                return false;
            }
            else if (horacaptu > xhourLimite)
            {
                return false;
            } else if (horacaptu == xhourLimite & MinutoCaptu < xminuoLimite)
            {
                return true;
            }
            else if (horacaptu<xhourLimite)
            {
                return true;
            }else
            {
               return false;

            }
        }

        private void lbl_waiting_Click(object sender, EventArgs e)
        {

        }

        private int  sec = 10;


        private void tmr_Conta_Tick(object sender, EventArgs e)
        {
            sec -= 1;
            lbl_Cont.Text = sec.ToString();
            lbl_Cont.Refresh();


            if (sec == 0)
            {
                LimpiarFormulario();
                sec = 10;
                tmr_Conta.Stop();
                lbl_Cont.Text = "10";
            }
        }


        private void LimpiarFormulario()
        {
            lbl_nombresocio.Text = "";
            lbl_totaltarde.Text = "0";
            lbl_TotalHotrabajda.Text="0";
            lbl_Dni.Text = "";
            lbl_Cont.Text="";
            lbl_IdAsis.Text = "";
            Lbl_Idperso.Text = "";
            lbl_justifi.Text = "";
            lbl_msm.BackColor = Color.Transparent;
            lbl_msm.Text = "";
            picSocio.Image = null;
            xVerificationControl.Enabled = true;
        }

        private void xVerificationControl_Load(object sender, EventArgs e)
        {

        }
    }
}
