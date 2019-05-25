using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Jogo
{
    class Connection
    {
        public List<Pergunta> questoesNivelA;
        public List<Pergunta> questoesNivelB;
        public List<Pergunta> questoesNivelC;
        public List<Pergunta> questoesNivelD;

        private PerguntasTupla perguntas;

        private static Connection instance;

        public static Connection Instance
        {
            get
            {
                if (instance == null)
                    instance = new Connection();

                return instance;
            }
        }

        private Connection()
        {
            questoesNivelA = new List<Pergunta>();
            questoesNivelB = new List<Pergunta>();
            questoesNivelC = new List<Pergunta>();
            questoesNivelD = new List<Pergunta>();
        }

        //Função responsável para conexão com o banco de dados e polpular as perguntas
        public bool connect(string connString)
        {
            using (MySqlConnection conexao = new MySqlConnection(connString))
            {
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

                            Pergunta p = new Pergunta();
                            p.id_pergunta = (int)sqlreader["id_pergunta"];
                            p.enunciado = (string)sqlreader["enunciado"];
                            p.alternativa_v = (string)sqlreader["alternativa_v"];
                            p.alternativa_f1 = (string)sqlreader["alternativa_f1"];
                            p.alternativa_f2 = (string)sqlreader["alternativa_f2"];
                            p.alternativa_f3 = (string)sqlreader["alternativa_f3"];
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
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro ao conectar com o banco de dados\n" + e.Message);
                    return false;
                }
            }
        }


        public PerguntasTupla getPerguntas()
        {
            PerguntasTupla perguntas = new PerguntasTupla();

            perguntas.nivelA = questoesNivelA;
            perguntas.nivelB = questoesNivelB;
            perguntas.nivelC = questoesNivelC;
            perguntas.nivelD = questoesNivelD;

            return perguntas;
        }

    }
}
