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
    public class ToplayanFincan : Cisim
    {
        public ToplayanFincan(int PanelGenisligi, Size hareketAlaniBoyutlari) : base(hareketAlaniBoyutlari)
        {
            Center = PanelGenisligi / 2;
            Bottom = PanelGenisligi;
            HareketMesafesi =(int) (Width*0.5);
        }
    }
}

 