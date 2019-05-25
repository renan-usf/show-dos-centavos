using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Jogo
{
    public class Jogo
    {
        private static Jogo instance;
        private Form formPergunta;

        public static Jogo Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Jogo();
                }
                return instance;
            }
        }

        /// <summary>
        /// Representa a quantidade de dinheiro acumulada pelo jogador até o momento
        /// </summary>
        public int valorAtual;

        /// <summary>
        /// Representa o nível do jogo em que o jogador está no momento (de 0 a 3)
        /// </summary>
        public int nivelAtual;

        /// <summary>
        /// Representa a quantidade de questões respondidas pelo jogador até o momento.
        /// </summary>
        public int questoesRespondidas;

        /// <summary>
        /// Representa quantidade de erros que usuario pode realizar
        /// </summary>
        public int contaErro;

        /// <summary>
        /// Todas as perguntas de um jogo.
        /// </summary>
        public PerguntasTupla perguntas;

        /// <summary>
        /// Inicia estado do jogo
        /// </summary>
        public void iniciar(PerguntasTupla perguntas)
        {
            this.perguntas = perguntas;

            valorAtual = 0;
            nivelAtual = 0;
            contaErro = 3;

            inserirPergunta();
        }

        /// <summary>
        /// Usado para retornar letra do nivel (A, B, C, ou D)
        /// </summary>
        /// <param name="nivelInt">Representa nivel atual em inteiros (0 a 3)</param>
        /// <returns>Representacao em letra do nivel atual, usado para filtro da busca no SQL</returns>
        private string getNivel(int nivelInt)
        {
            if (nivelInt == 0)
            {
                return "A";
            }
            else if (nivelInt == 1)
            {
                return "B";
            }
            else if (nivelInt == 2)
            {
                return "C";
            }
            else
            {
                return "D";
            }
        }

        private List<Pergunta> getPerguntasNível()
        {
            string nivelChar = getNivel(nivelAtual);

            if (nivelChar == "A")
                return perguntas.nivelA;
            else if (nivelChar == "B")
                return perguntas.nivelB;
            else if (nivelChar == "C")
                return perguntas.nivelC;
            else
                return perguntas.nivelD;
        }

        // Insere a próxima pergunta no jogo
        private void inserirPergunta()
        {
            List<Pergunta> perguntasNivel = getPerguntasNível();

            // Verifica se o jogador não subiu de nível
            if (perguntasNivel.Count == 0 && nivelAtual != 4)
            {
                nivelAtual++;
                perguntasNivel = getPerguntasNível();
            }

            if (nivelAtual == 4)
                finalizar();
            else {
                Random r = new Random();
                Pergunta perguntaEscolhida;

                int randomIndex = r.Next(perguntasNivel.Count);
                perguntaEscolhida = perguntasNivel[randomIndex];
                perguntasNivel.RemoveAt(randomIndex);

                formPergunta = new Form1(instance, perguntaEscolhida);
                formPergunta.Show();
            }
        }

        public void acertou()
        {
            MessageBox.Show("Parabéns você acertou =)");
            inserirPergunta();
        }

        public void errou()
        {
            MessageBox.Show("Que pena você errou =(");
            inserirPergunta();
        }

        private void finalizar()
        {
            MessageBox.Show("Acabaram todas as perguntas");
            Application.Exit();
        }
    }
}
