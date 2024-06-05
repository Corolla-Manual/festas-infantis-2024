using eAgenda.ConsoleApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class Festa : EntidadeBase
    {
        public string Endereco { get; set; }
        public DateTime DataFesta  { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraTermino { get; set; }

        public Festa(string endereco, DateTime dataFesta, DateTime horaInicio, DateTime horaTermino)
        {
            Endereco = endereco;
            DataFesta = dataFesta;
            HoraInicio = horaInicio;
            HoraTermino = horaTermino;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            throw new NotImplementedException();
        }

        public override List<string> Validar()
        {
            throw new NotImplementedException();
        }
    }
}
