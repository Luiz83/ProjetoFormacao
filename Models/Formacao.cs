namespace ProjetoFormacao.Models
{
    public class Formacao
    {
        private string Descricao { get; set; }
        private int Periodo { get; set; }
        private double Mensalidade { get; set; }
        private int Duracao { get; set; }

        public void SetDescricao(string descricao)
        {
            Descricao = descricao;
        }
        public string GetDescricao()
        {
            return Descricao;
        }
        public void SetPeriodo(int periodo)
        {
            Periodo = periodo;
        }
        public int GetPeriodo()
        {
            return Periodo;
        }
        public void SetMensalidade(double mensalidade)
        {
            Mensalidade = mensalidade;
        }
        public double GetMensalidade()
        {
            return Mensalidade;
        }
        public void SetDuracao(int duracao)
        {
            Duracao = duracao;
        }
        public int GetDuracao()
        {
            return Duracao;
        }

        public double ExibirMedia(double provaSemestralUm, double provaSemestralDois)
        {
            var media = 0.0;
            return media;
        }

        public double ExibirMedia(double provaSemestralUm, double provaSemestralDois, double trabalhoSemestralUm,
                                  double trabalhoSemestralDois)
        {
            var media = 0.0;
            return media;
        }

        public double ExibirMedia(double provaSemestralUm, double provaSemestralDois, double trabalhoSemestralUm,
                                  double trabalhoSemestralDois, double provaMensalUm, double provaMensalDois)
        {
            var media = 0.0;
            return media;
        }

        public virtual void DefinirDuracao()
        {

        }

        public virtual void CalcularMensalidade()
        {

        }

    }
}