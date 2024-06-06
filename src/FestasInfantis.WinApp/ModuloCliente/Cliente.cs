using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloAluguel;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public class Cliente : EntidadeBase
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public List<Aluguel> Alugueis { get; set; }

        public Cliente()
        {

        }
        public Cliente(string nome, string telefone, string cpf)
        {
            Nome = nome;
            Telefone = telefone;
            Cpf = cpf;
            Alugueis = new List<Aluguel>();
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Cliente c = (Cliente)novoRegistro;

            Nome = c.Nome;
            Telefone = c.Telefone;
            Cpf = c.Cpf;
            Alugueis = c.Alugueis;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            if (string.IsNullOrEmpty(Telefone.Trim()))
                erros.Add("O campo \"telefone\" é obrigatório");

            if (string.IsNullOrEmpty(Cpf.Trim()))
                erros.Add("O campo \"cpf\" é obrigatório");

            return erros;
        }

        public override string ToString()
        {
            return $"{Nome}";
        }
    }
}
