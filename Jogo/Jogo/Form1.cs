using System;
using System.Windows.Forms;

namespace Jogo
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int mudar;
        Jogo jogo;

        public Form1(Jogo jogo, Pergunta p)
        {
            this.jogo = jogo;
            InitializeComponent();
            InserirQuestao(p);
        }

        public void InserirQuestao(Pergunta p)
        {
            lblEnunciado.Text = p.enunciado;
            mudar = rand.Next(0, 4);

            switch (mudar)
            {
                case 0:
                    lblResposta1.Text = p.alternativa_v;
                    lblResposta2.Text = p.alternativa_f1;
                    lblResposta3.Text = p.alternativa_f3;
                    lblResposta4.Text = p.alternativa_f2;
                    break;
                case 1:
                    lblResposta1.Text = p.alternativa_f2;
                    lblResposta2.Text = p.alternativa_v;
                    lblResposta3.Text = p.alternativa_f3;
                    lblResposta4.Text = p.alternativa_f1;
                    break;
                case 2:
                    lblResposta1.Text = p.alternativa_f3;
                    lblResposta2.Text = p.alternativa_f2;
                    lblResposta3.Text = p.alternativa_v;
                    lblResposta4.Text = p.alternativa_f1;
                    break;
                case 3:
                    lblResposta1.Text = p.alternativa_f3;
                    lblResposta2.Text = p.alternativa_f1;
                    lblResposta3.Text = p.alternativa_f2;
                    lblResposta4.Text = p.alternativa_v;
                    break;
                case 4:
                default:
                    break;
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(mudar == 0)
            {
                jogo.acertou();
            }
            else
            {
                jogo.errou();
            }
            Dispose(true);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (mudar == 1)
            {
                jogo.acertou();
            }
            else
            {
                jogo.errou();
            }
            Dispose(true);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (mudar == 2)
            {
                jogo.acertou();
            }
            else
            {
                jogo.errou();
            }
            Dispose(true);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (mudar == 3)
            {
                jogo.acertou();
            }
            else
            {
                jogo.errou();
            }
            Dispose(true);
        }
    }
}
