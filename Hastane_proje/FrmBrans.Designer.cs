namespace Hastane_proje
{
    partial class FrmBrans
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
            BtnGuncelle = new Button();
            BtnSil = new Button();
            BtnEkle = new Button();
            dataGridView1 = new DataGridView();
            TxtBransAd = new TextBox();
            Txtid = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.BackColor = Color.FromArgb(255, 128, 0);
            BtnGuncelle.Location = new Point(169, 221);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(156, 35);
            BtnGuncelle.TabIndex = 21;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = false;
            // 
            // BtnSil
            // 
            BtnSil.BackColor = Color.HotPink;
            BtnSil.Location = new Point(255, 180);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(70, 35);
            BtnSil.TabIndex = 22;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = false;
            // 
            // BtnEkle
            // 
            BtnEkle.BackColor = Color.Cyan;
            BtnEkle.Location = new Point(169, 180);
            BtnEkle.Name = "BtnEkle";
            BtnEkle.Size = new Size(78, 35);
            BtnEkle.TabIndex = 23;
            BtnEkle.Text = "Ekle";
            BtnEkle.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(343, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(393, 187);
            dataGridView1.TabIndex = 20;
            // 
            // TxtBransAd
            // 
            TxtBransAd.Location = new Point(169, 106);
            TxtBransAd.Margin = new Padding(3, 4, 3, 4);
            TxtBransAd.Name = "TxtBransAd";
            TxtBransAd.Size = new Size(156, 33);
            TxtBransAd.TabIndex = 16;
            // 
            // Txtid
            // 
            Txtid.Location = new Point(169, 68);
            Txtid.Margin = new Padding(3, 4, 3, 4);
            Txtid.Name = "Txtid";
            Txtid.Size = new Size(156, 33);
            Txtid.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 109);
            label2.Name = "label2";
            label2.Size = new Size(99, 26);
            label2.TabIndex = 13;
            label2.Text = "Branş Ad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 71);
            label1.Name = "label1";
            label1.Size = new Size(92, 26);
            label1.TabIndex = 14;
            label1.Text = "Brans İd:";
            // 
            // FrmBrans
            // 
            AutoScaleDimensions = new SizeF(12F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(800, 338);
            Controls.Add(BtnGuncelle);
            Controls.Add(BtnSil);
            Controls.Add(BtnEkle);
            Controls.Add(dataGridView1);
            Controls.Add(TxtBransAd);
            Controls.Add(Txtid);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Corbel", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(5, 5, 5, 5);
            Name = "FrmBrans";
            Text = "FrmBrans";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnGuncelle;
        private Button BtnSil;
        private Button BtnEkle;
        private DataGridView dataGridView1;
        private TextBox TxtBransAd;
        private TextBox Txtid;
        private Label label2;
        private Label label1;
    }
}