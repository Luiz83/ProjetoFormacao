namespace ProjetoFormacao.Models
{
    public class Tecnologo : Formacao
    {
        private bool PlanoEstendido { get; set; }

        public Tecnologo(string descricao, int periodo, bool planoEstendido) : base(descricao, periodo)
        {
            SetPlanoEstendido(planoEstendido); ;
        }

        public void SetPlanoEstendido(bool planoEstendido)
        {
            PlanoEstendido = planoEstendido;
        }
        public bool GetPlanoEstendido()
        {
            return PlanoEstendido;
        }

        public override void DefinirDuracao()
        {
            SetDuracao(24);
        }

        public override void CalcularMensalidade()
        {
            var mensalidade = 0.0;
            mensalidade = GetDuracao() * GetPeriodo() * 8;
            SetMensalidade(mensalidade);
        }
    }
}