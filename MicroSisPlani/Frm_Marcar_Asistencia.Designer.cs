﻿namespace MicroSisPlani
{
    partial class Frm_Marcar_Asistencia
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Marcar_Asistencia));
            Klik.Windows.Forms.v1.Common.PaintStyle paintStyle4 = new Klik.Windows.Forms.v1.Common.PaintStyle();
            Klik.Windows.Forms.v1.Common.PaintStyle paintStyle5 = new Klik.Windows.Forms.v1.Common.PaintStyle();
            Klik.Windows.Forms.v1.Common.PaintStyle paintStyle6 = new Klik.Windows.Forms.v1.Common.PaintStyle();
            Klik.Windows.Forms.v1.Common.PaintStyle paintStyle7 = new Klik.Windows.Forms.v1.Common.PaintStyle();
            Klik.Windows.Forms.v1.Common.PaintStyle paintStyle8 = new Klik.Windows.Forms.v1.Common.PaintStyle();
            Klik.Windows.Forms.v1.Common.PaintStyle paintStyle3 = new Klik.Windows.Forms.v1.Common.PaintStyle();
            Klik.Windows.Forms.v1.Common.PaintStyle paintStyle2 = new Klik.Windows.Forms.v1.Common.PaintStyle();
            Klik.Windows.Forms.v1.Common.PaintStyle paintStyle1 = new Klik.Windows.Forms.v1.Common.PaintStyle();
            this.xVerificationControl = new DPFP.Gui.Verification.VerificationControl();
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_IdAsis = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.lbl_TotalHotrabajda = new System.Windows.Forms.Label();
            this.dtp_hora_tolercia = new System.Windows.Forms.DateTimePicker();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.Dtp_Hora_Limite = new System.Windows.Forms.DateTimePicker();
            this.Label27 = new System.Windows.Forms.Label();
            this.dtp_horaIngre = new System.Windows.Forms.DateTimePicker();
            this.dtp_horaSalida = new System.Windows.Forms.DateTimePicker();
            this.lbl_msm = new System.Windows.Forms.Label();
            this.lbl_totaltarde = new Klik.Windows.Forms.v1.EntryLib.ELLabel();
            this.lbl_justifi = new Klik.Windows.Forms.v1.EntryLib.ELLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_Idperso = new Klik.Windows.Forms.v1.EntryLib.ELLabel();
            this.lbl_Dni = new Klik.Windows.Forms.v1.EntryLib.ELLabel();
            this.picSocio = new System.Windows.Forms.PictureBox();
            this.lbl_nombresocio = new Klik.Windows.Forms.v1.EntryLib.ELLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_HoraActual = new System.Windows.Forms.DateTimePicker();
            this.lbl_hora = new Klik.Windows.Forms.v1.EntryLib.ELLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Lbl_HoraEntrada = new Klik.Windows.Forms.v1.EntryLib.ELLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_Cont = new Klik.Windows.Forms.v1.EntryLib.ELLabel();
            this.tmr_Conta = new System.Windows.Forms.Timer(this.components);
            this.lbl_waiting = new System.Windows.Forms.Label();
            this.pnl_Msm = new System.Windows.Forms.Panel();
            this.pnl_titulo.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_totaltarde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_justifi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lbl_Idperso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Dni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSocio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_nombresocio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_hora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lbl_HoraEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Cont)).BeginInit();
            this.pnl_Msm.SuspendLayout();
            this.SuspendLayout();
            // 
            // xVerificationControl
            // 
            this.xVerificationControl.Active = true;
            this.xVerificationControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.xVerificationControl.Location = new System.Drawing.Point(720, 68);
            this.xVerificationControl.Margin = new System.Windows.Forms.Padding(5);
            this.xVerificationControl.Name = "xVerificationControl";
            this.xVerificationControl.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000";
            this.xVerificationControl.Size = new System.Drawing.Size(64, 58);
            this.xVerificationControl.TabIndex = 6;
            this.xVerificationControl.OnComplete += new DPFP.Gui.Verification.VerificationControl._OnComplete(this.xVerificationControl_OnComplete);
            this.xVerificationControl.Load += new System.EventHandler(this.xVerificationControl_Load);
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.BackColor = System.Drawing.Color.Gray;
            this.pnl_titulo.Controls.Add(this.label7);
            this.pnl_titulo.Controls.Add(this.btn_Salir);
            this.pnl_titulo.Controls.Add(this.label1);
            this.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_titulo.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_titulo.Name = "pnl_titulo";
            this.pnl_titulo.Size = new System.Drawing.Size(1573, 62);
            this.pnl_titulo.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(47, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 29);
            this.label7.TabIndex = 25;
            this.label7.Text = "Marcar Asistencia";
            // 
            // btn_Salir
            // 
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.ForeColor = System.Drawing.Color.White;
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.Location = new System.Drawing.Point(4, 12);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(40, 37);
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1573, 5);
            this.label1.TabIndex = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.lbl_IdAsis);
            this.GroupBox2.Controls.Add(this.Label21);
            this.GroupBox2.Controls.Add(this.lbl_TotalHotrabajda);
            this.GroupBox2.Controls.Add(this.dtp_hora_tolercia);
            this.GroupBox2.Controls.Add(this.Label24);
            this.GroupBox2.Controls.Add(this.Label25);
            this.GroupBox2.Controls.Add(this.Label26);
            this.GroupBox2.Controls.Add(this.Dtp_Hora_Limite);
            this.GroupBox2.Controls.Add(this.Label27);
            this.GroupBox2.Controls.Add(this.dtp_horaIngre);
            this.GroupBox2.Controls.Add(this.dtp_horaSalida);
            this.GroupBox2.Location = new System.Drawing.Point(16, 514);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Size = new System.Drawing.Size(257, 164);
            this.GroupBox2.TabIndex = 109;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "HORARIOS DEFINIDOS";
            this.GroupBox2.Visible = false;
            // 
            // lbl_IdAsis
            // 
            this.lbl_IdAsis.AutoSize = true;
            this.lbl_IdAsis.Location = new System.Drawing.Point(101, 198);
            this.lbl_IdAsis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IdAsis.Name = "lbl_IdAsis";
            this.lbl_IdAsis.Size = new System.Drawing.Size(133, 16);
            this.lbl_IdAsis.TabIndex = 19;
            this.lbl_IdAsis.Text = "000000000000000000";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(48, 169);
            this.Label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(47, 16);
            this.Label21.TabIndex = 18;
            this.Label21.Text = "idAsis:";
            // 
            // lbl_TotalHotrabajda
            // 
            this.lbl_TotalHotrabajda.AutoSize = true;
            this.lbl_TotalHotrabajda.Location = new System.Drawing.Point(105, 169);
            this.lbl_TotalHotrabajda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TotalHotrabajda.Name = "lbl_TotalHotrabajda";
            this.lbl_TotalHotrabajda.Size = new System.Drawing.Size(14, 16);
            this.lbl_TotalHotrabajda.TabIndex = 17;
            this.lbl_TotalHotrabajda.Text = "0";
            // 
            // dtp_hora_tolercia
            // 
            this.dtp_hora_tolercia.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_hora_tolercia.Location = new System.Drawing.Point(105, 58);
            this.dtp_hora_tolercia.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_hora_tolercia.Name = "dtp_hora_tolercia";
            this.dtp_hora_tolercia.Size = new System.Drawing.Size(137, 22);
            this.dtp_hora_tolercia.TabIndex = 13;
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(24, 97);
            this.Label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(68, 16);
            this.Label24.TabIndex = 12;
            this.Label24.Text = "hora limite";
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Location = new System.Drawing.Point(35, 58);
            this.Label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(66, 16);
            this.Label25.TabIndex = 9;
            this.Label25.Text = "tolerancia";
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Location = new System.Drawing.Point(20, 137);
            this.Label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(74, 16);
            this.Label26.TabIndex = 8;
            this.Label26.Text = "hora salida";
            // 
            // Dtp_Hora_Limite
            // 
            this.Dtp_Hora_Limite.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Dtp_Hora_Limite.Location = new System.Drawing.Point(105, 90);
            this.Dtp_Hora_Limite.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_Hora_Limite.Name = "Dtp_Hora_Limite";
            this.Dtp_Hora_Limite.Size = new System.Drawing.Size(137, 22);
            this.Dtp_Hora_Limite.TabIndex = 11;
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Location = new System.Drawing.Point(11, 23);
            this.Label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(82, 16);
            this.Label27.TabIndex = 7;
            this.Label27.Text = "hora ingreso";
            // 
            // dtp_horaIngre
            // 
            this.dtp_horaIngre.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_horaIngre.Location = new System.Drawing.Point(105, 23);
            this.dtp_horaIngre.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_horaIngre.Name = "dtp_horaIngre";
            this.dtp_horaIngre.Size = new System.Drawing.Size(137, 22);
            this.dtp_horaIngre.TabIndex = 5;
            // 
            // dtp_horaSalida
            // 
            this.dtp_horaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_horaSalida.Location = new System.Drawing.Point(105, 129);
            this.dtp_horaSalida.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_horaSalida.Name = "dtp_horaSalida";
            this.dtp_horaSalida.Size = new System.Drawing.Size(137, 22);
            this.dtp_horaSalida.TabIndex = 6;
            // 
            // lbl_msm
            // 
            this.lbl_msm.BackColor = System.Drawing.Color.Transparent;
            this.lbl_msm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msm.ForeColor = System.Drawing.Color.Gray;
            this.lbl_msm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_msm.Location = new System.Drawing.Point(16, 138);
            this.lbl_msm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_msm.Name = "lbl_msm";
            this.lbl_msm.Size = new System.Drawing.Size(1541, 116);
            this.lbl_msm.TabIndex = 110;
            this.lbl_msm.Text = "Codigo:";
            this.lbl_msm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_totaltarde
            // 
            this.lbl_totaltarde.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.lbl_totaltarde.BackgroundStyle.SolidColor = System.Drawing.Color.White;
            this.lbl_totaltarde.BorderStyle.SolidColor = System.Drawing.Color.Gainsboro;
            paintStyle4.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            paintStyle4.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.lbl_totaltarde.FlashStyle = paintStyle4;
            this.lbl_totaltarde.Location = new System.Drawing.Point(1244, 469);
            this.lbl_totaltarde.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_totaltarde.Name = "lbl_totaltarde";
            this.lbl_totaltarde.Size = new System.Drawing.Size(69, 28);
            this.lbl_totaltarde.TabIndex = 123;
            this.lbl_totaltarde.TextStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totaltarde.TextStyle.Text = "0";
            this.lbl_totaltarde.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            // 
            // lbl_justifi
            // 
            this.lbl_justifi.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.lbl_justifi.BackgroundStyle.SolidColor = System.Drawing.Color.White;
            this.lbl_justifi.BorderStyle.SolidColor = System.Drawing.Color.Gainsboro;
            paintStyle5.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            paintStyle5.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.lbl_justifi.FlashStyle = paintStyle5;
            this.lbl_justifi.Location = new System.Drawing.Point(1115, 469);
            this.lbl_justifi.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_justifi.Name = "lbl_justifi";
            this.lbl_justifi.Size = new System.Drawing.Size(121, 28);
            this.lbl_justifi.TabIndex = 122;
            this.lbl_justifi.TabStop = false;
            this.lbl_justifi.TextStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_justifi.Visible = false;
            this.lbl_justifi.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(980, 441);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 22);
            this.label5.TabIndex = 117;
            this.label5.Text = "Codigo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(303, 437);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 28);
            this.label4.TabIndex = 116;
            this.label4.Text = "ID Alumno:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_Idperso
            // 
            this.Lbl_Idperso.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.Lbl_Idperso.BackgroundStyle.SolidColor = System.Drawing.Color.White;
            this.Lbl_Idperso.BorderStyle.SolidColor = System.Drawing.Color.Gainsboro;
            paintStyle6.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            paintStyle6.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.Lbl_Idperso.FlashStyle = paintStyle6;
            this.Lbl_Idperso.Location = new System.Drawing.Point(305, 469);
            this.Lbl_Idperso.Margin = new System.Windows.Forms.Padding(4);
            this.Lbl_Idperso.Name = "Lbl_Idperso";
            this.Lbl_Idperso.Size = new System.Drawing.Size(121, 28);
            this.Lbl_Idperso.TabIndex = 115;
            this.Lbl_Idperso.TabStop = false;
            this.Lbl_Idperso.TextStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Idperso.TextStyle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Lbl_Idperso.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            // 
            // lbl_Dni
            // 
            this.lbl_Dni.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.lbl_Dni.BackgroundStyle.SolidColor = System.Drawing.Color.White;
            this.lbl_Dni.BorderStyle.SolidColor = System.Drawing.Color.Gainsboro;
            paintStyle7.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            paintStyle7.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.lbl_Dni.FlashStyle = paintStyle7;
            this.lbl_Dni.Location = new System.Drawing.Point(985, 469);
            this.lbl_Dni.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_Dni.Name = "lbl_Dni";
            this.lbl_Dni.Size = new System.Drawing.Size(121, 28);
            this.lbl_Dni.TabIndex = 114;
            this.lbl_Dni.TabStop = false;
            this.lbl_Dni.TextStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dni.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            // 
            // picSocio
            // 
            this.picSocio.Image = ((System.Drawing.Image)(resources.GetObject("picSocio.Image")));
            this.picSocio.Location = new System.Drawing.Point(652, 437);
            this.picSocio.Margin = new System.Windows.Forms.Padding(4);
            this.picSocio.Name = "picSocio";
            this.picSocio.Size = new System.Drawing.Size(235, 204);
            this.picSocio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSocio.TabIndex = 113;
            this.picSocio.TabStop = false;
            // 
            // lbl_nombresocio
            // 
            this.lbl_nombresocio.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.lbl_nombresocio.BackgroundStyle.SolidColor = System.Drawing.Color.White;
            this.lbl_nombresocio.BorderStyle.SolidColor = System.Drawing.Color.WhiteSmoke;
            paintStyle8.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            paintStyle8.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.lbl_nombresocio.FlashStyle = paintStyle8;
            this.lbl_nombresocio.Location = new System.Drawing.Point(305, 383);
            this.lbl_nombresocio.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_nombresocio.Name = "lbl_nombresocio";
            this.lbl_nombresocio.Size = new System.Drawing.Size(1021, 39);
            this.lbl_nombresocio.TabIndex = 112;
            this.lbl_nombresocio.TabStop = false;
            this.lbl_nombresocio.TextStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombresocio.TextStyle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_nombresocio.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(307, 354);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 22);
            this.label6.TabIndex = 111;
            this.label6.Text = "Nombre:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtp_HoraActual
            // 
            this.dtp_HoraActual.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_HoraActual.Location = new System.Drawing.Point(1188, 84);
            this.dtp_HoraActual.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_HoraActual.Name = "dtp_HoraActual";
            this.dtp_HoraActual.Size = new System.Drawing.Size(137, 22);
            this.dtp_HoraActual.TabIndex = 124;
            this.dtp_HoraActual.Visible = false;
            // 
            // lbl_hora
            // 
            this.lbl_hora.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.lbl_hora.BackgroundStyle.SolidColor = System.Drawing.Color.White;
            this.lbl_hora.BorderStyle.SolidColor = System.Drawing.Color.Gainsboro;
            paintStyle3.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            paintStyle3.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.lbl_hora.FlashStyle = paintStyle3;
            this.lbl_hora.ForegroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.lbl_hora.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_hora.Location = new System.Drawing.Point(1359, 69);
            this.lbl_hora.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(199, 39);
            this.lbl_hora.TabIndex = 125;
            this.lbl_hora.TabStop = false;
            this.lbl_hora.TextStyle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.TextStyle.Text = "00:00:00";
            this.lbl_hora.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_hora.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Lbl_HoraEntrada
            // 
            this.Lbl_HoraEntrada.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.Lbl_HoraEntrada.BackgroundStyle.SolidColor = System.Drawing.Color.White;
            this.Lbl_HoraEntrada.BorderStyle.SolidColor = System.Drawing.Color.Gainsboro;
            paintStyle2.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            paintStyle2.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.Lbl_HoraEntrada.FlashStyle = paintStyle2;
            this.Lbl_HoraEntrada.ForegroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.Lbl_HoraEntrada.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_HoraEntrada.Location = new System.Drawing.Point(16, 69);
            this.Lbl_HoraEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.Lbl_HoraEntrada.Name = "Lbl_HoraEntrada";
            this.Lbl_HoraEntrada.Size = new System.Drawing.Size(141, 39);
            this.Lbl_HoraEntrada.TabIndex = 126;
            this.Lbl_HoraEntrada.TabStop = false;
            this.Lbl_HoraEntrada.TextStyle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_HoraEntrada.TextStyle.ForeColor = System.Drawing.Color.DimGray;
            this.Lbl_HoraEntrada.TextStyle.Text = "00:00";
            this.Lbl_HoraEntrada.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.Lbl_HoraEntrada, "Hora de Entrada");
            this.Lbl_HoraEntrada.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // lbl_Cont
            // 
            this.lbl_Cont.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.lbl_Cont.BackgroundStyle.SolidColor = System.Drawing.Color.White;
            this.lbl_Cont.BorderStyle.SolidColor = System.Drawing.Color.Gainsboro;
            paintStyle1.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            paintStyle1.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.lbl_Cont.FlashStyle = paintStyle1;
            this.lbl_Cont.ForegroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.lbl_Cont.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Cont.Location = new System.Drawing.Point(8, 9);
            this.lbl_Cont.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_Cont.Name = "lbl_Cont";
            this.lbl_Cont.Size = new System.Drawing.Size(265, 39);
            this.lbl_Cont.TabIndex = 127;
            this.lbl_Cont.TabStop = false;
            this.lbl_Cont.TextStyle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cont.TextStyle.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Cont.TextStyle.Text = "10";
            this.lbl_Cont.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.lbl_Cont, "Hora de Entrada");
            this.lbl_Cont.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            // 
            // tmr_Conta
            // 
            this.tmr_Conta.Interval = 1000;
            this.tmr_Conta.Tick += new System.EventHandler(this.tmr_Conta_Tick);
            // 
            // lbl_waiting
            // 
            this.lbl_waiting.AutoSize = true;
            this.lbl_waiting.BackColor = System.Drawing.Color.Transparent;
            this.lbl_waiting.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_waiting.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_waiting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_waiting.Location = new System.Drawing.Point(44, 18);
            this.lbl_waiting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_waiting.Name = "lbl_waiting";
            this.lbl_waiting.Size = new System.Drawing.Size(165, 21);
            this.lbl_waiting.TabIndex = 128;
            this.lbl_waiting.Text = "Espere por Favor ..";
            this.lbl_waiting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_waiting.Click += new System.EventHandler(this.lbl_waiting_Click);
            // 
            // pnl_Msm
            // 
            this.pnl_Msm.Controls.Add(this.lbl_waiting);
            this.pnl_Msm.Controls.Add(this.lbl_Cont);
            this.pnl_Msm.Location = new System.Drawing.Point(605, 281);
            this.pnl_Msm.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Msm.Name = "pnl_Msm";
            this.pnl_Msm.Size = new System.Drawing.Size(281, 55);
            this.pnl_Msm.TabIndex = 129;
            this.pnl_Msm.Visible = false;
            // 
            // Frm_Marcar_Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1573, 693);
            this.Controls.Add(this.pnl_Msm);
            this.Controls.Add(this.Lbl_HoraEntrada);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.dtp_HoraActual);
            this.Controls.Add(this.lbl_totaltarde);
            this.Controls.Add(this.lbl_justifi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lbl_Idperso);
            this.Controls.Add(this.lbl_Dni);
            this.Controls.Add(this.picSocio);
            this.Controls.Add(this.lbl_nombresocio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_msm);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.pnl_titulo);
            this.Controls.Add(this.xVerificationControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Marcar_Asistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcar Asistencia del Personal";
            this.Load += new System.EventHandler(this.Frm_Marcar_Asistencia_Load);
            this.pnl_titulo.ResumeLayout(false);
            this.pnl_titulo.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_totaltarde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_justifi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lbl_Idperso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Dni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSocio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_nombresocio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_hora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lbl_HoraEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Cont)).EndInit();
            this.pnl_Msm.ResumeLayout(false);
            this.pnl_Msm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DPFP.Gui.Verification.VerificationControl xVerificationControl;
        private System.Windows.Forms.Panel pnl_titulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label lbl_IdAsis;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.Label lbl_TotalHotrabajda;
        internal System.Windows.Forms.DateTimePicker dtp_hora_tolercia;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.DateTimePicker Dtp_Hora_Limite;
        internal System.Windows.Forms.Label Label27;
        internal System.Windows.Forms.DateTimePicker dtp_horaIngre;
        internal System.Windows.Forms.DateTimePicker dtp_horaSalida;
        private System.Windows.Forms.Label lbl_msm;
        public Klik.Windows.Forms.v1.EntryLib.ELLabel lbl_totaltarde;
        public Klik.Windows.Forms.v1.EntryLib.ELLabel lbl_justifi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public Klik.Windows.Forms.v1.EntryLib.ELLabel Lbl_Idperso;
        public Klik.Windows.Forms.v1.EntryLib.ELLabel lbl_Dni;
        private System.Windows.Forms.PictureBox picSocio;
        private Klik.Windows.Forms.v1.EntryLib.ELLabel lbl_nombresocio;
        private System.Windows.Forms.Label label6;
        public Klik.Windows.Forms.v1.EntryLib.ELLabel lbl_hora;
        internal System.Windows.Forms.DateTimePicker dtp_HoraActual;
        private System.Windows.Forms.Timer timer1;
        public Klik.Windows.Forms.v1.EntryLib.ELLabel Lbl_HoraEntrada;
        private System.Windows.Forms.ToolTip toolTip1;
        public Klik.Windows.Forms.v1.EntryLib.ELLabel lbl_Cont;
        private System.Windows.Forms.Timer tmr_Conta;
        private System.Windows.Forms.Label lbl_waiting;
        private System.Windows.Forms.Panel pnl_Msm;
    }
}

