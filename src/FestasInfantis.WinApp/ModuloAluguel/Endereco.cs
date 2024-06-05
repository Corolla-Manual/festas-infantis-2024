namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class Endereco
    {
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Endereco(string rua, int numero, string bairro, string cidade, string estado)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }
        public List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (String.IsNullOrEmpty(Rua.Trim()))
                erros.Add("O campo \"Rua\" é obrigatório");
            if (String.IsNullOrEmpty(Bairro.Trim()))
                erros.Add("O campo \"Bairro\" é obrigatório");
            if (String.IsNullOrEmpty(Cidade.Trim()))
                erros.Add("O campo \"Cidade\" é obrigatório");
            if (String.IsNullOrEmpty(Estado.Trim()))
                erros.Add("O campo \"Estado\" é obrigatório");
            if (Numero < 0)
                erros.Add("O campo \"Rua\" é obrigatório");

            return erros;
        }
    }
}
