namespace AracKiralama
{
    partial class LoginForm
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
            this.Loginlabel1 = new System.Windows.Forms.Label();
            this.epostalabel2 = new System.Windows.Forms.Label();
            this.sifrelabel3 = new System.Windows.Forms.Label();
            this.EpostatextBox1 = new System.Windows.Forms.TextBox();
            this.SifretextBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.kayitlinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SifrelinkLabel2 = new System.Windows.Forms.LinkLabel();
            this.Adminbutton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Loginlabel1
            // 
            this.Loginlabel1.AutoSize = true;
            this.Loginlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Loginlabel1.Location = new System.Drawing.Point(291, 66);
            this.Loginlabel1.Name = "Loginlabel1";
            this.Loginlabel1.Size = new System.Drawing.Size(142, 29);
            this.Loginlabel1.TabIndex = 0;
            this.Loginlabel1.Text = "Giriş Yapın";
            // 
            // epostalabel2
            // 
            this.epostalabel2.AutoSize = true;
            this.epostalabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.epostalabel2.Location = new System.Drawing.Point(187, 139);
            this.epostalabel2.Name = "epostalabel2";
            this.epostalabel2.Size = new System.Drawing.Size(74, 20);
            this.epostalabel2.TabIndex = 1;
            this.epostalabel2.Text = "E-Posta ";
            // 
            // sifrelabel3
            // 
            this.sifrelabel3.AutoSize = true;
            this.sifrelabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifrelabel3.Location = new System.Drawing.Point(187, 180);
            this.sifrelabel3.Name = "sifrelabel3";
            this.sifrelabel3.Size = new System.Drawing.Size(44, 20);
            this.sifrelabel3.TabIndex = 2;
            this.sifrelabel3.Text = "Şifre";
            // 
            // EpostatextBox1
            // 
            this.EpostatextBox1.Location = new System.Drawing.Point(278, 137);
            this.EpostatextBox1.Name = "EpostatextBox1";
            this.EpostatextBox1.Size = new System.Drawing.Size(210, 22);
            this.EpostatextBox1.TabIndex = 3;
            // 
            // SifretextBox2
            // 
            this.SifretextBox2.Location = new System.Drawing.Point(278, 178);
            this.SifretextBox2.Name = "SifretextBox2";
            this.SifretextBox2.PasswordChar = '*';
            this.SifretextBox2.Size = new System.Drawing.Size(210, 22);
            this.SifretextBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 57);
            this.button1.TabIndex = 5;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // kayitlinkLabel1
            // 
            this.kayitlinkLabel1.AutoSize = true;
            this.kayitlinkLabel1.Location = new System.Drawing.Point(306, 231);
            this.kayitlinkLabel1.Name = "kayitlinkLabel1";
            this.kayitlinkLabel1.Size = new System.Drawing.Size(182, 16);
            this.kayitlinkLabel1.TabIndex = 6;
            this.kayitlinkLabel1.TabStop = true;
            this.kayitlinkLabel1.Text = "Hesabınız yok mu? Kayıt Olun";
            this.kayitlinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.kayitlinkLabel1_LinkClicked);
            // 
            // SifrelinkLabel2
            // 
            this.SifrelinkLabel2.AutoSize = true;
            this.SifrelinkLabel2.Location = new System.Drawing.Point(389, 203);
            this.SifrelinkLabel2.Name = "SifrelinkLabel2";
            this.SifrelinkLabel2.Size = new System.Drawing.Size(99, 16);
            this.SifrelinkLabel2.TabIndex = 7;
            this.SifrelinkLabel2.TabStop = true;
            this.SifrelinkLabel2.Text = "Şifremi Unuttum";
            // 
            // Adminbutton2
            // 
            this.Adminbutton2.Location = new System.Drawing.Point(507, 255);
            this.Adminbutton2.Name = "Adminbutton2";
            this.Adminbutton2.Size = new System.Drawing.Size(89, 33);
            this.Adminbutton2.TabIndex = 8;
            this.Adminbutton2.Text = "Yetkili Girişi";
            this.Adminbutton2.UseVisualStyleBackColor = true;
            this.Adminbutton2.Click += new System.EventHandler(this.Adminbutton2_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 397);
            this.Controls.Add(this.Adminbutton2);
            this.Controls.Add(this.SifrelinkLabel2);
            this.Controls.Add(this.kayitlinkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SifretextBox2);
            this.Controls.Add(this.EpostatextBox1);
            this.Controls.Add(this.sifrelabel3);
            this.Controls.Add(this.epostalabel2);
            this.Controls.Add(this.Loginlabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Loginlabel1;
        private System.Windows.Forms.Label epostalabel2;
        private System.Windows.Forms.Label sifrelabel3;
        private System.Windows.Forms.TextBox EpostatextBox1;
        private System.Windows.Forms.TextBox SifretextBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel kayitlinkLabel1;
        private System.Windows.Forms.LinkLabel SifrelinkLabel2;
        private System.Windows.Forms.Button Adminbutton2;
    }
}