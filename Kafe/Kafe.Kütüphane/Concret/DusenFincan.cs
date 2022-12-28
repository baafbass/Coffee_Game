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
    public class DusenFincan : Cisim
    {
        public static double hiz = 0.05;
        public static int UretilenFincan = 0;

        public DusenFincan(Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
        {
            DusenFincanHizlandir();
        }
        
        public void DusenFincanHizlandir()
        {
            if (hiz > 0)
            {
                if (UretilenFincan <= 10)
                {
                    if (UretilenFincan == 10)
                    {
                        HareketMesafesi = (int)(Height * (hiz+ 0.03));
                        UretilenFincan = 0;
                        hiz += 0.03;
                    }
                    else
                    {
                        HareketMesafesi = (int)(Height * hiz);
                        UretilenFincan++;
                    }
                }
            }

        }
        
        public bool DusenFincanTopladiMi(ToplayanFincan toplayanfincan)
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
