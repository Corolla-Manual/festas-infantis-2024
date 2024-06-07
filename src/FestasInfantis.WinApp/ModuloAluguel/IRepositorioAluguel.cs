namespace FestasInfantis.WinApp.ModuloAluguel
{
    public interface IRepositorioAluguel
    {
        void Cadastrar(Aluguel novoAluguel);
        bool Editar(int id, Aluguel aluguelEditado);
        bool Excluir(int id);
        Aluguel SelecionarPorId(int v);
        List<Aluguel> SelecionarTodos();
        List<Aluguel> SelecionarAlugueisConcluidos();
        List<Aluguel> SelecionarAlugueisPendentes();

    }
}
