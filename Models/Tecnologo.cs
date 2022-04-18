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

        }

        public override void CalcularMensalidade()
        {

        }
    }
}