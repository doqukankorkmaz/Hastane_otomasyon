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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(333, 155);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Doktor Bilgileri";
            // 
            // LblAdSoyad
            // 
            LblAdSoyad.AutoSize = true;
            LblAdSoyad.Location = new Point(147, 92);
            LblAdSoyad.Name = "LblAdSoyad";
            LblAdSoyad.Size = new Size(119, 35);
            LblAdSoyad.TabIndex = 1;
            LblAdSoyad.Text = "Null Null";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 92);
            label3.Name = "label3";
            label3.Size = new Size(133, 35);
            label3.TabIndex = 0;
            label3.Text = "AdSoyad:";
            // 
            // LblTC
            // 
            LblTC.AutoSize = true;
            LblTC.Location = new Point(147, 57);
            LblTC.Name = "LblTC";
            LblTC.Size = new Size(169, 35);
            LblTC.TabIndex = 0;
            LblTC.Text = "00000000000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 57);
            label1.Name = "label1";
            label1.Size = new Size(96, 35);
            label1.TabIndex = 0;
            label1.Text = "TC No:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(RchSikayet);
            groupBox2.Location = new Point(12, 173);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(333, 198);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Randevu Detay";
            // 
            // RchSikayet
            // 
            RchSikayet.Location = new Point(6, 39);
            RchSikayet.Name = "RchSikayet";
            RchSikayet.Size = new Size(321, 153);
            RchSikayet.TabIndex = 3;
            RchSikayet.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(351, 28);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(476, 490);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(470, 451);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(BtnCikis);
            groupBox4.Controls.Add(BtnDuyurular);
            groupBox4.Controls.Add(BtnGuncelle);
            groupBox4.Location = new Point(12, 377);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(333, 141);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Hızlı Erişim";
            // 
            // BtnCikis
            // 
            BtnCikis.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnCikis.Location = new Point(16, 81);
            BtnCikis.Name = "BtnCikis";
            BtnCikis.Size = new Size(300, 40);
            BtnCikis.TabIndex = 1;
            BtnCikis.Text = "Çıkış";
            BtnCikis.UseVisualStyleBackColor = true;
            // 
            // BtnDuyurular
            // 
            BtnDuyurular.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnDuyurular.Location = new Point(176, 39);
            BtnDuyurular.Name = "BtnDuyurular";
            BtnDuyurular.Size = new Size(140, 40);
            BtnDuyurular.TabIndex = 1;
            BtnDuyurular.Text = "Duyurular";
            BtnDuyurular.UseVisualStyleBackColor = true;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnGuncelle.Location = new Point(16, 39);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(140, 40);
            BtnGuncelle.TabIndex = 0;
            BtnGuncelle.Text = "Bilgi Düzenle";
            BtnGuncelle.UseVisualStyleBackColor = true;
            BtnGuncelle.Click += button1_Click;
            // 
            // FrmDoktorDetay
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(875, 530);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Corbel", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(6, 5, 6, 5);
            Name = "FrmDoktorDetay";
            Text = "FrmDoktorDetay";
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