namespace LibraryManagementSystem
{
    partial class FormBooks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBooks));
            groupBox1 = new GroupBox();
            textBoxKitapTurKodu = new TextBox();
            textBoxISBN = new TextBox();
            textBoxYazarSoyadı = new TextBox();
            textBoxYazarAdı = new TextBox();
            textBoxKitapAdı = new TextBox();
            labelID = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox5 = new GroupBox();
            buttonTumKitaplariGoster = new Button();
            buttonAra = new Button();
            buttonTemizle = new Button();
            groupBox4 = new GroupBox();
            buttonSil = new Button();
            buttonKitapEkle = new Button();
            buttonKitapBilgiGuncelle = new Button();
            groupBox2 = new GroupBox();
            buttonKitapOduncVer = new Button();
            dateTimePickerOduncAlmaTarihi = new DateTimePicker();
            textBoxOduncAlan = new TextBox();
            label8 = new Label();
            label7 = new Label();
            groupBox3 = new GroupBox();
            buttonKitabiIadeEt = new Button();
            buttonGecikmeBedeliHesapla = new Button();
            label11 = new Label();
            labelGecikmeBedeli = new Label();
            label9 = new Label();
            groupBox6 = new GroupBox();
            dataGridViewKitaplar = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxKitapTurKodu);
            groupBox1.Controls.Add(textBoxISBN);
            groupBox1.Controls.Add(textBoxYazarSoyadı);
            groupBox1.Controls.Add(textBoxYazarAdı);
            groupBox1.Controls.Add(textBoxKitapAdı);
            groupBox1.Controls.Add(labelID);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Location = new Point(52, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1029, 683);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitap Kayıt Etme ve Güncelleme";
            // 
            // textBoxKitapTurKodu
            // 
            textBoxKitapTurKodu.Location = new Point(203, 281);
            textBoxKitapTurKodu.Name = "textBoxKitapTurKodu";
            textBoxKitapTurKodu.Size = new Size(218, 31);
            textBoxKitapTurKodu.TabIndex = 13;
            // 
            // textBoxISBN
            // 
            textBoxISBN.Location = new Point(203, 234);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(218, 31);
            textBoxISBN.TabIndex = 12;
            // 
            // textBoxYazarSoyadı
            // 
            textBoxYazarSoyadı.Location = new Point(203, 183);
            textBoxYazarSoyadı.Name = "textBoxYazarSoyadı";
            textBoxYazarSoyadı.Size = new Size(293, 31);
            textBoxYazarSoyadı.TabIndex = 11;
            // 
            // textBoxYazarAdı
            // 
            textBoxYazarAdı.Location = new Point(203, 135);
            textBoxYazarAdı.Name = "textBoxYazarAdı";
            textBoxYazarAdı.Size = new Size(293, 31);
            textBoxYazarAdı.TabIndex = 10;
            // 
            // textBoxKitapAdı
            // 
            textBoxKitapAdı.Location = new Point(203, 85);
            textBoxKitapAdı.Name = "textBoxKitapAdı";
            textBoxKitapAdı.Size = new Size(293, 31);
            textBoxKitapAdı.TabIndex = 9;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(150, 45);
            labelID.Name = "labelID";
            labelID.Size = new Size(22, 24);
            labelID.TabIndex = 8;
            labelID.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 284);
            label6.Name = "label6";
            label6.Size = new Size(163, 24);
            label6.TabIndex = 7;
            label6.Text = "Kitap Tür Kodu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 234);
            label5.Name = "label5";
            label5.Size = new Size(62, 24);
            label5.TabIndex = 6;
            label5.Text = "ISBN:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 186);
            label4.Name = "label4";
            label4.Size = new Size(155, 24);
            label4.TabIndex = 5;
            label4.Text = "Yazar Soyismi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 138);
            label3.Name = "label3";
            label3.Size = new Size(119, 24);
            label3.TabIndex = 4;
            label3.Text = "Yazar İsmi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 88);
            label2.Name = "label2";
            label2.Size = new Size(105, 24);
            label2.TabIndex = 3;
            label2.Text = "Kitap Adı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 45);
            label1.Name = "label1";
            label1.Size = new Size(94, 24);
            label1.TabIndex = 2;
            label1.Text = "Kitap ID:";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(buttonTumKitaplariGoster);
            groupBox5.Controls.Add(buttonAra);
            groupBox5.Controls.Add(buttonTemizle);
            groupBox5.Location = new Point(524, 329);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(499, 150);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Kitap Arama";
            // 
            // buttonTumKitaplariGoster
            // 
            buttonTumKitaplariGoster.Location = new Point(344, 41);
            buttonTumKitaplariGoster.Name = "buttonTumKitaplariGoster";
            buttonTumKitaplariGoster.Size = new Size(135, 80);
            buttonTumKitaplariGoster.TabIndex = 3;
            buttonTumKitaplariGoster.Text = "TÜM KİTAPLARI GÖSTER";
            buttonTumKitaplariGoster.UseVisualStyleBackColor = true;
            buttonTumKitaplariGoster.Click += buttonTumKitaplariGoster_Click;
            // 
            // buttonAra
            // 
            buttonAra.Location = new Point(183, 54);
            buttonAra.Name = "buttonAra";
            buttonAra.Size = new Size(134, 55);
            buttonAra.TabIndex = 2;
            buttonAra.Text = "KİTAP ARA";
            buttonAra.UseVisualStyleBackColor = true;
            buttonAra.Click += buttonAra_Click;
            // 
            // buttonTemizle
            // 
            buttonTemizle.Location = new Point(17, 54);
            buttonTemizle.Name = "buttonTemizle";
            buttonTemizle.Size = new Size(133, 55);
            buttonTemizle.TabIndex = 1;
            buttonTemizle.Text = "TEMİZLE";
            buttonTemizle.UseVisualStyleBackColor = true;
            buttonTemizle.Click += buttonTemizle_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(buttonSil);
            groupBox4.Controls.Add(buttonKitapEkle);
            groupBox4.Controls.Add(buttonKitapBilgiGuncelle);
            groupBox4.Location = new Point(6, 327);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(490, 152);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kayıt ve Düzenleme İşlemleri";
            // 
            // buttonSil
            // 
            buttonSil.Location = new Point(341, 49);
            buttonSil.Name = "buttonSil";
            buttonSil.Size = new Size(134, 69);
            buttonSil.TabIndex = 2;
            buttonSil.Text = "KİTAP SİL";
            buttonSil.UseVisualStyleBackColor = true;
            buttonSil.Click += buttonSil_Click;
            // 
            // buttonKitapEkle
            // 
            buttonKitapEkle.Location = new Point(181, 49);
            buttonKitapEkle.Name = "buttonKitapEkle";
            buttonKitapEkle.Size = new Size(135, 69);
            buttonKitapEkle.TabIndex = 1;
            buttonKitapEkle.Text = "YENİ KİTAP EKLE";
            buttonKitapEkle.UseVisualStyleBackColor = true;
            buttonKitapEkle.Click += buttonKitapEkle_Click;
            // 
            // buttonKitapBilgiGuncelle
            // 
            buttonKitapBilgiGuncelle.Location = new Point(24, 43);
            buttonKitapBilgiGuncelle.Name = "buttonKitapBilgiGuncelle";
            buttonKitapBilgiGuncelle.Size = new Size(135, 80);
            buttonKitapBilgiGuncelle.TabIndex = 0;
            buttonKitapBilgiGuncelle.Text = "KİTAP BİLGİLERİ GÜNCELLE";
            buttonKitapBilgiGuncelle.UseVisualStyleBackColor = true;
            buttonKitapBilgiGuncelle.Click += buttonKitapBilgiGuncelle_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonKitapOduncVer);
            groupBox2.Controls.Add(dateTimePickerOduncAlmaTarihi);
            groupBox2.Controls.Add(textBoxOduncAlan);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(1099, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(397, 683);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kitap Ödünç Alma";
            // 
            // buttonKitapOduncVer
            // 
            buttonKitapOduncVer.Location = new Point(135, 304);
            buttonKitapOduncVer.Name = "buttonKitapOduncVer";
            buttonKitapOduncVer.Size = new Size(153, 80);
            buttonKitapOduncVer.TabIndex = 16;
            buttonKitapOduncVer.Text = "KİTABI ÖDÜNÇ VER";
            buttonKitapOduncVer.UseVisualStyleBackColor = true;
            buttonKitapOduncVer.Click += buttonKitapOduncVer_Click;
            // 
            // dateTimePickerOduncAlmaTarihi
            // 
            dateTimePickerOduncAlmaTarihi.Location = new Point(89, 181);
            dateTimePickerOduncAlmaTarihi.Name = "dateTimePickerOduncAlmaTarihi";
            dateTimePickerOduncAlmaTarihi.Size = new Size(300, 31);
            dateTimePickerOduncAlmaTarihi.TabIndex = 15;
            // 
            // textBoxOduncAlan
            // 
            textBoxOduncAlan.Location = new Point(149, 82);
            textBoxOduncAlan.Name = "textBoxOduncAlan";
            textBoxOduncAlan.Size = new Size(228, 31);
            textBoxOduncAlan.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 183);
            label8.Name = "label8";
            label8.Size = new Size(67, 24);
            label8.TabIndex = 7;
            label8.Text = "Tarih:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 85);
            label7.Name = "label7";
            label7.Size = new Size(127, 24);
            label7.TabIndex = 6;
            label7.Text = "Ödünç Alan:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonKitabiIadeEt);
            groupBox3.Controls.Add(buttonGecikmeBedeliHesapla);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(labelGecikmeBedeli);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(1518, 26);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(397, 683);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kitap İade Etme";
            // 
            // buttonKitabiIadeEt
            // 
            buttonKitabiIadeEt.Location = new Point(119, 318);
            buttonKitabiIadeEt.Name = "buttonKitabiIadeEt";
            buttonKitabiIadeEt.Size = new Size(167, 66);
            buttonKitabiIadeEt.TabIndex = 11;
            buttonKitabiIadeEt.Text = "KİTABI İADE ET";
            buttonKitabiIadeEt.UseVisualStyleBackColor = true;
            buttonKitabiIadeEt.Click += buttonKitabiIadeEt_Click;
            // 
            // buttonGecikmeBedeliHesapla
            // 
            buttonGecikmeBedeliHesapla.Location = new Point(137, 204);
            buttonGecikmeBedeliHesapla.Name = "buttonGecikmeBedeliHesapla";
            buttonGecikmeBedeliHesapla.Size = new Size(138, 84);
            buttonGecikmeBedeliHesapla.TabIndex = 10;
            buttonGecikmeBedeliHesapla.Text = "GECİKME BEDELİNİ HESAPLA";
            buttonGecikmeBedeliHesapla.UseVisualStyleBackColor = true;
            buttonGecikmeBedeliHesapla.Click += buttonGecikmeBedeliHesapla_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(320, 82);
            label11.Name = "label11";
            label11.Size = new Size(34, 24);
            label11.TabIndex = 9;
            label11.Text = "TL";
            // 
            // labelGecikmeBedeli
            // 
            labelGecikmeBedeli.AutoSize = true;
            labelGecikmeBedeli.Location = new Point(208, 82);
            labelGecikmeBedeli.Name = "labelGecikmeBedeli";
            labelGecikmeBedeli.Size = new Size(22, 24);
            labelGecikmeBedeli.TabIndex = 8;
            labelGecikmeBedeli.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 82);
            label9.Name = "label9";
            label9.Size = new Size(169, 24);
            label9.TabIndex = 7;
            label9.Text = "Gecikme Bedeli:";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dataGridViewKitaplar);
            groupBox6.Location = new Point(52, 715);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1499, 334);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            groupBox6.Text = "Kitap Listesi";
            // 
            // dataGridViewKitaplar
            // 
            dataGridViewKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKitaplar.Dock = DockStyle.Fill;
            dataGridViewKitaplar.Location = new Point(3, 27);
            dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            dataGridViewKitaplar.RowHeadersWidth = 62;
            dataGridViewKitaplar.RowTemplate.Height = 33;
            dataGridViewKitaplar.Size = new Size(1493, 304);
            dataGridViewKitaplar.TabIndex = 0;
            dataGridViewKitaplar.CellContentClick += dataGridViewKitaplar_CellContentClick;
            // 
            // FormBooks
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1923, 1050);
            Controls.Add(groupBox6);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Siemens AD Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormBooks";
            Text = "Management & Organization";
            FormClosed += FormBooks_FormClosed;
            Load += FormBooks_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private TextBox textBoxKitapTurKodu;
        private TextBox textBoxISBN;
        private TextBox textBoxYazarSoyadı;
        private TextBox textBoxYazarAdı;
        private TextBox textBoxKitapAdı;
        private Label labelID;
        private Label label8;
        private Label label7;
        private DateTimePicker dateTimePickerOduncAlmaTarihi;
        private TextBox textBoxOduncAlan;
        private Label label11;
        private Label labelGecikmeBedeli;
        private Label label9;
        private Button buttonTumKitaplariGoster;
        private Button buttonAra;
        private Button buttonTemizle;
        private Button buttonSil;
        private Button buttonKitapEkle;
        private Button buttonKitapBilgiGuncelle;
        private Button buttonKitapOduncVer;
        private Button buttonKitabiIadeEt;
        private Button buttonGecikmeBedeliHesapla;
        private GroupBox groupBox6;
        private DataGridView dataGridViewKitaplar;
    }
}