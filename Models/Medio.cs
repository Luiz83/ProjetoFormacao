namespace ProjetoFormacao.Models
{
    public class Medio : Formacao
    {
        private string Tipo { get; set; }

        public Medio(string descricao, int periodo, string tipo) : base(descricao, periodo)
        {
            SetTipo(tipo);
        }

        public void SetTipo(string tipo)
        {
            Tipo = tipo;
        }
        public string GetTipo()
        {
            return Tipo;
        }

        public override void DefinirDuracao()
        {
            SetDuracao(36);
        }

        public override void CalcularMensalidade()
        {
            var mensalidade = 0.0;
            mensalidade = GetDuracao() * GetPeriodo() * 7;
            SetMensalidade(mensalidade);
        }
    }
}