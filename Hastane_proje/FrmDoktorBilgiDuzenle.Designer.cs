namespace Hastane_proje
{
    partial class FrmDoktorBilgiDuzenle
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
            TxtSoyad = new TextBox();
            label4 = new Label();
            TxtAd = new TextBox();
            label1 = new Label();
            TxtSifre = new TextBox();
            MskTC = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            CmbBrans = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // BtBilgiGuncelle
            // 
            BtBilgiGuncelle.BackColor = Color.FromArgb(192, 255, 192);
            BtBilgiGuncelle.ForeColor = Color.Black;
            BtBilgiGuncelle.Location = new Point(189, 267);
            BtBilgiGuncelle.Name = "BtBilgiGuncelle";
            BtBilgiGuncelle.Size = new Size(189, 45);
            BtBilgiGuncelle.TabIndex = 43;
            BtBilgiGuncelle.Text = "Güncelle";
            BtBilgiGuncelle.UseVisualStyleBackColor = false;
            BtBilgiGuncelle.Click += BtBilgiGuncelle_Click;
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(189, 82);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(189, 40);
            TxtSoyad.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 87);
            label4.Name = "label4";
            label4.Size = new Size(99, 35);
            label4.TabIndex = 39;
            label4.Text = "Soyad:";
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(189, 36);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(189, 40);
            TxtAd.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 41);
            label1.Name = "label1";
            label1.Size = new Size(57, 35);
            label1.TabIndex = 37;
            label1.Text = "Ad:";
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(189, 221);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(189, 40);
            TxtSifre.TabIndex = 36;
            // 
            // MskTC
            // 
            MskTC.Location = new Point(189, 129);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(189, 40);
            MskTC.TabIndex = 35;
            MskTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 226);
            label3.Name = "label3";
            label3.Size = new Size(79, 35);
            label3.TabIndex = 31;
            label3.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 134);
            label2.Name = "label2";
            label2.Size = new Size(133, 35);
            label2.TabIndex = 33;
            label2.Text = "TC kimlik:";
            // 
            // CmbBrans
            // 
            CmbBrans.FormattingEnabled = true;
            CmbBrans.Location = new Point(189, 174);
            CmbBrans.Name = "CmbBrans";
            CmbBrans.Size = new Size(189, 41);
            CmbBrans.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 177);
            label5.Name = "label5";
            label5.Size = new Size(92, 35);
            label5.TabIndex = 33;
            label5.Text = "Branş:";
            // 
            // FrmDoktorBilgiDuzenle
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(470, 370);
            Controls.Add(CmbBrans);
            Controls.Add(BtBilgiGuncelle);
            Controls.Add(TxtSoyad);
            Controls.Add(label4);
            Controls.Add(TxtAd);
            Controls.Add(label1);
            Controls.Add(TxtSifre);
            Controls.Add(MskTC);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Font = new Font("Corbel", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(6, 5, 6, 5);
            Name = "FrmDoktorBilgiDuzenle";
            Text = "FrmDoktorBilgiDuzenle";
            Load += FrmDoktorBilgiDuzenle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtBilgiGuncelle;
        private TextBox TxtSoyad;
        private Label label4;
        private TextBox TxtAd;
        private Label label1;
        private TextBox TxtSifre;
        private MaskedTextBox MskTC;
        private Label label3;
        private Label label2;
        private ComboBox CmbBrans;
        private Label label5;
    }
}