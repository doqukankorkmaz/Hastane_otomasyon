namespace Hastane_proje
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void BtnHastaGirisi_Click(object sender, EventArgs e)
        {
            FrmHastaGiris frm = new FrmHastaGiris();
            frm.Show();//frmhastagiris gösterir
            this.Hide();//FrmGirisler kýsmýný gizler
        }

        private void BtnDoktorGirisi_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris frm = new FrmDoktorGiris();
            frm.Show();//frmDoktorgiris gösterir
            this.Hide();//FrmGirisler kýsmýný gizler
        }

        private void BtnSekreterGirisi_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris frm = new FrmSekreterGiris();
            frm.Show();//frmsekretergiris gösterir
            this.Hide();//FrmGirisler kýsmýný gizler
        }
    }
}
