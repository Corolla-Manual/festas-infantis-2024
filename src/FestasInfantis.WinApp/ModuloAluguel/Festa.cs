namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class Festa
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
    }
}
