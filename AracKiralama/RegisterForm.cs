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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kutuların boş olup olmadığını kontrol et
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz doldurun!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // TC Kimlik No (textBox2) 11 haneden kısa mı diye kontrol et
            else if (textBox2.Text.Length < 11)
            {
                MessageBox.Show("TC Kimlik Numarası tam 11 haneli olmalıdır!", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Her şey doğruysa kaydı tamamla
            else
            {
                MessageBox.Show("Kayıt başarıyla oluşturuldu! Giriş yapabilirsiniz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Kayıt sayfasını kapatır ve arkada bekleyen Giriş (Login) sayfasına geri döner
            }
        }
    }
}
