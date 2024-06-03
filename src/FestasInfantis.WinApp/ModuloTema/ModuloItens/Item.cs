﻿using eAgenda.ConsoleApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloTema.ModuloItens
{
    internal class Item : EntidadeBase
    {
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public string Tema { get; set; }
        public Item(string descricao, double valor)
        {
            Descricao = descricao;
            Valor = valor;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Item item = (Item)novoRegistro;

            Descricao = item.Descricao;
            Valor = item.Valor;
            Tema = item.Tema;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Descricao.Trim()))
                erros.Add("O campo \"Descrição\" é obrigatório");

            if (Valor > 0)
                erros.Add("O campo \"Valor\" é obrigatório");

            return erros;
        }
    }
}
