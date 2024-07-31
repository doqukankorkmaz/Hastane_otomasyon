namespace Hastane_proje
{
    partial class FrmHastaGiris
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
            BtnGiris = new Button();
            LnkUyeOl = new LinkLabel();
            TxtSifre = new TextBox();
            MskTC = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // BtnGiris
            // 
            BtnGiris.Location = new Point(350, 192);
            BtnGiris.Margin = new Padding(5);
            BtnGiris.Name = "BtnGiris";
            BtnGiris.Size = new Size(108, 41);
            BtnGiris.TabIndex = 12;
            BtnGiris.Text = "Giriş";
            BtnGiris.UseVisualStyleBackColor = true;
            BtnGiris.Click += BtnGiris_Click;
            // 
            // LnkUyeOl
            // 
            LnkUyeOl.AutoSize = true;
            LnkUyeOl.Location = new Point(468, 199);
            LnkUyeOl.Margin = new Padding(5, 0, 5, 0);
            LnkUyeOl.Name = "LnkUyeOl";
            LnkUyeOl.Size = new Size(94, 33);
            LnkUyeOl.TabIndex = 11;
            LnkUyeOl.TabStop = true;
            LnkUyeOl.Text = "Üye Ol";
            LnkUyeOl.LinkClicked += LnkUyeOl_LinkClicked;
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(137, 149);
            TxtSifre.Margin = new Padding(5);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(321, 40);
            TxtSifre.TabIndex = 10;
            TxtSifre.Text = "1234";
            TxtSifre.UseSystemPasswordChar = true;
            // 
            // MskTC
            // 
            MskTC.Location = new Point(137, 103);
            MskTC.Margin = new Padding(5);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(321, 40);
            MskTC.TabIndex = 9;
            MskTC.Text = "10268754126";
            MskTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 149);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 33);
            label3.TabIndex = 7;
            label3.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 106);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(131, 33);
            label2.TabIndex = 8;
            label2.Text = "TC kimlik:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(210, 25);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(302, 39);
            label1.TabIndex = 6;
            label1.Text = "Hasta Giriş Paneli";
            // 
            // FrmHastaGiris
            // 
            AcceptButton = BtnGiris;
            AutoScaleDimensions = new SizeF(15F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(603, 273);
            Controls.Add(BtnGiris);
            Controls.Add(LnkUyeOl);
            Controls.Add(TxtSifre);
            Controls.Add(MskTC);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Corbel", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FrmHastaGiris";
            Text = "FrmHastaGiris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnGiris;
        private LinkLabel LnkUyeOl;
        private TextBox TxtSifre;
        private MaskedTextBox MskTC;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}