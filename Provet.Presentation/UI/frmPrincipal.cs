namespace Provet.Presentation.UI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal(string nome, string nomeUsuario, int perfilId)
        {
            InitializeComponent();

            statusStrip1.Items[0].Text = $"Hoje é {DateTime.Now:D} |";
            statusStrip1.Items[2].Text = $"Usuário logado: {nome}";
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusStrip1.Items[1].Text = $"Agora são: {DateTime.Now:T} |";
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre frmSobre = new();
            frmSobre.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new();
            frmLogin.Show();
            Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
