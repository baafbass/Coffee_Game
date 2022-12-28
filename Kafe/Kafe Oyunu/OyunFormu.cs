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
using System.IO;
using Kafe.Kütüphane.Enum;
using System.Windows.Forms;
using Kafe.Kütüphane.Concret;


namespace Kafe_Oyunu
{
    public partial class OyunFormu : Form
    {

        #region Alanlar
        SkorFormu skorform = new SkorFormu();

        private int puan = 0;
       
        private int Puan { get => puan; set { if (value < 0) return; puan = value; } }



        private readonly Oyun _oyun;
        string oyuncu_Adi;
        string oyuncu_Soyadi;
        string UrunAdi;
        int Sure;
        int Score;
        int UrunMiktari;
        int MasaNO;
        #endregion

        //Constructor
        public OyunFormu(int Masa_NO, string ad, string soyad, string urun_adi, int Urun_Miktari, int sure)
        {
            InitializeComponent();

            MasaNO = Masa_NO;
            oyuncu_Adi = ad;
            oyuncu_Soyadi = soyad;
            UrunAdi = urun_adi;
            UrunMiktari = Urun_Miktari;
            Sure = sure;

            _oyun = new Oyun(oyunPanel, AnaForm.Urunmiktari);

            MasaNoLabel.Text = Masa_NO.ToString();
            AdLabel.Text = oyuncu_Adi;
            SoyadLabel.Text = oyuncu_Soyadi;
            TalepUrunLabel.Text = urun_adi;
            SureLabel.Text = Sure.ToString();
            Kalan.Text = "Kalan : " + Urun_Miktari;
            Toplam.Text = "Yapilan Toplam : " + 0;
        }



        //Oyun Form uzerindeki Bilgileri Guncelleyen Olayi
        private void guncenlleyenTimer_Tick(object sender, EventArgs e)
        {
            txttoplanankafe.Text = _oyun.toplanankafe.ToString();
            txttoplananfincan.Text = _oyun.toplananFincan.ToString();
            txttoplanansudamla.Text = _oyun.toplananSudamla.ToString();
            Kalan.Text = "Kalan : " + (_oyun._uretecekUrunMiktari).ToString();
            Toplam.Text = "Yapilan Toplam : " + _oyun.ToplamYapilan.ToString();
            Score = _oyun.Skor;
            Puan = Score;
            skorTextBox.Text = Puan.ToString();
        }



        //Oyun hakkinda tuslari ile ilgili Olaylar
        private void OyunFormu_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.E:
                    if (!_oyun.DevamEdiyorMu)
                    {

                        timer1.Enabled = true;
                        guncenlleyenTimer.Enabled = true;
                        _oyun.UrunToplayanCubuguOlustur();
                        _oyun.KafeTanelerOlustur();
                        _oyun.SuDamlaOlustur();
                        _oyun.DusenFincanOlustur();
                        _oyun.GizliKutuOlustur();
                        _oyun.Baslat();
                    }
                    break;
                case Keys.S:
                    _oyun.UrunToplamaCubuguHareketEttir(Yon.Saga); break;
                case Keys.F:
                    _oyun.UrunToplamaCubuguHareketEttir(Yon.Sola); break;
                case Keys.P:
                    timer1.Stop();
                    guncenlleyenTimer.Stop();
                    _oyun.ZamanlayicilariDurdur();
                    break;
                case Keys.C:
                    timer1.Start();
                    guncenlleyenTimer.Stop();
                    _oyun.ZamanlayicilariBaslat();
                    break;
            }
        }


        //Zamani kontrol eden Olayi
        private void timer1_Tick(object sender, EventArgs e)
        {
            Sure -= 1;
            SureLabel.Text = Sure.ToString();

            if (SureLabel.Text == "0")
            {
                timer1.Stop();
                guncenlleyenTimer.Stop();
                _oyun.ZamanlayicilariDurdur();

                int[] score = new int[5];

                if (File.Exists(@"Puanlama\Sira.Txt"))
                    score = convert(File.ReadAllLines(@"Puanlama\Sira.Txt"));
                Sirlan(score);
                Array.Sort(score);
                File.WriteAllLines(@"Puanlama\Sira.Txt", convert(score));
               
                skorform.ShowDialog();
            }
        }

        private void Sirlan(int[] score)
        {
            int ekPuan = Convert.ToInt32(skorTextBox.Text);
            for (int i = 0; i < score.Length; i++)
            {
                if (ekPuan > score[i])
                {
                    for (int k = 0; k < score.Length; k++)
                    {
                        if (score[k] == ekPuan) return;
                    }
                    int gecici = score[i];
                    score[i] = ekPuan;
                    int min = 0;
                    for (int j = 0; j < score.Length; j++)
                    {
                        min = gecici;
                        if (min > score[j])
                        {
                            gecici = score[j];
                            score[j] = min;
                        }
                    }
                    break;
                }
            }
        }

        static private int[] convert(string[] tab)
        {
            int[] _array = new int[5];
            for (int i = 0; i < tab.Length; i++)
            {
                try
                {
                    _array[i] = Convert.ToInt32(tab[i]);
                }
                catch
                {
                    //Hiç bir şey yapma!
                }
            }
            Array.Sort(_array);
            return _array;
        }



        static private string[] convert(int[] tab)
        {
            string[] _array = new string[5];
            for (int i = 0; i < tab.Length; i++)
            {
                _array[i] = tab[i].ToString();
            }
            return _array;
        }


        /*static private int EnBuyuk(int[] tab)
        {
            int max = tab[0];
            for (int i = 0; i < tab.Length; i++)
            {
                if (max < tab[i])
                    max = tab[i];
            }
            return max;
        }*/


















    }  

}

