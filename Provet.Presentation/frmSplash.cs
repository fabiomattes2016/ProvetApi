namespace Provet.Presentation
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;

            if(panel2.Width >= 651)
            {
                timer1.Stop();
                frmLogin login = new();
                login.Show();

                this.Hide();
            }
        }
    }
}