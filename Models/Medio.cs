namespace ProjetoFormacao.Models
{
    public class Medio : Formacao
    {
        private string Tipo { get; set; }

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

        }

        public override void CalcularMensalidade()
        {

        }
    }
}