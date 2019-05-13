using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Jogo
{
    public struct Perguntas
    {
        public int id_pergunta;
        public string enunciado;
        public string alternativa_v;
        public string alternativa_f1;
        public string alternativa_f2;
        public string alternativa_f3;
        public int resposta;
        public string nivel;

        public string respostaCorreta
        {
            get
            {
                if (resposta == 1)
                {
                    return alternativa_v;
                }
                else if (resposta == 2)
                {
                    return alternativa_f1;
                }
                else if (resposta == 3)
                {
                    return alternativa_f2;
                }
                else
                {
                    return alternativa_f3;
                }
            }
        }
    }

    class Jogo
    {
        private static Jogo instance;

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

        private Jogo()
        {
            valores = new List<Tuple<int, int>>();

            valores.Add(Tuple.Create(1, 1000));
            valores.Add(Tuple.Create(2, 2000));
            valores.Add(Tuple.Create(3, 3000));
            valores.Add(Tuple.Create(4, 4000));
            valores.Add(Tuple.Create(5, 5000));
            valores.Add(Tuple.Create(6, 10000));
            valores.Add(Tuple.Create(7, 20000));
            valores.Add(Tuple.Create(8, 30000));
            valores.Add(Tuple.Create(9, 40000));
            valores.Add(Tuple.Create(10, 50000));
            valores.Add(Tuple.Create(11, 100000));
            valores.Add(Tuple.Create(12, 200000));
            valores.Add(Tuple.Create(13, 300000));
            valores.Add(Tuple.Create(14, 400000));
            valores.Add(Tuple.Create(15, 500000));
            valores.Add(Tuple.Create(16, 1000000));

            valorAtual = 0;
            nivelAtual = 1;
            contaPulo = 3;

            questoesNivelA = new List<Perguntas>();
            questoesNivelB = new List<Perguntas>();
            questoesNivelC = new List<Perguntas>();
            questoesNivelD = new List<Perguntas>();

            popularPerguntas();

            inicializado = false;
            errouPergunta = false;
        }

        /// <summary>
        /// Tabela de valores
        /// </summary>
        public List<Tuple<int, int>> valores;

        /// <summary>
        /// Representa a quantidade de dinheiro acumulada pelo jogador até o momento
        /// </summary>
        public int valorAtual;

        /// <summary>
        /// Representa a quantidade de questões respondidas pelo jogador até o momento.
        /// </summary>
        public int questoesRespondidas;

        /// <summary>
        /// Representa o nivel atual do jogador (1 a 16)
        /// </summary>
        public int nivelAtual;

        /// <summary>
        /// Indica se o jogo foi inicializado. Usado pelo construtor da tela principal, para carregar primeira pergunta
        /// </summary>
        public bool inicializado;

        /// <summary>
        /// Indica se usuario errou pergunta. Usado pela tela final para exibir ou nao a resposta correta
        /// </summary>
        public bool errouPergunta;

        /// <summary>
        /// Representa quantidade de pulos que usuario pode realizar
        /// </summary>
        public int contaPulo;

        /// <summary>
        /// Instancia de struct com a questao no momento.
        /// </summary>
        public Perguntas questaoAtual;

        public List<Perguntas> questoesNivelA;
        public List<Perguntas> questoesNivelB;
        public List<Perguntas> questoesNivelC;
        public List<Perguntas> questoesNivelD;

        public int Premio
        {
            get
            {
                return valores[nivelAtual - 1].Item2; //-1 pq indices de lista tamanho 'n' vão de 0 até n-1
            }
        }

        /// <summary>
        /// Inicia estado do jogo
        /// </summary>
        public void iniciar()
        {
            valorAtual = 0;
            nivelAtual = 1;
            contaPulo = 3;
            questoesNivelA.Clear();
            questoesNivelB.Clear();
            questoesNivelC.Clear();
            questoesNivelD.Clear();
            popularPerguntas();
            inicializado = true;
        }

        /// <summary>
        /// Usado para retornar letra do nivel (A, B, C, ou D)
        /// </summary>
        /// <param name="nivelInt">Representa nivel atual em inteiros (1 a 16)</param>
        /// <returns>Representacao em letra do nivel atual, usado para filtro da busca no SQL</returns>
        private string getNivel(int nivelInt)
        {
            if (nivelInt >= 1 && nivelInt <= 5)
            {
                return "A";
            }
            else if (nivelInt >= 6 && nivelInt <= 10)
            {
                return "B";
            }
            else if (nivelInt >= 11 && nivelInt <= 15)
            {
                return "C";
            }
            else
            {
                return "D";
            }
        }

        //Fazer o Form responsável para chamar esta função
        private void popularPerguntas()//Função responsável para conexão com o banco de dados e polpular as perguntas
        {
            using (MySqlConnection conexao = new MySqlConnection("datasource=sql172.main-hosting.eu;port=3306;username=u727992112_cnp;password=telaazul404;database=u727992112_cnp"))
            {
                //@"Server =.\SQLEXPRESS;Database=NomeDoBanco;Integrated Security=True;User Instance=True"
                //datasource = sql172.main - hosting.eu; port = 3306; username = u727992112_cnp; password = telaazul404; database = u727992112_cnp
                try
                {
                    conexao.Open();
                    string query = string.Format("SELECT * FROM perguntas");
                    MySqlCommand sqlcommand = new MySqlCommand(query, conexao);
                    //sqldatareader retorna somente os valores, o usuario requisita os dados e o sql retora os mesmos, isso torna mais rápido o acesso
                    MySqlDataReader sqlreader = sqlcommand.ExecuteReader();
                    if (sqlreader.HasRows)
                    {
                        while (sqlreader.Read())
                        {

                            Perguntas p = new Perguntas();
                            p.id_pergunta = (int)sqlreader["id_pergunta"];
                            p.enunciado = (string)sqlreader["enunciado"];
                            p.alternativa_v = (string)sqlreader["alternativa_v"];
                            p.alternativa_f1 = (string)sqlreader["alternativa_f1"];
                            p.alternativa_f2 = (string)sqlreader["alternativa_f2"];
                            p.alternativa_f3 = (string)sqlreader["alternativa_f3"];
                            // p.resposta = (int)sqlreader["respostacorreta"];
                            p.nivel = (string)sqlreader["tipo"];
                            if (p.nivel == "A")
                            {
                                questoesNivelA.Add(p);
                            }
                            else if (p.nivel == "B")
                            {
                                questoesNivelB.Add(p);
                            }
                            else if (p.nivel == "C")
                            {
                                questoesNivelC.Add(p);
                            }
                            else
                            {
                                questoesNivelD.Add(p);
                            }

                        }
                    }
                    sqlreader.Close();

                }
                catch (Exception e)
                {

                    MessageBox.Show("Erro ao conectar com o banco de dados" + e.Message);
                }

            }
        }

        public void MudarPerguntas()
        {
            Random r = new Random();
            string nivelChar = getNivel(nivelAtual);
            List<Perguntas> listaPerguntas = new List<Perguntas>();

            if (nivelChar == "A")
            {
                listaPerguntas = questoesNivelA;
            }
            else if (nivelChar == "B")
            {
                listaPerguntas = questoesNivelB;
            }
            else if (nivelChar == "C")
            {
                listaPerguntas = questoesNivelC;
            }
            else if (nivelChar == "D")
            {
                listaPerguntas = questoesNivelD;
            }

            int randomIndex = r.Next(listaPerguntas.Count);
            questaoAtual = listaPerguntas[randomIndex];
            listaPerguntas.RemoveAt(randomIndex);
        }

    }
}
