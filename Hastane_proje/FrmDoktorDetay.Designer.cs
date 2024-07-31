namespace Hastane_proje
{
    partial class FrmDoktorDetay
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
            LblAdSoyad = new Label();
            label3 = new Label();
            LblTC = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            RchSikayet = new RichTextBox();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox4 = new GroupBox();
            BtnCikis = new Button();
            BtnDuyurular = new Button();
            BtnGuncelle = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LblAdSoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(LblTC);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(9, 9);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(286, 113);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Doktor Bilgileri";
            // 
            // LblAdSoyad
            // 
            LblAdSoyad.AutoSize = true;
            LblAdSoyad.Location = new Point(108, 67);
            LblAdSoyad.Margin = new Padding(2, 0, 2, 0);
            LblAdSoyad.Name = "LblAdSoyad";
            LblAdSoyad.Size = new Size(86, 24);
            LblAdSoyad.TabIndex = 1;
            LblAdSoyad.Text = "Null Null";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 24);
            label3.TabIndex = 0;
            label3.Text = "AdSoyad:";
            // 
            // LblTC
            // 
            LblTC.AutoSize = true;
            LblTC.Location = new Point(108, 41);
            LblTC.Margin = new Padding(2, 0, 2, 0);
            LblTC.Name = "LblTC";
            LblTC.Size = new Size(120, 24);
            LblTC.TabIndex = 0;
            LblTC.Text = "00000000000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 41);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 24);
            label1.TabIndex = 0;
            label1.Text = "TC No:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(RchSikayet);
            groupBox2.Location = new Point(9, 126);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(286, 144);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Randevu Detay";
            // 
            // RchSikayet
            // 
            RchSikayet.Location = new Point(4, 28);
            RchSikayet.Margin = new Padding(2);
            RchSikayet.Name = "RchSikayet";
            RchSikayet.Size = new Size(278, 112);
            RchSikayet.TabIndex = 3;
            RchSikayet.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(299, 21);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(849, 356);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(2, 27);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(845, 327);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(BtnCikis);
            groupBox4.Controls.Add(BtnDuyurular);
            groupBox4.Controls.Add(BtnGuncelle);
            groupBox4.Location = new Point(9, 274);
            groupBox4.Margin = new Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2);
            groupBox4.Size = new Size(286, 103);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Hızlı Erişim";
            // 
            // BtnCikis
            // 
            BtnCikis.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnCikis.Location = new Point(39, 61);
            BtnCikis.Margin = new Padding(2);
            BtnCikis.Name = "BtnCikis";
            BtnCikis.Size = new Size(220, 29);
            BtnCikis.TabIndex = 1;
            BtnCikis.Text = "Çıkış";
            BtnCikis.UseVisualStyleBackColor = true;
            BtnCikis.Click += BtnCikis_Click;
            // 
            // BtnDuyurular
            // 
            BtnDuyurular.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnDuyurular.Location = new Point(161, 29);
            BtnDuyurular.Margin = new Padding(2);
            BtnDuyurular.Name = "BtnDuyurular";
            BtnDuyurular.Size = new Size(121, 29);
            BtnDuyurular.TabIndex = 1;
            BtnDuyurular.Text = "Duyurular";
            BtnDuyurular.UseVisualStyleBackColor = true;
            BtnDuyurular.Click += BtnDuyurular_Click;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnGuncelle.Location = new Point(27, 28);
            BtnGuncelle.Margin = new Padding(2);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(130, 29);
            BtnGuncelle.TabIndex = 0;
            BtnGuncelle.Text = "Bilgi Düzenle";
            BtnGuncelle.UseVisualStyleBackColor = true;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // FrmDoktorDetay
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1159, 385);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "FrmDoktorDetay";
            Text = "FrmDoktorDetay";
            Load += FrmDoktorDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label LblAdSoyad;
        private Label label3;
        private Label LblTC;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private RichTextBox RchSikayet;
        private GroupBox groupBox4;
        private Button BtnGuncelle;
        private Button BtnCikis;
        private Button BtnDuyurular;
    }
}