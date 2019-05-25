using System;
using System.Windows.Forms;

namespace Jogo
{
    public partial class MenuPrincipal : Form
    {

        private Connection conn;
        private Jogo jogo;

        public MenuPrincipal()
        {
            InitializeComponent();
            conn = Connection.Instance;
        }

        private void btnConect_Click(object sender, EventArgs e)
        {
            string connString =
                "datasource=" + tbUrl.Text + ";port=3306;" +
                "username=" + tbUser.Text + ";password=" + tbPassword.Text +
                ";database=" + tbDatabase.Text + ";";

            panelJogar.Visible = conn.connect(connString);
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            jogo = Jogo.Instance;
            jogo.iniciar(conn.getPerguntas());

            Hide();
        }
    }
}
