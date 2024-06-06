using FestasInfantis.WinApp.ModuloAluguel;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloDesconto;
using FestasInfantis.WinApp.ModuloTema;
using FestasInfantis.WinApp.ModuloTema.ModuloItens;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace FestasInfantis.WinApp.Compartilhado
{
    public class ContextoDados
    {
        private string caminho = Directory.GetCurrentDirectory().Split("bin")[0] + "\\Dados\\Dados.json";
        public List<Item> Itens { get; set; }
        public List<Tema> Temas { get; set; }
        public List<Cliente> Clientes { get; set; }
        public List<Aluguel> Alugueis { get; set; }

        public Desconto Desconto { get; set; }

        public ContextoDados()
        {
            Itens = new List<Item>();
            Temas = new List<Tema>();
            Clientes = new List<Cliente>();
            Alugueis = new List<Aluguel>();
            Desconto = new(0, 0);
        }
        public ContextoDados(bool carregarDados) : this()
        {
            if (carregarDados)
                CarregarDados();
        }
        public void Gravar()
        {
            FileInfo arquivo = new FileInfo(caminho);

            arquivo.Directory.Create();

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                ReferenceHandler = ReferenceHandler.Preserve
            };

            byte[] registrosEmBytes = JsonSerializer.SerializeToUtf8Bytes(this, options);

            File.WriteAllBytes(caminho, registrosEmBytes);
        }

        protected void CarregarDados()
        {
            FileInfo arquivo = new FileInfo(caminho);

            if (!arquivo.Exists)
                return;

            byte[] registrosEmBytes = File.ReadAllBytes(caminho);

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };

            ContextoDados ctx = JsonSerializer.Deserialize<ContextoDados>(registrosEmBytes, options);

            if (ctx == null)
                return;

            Itens = ctx.Itens;
            Temas = ctx.Temas;
            Clientes = ctx.Clientes;
            Alugueis = ctx.Alugueis;
            Desconto = ctx.Desconto;
        }

    }
}
