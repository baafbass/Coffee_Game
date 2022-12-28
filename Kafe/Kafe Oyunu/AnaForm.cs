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



using System.Windows.Forms;

namespace Kafe_Oyunu
{
    public partial class AnaForm : Form
    {

        #region Alanlar
        
        //Kullanicinin girilen verilerini yakalayan Degiskenler
        public static int MasaNo = 0;
        public static string Ad = null;
        public static string Soyad = null;
        public static string TalepEdilenUrun = null;
        public static int Urunmiktari=0; 
        public static int sure=0;
        #endregion


        //Constructor
        public AnaForm()
        {
            InitializeComponent();
        }

        
        //Kaydet buttonu tiklandigi zaman Ana Formdaki verileri Oyun Formuna Aktaran Olayi
        private void KaydetButton_Click(object sender, System.EventArgs e)
        {
            // Yakalama ve Cevirme Sureci
            MasaNo = int.Parse(txt_masaNo.Text);
            Ad = txt_musteriAdi.Text;
            Soyad = txt_musteriSoyadi.Text;
            TalepEdilenUrun = txt_talepEdilenUrun.Text;
            Urunmiktari = int.Parse(txtboxUrunMiktari.Text);
            sure = int.Parse(txt_surebox.Text);

            //Aktarma sureci
            OyunFormu oyun_formu = new OyunFormu(MasaNo,Ad,Soyad,TalepEdilenUrun,Urunmiktari,sure);

            oyun_formu.ShowDialog();
        }

        //Buttonu tiklandiginda Skor Formu gosteren Olayi
        private void button3_Click(object sender, System.EventArgs e)
        {
            SkorFormu skorform = new SkorFormu();

            skorform.ShowDialog();
        }

        private void AnaForm_Load(object sender, System.EventArgs e)
        {
            YardimFormu yardimform = new YardimFormu();

            yardimform.ShowDialog();


        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            YardimFormu yardimform = new YardimFormu();

            yardimform.ShowDialog();

        }
    }
}
