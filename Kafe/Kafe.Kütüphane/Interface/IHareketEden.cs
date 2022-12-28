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

using Kafe.Kütüphane.Enum;
using System.Drawing;

namespace Kafe.Kütüphane.Interface
{
    public interface IHareketEden
    {
        Size HareketAlaniBoyutlari { get; }

        int  HareketMesafesi { get; }




        /// <summary>
        /// Cisim istenilen yon hareket ettirir
        /// </summary>
        /// <param name="yon">hangi yone hareket edilecegi</param>
        /// <returns>Cisim duvara carparsa true dondur.</returns>


        bool HareketEttir(Yon yon);
    }
}
