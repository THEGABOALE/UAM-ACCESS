﻿namespace UamAcces.Formularios
{
    partial class Report1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Desde = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpDate1 = new System.Windows.Forms.DateTimePicker();
            this.Rol = new System.Windows.Forms.Label();
            this.btmInforme = new System.Windows.Forms.Button();
            this.CbRole = new System.Windows.Forms.ComboBox();
            this.BtmReturn = new System.Windows.Forms.Button();
            this.BtmGraphic = new System.Windows.Forms.Button();
            this.DtpDate2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::UamAcces.Properties.Resources.Logo;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 77);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(236, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escoja los valores necesarios";
            // 
            // Desde
            // 
            this.Desde.AutoSize = true;
            this.Desde.BackColor = System.Drawing.Color.White;
            this.Desde.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desde.Location = new System.Drawing.Point(193, 136);
            this.Desde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Desde.Name = "Desde";
            this.Desde.Size = new System.Drawing.Size(51, 17);
            this.Desde.TabIndex = 3;
            this.Desde.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta";
            // 
            // DtpDate1
            // 
            this.DtpDate1.CalendarFont = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDate1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpDate1.Location = new System.Drawing.Point(254, 136);
            this.DtpDate1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DtpDate1.Name = "DtpDate1";
            this.DtpDate1.Size = new System.Drawing.Size(199, 21);
            this.DtpDate1.TabIndex = 5;
            // 
            // Rol
            // 
            this.Rol.AutoSize = true;
            this.Rol.BackColor = System.Drawing.Color.White;
            this.Rol.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rol.Location = new System.Drawing.Point(193, 223);
            this.Rol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Rol.Name = "Rol";
            this.Rol.Size = new System.Drawing.Size(30, 17);
            this.Rol.TabIndex = 7;
            this.Rol.Text = "Rol";
            // 
            // btmInforme
            // 
            this.btmInforme.Image = global::UamAcces.Properties.Resources.formulario_de_llenado;
            this.btmInforme.Location = new System.Drawing.Point(254, 267);
            this.btmInforme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btmInforme.Name = "btmInforme";
            this.btmInforme.Size = new System.Drawing.Size(78, 90);
            this.btmInforme.TabIndex = 13;
            this.btmInforme.UseVisualStyleBackColor = true;
            this.btmInforme.Click += new System.EventHandler(this.btmInforme_Click);
            // 
            // CbRole
            // 
            this.CbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbRole.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbRole.FormattingEnabled = true;
            this.CbRole.Location = new System.Drawing.Point(254, 224);
            this.CbRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbRole.Name = "CbRole";
            this.CbRole.Size = new System.Drawing.Size(199, 24);
            this.CbRole.TabIndex = 14;
            // 
            // BtmReturn
            // 
            this.BtmReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BtmReturn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmReturn.ForeColor = System.Drawing.Color.White;
            this.BtmReturn.Location = new System.Drawing.Point(9, 324);
            this.BtmReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtmReturn.Name = "BtmReturn";
            this.BtmReturn.Size = new System.Drawing.Size(98, 33);
            this.BtmReturn.TabIndex = 22;
            this.BtmReturn.Text = "Regresar";
            this.BtmReturn.UseVisualStyleBackColor = false;
            this.BtmReturn.Click += new System.EventHandler(this.BtmReturn_Click);
            // 
            // BtmGraphic
            // 
            this.BtmGraphic.Image = global::UamAcces.Properties.Resources.grafico;
            this.BtmGraphic.Location = new System.Drawing.Point(374, 267);
            this.BtmGraphic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtmGraphic.Name = "BtmGraphic";
            this.BtmGraphic.Size = new System.Drawing.Size(78, 90);
            this.BtmGraphic.TabIndex = 23;
            this.BtmGraphic.UseVisualStyleBackColor = true;
            this.BtmGraphic.Click += new System.EventHandler(this.BtmGraphic_Click);
            // 
            // DtpDate2
            // 
            this.DtpDate2.CalendarFont = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDate2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDate2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpDate2.Location = new System.Drawing.Point(254, 178);
            this.DtpDate2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DtpDate2.Name = "DtpDate2";
            this.DtpDate2.Size = new System.Drawing.Size(199, 21);
            this.DtpDate2.TabIndex = 24;
            // 
            // Report1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 375);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DtpDate2);
            this.Controls.Add(this.BtmGraphic);
            this.Controls.Add(this.BtmReturn);
            this.Controls.Add(this.CbRole);
            this.Controls.Add(this.btmInforme);
            this.Controls.Add(this.Rol);
            this.Controls.Add(this.DtpDate1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Desde);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Report1";
            this.Sizable = false;
            this.Text = "Reporte Historial";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Desde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpDate1;
        private System.Windows.Forms.Label Rol;
        private System.Windows.Forms.Button btmInforme;
        private System.Windows.Forms.ComboBox CbRole;
        private System.Windows.Forms.Button BtmReturn;
        private System.Windows.Forms.Button BtmGraphic;
        private System.Windows.Forms.DateTimePicker DtpDate2;
    }
}