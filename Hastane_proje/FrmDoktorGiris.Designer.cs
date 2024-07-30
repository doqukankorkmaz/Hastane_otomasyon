namespace Hastane_proje
{
    partial class FrmDoktorGiris
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
            TxtSifre = new TextBox();
            MskTC = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // BtnGiris
            // 
            BtnGiris.Location = new Point(338, 286);
            BtnGiris.Margin = new Padding(6, 5, 6, 5);
            BtnGiris.Name = "BtnGiris";
            BtnGiris.Size = new Size(130, 52);
            BtnGiris.TabIndex = 12;
            BtnGiris.Text = "Giriş";
            BtnGiris.UseVisualStyleBackColor = true;
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(234, 236);
            TxtSifre.Margin = new Padding(6, 5, 6, 5);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(234, 40);
            TxtSifre.TabIndex = 10;
            // 
            // MskTC
            // 
            MskTC.Location = new Point(234, 164);
            MskTC.Margin = new Padding(6, 5, 6, 5);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(234, 40);
            MskTC.TabIndex = 9;
            MskTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 239);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 35);
            label3.TabIndex = 7;
            label3.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 164);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 35);
            label2.TabIndex = 8;
            label2.Text = "TC kimlik:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(162, 60);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(322, 39);
            label1.TabIndex = 6;
            label1.Text = "Doktor Giriş Paneli";
            // 
            // FrmDoktorGiris
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(562, 406);
            Controls.Add(BtnGiris);
            Controls.Add(TxtSifre);
            Controls.Add(MskTC);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Corbel", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(6, 5, 6, 5);
            Name = "FrmDoktorGiris";
            Text = "FrmDoktorGiris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnGiris;
        private TextBox TxtSifre;
        private MaskedTextBox MskTC;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}