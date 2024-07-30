namespace Hastane_proje
{
    partial class FrmBilgiDuzenle
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
            BtBilgiGuncelle = new Button();
            CmbCinsiyet = new ComboBox();
            label5 = new Label();
            TxtSoyad = new TextBox();
            label4 = new Label();
            TxtAd = new TextBox();
            label1 = new Label();
            TxtSifre = new TextBox();
            MskTelefon = new MaskedTextBox();
            MskTC = new MaskedTextBox();
            label3 = new Label();
            label6 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // BtBilgiGuncelle
            // 
            BtBilgiGuncelle.BackColor = Color.FromArgb(192, 255, 192);
            BtBilgiGuncelle.ForeColor = Color.Black;
            BtBilgiGuncelle.Location = new Point(194, 333);
            BtBilgiGuncelle.Name = "BtBilgiGuncelle";
            BtBilgiGuncelle.Size = new Size(189, 45);
            BtBilgiGuncelle.TabIndex = 7;
            BtBilgiGuncelle.Text = "Güncelle";
            BtBilgiGuncelle.UseVisualStyleBackColor = false;
            BtBilgiGuncelle.Click += BtBilgiGuncelle_Click;
            // 
            // CmbCinsiyet
            // 
            CmbCinsiyet.FormattingEnabled = true;
            CmbCinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            CmbCinsiyet.Location = new Point(194, 286);
            CmbCinsiyet.Name = "CmbCinsiyet";
            CmbCinsiyet.Size = new Size(189, 41);
            CmbCinsiyet.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 286);
            label5.Name = "label5";
            label5.Size = new Size(113, 35);
            label5.TabIndex = 28;
            label5.Text = "Cİnsiyet";
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(194, 97);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(189, 40);
            TxtSoyad.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 102);
            label4.Name = "label4";
            label4.Size = new Size(99, 35);
            label4.TabIndex = 26;
            label4.Text = "Soyad:";
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(194, 51);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(189, 40);
            TxtAd.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 56);
            label1.Name = "label1";
            label1.Size = new Size(57, 35);
            label1.TabIndex = 24;
            label1.Text = "Ad:";
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(194, 236);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(189, 40);
            TxtSifre.TabIndex = 5;
            // 
            // MskTelefon
            // 
            MskTelefon.Location = new Point(194, 190);
            MskTelefon.Mask = "(999) 000-0000";
            MskTelefon.Name = "MskTelefon";
            MskTelefon.Size = new Size(189, 40);
            MskTelefon.TabIndex = 4;
            // 
            // MskTC
            // 
            MskTC.Location = new Point(194, 144);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(189, 40);
            MskTC.TabIndex = 3;
            MskTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 241);
            label3.Name = "label3";
            label3.Size = new Size(79, 35);
            label3.TabIndex = 18;
            label3.Text = "Şifre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 195);
            label6.Name = "label6";
            label6.Size = new Size(113, 35);
            label6.TabIndex = 19;
            label6.Text = "Telefon:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 149);
            label2.Name = "label2";
            label2.Size = new Size(133, 35);
            label2.TabIndex = 20;
            label2.Text = "TC kimlik:";
            // 
            // FrmBilgiDuzenle
            // 
            AcceptButton = BtBilgiGuncelle;
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(441, 421);
            Controls.Add(BtBilgiGuncelle);
            Controls.Add(CmbCinsiyet);
            Controls.Add(label5);
            Controls.Add(TxtSoyad);
            Controls.Add(label4);
            Controls.Add(TxtAd);
            Controls.Add(label1);
            Controls.Add(TxtSifre);
            Controls.Add(MskTelefon);
            Controls.Add(MskTC);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Font = new Font("Corbel", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(6, 5, 6, 5);
            MaximizeBox = false;
            Name = "FrmBilgiDuzenle";
            Text = "FrmBilgiDuzenle";
            Load += FrmBilgiDuzenle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtBilgiGuncelle;
        private ComboBox CmbCinsiyet;
        private Label label5;
        private TextBox TxtSoyad;
        private Label label4;
        private TextBox TxtAd;
        private Label label1;
        private TextBox TxtSifre;
        private MaskedTextBox MskTelefon;
        private MaskedTextBox MskTC;
        private Label label3;
        private Label label6;
        private Label label2;
    }
}