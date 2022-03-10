using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.ConsoleApp
{
    internal class Movimentacao
    {
        public Movimentacao(string tipoAcao, decimal valor)
        {
            TipoAcao = tipoAcao;
            Valor = valor;
        }

        public string TipoAcao { get; set; }
        public decimal Valor { get; set; }
    }
}
