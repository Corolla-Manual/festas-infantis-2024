using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloAluguel;

namespace FestasInfantis.WinApp.ModuloCliente
{
    internal class RepositorioClienteEmArquivo : RepositorioBaseEmArquivo<Cliente>, IRepositorioCliente
    {
        public RepositorioClienteEmArquivo(ContextoDados contexto) : base(contexto)
        {
            if (contexto.Clientes.Any())
                contadorId = contexto.Clientes.Max(i => i.Id) + 1;
        }
        protected override List<Cliente> ObterRegistros()
        {
            return contexto.Clientes;
        }
        public override bool Excluir(int id)
        {
            Cliente cliente = SelecionarPorId(id);

            Aluguel aluguelRelacionados = contexto.Alugueis.Find(x => x.Cliente == cliente);
            if (aluguelRelacionados != null)
                aluguelRelacionados.Cliente = null;

            return base.Excluir(id);
        }
    }
}
