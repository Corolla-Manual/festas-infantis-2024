using FestasInfantis.WinApp.ModuloAluguel;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public interface IRepositorioCliente
    {
        void AdicionarDependencia(Aluguel novoAluguel);
        void AtualizarDependencia(Aluguel aluguelSelecionado, Aluguel aluguelEditado);
        void Cadastrar(Cliente novoCliente);
        bool Editar(int id, Cliente clienteEditado);
        bool Excluir(int id);
        Cliente SelecionarPorId(int v);
        List<Cliente> SelecionarTodos();

    }
}
