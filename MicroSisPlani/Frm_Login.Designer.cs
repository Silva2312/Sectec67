﻿namespace MicroSisPlani
{
    partial class Frm_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Label1 = new System.Windows.Forms.Label();
            this.ElDivider1 = new Klik.Windows.Forms.v1.EntryLib.ELDivider();
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.txt_pass = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.txt_usu = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.btn_Aceptar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ElDivider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_usu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Aceptar)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label1.Location = new System.Drawing.Point(135, 95);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(257, 49);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "Sec Tec #67";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // ElDivider1
            // 
            this.ElDivider1.FadeStyle = Klik.Windows.Forms.v1.EntryLib.DividerFadeStyles.Center;
            this.ElDivider1.LineColor = System.Drawing.Color.Silver;
            this.ElDivider1.LineSize = 1;
            this.ElDivider1.Location = new System.Drawing.Point(13, 133);
            this.ElDivider1.Margin = new System.Windows.Forms.Padding(4);
            this.ElDivider1.Name = "ElDivider1";
            this.ElDivider1.Size = new System.Drawing.Size(428, 28);
            this.ElDivider1.TabIndex = 22;
            this.ElDivider1.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_titulo.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_titulo.Name = "pnl_titulo";
            this.pnl_titulo.Size = new System.Drawing.Size(1105, 30);
            this.pnl_titulo.TabIndex = 23;
            this.pnl_titulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_titulo_Paint);
            this.pnl_titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_titulo_MouseMove);
            // 
            // Label12
            // 
            this.Label12.BackColor = System.Drawing.Color.White;
            this.Label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.ForeColor = System.Drawing.Color.SkyBlue;
            this.Label12.Image = ((System.Drawing.Image)(resources.GetObject("Label12.Image")));
            this.Label12.Location = new System.Drawing.Point(56, 256);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(27, 25);
            this.Label12.TabIndex = 452;
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.Color.White;
            this.Label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.ForeColor = System.Drawing.Color.SkyBlue;
            this.Label13.Image = ((System.Drawing.Image)(resources.GetObject("Label13.Image")));
            this.Label13.Location = new System.Drawing.Point(56, 340);
            this.Label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(27, 25);
            this.Label13.TabIndex = 454;
            // 
            // txt_pass
            // 
            this.txt_pass.CaptionStyle.CaptionSize = 0;
            this.txt_pass.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_pass.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.txt_pass.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.txt_pass.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.White;
            this.txt_pass.EditBoxStyle.BackColor = System.Drawing.Color.White;
            this.txt_pass.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None;
            this.txt_pass.EditBoxStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.EditBoxStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_pass.EditBoxStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.txt_pass.EditBoxStyle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_pass.Location = new System.Drawing.Point(45, 329);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(384, 45);
            this.txt_pass.TabIndex = 453;
            this.txt_pass.ValidationStyle.PasswordChar = '\0';
            this.txt_pass.ValidationStyle.UseSystemPasswordChar = true;
            this.txt_pass.Value = "";
            this.txt_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pass_KeyDown);
            // 
            // txt_usu
            // 
            this.txt_usu.CaptionStyle.CaptionSize = 0;
            this.txt_usu.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_usu.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.txt_usu.CaptionStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.txt_usu.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.White;
            this.txt_usu.EditBoxStyle.BackColor = System.Drawing.Color.White;
            this.txt_usu.EditBoxStyle.BorderStyle.BorderType = Klik.Windows.Forms.v1.Common.BorderTypes.None;
            this.txt_usu.EditBoxStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usu.EditBoxStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_usu.EditBoxStyle.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ModernBlack;
            this.txt_usu.EditBoxStyle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_usu.Location = new System.Drawing.Point(45, 245);
            this.txt_usu.Margin = new System.Windows.Forms.Padding(4);
            this.txt_usu.Name = "txt_usu";
            this.txt_usu.Size = new System.Drawing.Size(384, 45);
            this.txt_usu.TabIndex = 450;
            this.txt_usu.ValidationStyle.PasswordChar = '\0';
            this.txt_usu.Value = "";
            this.txt_usu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_usu_KeyDown);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackgroundStyle.GradientAngle = 0F;
            this.btn_Aceptar.BackgroundStyle.GradientEndColor = System.Drawing.Color.OrangeRed;
            this.btn_Aceptar.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Aceptar.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_Aceptar.BackgroundStyle.SolidColor = System.Drawing.Color.DarkCyan;
            this.btn_Aceptar.BorderStyle.SolidColor = System.Drawing.Color.DarkCyan;
            this.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Aceptar.DropDownArrowColor = System.Drawing.Color.White;
            this.btn_Aceptar.EnableThemes = false;
            this.btn_Aceptar.FlashStyle.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Aceptar.FlashStyle.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Aceptar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_Aceptar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Aceptar.ForegroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btn_Aceptar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Aceptar.Location = new System.Drawing.Point(88, 404);
            this.btn_Aceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(299, 52);
            this.btn_Aceptar.StateStyles.HoverStyle.BackgroundGradientEndColor = System.Drawing.Color.YellowGreen;
            this.btn_Aceptar.StateStyles.HoverStyle.BackgroundGradientStartColor = System.Drawing.Color.YellowGreen;
            this.btn_Aceptar.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.YellowGreen;
            this.btn_Aceptar.StateStyles.HoverStyle.BorderGradientEndColor = System.Drawing.Color.YellowGreen;
            this.btn_Aceptar.StateStyles.HoverStyle.BorderGradientStartColor = System.Drawing.Color.YellowGreen;
            this.btn_Aceptar.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.YellowGreen;
            this.btn_Aceptar.TabIndex = 458;
            this.btn_Aceptar.TextStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Aceptar.TextStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.TextStyle.ForeColor = System.Drawing.Color.White;
            this.btn_Aceptar.TextStyle.Text = "Iniciar Sesion";
            this.btn_Aceptar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Aceptar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.DimGray;
            this.Label10.Location = new System.Drawing.Point(235, 527);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(21, 21);
            this.Label10.TabIndex = 461;
            this.Label10.Text = "|";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.BackColor = System.Drawing.Color.Transparent;
            this.Label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.ForeColor = System.Drawing.Color.DimGray;
            this.Label15.Location = new System.Drawing.Point(307, 527);
            this.Label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(76, 21);
            this.Label15.TabIndex = 460;
            this.Label15.Text = "Revision";
            // 
            // Panel1
            // 
            this.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel1.BackgroundImage")));
            this.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel1.Location = new System.Drawing.Point(505, 30);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(600, 565);
            this.Panel1.TabIndex = 462;
            // 
            // lbl_estado
            // 
            this.lbl_estado.BackColor = System.Drawing.Color.Transparent;
            this.lbl_estado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_estado.Location = new System.Drawing.Point(9, 482);
            this.lbl_estado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(440, 21);
            this.lbl_estado.TabIndex = 463;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.ForeColor = System.Drawing.Color.White;
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.Location = new System.Drawing.Point(454, 34);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(43, 39);
            this.btn_Salir.TabIndex = 464;
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 465;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 466;
            this.label3.Text = "Contraseña";
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1105, 595);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_usu);
            this.Controls.Add(this.pnl_titulo);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ElDivider1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ElDivider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_usu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Aceptar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label15;
        internal Klik.Windows.Forms.v1.EntryLib.ELButton btn_Aceptar;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label13;
        internal Klik.Windows.Forms.v1.EntryLib.ELEntryBox txt_pass;
        internal Klik.Windows.Forms.v1.EntryLib.ELEntryBox txt_usu;
        internal System.Windows.Forms.Panel pnl_titulo;
        internal System.Windows.Forms.Label Label1;
        internal Klik.Windows.Forms.v1.EntryLib.ELDivider ElDivider1;
        internal System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}