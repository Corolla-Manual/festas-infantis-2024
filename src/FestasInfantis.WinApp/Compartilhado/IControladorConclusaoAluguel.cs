using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    internal interface IControladorConclusaoAluguel
    {
        string ToolTipConclusaoAluguel { get; }

        void Concluir();
    }
}
