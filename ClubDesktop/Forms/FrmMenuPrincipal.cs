using ClubDesktop.Forms;

namespace ClubDesktop
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void gestiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSocios frmSocios = new FrmSocios();
            frmSocios.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmSocios frmSocios = new FrmSocios();
            frmSocios.ShowDialog();
        }
    }
}