namespace Jogo
{
    public struct Pergunta
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
}
