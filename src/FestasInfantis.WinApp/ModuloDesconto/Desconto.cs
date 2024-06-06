using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;

namespace FestasInfantis.WinApp.ModuloDesconto
{
    public class Desconto : EntidadeBase
    {
        public double DescontoUnitario { get; set; }
        public double DescontoMaximo { get; set; }

        public Desconto()
        {

        }
        public Desconto(double descontoUnitario, double descontoMaximo)
        {
            DescontoUnitario = descontoUnitario;
            DescontoMaximo = descontoMaximo;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (DescontoUnitario > DescontoMaximo)
                erros.Add("O desconto por aluguel não pode ser maior que o desconto máximo!");

            return erros;
        }
        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Desconto d = (Desconto)novoRegistro;
            DescontoUnitario = d.DescontoUnitario;
            DescontoMaximo = d.DescontoMaximo;
        }
        public double CalcularPorcentagem(Cliente cliente)
        {
            double desconto;
            if (cliente.Alugueis.FindAll(x => x.Status == true).Count > 0)
            {
                desconto = cliente.Alugueis.FindAll(x => x.Status == true).Count * DescontoUnitario;

                return desconto > DescontoMaximo ? DescontoMaximo : desconto;
            }
            else
                return 0;
        }
    }
}
