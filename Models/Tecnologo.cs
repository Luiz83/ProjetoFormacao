namespace ProjetoFormacao.Models
{
    public class Tecnologo : Formacao
    {
        private bool PlanoEstendido { get; set; }

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
            mensalidade = GetDuracao() * 3 * 8;
            SetMensalidade(mensalidade);
        }
    }
}