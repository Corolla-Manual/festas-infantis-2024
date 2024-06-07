using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloAluguel;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public class RepositorioClienteEmMemoria : RepositorioBaseEmMemoria<Cliente>, IRepositorioCliente
    {
        public void AdicionarDependencia(Aluguel novoAluguel)
        {
            throw new NotImplementedException();
        }

        public void AtualizarDependencia(Aluguel aluguelSelecionado, Aluguel aluguelEditado)
        {
            throw new NotImplementedException();
        }
    }
}
