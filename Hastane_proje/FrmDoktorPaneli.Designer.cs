namespace Hastane_proje
{
    partial class FrmDoktorPaneli
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
            CmbBrans = new ComboBox();
            TxtAd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            MskTC = new MaskedTextBox();
            TxtSoyad = new TextBox();
            TxtSifre = new TextBox();
            dataGridView1 = new DataGridView();
            BtnEkle = new Button();
            BtnSil = new Button();
            BtnGuncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // CmbBrans
            // 
            CmbBrans.FormattingEnabled = true;
            CmbBrans.Location = new Point(188, 115);
            CmbBrans.Margin = new Padding(3, 4, 3, 4);
            CmbBrans.Name = "CmbBrans";
            CmbBrans.Size = new Size(156, 41);
            CmbBrans.TabIndex = 3;
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(188, 19);
            TxtAd.Margin = new Padding(3, 4, 3, 4);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(156, 40);
            TxtAd.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 24);
            label1.Name = "label1";
            label1.Size = new Size(57, 35);
            label1.TabIndex = 4;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 67);
            label2.Name = "label2";
            label2.Size = new Size(99, 35);
            label2.TabIndex = 4;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 118);
            label3.Name = "label3";
            label3.Size = new Size(92, 35);
            label3.TabIndex = 4;
            label3.Text = "Branş:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 163);
            label4.Name = "label4";
            label4.Size = new Size(96, 35);
            label4.TabIndex = 4;
            label4.Text = "TC No:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(103, 210);
            label5.Name = "label5";
            label5.Size = new Size(79, 35);
            label5.TabIndex = 4;
            label5.Text = "Şifre:";
            // 
            // MskTC
            // 
            MskTC.Location = new Point(188, 163);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(156, 40);
            MskTC.TabIndex = 4;
            MskTC.ValidatingType = typeof(int);
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(188, 67);
            TxtSoyad.Margin = new Padding(3, 4, 3, 4);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(156, 40);
            TxtSoyad.TabIndex = 2;
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(188, 210);
            TxtSifre.Margin = new Padding(3, 4, 3, 4);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(156, 40);
            TxtSifre.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(376, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(794, 291);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // BtnEkle
            // 
            BtnEkle.BackColor = Color.Cyan;
            BtnEkle.Location = new Point(188, 266);
            BtnEkle.Name = "BtnEkle";
            BtnEkle.Size = new Size(80, 44);
            BtnEkle.TabIndex = 6;
            BtnEkle.Text = "Ekle";
            BtnEkle.UseVisualStyleBackColor = false;
            BtnEkle.Click += BtnEkle_Click;
            // 
            // BtnSil
            // 
            BtnSil.BackColor = Color.HotPink;
            BtnSil.Location = new Point(274, 266);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(70, 44);
            BtnSil.TabIndex = 7;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = false;
            BtnSil.Click += BtnSil_Click;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.BackColor = Color.FromArgb(255, 128, 0);
            BtnGuncelle.Location = new Point(188, 316);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(156, 45);
            BtnGuncelle.TabIndex = 8;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = false;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // FrmDoktorPaneli
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1182, 413);
            Controls.Add(BtnGuncelle);
            Controls.Add(BtnSil);
            Controls.Add(BtnEkle);
            Controls.Add(dataGridView1);
            Controls.Add(MskTC);
            Controls.Add(CmbBrans);
            Controls.Add(TxtSifre);
            Controls.Add(TxtSoyad);
            Controls.Add(TxtAd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Corbel", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(6, 5, 6, 5);
            Name = "FrmDoktorPaneli";
            Text = "FrmDoktorPaneli";
            Load += FrmDoktorPaneli_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CmbBrans;
        private TextBox TxtAd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private MaskedTextBox MskTC;
        private TextBox TxtSoyad;
        private TextBox TxtSifre;
        private DataGridView dataGridView1;
        private Button BtnEkle;
        private Button BtnSil;
        private Button BtnGuncelle;
    }
}