namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class Festa
    {
        public Endereco Endereco { get; set; }
        public DateTime DataFesta { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraTermino { get; set; }

        public Festa()
        {

        }
        public Festa(Endereco endereco, DateTime dataFesta, DateTime horaInicio, DateTime horaTermino)
        {
            Endereco = endereco;
            DataFesta = dataFesta;
            HoraInicio = horaInicio;
            HoraTermino = horaTermino;
        }
    }
}
