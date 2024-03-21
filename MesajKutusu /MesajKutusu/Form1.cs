using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesajKutusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Merhaba");
        }


        private void button2_Click(object sender, EventArgs e)// bu satır Button2' ye tıknalanıldığındaki olayı tanımlar.
        {
            //başlık adında bir metin değişkeni tanımlar ve içine "Selemlama Penceresi" metnini atar.
            string başlık = "Selemlama Penceresi";
            // iletişim kutusu  görüntüler ve  "Merhaba" mesajını ve önceden tanımlanan başlık değişkenini kullanır(selemlama Penceresi).
            MessageBox.Show("Merhaba",başlık);
        }
        
        private void button3_Click(object sender, EventArgs e)// bu satır Button3'e tıknalanıldığındaki olayı tanımlar.
        {
           
            string başlık = "Selemlama Penceresi";

            // bir iletişim kutusu görüntüler ve kullanıcıya "Merhaba" mesajı ve üç seçenek (Evet, Hayır, İptal)  Kullanıcının seçimini  DialogResult türünden  değer döndürür ve bu değeri dr değişkeninde saklar.
            DialogResult dr = MessageBox.Show("Merhaba", başlık, MessageBoxButtons.YesNoCancel);

            //dr değişkeninin değerini kontrol eder. Eğer kullanıcı Evet'i seçtiyse, bu blok çalışır.
            if (dr == DialogResult.Yes)
            { //Evet'i seçtiyse iletişim kutusu görüntüler ve "Evete tıkladınız" mesajını içerir.
                MessageBox.Show("Evete tıkladınız");
            }
            //Hayır'ı seçtiyse
            else if (dr == DialogResult.No)
            {
                MessageBox.Show("Hayıra tıkladınız");
            }
            // İptal'i seçtiyse
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("İptal ettiniz");
            }
        }
    }
}