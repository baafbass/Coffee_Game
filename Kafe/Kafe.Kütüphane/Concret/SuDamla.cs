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

using Kafe.Kütüphane.Abstract;
using System.Drawing;

namespace Kafe.Kütüphane.Concret
{
    public class SuDamla : Cisim
    {

        public static double hiz = 0.05;
        public static int UretilenSudamla = 0;

        public SuDamla(Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
        { 
            SudamlaHizlandir();
        }

        public void SudamlaHizlandir()
        {
            if (hiz > 0)
            {
                if (UretilenSudamla <= 10)
                {
                    if (UretilenSudamla == 10)
                    {
                        HareketMesafesi = (int)(Height * (hiz + 0.03));
                        UretilenSudamla = 0;
                        hiz += 0.03;
                    }
                    else
                    {
                        HareketMesafesi = (int)(Height * hiz);
                        UretilenSudamla++;
                    }
                }
            }
        }
       

        public bool SudamlaTopladiMi(ToplayanFincan toplayanfincan)
        {
            var toplandiMi = toplayanfincan.Top < Bottom && toplayanfincan.Right > Left && toplayanfincan.Left < Right;

            if (toplandiMi)
            {
                return true;
                
            }
            return false;
        }
    }
}
