namespace ProjetoFormacao.Models
{
    public class Bacharelado : Formacao
    {
        private string ProjetoConclusao { get; set; }
        private int CargaHorarioEstagio { get; set; }

        public void SetProjetoConclusao(string projetoConclusao)
        {
            ProjetoConclusao = projetoConclusao;
        }
        public string GetProjetoConclusao()
        {
            return ProjetoConclusao;
        }
        public void SetCargaHorarioEstagio(int cargaHoraria)
        {
            CargaHorarioEstagio = cargaHoraria;
        }
        public int GetCargaHorarioEstagio()
        {
            return CargaHorarioEstagio;
        }

        public override void DefinirDuracao()
        {

        }

        public override void CalcularMensalidade()
        {

        }
    }
}