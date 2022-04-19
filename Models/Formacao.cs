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
            media = CalcularMediaBasica(provaSemestralUm, provaSemestralDois) * 0.5;
            return media;
        }

        public double ExibirMedia(double provaSemestralUm, double provaSemestralDois, double trabalhoSemestralUm,
                                  double trabalhoSemestralDois)
        {
            var media = 0.0;
            media = ((CalcularMediaBasica(provaSemestralUm, provaSemestralDois) * 0.5) +
                    (CalcularMediaBasica(trabalhoSemestralUm, trabalhoSemestralDois) * 0.2));
            return media;
        }

        public double ExibirMedia(double provaSemestralUm, double provaSemestralDois, double trabalhoSemestralUm,
                                  double trabalhoSemestralDois, double provaMensalUm, double provaMensalDois)
        {
            var media = 0.0;
            media = ((CalcularMediaBasica(provaSemestralUm, provaSemestralDois) * 0.5) +
                    (CalcularMediaBasica(trabalhoSemestralUm, trabalhoSemestralDois) * 0.2) +
                    (CalcularMediaBasica(provaMensalUm, provaMensalDois) * 0.3));
            return media;
        }

        public double CalcularMediaBasica(double valorUm, double valorDois)
        {
            var mediaBasica = 0.0;
            mediaBasica = (valorUm + valorDois) / 2;
            return mediaBasica;
        }

        public virtual void DefinirDuracao()
        {

        }

        public virtual void CalcularMensalidade()
        {

        }

    }
}