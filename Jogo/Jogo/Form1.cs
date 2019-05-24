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
        int mudar = 0;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            jogo = Jogo.Instance;

            atualizarQuestoes();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            bool acertou = false;
            if (mudar == 0)
            {

                if (checkBox1.CheckState == CheckState.Checked)
                {
                    acertou = true;                    
                }
            }
            if (mudar == 1)
            {

                if (checkBox2.CheckState == CheckState.Checked)
                {
                    acertou = true;
                }
            }
            if (mudar == 2)
            {
                if (checkBox3.CheckState == CheckState.Checked)
                {
                    acertou = true;
                }
            }
            if (mudar == 3)
            {

                if (checkBox4.Checked == true)
                {
                    acertou = true;
                }

            }
            if (acertou == true)
            {
                MessageBox.Show("Acertou!");
                jogo.questoesRespondidas++;
            }
            else
                MessageBox.Show("Errou!");

            // MessageBox.Show("Você possui " + Convert.ToString(jogo.questoesRespondidas) + " acertos!");
            atualizarQuestoes();

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void lblResposta1_Click(object sender, EventArgs e)
        {

        }

        private void atualizarQuestoes()
        {
            jogo.MudarPerguntas();
            lblEnunciado.Text = jogo.questaoAtual.enunciado;
            mudar = rand.Next(0, 4);
            // MessageBox.Show(Convert.ToString(mudar));
            switch (mudar)
            {
                case 0:
                    lblResposta1.Text = jogo.questaoAtual.alternativa_v;
                    lblResposta2.Text = jogo.questaoAtual.alternativa_f1;
                    lblResposta3.Text = jogo.questaoAtual.alternativa_f3;
                    lblResposta4.Text = jogo.questaoAtual.alternativa_f2;
                    break;
                case 1:
                    lblResposta1.Text = jogo.questaoAtual.alternativa_f2;
                    lblResposta2.Text = jogo.questaoAtual.alternativa_v;
                    lblResposta3.Text = jogo.questaoAtual.alternativa_f3;
                    lblResposta4.Text = jogo.questaoAtual.alternativa_f1;
                    break;
                case 2:
                    lblResposta1.Text = jogo.questaoAtual.alternativa_f3;
                    lblResposta2.Text = jogo.questaoAtual.alternativa_f2;
                    lblResposta3.Text = jogo.questaoAtual.alternativa_v;
                    lblResposta4.Text = jogo.questaoAtual.alternativa_f1;
                    break;
                case 3:
                    lblResposta1.Text = jogo.questaoAtual.alternativa_f3;
                    lblResposta2.Text = jogo.questaoAtual.alternativa_f1;
                    lblResposta3.Text = jogo.questaoAtual.alternativa_f2;
                    lblResposta4.Text = jogo.questaoAtual.alternativa_v;
                    break;
                case 4:
                default:
                    break;
            }

        }
    }
}
