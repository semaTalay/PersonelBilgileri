namespace PersonelBilgileri11092023
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            pboxResim = new PictureBox();
            btnSil = new Button();
            btnGüncelle = new Button();
            btnKaydet = new Button();
            btnResimSec = new Button();
            dtpİseGirisTarihi = new DateTimePicker();
            label8 = new Label();
            txtAdres = new TextBox();
            label7 = new Label();
            mTextBoxTelefon = new MaskedTextBox();
            dtpDogumTarihi = new DateTimePicker();
            txtEmail = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            txtPersonelID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lvPersonel = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxResim).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pboxResim);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnGüncelle);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(btnResimSec);
            groupBox1.Controls.Add(dtpİseGirisTarihi);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtAdres);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(mTextBoxTelefon);
            groupBox1.Controls.Add(dtpDogumTarihi);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(txtPersonelID);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(41, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(762, 328);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Bilgileri";
            // 
            // pboxResim
            // 
            pboxResim.Location = new Point(440, 212);
            pboxResim.Name = "pboxResim";
            pboxResim.Size = new Size(100, 86);
            pboxResim.SizeMode = PictureBoxSizeMode.Zoom;
            pboxResim.TabIndex = 16;
            pboxResim.TabStop = false;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(608, 299);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 15;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(608, 268);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(75, 23);
            btnGüncelle.TabIndex = 14;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(608, 239);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 13;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnResimSec
            // 
            btnResimSec.Location = new Point(608, 210);
            btnResimSec.Name = "btnResimSec";
            btnResimSec.Size = new Size(75, 23);
            btnResimSec.TabIndex = 12;
            btnResimSec.Text = "Resim Seç";
            btnResimSec.UseVisualStyleBackColor = true;
            btnResimSec.Click += btnResimSec_Click;
            // 
            // dtpİseGirisTarihi
            // 
            dtpİseGirisTarihi.Location = new Point(520, 174);
            dtpİseGirisTarihi.Name = "dtpİseGirisTarihi";
            dtpİseGirisTarihi.Size = new Size(163, 23);
            dtpİseGirisTarihi.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(432, 174);
            label8.Name = "label8";
            label8.Size = new Size(78, 15);
            label8.TabIndex = 10;
            label8.Text = "İşe Giriş Tarihi";
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(520, 22);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(153, 83);
            txtAdres.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(432, 31);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 8;
            label7.Text = "Adres";
            // 
            // mTextBoxTelefon
            // 
            mTextBoxTelefon.Location = new Point(109, 204);
            mTextBoxTelefon.Mask = "(999) 000-0000";
            mTextBoxTelefon.Name = "mTextBoxTelefon";
            mTextBoxTelefon.Size = new Size(110, 23);
            mTextBoxTelefon.TabIndex = 7;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(109, 166);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(110, 23);
            dtpDogumTarihi.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(109, 258);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(110, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(109, 120);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(110, 23);
            txtSoyad.TabIndex = 3;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(109, 74);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(110, 23);
            txtAd.TabIndex = 2;
            // 
            // txtPersonelID
            // 
            txtPersonelID.Location = new Point(109, 31);
            txtPersonelID.Name = "txtPersonelID";
            txtPersonelID.Size = new Size(110, 23);
            txtPersonelID.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 261);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 0;
            label6.Text = "E-Mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 212);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 0;
            label5.Text = "Telefon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 166);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 0;
            label4.Text = "Doğum Tarihi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 123);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 0;
            label3.Text = "Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 77);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 0;
            label2.Text = "Ad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 39);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Personel ID";
            // 
            // lvPersonel
            // 
            lvPersonel.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            lvPersonel.FullRowSelect = true;
            lvPersonel.GridLines = true;
            lvPersonel.Location = new Point(41, 346);
            lvPersonel.Name = "lvPersonel";
            lvPersonel.Size = new Size(775, 176);
            lvPersonel.TabIndex = 1;
            lvPersonel.UseCompatibleStateImageBehavior = false;
            lvPersonel.View = View.Details;
            lvPersonel.SelectedIndexChanged += lvPersonel_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Personel ID";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ad";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Soyad";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Doğum Tarihi";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Telefon";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Email";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Adres";
            columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "İşe Giriş Tarihi";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Resim Yolu";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 515);
            Controls.Add(lvPersonel);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboxResim).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private TextBox txtPersonelID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSil;
        private Button btnGüncelle;
        private Button btnKaydet;
        private Button btnResimSec;
        private DateTimePicker dtpİseGirisTarihi;
        private Label label8;
        private TextBox txtAdres;
        private Label label7;
        private MaskedTextBox mTextBoxTelefon;
        private DateTimePicker dtpDogumTarihi;
        private TextBox txtEmail;
        private ListView lvPersonel;
        private PictureBox pboxResim;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
    }
}