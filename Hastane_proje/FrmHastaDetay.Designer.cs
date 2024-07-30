namespace Hastane_proje
{
    partial class FrmHastaDetay
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
            label2 = new Label();
            groupBox2 = new GroupBox();
            Txtid = new TextBox();
            LnkBilgiDuzenle = new LinkLabel();
            BtnRandevuAl = new Button();
            label7 = new Label();
            label6 = new Label();
            RchSikayet = new RichTextBox();
            label1 = new Label();
            label5 = new Label();
            CmbDoktor = new ComboBox();
            CmbBrans = new ComboBox();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox4 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LblAdSoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(LblTC);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(10, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 142);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kişi Bilgi";
            // 
            // LblAdSoyad
            // 
            LblAdSoyad.AutoSize = true;
            LblAdSoyad.Font = new Font("Corbel", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LblAdSoyad.Location = new Point(120, 80);
            LblAdSoyad.Name = "LblAdSoyad";
            LblAdSoyad.Size = new Size(101, 28);
            LblAdSoyad.TabIndex = 12;
            LblAdSoyad.Text = "Null Null";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 74);
            label3.Name = "label3";
            label3.Size = new Size(114, 28);
            label3.TabIndex = 11;
            label3.Text = "Ad Soyad:";
            // 
            // LblTC
            // 
            LblTC.AutoSize = true;
            LblTC.Font = new Font("Corbel", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LblTC.Location = new Point(120, 44);
            LblTC.Name = "LblTC";
            LblTC.Size = new Size(144, 28);
            LblTC.TabIndex = 9;
            LblTC.Text = "00000000000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 44);
            label2.Name = "label2";
            label2.Size = new Size(79, 28);
            label2.TabIndex = 10;
            label2.Text = "TC No:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Txtid);
            groupBox2.Controls.Add(LnkBilgiDuzenle);
            groupBox2.Controls.Add(BtnRandevuAl);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(RchSikayet);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(CmbDoktor);
            groupBox2.Controls.Add(CmbBrans);
            groupBox2.Location = new Point(10, 157);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(372, 342);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Randevu";
            // 
            // Txtid
            // 
            Txtid.Location = new Point(144, 43);
            Txtid.Name = "Txtid";
            Txtid.Size = new Size(182, 36);
            Txtid.TabIndex = 7;
            // 
            // LnkBilgiDuzenle
            // 
            LnkBilgiDuzenle.AutoSize = true;
            LnkBilgiDuzenle.BackColor = Color.CadetBlue;
            LnkBilgiDuzenle.Location = new Point(5, 311);
            LnkBilgiDuzenle.Name = "LnkBilgiDuzenle";
            LnkBilgiDuzenle.Size = new Size(177, 28);
            LnkBilgiDuzenle.TabIndex = 6;
            LnkBilgiDuzenle.TabStop = true;
            LnkBilgiDuzenle.Text = "Bilgileri Düzenle";
            LnkBilgiDuzenle.LinkClicked += LnkBilgiDuzenle_LinkClicked;
            // 
            // BtnRandevuAl
            // 
            BtnRandevuAl.Location = new Point(144, 271);
            BtnRandevuAl.Name = "BtnRandevuAl";
            BtnRandevuAl.Size = new Size(182, 34);
            BtnRandevuAl.TabIndex = 5;
            BtnRandevuAl.Text = "Randevu Al";
            BtnRandevuAl.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 164);
            label7.Name = "label7";
            label7.Size = new Size(95, 28);
            label7.TabIndex = 3;
            label7.Text = "Şikayet:";
            label7.Click += label6_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 124);
            label6.Name = "label6";
            label6.Size = new Size(90, 28);
            label6.TabIndex = 3;
            label6.Text = "Doktor:";
            label6.Click += label6_Click;
            // 
            // RchSikayet
            // 
            RchSikayet.Location = new Point(144, 164);
            RchSikayet.Name = "RchSikayet";
            RchSikayet.Size = new Size(182, 102);
            RchSikayet.TabIndex = 4;
            RchSikayet.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 46);
            label1.Name = "label1";
            label1.Size = new Size(131, 28);
            label1.TabIndex = 3;
            label1.Text = "Randevu id:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 82);
            label5.Name = "label5";
            label5.Size = new Size(76, 28);
            label5.TabIndex = 3;
            label5.Text = "Branş:";
            // 
            // CmbDoktor
            // 
            CmbDoktor.FormattingEnabled = true;
            CmbDoktor.Location = new Point(144, 124);
            CmbDoktor.Name = "CmbDoktor";
            CmbDoktor.Size = new Size(182, 36);
            CmbDoktor.TabIndex = 2;
            CmbDoktor.SelectedIndexChanged += CmbDoktor_SelectedIndexChanged;
            // 
            // CmbBrans
            // 
            CmbBrans.FormattingEnabled = true;
            CmbBrans.Location = new Point(144, 83);
            CmbBrans.Name = "CmbBrans";
            CmbBrans.Size = new Size(182, 36);
            CmbBrans.TabIndex = 2;
            CmbBrans.SelectedIndexChanged += CmbBrans_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox3.Location = new Point(407, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(653, 217);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Randevu Geçmişi";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(647, 186);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView2);
            groupBox4.Location = new Point(404, 259);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(653, 221);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Aktif Randevular";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 32);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(647, 186);
            dataGridView2.TabIndex = 0;
            // 
            // FrmHastaDetay
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1150, 511);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Corbel", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmHastaDetay";
            Text = "FrmHastaDetay";
            Load += FrmHastaDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label LblTC;
        private Label label2;
        private Label LblAdSoyad;
        private GroupBox groupBox2;
        private Label label6;
        private RichTextBox RchSikayet;
        private Label label5;
        private ComboBox CmbDoktor;
        private ComboBox CmbBrans;
        private Button BtnRandevuAl;
        private Label label7;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private LinkLabel LnkBilgiDuzenle;
        private Label label1;
        private TextBox Txtid;
    }
}