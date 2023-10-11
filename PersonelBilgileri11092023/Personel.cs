using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelBilgileri11092023
{
    public class Personel
    {
        public Image Resim { get; set; }
        public string PersonelID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public int Telefon { get; set; }
        public string  Email { get; set; }
        public string Adres { get; set; }
        public DateTime İseGirisTarihi { get; set; }






        public static void VerileriGetir(TextBox txtPersonelID, TextBox txtAd, TextBox txtSoyad, DateTimePicker dtpDogumTarihi, MaskedTextBox mTextBoxTelefon, TextBox txtEmail, TextBox txtAdres, DateTimePicker dtpİseGirisTarihi, PictureBox pboxResim)
        {
            
        }

        

         

        internal void VerileriTemizle(TextBox txtPersonelID, TextBox txtAd, TextBox txtSoyad, DateTimePicker dtpDogumTarihi1, MaskedTextBox mTextBoxTelefon, TextBox txtEmail, TextBox txtAdres, DateTimePicker dtpDogumTarihi2, PictureBox pboxResim)
        {
            txtPersonelID.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            dtpDogumTarihi1.Value = DateTime.Now;
            mTextBoxTelefon.Text = "";
            txtEmail.Text = "";
            txtAdres.Text = "";
            dtpDogumTarihi2.Value = DateTime.Now;
            pboxResim.Enabled = false;
        }
    }
}
