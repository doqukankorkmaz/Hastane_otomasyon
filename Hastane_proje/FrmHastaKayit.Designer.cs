namespace Hastane_proje
{
    partial class FrmHastaKayit
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
            TxtSifre = new TextBox();
            MskTC = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            TxtAd = new TextBox();
            label1 = new Label();
            TxtSoyad = new TextBox();
            label4 = new Label();
            label5 = new Label();
            MskTelefon = new MaskedTextBox();
            label6 = new Label();
            CmbCinsiyet = new ComboBox();
            BtnKayit = new Button();
            SuspendLayout();
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(233, 194);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(189, 40);
            TxtSifre.TabIndex = 5;
            // 
            // MskTC
            // 
            MskTC.Location = new Point(233, 102);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(189, 40);
            MskTC.TabIndex = 3;
            MskTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 199);
            label3.Name = "label3";
            label3.Size = new Size(79, 35);
            label3.TabIndex = 4;
            label3.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 107);
            label2.Name = "label2";
            label2.Size = new Size(133, 35);
            label2.TabIndex = 5;
            label2.Text = "TC kimlik:";
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(233, 9);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(189, 40);
            TxtAd.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 14);
            label1.Name = "label1";
            label1.Size = new Size(57, 35);
            label1.TabIndex = 8;
            label1.Text = "Ad:";
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(233, 55);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(189, 40);
            TxtSoyad.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(112, 60);
            label4.Name = "label4";
            label4.Size = new Size(99, 35);
            label4.TabIndex = 10;
            label4.Text = "Soyad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(98, 244);
            label5.Name = "label5";
            label5.Size = new Size(113, 35);
            label5.TabIndex = 12;
            label5.Text = "Cİnsiyet";
            // 
            // MskTelefon
            // 
            MskTelefon.Location = new Point(233, 148);
            MskTelefon.Mask = "(999) 000-0000";
            MskTelefon.Name = "MskTelefon";
            MskTelefon.Size = new Size(189, 40);
            MskTelefon.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(98, 153);
            label6.Name = "label6";
            label6.Size = new Size(113, 35);
            label6.TabIndex = 5;
            label6.Text = "Telefon:";
            // 
            // CmbCinsiyet
            // 
            CmbCinsiyet.FormattingEnabled = true;
            CmbCinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            CmbCinsiyet.Location = new Point(233, 244);
            CmbCinsiyet.Name = "CmbCinsiyet";
            CmbCinsiyet.Size = new Size(189, 41);
            CmbCinsiyet.TabIndex = 6;
            // 
            // BtnKayit
            // 
            BtnKayit.BackColor = Color.FromArgb(192, 255, 192);
            BtnKayit.ForeColor = Color.Black;
            BtnKayit.Location = new Point(233, 291);
            BtnKayit.Name = "BtnKayit";
            BtnKayit.Size = new Size(189, 45);
            BtnKayit.TabIndex = 7;
            BtnKayit.Text = "Kayıt";
            BtnKayit.UseVisualStyleBackColor = false;
            BtnKayit.Click += BtnKayit_Click;
            // 
            // FrmHastaKayit
            // 
            AcceptButton = BtnKayit;
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(521, 347);
            Controls.Add(BtnKayit);
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
            Name = "FrmHastaKayit";
            Text = "FrmHastaKayit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtSifre;
        private MaskedTextBox MskTC;
        private Label label3;
        private Label label2;
        private TextBox TxtAd;
        private Label label1;
        private TextBox TxtSoyad;
        private Label label4;
        private Label label5;
        private MaskedTextBox MskTelefon;
        private Label label6;
        private ComboBox CmbCinsiyet;
        private Button BtnKayit;
    }
}