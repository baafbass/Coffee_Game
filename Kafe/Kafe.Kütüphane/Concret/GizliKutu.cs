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

using System.Drawing;
using Kafe.Kütüphane.Abstract;

namespace Kafe.Kütüphane.Concret
{
    public class GizliKutu : Cisim
    {
        public static double hiz = 0.07; 

        public GizliKutu(Size hareketAlaniBoyutlari ) : base(hareketAlaniBoyutlari)
        {
          HareketMesafesi = (int)(Height *0.07);
        }

        public bool GizlikutuTopladiMi(ToplayanFincan toplayanfincan)
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
