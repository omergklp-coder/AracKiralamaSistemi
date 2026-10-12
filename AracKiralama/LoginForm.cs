using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void kayitlinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm kayitEkrani = new RegisterForm();
            kayitEkrani.ShowDialog();
            this.Show();

        }

        private void Adminbutton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanelForm adminEkrani = new AdminPanelForm();
            adminEkrani.ShowDialog();
            this.Show();
        }
    }
}
