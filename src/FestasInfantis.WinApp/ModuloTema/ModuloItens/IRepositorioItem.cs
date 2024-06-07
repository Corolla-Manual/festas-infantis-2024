
namespace FestasInfantis.WinApp.ModuloTema.ModuloItens
{
    public interface IRepositorioItem
    {
        void Cadastrar(Item novoItem);
        void LimparDesmarcados(Tema tema);
        bool Editar(int id, Item itemEditado);
        bool Excluir(int id);
        Item SelecionarPorId(int v);
        List<Item> SelecionarTodos();
        void AdicionarDependencia(Tema novoTema);
        void AtualizarDependencia(Tema antigoTema, Tema novoTema);
    }
}
