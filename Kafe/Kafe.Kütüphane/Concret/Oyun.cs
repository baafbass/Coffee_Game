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
using System.Windows.Forms;
using System.Collections.Generic;
using Kafe.Kütüphane.Enum;
using Kafe.Kütüphane.Interface;

namespace Kafe.Kütüphane.Concret
{
    public class Oyun : IOyun
    {




        #region Alanlar 

        public readonly Random rnd = new Random();

        public readonly Panel _oyunPanell;
        public ToplayanFincan _toplayanfincan;
        public KafeTaneler _kafetaneler;
        public SuDamla _sudamla;
        public DusenFincan _dusenfincan;
        public GizliKutu _gizlikutu;

        //listler
        public readonly List<KafeTaneler> _kkafetaneler = new List<KafeTaneler>();
        public readonly List<SuDamla> _ssudamla = new List<SuDamla>();
        public readonly List<DusenFincan> _ddusenfincan = new List<DusenFincan>();
        public readonly List<GizliKutu> _ggizlikutular = new List<GizliKutu>();

        //Timerler
        public Timer _HareketTimer = new Timer { Interval = 10 };
        public Timer _guncenlleyenTimer = new Timer { Interval = 100 };
        public Timer _KafeTanelerOlusturTimer = new Timer { Interval = 3000 };
        public Timer _DusenFincanOlusturTimer = new Timer { Interval = 2500 };
        public Timer _SuDamlaOlusturTimer = new Timer { Interval = 2000 };
        public Timer _GizliKutuOlusturTimer = new Timer { Interval = 10000 };
        #endregion

        #region Ozellikler
        public bool DevamEdiyorMu { get; private set; }
        public  int Skor { get; private set; }
        public int _uretecekUrunMiktari { get; set; }
        public int toplanankafe { get; private set; }
        public int toplananSudamla { get; private set; }
        public int toplananFincan { get; private set; }
        public  int ToplamYapilan { get; private set; }
        public int FaydaZarar { get; set; }
        public int UrunEkle { get; set; }
        public int UrunCikar { get; set; }
        #endregion


        #region Metotlar

        //Kurucu
        public Oyun(Panel OyunPanel,int UretecekUrunMiktari)
        {
            _oyunPanell = OyunPanel;

            _uretecekUrunMiktari = UretecekUrunMiktari;

            _HareketTimer.Tick += HareketTimer_Tick;
            _KafeTanelerOlusturTimer.Tick += KafeTanelerOlusturTimer_Tick;
            _DusenFincanOlusturTimer.Tick += DusenFincanOlusturTimer_Tick;
            _SuDamlaOlusturTimer.Tick += SuDamlaOlusturTimer_Tick;
            _GizliKutuOlusturTimer.Tick += GizliKutuTimer_Tick;
           _guncenlleyenTimer.Tick += GuncenlleyenTimer_Tick;
        }

      
        
        


#region Toplanan Malzemeler Oyun Ekranindan Silinen Metotlar
        public void ToplananKafeSil()
        {
            for (var i = _kkafetaneler.Count - 1; i >= 0; i--)
            {
                var coffeee = _kkafetaneler[i];

                var toplandiMi = coffeee.KafeTopladiMi(_toplayanfincan);


                if (toplandiMi)
                {
                    
                    _kkafetaneler.Remove(coffeee);
                    _oyunPanell.Controls.Remove(coffeee);
                    
                    toplanankafe+=1;

                    Skor += 5;

                }


            }

        }

        public void ToplananDusenFincanSil()
        {
            for (var j = _ddusenfincan.Count - 1; j >= 0; j--)
            {
                var fincann = _ddusenfincan[j];

                var toplandiMi = fincann.DusenFincanTopladiMi(_toplayanfincan);


                if (toplandiMi)
                {
                    _ddusenfincan.Remove(fincann);
                    _oyunPanell.Controls.Remove(fincann);
                    toplananFincan += 1;
                    Skor += 10;
                }
            }
        }




        public void ToplananSuDamlaSil()
        {
            for (var k = _ssudamla.Count - 1; k >= 0; k--)
            {
                var sudamlaa = _ssudamla[k];

                var toplandiMi = sudamlaa.SudamlaTopladiMi(_toplayanfincan);


                if (toplandiMi)
                {
                    _ssudamla.Remove(sudamlaa);
                    _oyunPanell.Controls.Remove(sudamlaa);
                    toplananSudamla += 1;
                    Skor += 15;

                }
            }

        }
        

        public void ToplananGizlikutuSil()
        {
            for (var h = _ggizlikutular.Count - 1; h >= 0; h--)
            {
                var gizlikutuu = _ggizlikutular[h];

                var toplandiMi = gizlikutuu.GizlikutuTopladiMi(_toplayanfincan);

                if (toplandiMi)
                {
                    _ggizlikutular.Remove(gizlikutuu);
                    _oyunPanell.Controls.Remove(gizlikutuu);

                    FaydaZarar = rnd.Next(0, 2);

                    if (FaydaZarar == 0)
                    {
                        UrunCikar = 2;

                        ToplamYapilan = ToplamYapilan - UrunCikar;
                        _uretecekUrunMiktari = _uretecekUrunMiktari + UrunCikar;

                        Skor -= 50;
                        

                    }
                    else
                    {
                        UrunEkle = 2;

                        ToplamYapilan = ToplamYapilan + UrunEkle;
                        _uretecekUrunMiktari = _uretecekUrunMiktari - UrunEkle;

                        Skor += 50;

                    }

                }

            }

        }

        // Ekranin Tavanina Ulasan her malzemeyi silen Metot
        public void AsagiUlasti()
        {
            for (var i = _kkafetaneler.Count - 1; i >= 0; i--)
            {
                var coffeee = _kkafetaneler[i];

                var AsagiUlastiMi = coffeee.AsagiUlastiMi(_oyunPanell);

                if (AsagiUlastiMi)
                {
                    _kkafetaneler.Remove(coffeee);
                    _oyunPanell.Controls.Remove(coffeee);
                }
            }
            for (var j = _ssudamla.Count - 1; j >= 0; j--)
            {
                var sudammla = _ssudamla[j];

                var AsagiUlastiMi = sudammla.AsagiUlastiMi(_oyunPanell);

                if (AsagiUlastiMi)
                {
                    _ssudamla.Remove(sudammla);
                    _oyunPanell.Controls.Remove(sudammla);
                }
            }
            for (var k = _ddusenfincan.Count - 1; k >= 0; k--)
            {
                var fincan = _ddusenfincan[k];

                var AsagiUlastiMi = fincan.AsagiUlastiMi(_oyunPanell);

                if (AsagiUlastiMi)
                {
                    _ddusenfincan.Remove(fincan);
                    _oyunPanell.Controls.Remove(fincan);
                }
            }
            for (var l = _ggizlikutular.Count - 1; l >= 0; l--)
            {
                var gizlikutu = _ggizlikutular[l];

                var AsagiUlastiMi = gizlikutu.AsagiUlastiMi(_oyunPanell);

                if (AsagiUlastiMi)
                {
                    _ggizlikutular.Remove(gizlikutu);
                    _oyunPanell.Controls.Remove(gizlikutu);
                }
            }
        }
        #endregion


        #region Timerleri kontrol eden Fonksyonlar
        public void ZamanlayicilariBaslat()
        {
            _HareketTimer.Start();
            _KafeTanelerOlusturTimer.Start();
            _DusenFincanOlusturTimer.Start();
            _SuDamlaOlusturTimer.Start();
            _GizliKutuOlusturTimer.Start();
            _guncenlleyenTimer.Start();
        }

        public void ZamanlayicilariDurdur()
        {
            _HareketTimer.Stop();
            _KafeTanelerOlusturTimer.Stop();
            _DusenFincanOlusturTimer.Stop();
            _SuDamlaOlusturTimer.Stop();
            _GizliKutuOlusturTimer.Stop();
            _guncenlleyenTimer.Stop();
        }
        #endregion


        #region Timerlerin Tick Olaylari

        private void GuncenlleyenTimer_Tick(object sender, EventArgs e)
        {
            if (toplanankafe >= 1 && toplananFincan >= 2 && toplananSudamla >= 3)
            {
                toplanankafe -= 1;
                toplananFincan -= 2;
                toplananSudamla -= 3;
                ToplamYapilan++;
                _uretecekUrunMiktari -= 1;
            }
        }

        private void KafeTanelerOlusturTimer_Tick(object sender, EventArgs e)
        {
            KafeTanelerOlustur();
        }
        private void DusenFincanOlusturTimer_Tick(object sender, EventArgs e)
        {
            DusenFincanOlustur();
        }
        private void SuDamlaOlusturTimer_Tick(object sender, EventArgs e)
        {
            SuDamlaOlustur();
        }

        private void GizliKutuTimer_Tick(object sender, EventArgs e)
        {
            GizliKutuOlustur();
        }

        private void HareketTimer_Tick(object sender, EventArgs e)
        {
            DusenMalzemelerHareketEttir();
            ToplananKafeSil();
            ToplananDusenFincanSil();
            ToplananSuDamlaSil();
            ToplananGizlikutuSil();
            AsagiUlasti();
        }
        #endregion


        #region Malzemeleri Olusturan Metotlar

        public void KafeTanelerOlustur()
        {
            _kafetaneler = new KafeTaneler(_oyunPanell.Size);
            _kkafetaneler.Add(_kafetaneler);
            _oyunPanell.Controls.Add(_kafetaneler);
        }

        public void SuDamlaOlustur()
        {
            _sudamla = new SuDamla(_oyunPanell.Size);
            _ssudamla.Add(_sudamla);
            _oyunPanell.Controls.Add(_sudamla);
        }

        public void DusenFincanOlustur()
        {
            _dusenfincan = new DusenFincan(_oyunPanell.Size);
            _ddusenfincan.Add(_dusenfincan);
            _oyunPanell.Controls.Add(_dusenfincan);
        }

        public void GizliKutuOlustur()
        { 
            _gizlikutu = new GizliKutu(_oyunPanell.Size);
            _ggizlikutular.Add(_gizlikutu);
            _oyunPanell.Controls.Add(_gizlikutu);
        }


        // Malzemeler Toplamak icin Olusturulan Bardak
        public void UrunToplayanCubuguOlustur()
        {
            _toplayanfincan = new ToplayanFincan(_oyunPanell.Height, _oyunPanell.Size);

            _oyunPanell.Controls.Add(_toplayanfincan);
        }
        #endregion


        #region Malzemeleri Hareket ettiren Metotlar 
        //Malzemeleri  Yukaridan Asagiya dogru hareket ettiren Fonksiyon
        public void DusenMalzemelerHareketEttir()
        {
            foreach (var coffee in _kkafetaneler)
            {
                coffee.HareketEttir(Yon.Asagi);

            }

            foreach (var su in _ssudamla)
            {
                su.HareketEttir(Yon.Asagi);

            }

            foreach (var fincan in _ddusenfincan)
            {
                fincan.HareketEttir(Yon.Asagi);
            }
            foreach (var gizlikutu in _ggizlikutular)
            {
                gizlikutu.HareketEttir(Yon.Asagi);
            }
        }

        // Toplayan Bardagi hareket ettiren Metot
        public void UrunToplamaCubuguHareketEttir(Yon yon)
        {
            if (!DevamEdiyorMu) return;

            _toplayanfincan.HareketEttir(yon);
        }
        #endregion


        #region Oyunu Baslattan ve Bitiren Metotlar
        public void Baslat()
        {
            if (DevamEdiyorMu) return;

            DevamEdiyorMu = true;

           ZamanlayicilariBaslat();
        }
          

        public void OyunBitir()
        {
            if (!DevamEdiyorMu) return;

            DevamEdiyorMu = false;

            ZamanlayicilariDurdur();
        }
        #endregion

        #endregion;





    }
}
