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
namespace Kafe.Kütüphane.Interface
{
    public interface IOyun
    {
        bool DevamEdiyorMu{ get; }
        void Baslat();
        void UrunToplamaCubuguHareketEttir(Yon yon);
        void OyunBitir();
    }
}
