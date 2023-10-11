using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PersonelBilgileri11092023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (lvPersonel.SelectedItems != null)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGüncelle.Enabled = false;
            btnSil.Enabled = false;



        }
        List<Personel> personels = new List<Personel>();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.PersonelID = txtPersonelID.Text;
            personel.Ad = txtAd.Text;
            personel.Soyad = txtSoyad.Text;
            personel.DogumTarihi = dtpDogumTarihi.Value;
            personel.Email = txtEmail.Text;
            personel.Adres = txtAdres.Text;
            personel.ÝseGirisTarihi = dtpÝseGirisTarihi.Value;
            personel.Resim = pboxResim.Image;

            personels.Add(personel);

            ListViewiDoldur();
            personel.VerileriTemizle(txtPersonelID, txtAd, txtSoyad, dtpDogumTarihi, mTextBoxTelefon, txtEmail, txtAdres, dtpDogumTarihi, pboxResim);
            try
            {
                if (personel.PersonelID.Length < 5)
                {
                    throw new Exception("Personel ID 5 karakterden az olamaz.");
                }

                else if (DateTime.Now.Year - personel.DogumTarihi.Year < 18)
                {
                    throw new Exception("Yaþ 18'den küçük olamaz.");
                }

                else if (personel.ÝseGirisTarihi > DateTime.Now)
                {
                    throw new Exception("Ýþe giriþ tarihi ileri bir tarih olamaz.");
                }
                else if (!personel.Email.EndsWith("@bilgeadam.com"))
                {
                    throw new Exception("Mail doðru formatta deðil.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

           


        }

        

        private void ListViewiDoldur()
        {
            lvPersonel.Items.Clear();
            foreach (Personel person in personels)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = person.PersonelID;
                lvi.SubItems.Add(person.Ad);
                lvi.SubItems.Add(person.Soyad);
                lvi.SubItems.Add(person.DogumTarihi.ToString());
                lvi.SubItems.Add(person.Email);
                lvi.SubItems.Add(person.Adres);
                //lvi.SubItems.Add(person.Resim.);
                lvPersonel.Items.Add(lvi);
            }
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Jpg(.jpg)| *.jpg | Png (.png)| *.png";
            ofd.ShowDialog();
            string dosyaYolu = ofd.FileName;
            pboxResim.ImageLocation = dosyaYolu;
        }





        private void lvPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGüncelle.Enabled = true;
            btnSil.Enabled = true;
            //Personel.VerileriGetir(txtPersonelID, txtAd, txtSoyad, dtpDogumTarihi, mTextBoxTelefon, txtEmail, txtAdres, dtpÝseGirisTarihi, pboxResim);


            if (lvPersonel.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = lvPersonel.SelectedItems[0];
                txtPersonelID.Text = selectedRow.SubItems[0].Text;
                txtAd.Text = selectedRow.SubItems[1].Text;
                txtSoyad.Text = selectedRow.SubItems[2].Text;
                DateTime selectedDate;
                if (DateTime.TryParse(lvPersonel.SelectedItems[0].SubItems[3].Text, out selectedDate)) // Örneðin, dördüncü sütun tarih deðerini içeriyorsa
                {
                    // Tarih deðerini DateTimePicker kontrolüne doldur
                    dtpDogumTarihi.Value = selectedDate;
                }

                mTextBoxTelefon.Text = selectedRow.SubItems[4].Text;

                if (DateTime.TryParse(lvPersonel.SelectedItems[0].SubItems[7].Text, out selectedDate)) // Örneðin, dördüncü sütun tarih deðerini içeriyorsa
                {
                    // Tarih deðerini DateTimePicker kontrolüne doldur
                    dtpÝseGirisTarihi.Value = selectedDate;
                }

                txtEmail.Text = selectedRow.SubItems[5].Text;
                txtAdres.Text = selectedRow.SubItems[6].Text;

                // resim olaný bulamadým...


            }





        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lvPersonel.SelectedItems.Count > 0)
            {
                int index = lvPersonel.FocusedItem.Index;
                lvPersonel.Items.RemoveAt(lvPersonel.SelectedIndices[index]);
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            Personel personel = lvPersonel.SelectedItems[0].Tag as Personel;
            ListViewiDoldur();
        }
    }
}