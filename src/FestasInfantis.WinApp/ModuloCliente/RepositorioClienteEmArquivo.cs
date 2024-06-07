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

        public void AdicionarDependencia(Aluguel novoAluguel)
        {
            Cliente cliente = contexto.Clientes.Find(i => i == novoAluguel.Cliente);
            cliente.Alugueis.Add(novoAluguel);
            base.Editar(cliente.Id, cliente);
        }

        public void AtualizarDependencia(Aluguel aluguelSelecionado, Aluguel aluguelEditado)
        {
            Aluguel aluguelARemover = new Aluguel();

            foreach (Cliente i in contexto.Clientes)
            {
                foreach (Aluguel a in i.Alugueis)
                {
                    if (aluguelSelecionado.Cliente.Nome == a.Cliente.Nome)
                        aluguelARemover = a;
                    break;
                }
                if (aluguelARemover.Cliente != null)
                    break;
            }

            Cliente cliente = contexto.Clientes.Find(c => c.Alugueis.Contains(aluguelARemover));
            if (cliente != null)
                cliente.Alugueis.Remove(aluguelARemover);

            cliente = contexto.Clientes.Find(i => i == aluguelEditado.Cliente);
            cliente.Alugueis.Add(aluguelEditado);
        }
    }
}
