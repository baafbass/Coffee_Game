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
using System.Drawing;
using Kafe.Kütüphane.Interface;
using Kafe.Kütüphane.Enum;

namespace Kafe.Kütüphane.Abstract
{
     public class Cisim : PictureBox, IHareketEden
    {
       
        
        public Size HareketAlaniBoyutlari { get; }

        public int HareketMesafesi { get; protected set; }

        public new int Right
        {
            get => base.Right;

            set => Left = value - Width;
        }

        public new int Bottom
        {
            get => base.Bottom;
            set => Top = value - Height;
        }

        public int Center
        {
            get => Left + Width / 2;
            set => Left = value - Width / 2;
        }

        public int Middle
        {
            get => Top + Height / 2;
            set => Top = value - Height / 2;
        }
         
        private static readonly Random Random1 = new Random();

       

        public Cisim(Size hareketAlaniBoyutlari)
        {
            Image = Image.FromFile($@"ninja\{GetType().Name}.png");
            HareketAlaniBoyutlari = hareketAlaniBoyutlari;
            SizeMode = PictureBoxSizeMode.AutoSize;
            Left = Random1.Next(hareketAlaniBoyutlari.Width - Width + 1);
            
        }


        public bool HareketEttir(Yon yon)
        {
            switch (yon)
            {
                case Yon.Yukari :
                    return YukariHareketEttir();
                case Yon.Asagi:
                    return AsagiHareketEttir();
                case Yon.Saga:
                    return SagaHareketEttir();
                case Yon.Sola:
                    return SolaHareketEttir();
                default:
                    throw new ArgumentOutOfRangeException(nameof(yon), yon, null);
            }

        }

        public bool SagaHareketEttir()
        {
            if (Left == 0) return true;
            var yenileft = Left - HareketMesafesi;
            var tasacakMi = yenileft < 0;
            Left = tasacakMi ? 0 : yenileft;

            return Left == 0;
        }

        public bool SolaHareketEttir()
        {
            if (Right == HareketAlaniBoyutlari.Width) return true;
            var yeniRight = Right + HareketMesafesi;
            var tasacakMi = yeniRight > HareketAlaniBoyutlari.Width;
            Right = tasacakMi ? HareketAlaniBoyutlari.Width : yeniRight;
           
            return Right == HareketAlaniBoyutlari.Width;
        }

        public bool YukariHareketEttir()
        {
            if (Top == 0) return true;
            var yeniTop = Top - HareketMesafesi;
            var tasacakMi = yeniTop < 0;
            Top = tasacakMi ? 0 : yeniTop;

            return Top == 0;
        }


        public bool AsagiHareketEttir()
        {
            if (Bottom == HareketAlaniBoyutlari.Height) return true;
            var yeniBottom = Bottom + HareketMesafesi;
            var tasacakMi = yeniBottom > HareketAlaniBoyutlari.Height;
            Bottom = tasacakMi ? HareketAlaniBoyutlari.Height : yeniBottom;

            return Bottom == HareketAlaniBoyutlari.Height;
        }

        public bool AsagiUlastiMi(Panel oyunPaneli)
        {
            var AsagiGeldiMi = oyunPaneli.Bottom == Bottom;

            if(AsagiGeldiMi)
            {
                return true;
            }

            return false;
        }

    }
}
