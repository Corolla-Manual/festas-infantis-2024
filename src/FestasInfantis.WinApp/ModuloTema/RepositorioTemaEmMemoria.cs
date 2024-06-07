using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloAluguel;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class RepositorioTemaEmMemoria : RepositorioBaseEmMemoria<Tema>, IRepositorioTema
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
