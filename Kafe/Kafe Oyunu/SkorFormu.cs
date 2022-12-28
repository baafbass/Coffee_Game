/*************************************************************************
/
/        AD : ABDOUL FARIDE
/         
/     SOYAD : BASSIROU ALZOUMA 
/
/    NUMARA : B201200575
/
/    BOLUM  : Bilişim Sistemleri Mühendisliği
/
/    Sınıf  : 1
/
/    Proje  : Oyun
/
/    Ülke   : Nijer
/    
*************************************************************************/



using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Kafe_Oyunu
{
    public partial class SkorFormu : Form
    {

       public List<TextBox> SkorYeri = new List<TextBox>();


        public SkorFormu()
        {
            InitializeComponent();

            SkorYeri.Add(scoretextBox1);
            SkorYeri.Add(scoretextBox2);
            SkorYeri.Add(scoretextBox3);
            SkorYeri.Add(scoretextBox4);
            SkorYeri.Add(scoretextBox5);
        }



        static public void DosyaIslemleri(TextBox textBox, int kacinci)
        {
            string[] score = new string[5];

            if (File.Exists(@"Puanlama\Sira.Txt"))
            {
                try
                {
                    score = File.ReadAllLines(@"Puanlama\Sira.Txt");
                    textBox.Text = score[kacinci];
                }
                catch
                {
                }

            }
        }

        private void SkorFormu_Load(object sender, EventArgs e)
        {
            Sayilar_Yerlestir();
        }

        private void Sayilar_Yerlestir()
        {
            for (int i = 0; i < 5; i++)
            {
                DosyaIslemleri(SkorYeri[i], 4 - i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Application.Restart();
        }

        
    }
}
