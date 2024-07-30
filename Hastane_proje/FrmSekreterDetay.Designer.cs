namespace Hastane_proje
{
    partial class FrmSekreterDetay
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
            groupBox1 = new GroupBox();
            label2 = new Label();
            LblAdSoyad = new Label();
            LblTC = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            BtnDuyuruOlustur = new Button();
            RchDuyuru = new RichTextBox();
            groupBox3 = new GroupBox();
            BtnDuzenle = new Button();
            BtnKaydet = new Button();
            ChkDurum = new CheckBox();
            CmbDoktor = new ComboBox();
            CmbBrans = new ComboBox();
            MskSaat = new MaskedTextBox();
            MskTC = new MaskedTextBox();
            MskTarih = new MaskedTextBox();
            Txtid = new TextBox();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox5 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox6 = new GroupBox();
            BtnRandevuListe = new Button();
            BtnBransPaneli = new Button();
            BtnDoktorPaneli = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(LblAdSoyad);
            groupBox1.Controls.Add(LblTC);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(368, 178);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "SekreterBilgi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 90);
            label2.Name = "label2";
            label2.Size = new Size(138, 35);
            label2.TabIndex = 0;
            label2.Text = "Ad Soyad:";
            // 
            // LblAdSoyad
            // 
            LblAdSoyad.AutoSize = true;
            LblAdSoyad.Location = new Point(162, 90);
            LblAdSoyad.Name = "LblAdSoyad";
            LblAdSoyad.Size = new Size(119, 35);
            LblAdSoyad.TabIndex = 0;
            LblAdSoyad.Text = "Null Null";
            // 
            // LblTC
            // 
            LblTC.AutoSize = true;
            LblTC.Location = new Point(162, 54);
            LblTC.Name = "LblTC";
            LblTC.Size = new Size(169, 35);
            LblTC.TabIndex = 0;
            LblTC.Text = "00000000000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 54);
            label1.Name = "label1";
            label1.Size = new Size(96, 35);
            label1.TabIndex = 0;
            label1.Text = "TC No:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnDuyuruOlustur);
            groupBox2.Controls.Add(RchDuyuru);
            groupBox2.Location = new Point(12, 196);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(372, 279);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Duyuru Olustur";
            // 
            // BtnDuyuruOlustur
            // 
            BtnDuyuruOlustur.Location = new Point(106, 165);
            BtnDuyuruOlustur.Margin = new Padding(3, 4, 3, 4);
            BtnDuyuruOlustur.Name = "BtnDuyuruOlustur";
            BtnDuyuruOlustur.Size = new Size(166, 50);
            BtnDuyuruOlustur.TabIndex = 1;
            BtnDuyuruOlustur.Text = "Olustur";
            BtnDuyuruOlustur.UseVisualStyleBackColor = true;
            BtnDuyuruOlustur.Click += BtnDuyuruOlustur_Click;
            // 
            // RchDuyuru
            // 
            RchDuyuru.Location = new Point(6, 39);
            RchDuyuru.Margin = new Padding(3, 4, 3, 4);
            RchDuyuru.Name = "RchDuyuru";
            RchDuyuru.Size = new Size(359, 120);
            RchDuyuru.TabIndex = 0;
            RchDuyuru.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnDuzenle);
            groupBox3.Controls.Add(BtnKaydet);
            groupBox3.Controls.Add(ChkDurum);
            groupBox3.Controls.Add(CmbDoktor);
            groupBox3.Controls.Add(CmbBrans);
            groupBox3.Controls.Add(MskSaat);
            groupBox3.Controls.Add(MskTC);
            groupBox3.Controls.Add(MskTarih);
            groupBox3.Controls.Add(Txtid);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(402, 12);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(312, 463);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Randevu Paneli";
            // 
            // BtnDuzenle
            // 
            BtnDuzenle.Location = new Point(130, 404);
            BtnDuzenle.Margin = new Padding(3, 4, 3, 4);
            BtnDuzenle.Name = "BtnDuzenle";
            BtnDuzenle.Size = new Size(156, 39);
            BtnDuzenle.TabIndex = 1;
            BtnDuzenle.Text = "Düzenle";
            BtnDuzenle.UseVisualStyleBackColor = true;
            // 
            // BtnKaydet
            // 
            BtnKaydet.Location = new Point(130, 359);
            BtnKaydet.Margin = new Padding(3, 4, 3, 4);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(156, 39);
            BtnKaydet.TabIndex = 1;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.UseVisualStyleBackColor = true;
            BtnKaydet.Click += BtnKaydet_Click;
            // 
            // ChkDurum
            // 
            ChkDurum.AutoSize = true;
            ChkDurum.Location = new Point(142, 325);
            ChkDurum.Margin = new Padding(3, 4, 3, 4);
            ChkDurum.Name = "ChkDurum";
            ChkDurum.Size = new Size(120, 39);
            ChkDurum.TabIndex = 4;
            ChkDurum.Text = "Durum";
            ChkDurum.UseVisualStyleBackColor = true;
            // 
            // CmbDoktor
            // 
            CmbDoktor.FormattingEnabled = true;
            CmbDoktor.Location = new Point(130, 231);
            CmbDoktor.Margin = new Padding(3, 4, 3, 4);
            CmbDoktor.Name = "CmbDoktor";
            CmbDoktor.Size = new Size(156, 41);
            CmbDoktor.TabIndex = 3;
            // 
            // CmbBrans
            // 
            CmbBrans.FormattingEnabled = true;
            CmbBrans.Location = new Point(130, 184);
            CmbBrans.Margin = new Padding(3, 4, 3, 4);
            CmbBrans.Name = "CmbBrans";
            CmbBrans.Size = new Size(156, 41);
            CmbBrans.TabIndex = 3;
            CmbBrans.SelectedIndexChanged += CmbBrans_SelectedIndexChanged;
            // 
            // MskSaat
            // 
            MskSaat.Location = new Point(130, 138);
            MskSaat.Margin = new Padding(3, 4, 3, 4);
            MskSaat.Mask = "00:00";
            MskSaat.Name = "MskSaat";
            MskSaat.Size = new Size(156, 40);
            MskSaat.TabIndex = 2;
            MskSaat.ValidatingType = typeof(DateTime);
            // 
            // MskTC
            // 
            MskTC.Location = new Point(130, 279);
            MskTC.Margin = new Padding(3, 4, 3, 4);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(156, 40);
            MskTC.TabIndex = 2;
            MskTC.ValidatingType = typeof(int);
            // 
            // MskTarih
            // 
            MskTarih.Location = new Point(130, 90);
            MskTarih.Margin = new Padding(3, 4, 3, 4);
            MskTarih.Mask = "00/00/0000";
            MskTarih.Name = "MskTarih";
            MskTarih.Size = new Size(156, 40);
            MskTarih.TabIndex = 2;
            MskTarih.ValidatingType = typeof(DateTime);
            // 
            // Txtid
            // 
            Txtid.Location = new Point(130, 39);
            Txtid.Margin = new Padding(3, 4, 3, 4);
            Txtid.Name = "Txtid";
            Txtid.Size = new Size(156, 40);
            Txtid.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(32, 284);
            label11.Name = "label11";
            label11.Size = new Size(96, 35);
            label11.TabIndex = 0;
            label11.Text = "TC No:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 237);
            label9.Name = "label9";
            label9.Size = new Size(109, 35);
            label9.TabIndex = 0;
            label9.Text = "Doktor:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 190);
            label8.Name = "label8";
            label8.Size = new Size(92, 35);
            label8.TabIndex = 0;
            label8.Text = "Branş:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 143);
            label7.Name = "label7";
            label7.Size = new Size(78, 35);
            label7.TabIndex = 0;
            label7.Text = "Saat:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 94);
            label6.Name = "label6";
            label6.Size = new Size(84, 35);
            label6.TabIndex = 0;
            label6.Text = "Tarih:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 39);
            label5.Name = "label5";
            label5.Size = new Size(46, 35);
            label5.TabIndex = 0;
            label5.Text = "id:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(734, 16);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(393, 286);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 37);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(387, 245);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridView2);
            groupBox5.Location = new Point(734, 308);
            groupBox5.Margin = new Padding(3, 4, 3, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 4, 3, 4);
            groupBox5.Size = new Size(393, 297);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 37);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(387, 256);
            dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(BtnRandevuListe);
            groupBox6.Controls.Add(BtnBransPaneli);
            groupBox6.Controls.Add(BtnDoktorPaneli);
            groupBox6.Location = new Point(12, 480);
            groupBox6.Margin = new Padding(3, 4, 3, 4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(3, 4, 3, 4);
            groupBox6.Size = new Size(702, 125);
            groupBox6.TabIndex = 4;
            groupBox6.TabStop = false;
            groupBox6.Text = "Hızlı erişim";
            // 
            // BtnRandevuListe
            // 
            BtnRandevuListe.Location = new Point(442, 54);
            BtnRandevuListe.Name = "BtnRandevuListe";
            BtnRandevuListe.Size = new Size(210, 50);
            BtnRandevuListe.TabIndex = 0;
            BtnRandevuListe.Text = "Randevu Liste";
            BtnRandevuListe.UseVisualStyleBackColor = true;
            // 
            // BtnBransPaneli
            // 
            BtnBransPaneli.Location = new Point(224, 54);
            BtnBransPaneli.Name = "BtnBransPaneli";
            BtnBransPaneli.Size = new Size(212, 50);
            BtnBransPaneli.TabIndex = 0;
            BtnBransPaneli.Text = "Branş Paneli";
            BtnBransPaneli.UseVisualStyleBackColor = true;
            // 
            // BtnDoktorPaneli
            // 
            BtnDoktorPaneli.Location = new Point(6, 54);
            BtnDoktorPaneli.Name = "BtnDoktorPaneli";
            BtnDoktorPaneli.Size = new Size(212, 50);
            BtnDoktorPaneli.TabIndex = 0;
            BtnDoktorPaneli.Text = "Doktor Paneli";
            BtnDoktorPaneli.UseVisualStyleBackColor = true;
            BtnDoktorPaneli.Click += BtnDoktorPaneli_Click;
            // 
            // FrmSekreterDetay
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1153, 618);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Corbel", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(6, 5, 6, 5);
            Name = "FrmSekreterDetay";
            Text = "FrmSekreterDetay";
            Load += FrmSekreterDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label LblAdSoyad;
        private Label LblTC;
        private GroupBox groupBox2;
        private Button BtnDuyuruOlustur;
        private RichTextBox RchDuyuru;
        private GroupBox groupBox3;
        private Label label11;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button BtnDuzenle;
        private Button BtnKaydet;
        private CheckBox ChkDurum;
        private ComboBox CmbDoktor;
        private ComboBox CmbBrans;
        private MaskedTextBox MskSaat;
        private MaskedTextBox MskTC;
        private MaskedTextBox MskTarih;
        private TextBox Txtid;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private GroupBox groupBox5;
        private DataGridView dataGridView2;
        private GroupBox groupBox6;
        private Button BtnRandevuListe;
        private Button BtnBransPaneli;
        private Button BtnDoktorPaneli;
    }
}