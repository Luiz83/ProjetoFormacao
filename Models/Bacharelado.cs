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
            string engenharia = "engenharia";
            bool CursaEngenahria = GetDescricao().Contains(engenharia);
            if (CursaEngenahria)
            {
                SetDuracao(60);
            }
            else
            {
                SetDuracao(48);
            }
        }

        public override void CalcularMensalidade()
        {
            var mensalidade = 0.0;
            mensalidade = (GetDuracao() * 3 * 8) + (GetCargaHorarioEstagio() * 12);
            SetMensalidade(mensalidade);
        }
    }
}