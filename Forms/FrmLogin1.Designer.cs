namespace UamAcces
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtmINgresar = new System.Windows.Forms.Button();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.TbCif = new System.Windows.Forms.TextBox();
            this.BtmReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iniciar Sesión";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CIF";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::UamAcces.Properties.Resources.Logo;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 75);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtmINgresar
            // 
            this.BtmINgresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtmINgresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BtmINgresar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmINgresar.ForeColor = System.Drawing.Color.White;
            this.BtmINgresar.Location = new System.Drawing.Point(288, 271);
            this.BtmINgresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtmINgresar.Name = "BtmINgresar";
            this.BtmINgresar.Size = new System.Drawing.Size(121, 46);
            this.BtmINgresar.TabIndex = 10;
            this.BtmINgresar.Text = "Ingresar";
            this.BtmINgresar.UseVisualStyleBackColor = false;
            this.BtmINgresar.Click += new System.EventHandler(this.BtmIngresar_Click);
            // 
            // TbPassword
            // 
            this.TbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbPassword.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPassword.Location = new System.Drawing.Point(286, 219);
            this.TbPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.PasswordChar = '⁕';
            this.TbPassword.Size = new System.Drawing.Size(138, 23);
            this.TbPassword.TabIndex = 2;
            this.TbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Letter2);
            // 
            // TbCif
            // 
            this.TbCif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbCif.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCif.Location = new System.Drawing.Point(286, 145);
            this.TbCif.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TbCif.Name = "TbCif";
            this.TbCif.Size = new System.Drawing.Size(138, 23);
            this.TbCif.TabIndex = 0;
            this.TbCif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Letter);
            // 
            // BtmReturn
            // 
            this.BtmReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtmReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.BtmReturn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtmReturn.ForeColor = System.Drawing.Color.White;
            this.BtmReturn.Location = new System.Drawing.Point(20, 327);
            this.BtmReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtmReturn.Name = "BtmReturn";
            this.BtmReturn.Size = new System.Drawing.Size(98, 33);
            this.BtmReturn.TabIndex = 21;
            this.BtmReturn.Text = "Regresar";
            this.BtmReturn.UseVisualStyleBackColor = false;
            this.BtmReturn.Click += new System.EventHandler(this.BtmReturn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(595, 393);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtmReturn);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbCif);
            this.Controls.Add(this.BtmINgresar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.Text = "UAM ACCESS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtmINgresar;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.TextBox TbCif;
        private System.Windows.Forms.Button BtmReturn;
    }
}

