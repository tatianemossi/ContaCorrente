using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.ConsoleApp
{
    internal class ContaCorrente
    {
        private const string DebitoConst = "Debito";
        private const string CreditoConst = "Credito";

        public string NumeroDaConta { get; set; }
        public int Limite { get; set; }
        public bool EhEspecial { get; set; }
        public decimal Saldo { get; set; }
        public Movimentacao[] Movimentacoes { get; set; }
        public int IndiceMovimentacoes { get; set; }

        internal void Sacar(int valorParaSacar)
        {
            if ((Saldo + Limite) >= valorParaSacar)
            {
                Saldo = Saldo - valorParaSacar;

                var movimentacao = new Movimentacao(DebitoConst, valorParaSacar);
                Movimentacoes[IndiceMovimentacoes] = movimentacao;
                IndiceMovimentacoes++;
            }
        }

        internal void Depositar(int valorASerDepositado)
        {
            Saldo = Saldo + valorASerDepositado;

            var movimentacao = new Movimentacao(CreditoConst, valorASerDepositado);
            Movimentacoes[IndiceMovimentacoes] = movimentacao;
            IndiceMovimentacoes++;
        }

        internal void Transferir(ContaCorrente conta2, int valorParaTransferencia)
        {
            if ((Saldo + Limite) >= valorParaTransferencia)
            {
                Saldo = Saldo - valorParaTransferencia;
                conta2.Saldo = conta2.Saldo + valorParaTransferencia;

                var movimentacaoConta1 = new Movimentacao(DebitoConst, valorParaTransferencia);
                Movimentacoes[IndiceMovimentacoes] = movimentacaoConta1;
                IndiceMovimentacoes++;

                var movimentacaoConta2 = new Movimentacao(CreditoConst, valorParaTransferencia);
                Movimentacoes[IndiceMovimentacoes] = movimentacaoConta2;
                IndiceMovimentacoes++;
            }
        }

        internal void Extrato()
        {
            for (int i = 0; i < Movimentacoes.Length; i++)
            {
                if (Movimentacoes[i] != null)
                {
                    Console.WriteLine($"Tipo de Operação: {Movimentacoes[i].TipoAcao} - " +
                    $"Valor da Operação: R${Movimentacoes[i].Valor}");
                }
            }
        }

    }
}
