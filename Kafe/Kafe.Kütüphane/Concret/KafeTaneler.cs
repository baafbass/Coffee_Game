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
    public class KafeTaneler : Cisim
    {


        public static double hiz = 0.05;
        public static int UretilenKafe = 0;

        public KafeTaneler(Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
        { 
            KafeHizlandir();
        }

        public void KafeHizlandir()
        { 
                if (hiz > 0)
               {
                if (UretilenKafe <= 10)
                {
                    if (UretilenKafe == 10)
                    {
                        HareketMesafesi = (int)(Height * (hiz + 0.03));
                        UretilenKafe = 0;
                        hiz += 0.03;
                    }
                    else
                    {
                        HareketMesafesi = (int)(Height * hiz);
                        UretilenKafe++;
                    }
                }
              }
                
        }
        public bool KafeTopladiMi(ToplayanFincan toplayanfincan)
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
