using Provet.Entities.Entities;
using Provet.Presentation.Services.Autenticacao;
using Provet.Presentation.UI;
using Provet.Presentation.Utils;

namespace Provet.Presentation
{
    public partial class frmLogin : Form
    {
        string _nome;
        string _nomeUsuario;
        int _perfilId;

        private readonly UsuarioService usuarioService = new();
        private readonly Helpers helpers = new();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = txtUsuario.Text;
                var senha = txtSenha.Text;

                var result = await usuarioService.Login(usuario, senha);

                var isAuthenticated = Convert.ToBoolean(result.StackTrace);

                if (result.Data != null)
                {
                    var usuarioLogadoString = result.Data.ToString();
                    var usuarioLogadoObjeto = helpers.ParseObject<Usuario>(usuarioLogadoString);

                    _nome = usuarioLogadoObjeto.Nome;
                    _nomeUsuario = usuarioLogadoObjeto.NomeUsuario;
                    //_perfilId = usuarioLogadoObjeto.PerfilId;
                }

                if (isAuthenticated == false)
                {
                    MessageBox.Show(result.Message);
                }
                else
                {
                    frmPrincipal frmPrincipal = new(_nome, _nomeUsuario, _perfilId);
                    frmPrincipal.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
