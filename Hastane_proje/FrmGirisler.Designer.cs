namespace Hastane_proje
{
    partial class FrmGirisler
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnHastaGirisi = new Button();
            BtnDoktorGirisi = new Button();
            BtnSekreterGirisi = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // BtnHastaGirisi
            // 
            BtnHastaGirisi.Location = new Point(61, 63);
            BtnHastaGirisi.Margin = new Padding(6, 4, 6, 4);
            BtnHastaGirisi.Name = "BtnHastaGirisi";
            BtnHastaGirisi.Size = new Size(249, 101);
            BtnHastaGirisi.TabIndex = 0;
            BtnHastaGirisi.Text = "Hasta";
            BtnHastaGirisi.UseVisualStyleBackColor = true;
            BtnHastaGirisi.Click += BtnHastaGirisi_Click;
            // 
            // BtnDoktorGirisi
            // 
            BtnDoktorGirisi.Location = new Point(343, 63);
            BtnDoktorGirisi.Margin = new Padding(6, 4, 6, 4);
            BtnDoktorGirisi.Name = "BtnDoktorGirisi";
            BtnDoktorGirisi.Size = new Size(275, 101);
            BtnDoktorGirisi.TabIndex = 0;
            BtnDoktorGirisi.Text = "Doktor";
            BtnDoktorGirisi.UseVisualStyleBackColor = true;
            BtnDoktorGirisi.Click += BtnDoktorGirisi_Click;
            // 
            // BtnSekreterGirisi
            // 
            BtnSekreterGirisi.Location = new Point(648, 63);
            BtnSekreterGirisi.Margin = new Padding(6, 4, 6, 4);
            BtnSekreterGirisi.Name = "BtnSekreterGirisi";
            BtnSekreterGirisi.Size = new Size(270, 101);
            BtnSekreterGirisi.TabIndex = 0;
            BtnSekreterGirisi.Text = "Sekreter";
            BtnSekreterGirisi.UseVisualStyleBackColor = true;
            BtnSekreterGirisi.Click += BtnSekreterGirisi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 184);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 27);
            label1.TabIndex = 1;
            label1.Text = "hasta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(425, 184);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 27);
            label2.TabIndex = 1;
            label2.Text = "doktor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(730, 184);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(135, 27);
            label3.TabIndex = 1;
            label3.Text = "sekreter";
            // 
            // FrmGirisler
            // 
            AutoScaleDimensions = new SizeF(15F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(967, 260);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnSekreterGirisi);
            Controls.Add(BtnDoktorGirisi);
            Controls.Add(BtnHastaGirisi);
            Font = new Font("Stencil", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 4, 6, 4);
            MaximizeBox = false;
            Name = "FrmGirisler";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnHastaGirisi;
        private Button BtnDoktorGirisi;
        private Button BtnSekreterGirisi;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
