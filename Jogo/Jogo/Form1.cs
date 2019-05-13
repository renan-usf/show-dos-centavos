using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo
{
    public partial class Form1 : Form
    {
        private Jogo jogo;

        public Form1()
        {
            InitializeComponent();
            jogo = Jogo.Instance;

            // Teste da classe de jogo
            jogo.MudarPerguntas();
            label1.Text = jogo.questaoAtual.enunciado;
        }
    }
}
