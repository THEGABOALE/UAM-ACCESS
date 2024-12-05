namespace UamAcces.Formularios
{
    partial class FrmLogin2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin2));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtmIngresar = new System.Windows.Forms.Button();
            this.TbCif = new System.Windows.Forms.TextBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.BtmReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "CIF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Iniciar Sesión";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::UamAcces.Properties.Resources.Logo;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 74);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtmIngresar
            // 
            this.BtmIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BtmIngresar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmIngresar.ForeColor = System.Drawing.Color.White;
            this.BtmIngresar.Location = new System.Drawing.Point(299, 262);
            this.BtmIngresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtmIngresar.Name = "BtmIngresar";
            this.BtmIngresar.Size = new System.Drawing.Size(121, 46);
            this.BtmIngresar.TabIndex = 11;
            this.BtmIngresar.Text = "Ingresar";
            this.BtmIngresar.UseVisualStyleBackColor = false;
            this.BtmIngresar.Click += new System.EventHandler(this.BtmIngresar_Click);
            // 
            // TbCif
            // 
            this.TbCif.Location = new System.Drawing.Point(291, 136);
            this.TbCif.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TbCif.Name = "TbCif";
            this.TbCif.Size = new System.Drawing.Size(138, 20);
            this.TbCif.TabIndex = 0;
            this.TbCif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbCif_KeyPress_1);
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(291, 210);
            this.TbPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.PasswordChar = '⁕';
            this.TbPassword.Size = new System.Drawing.Size(138, 20);
            this.TbPassword.TabIndex = 2;
            this.TbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbPassword_KeyPress);
            // 
            // BtmReturn
            // 
            this.BtmReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BtmReturn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmReturn.ForeColor = System.Drawing.Color.White;
            this.BtmReturn.Location = new System.Drawing.Point(29, 337);
            this.BtmReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtmReturn.Name = "BtmReturn";
            this.BtmReturn.Size = new System.Drawing.Size(90, 33);
            this.BtmReturn.TabIndex = 19;
            this.BtmReturn.Text = "Regresar";
            this.BtmReturn.UseVisualStyleBackColor = false;
            this.BtmReturn.Click += new System.EventHandler(this.BtmReturn_Click);
            // 
            // FrmLogin2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 380);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtmReturn);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbCif);
            this.Controls.Add(this.BtmIngresar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmLogin2";
            this.Sizable = false;
            this.Text = "UAM ACCESS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtmIngresar;
        private System.Windows.Forms.TextBox TbCif;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.Button BtmReturn;
    }
}