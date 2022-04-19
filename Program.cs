using ProjetoFormacao.Models;
namespace ProjetoFormacao;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual curso você deseja cadastrar? 1 - Medio / 2 - Tecnologo / 3 - Bacharelado / 4 - Bacharelado em Engenahria");
        var opcao = int.Parse(Console.ReadLine());
        var formacao = new Formacao("default", 0);
        switch (opcao)
        {
            case 1:
                formacao = new Medio("Ensino Medio", 1, "Integral");
                break;
            case 2:
                formacao = new Tecnologo("Mecatronica", 2, true);
                break;
            case 3:
                formacao = new Bacharelado("Ciencia da Computação", 3, "API", 120);
                break;
            case 4:
                formacao = new Bacharelado("Engenharia Civil", 3, "Projeto Casa", 180);
                break;
            default:
                break;
        }
        Console.WriteLine("Você está cursando " + formacao.GetDescricao());
        Console.WriteLine("Com a duracao de " + formacao.GetDuracao() + " meses");
        Console.WriteLine("A mensalidade no valor de R$" + formacao.GetMensalidade() + " reais");
        Console.WriteLine(formacao.ExibirMedia(8,9));
        Console.WriteLine(formacao.ExibirMedia(7,6,10,9));
        Console.WriteLine(formacao.ExibirMedia(10,8,7,10,9,9));

    }
}

