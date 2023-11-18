using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dersform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //bu 2 textbox 3 label 1 button ile yapıldı 2 sayıyı toplatan program
            //int s1, s2, sonuc = 0;
            //s1 = Convert.ToInt32(txtsayı1.Text);
            //s2 = Convert.ToInt32(txtsayı2.Text);
            //sonuc = s1 + s2;
            //lblsonuc.Text = "sonuç=" + sonuc;


            // evet bu programda final vize ayarlama ve kaldığında kırmızı geçtiğinde yeşil
            // veren program
            double vize, final, ortalama;
            vize = Convert.ToDouble(txtvize.Text);
            final = Convert.ToDouble(txtfinal.Text);
            ortalama = vize * 0.4 + final * 0.6;
            lblorta.Text = ortalama.ToString();
            if (ortalama<50|| final<50)
            {
                lbldurum.Text = "kaldınız";
                this.BackColor = Color.Red;
            }
            else
            {
                lbldurum.Text = "geçtiniz";
                this.BackColor = Color.Green;
            }
        }
    }
}
