using System;

namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente();
            conta1.NumeroDaConta = "1234";
            conta1.Saldo = 1000;
            conta1.EhEspecial = true;
            conta1.Limite = 1300;
            conta1.Movimentacoes = new Movimentacao[10];
            conta1.IndiceMovimentacoes = 0;

            var valorParaSacar = 300;
            conta1.Sacar(valorParaSacar);
            Console.WriteLine($"Valor sacado: R${valorParaSacar}");
            Console.WriteLine($"O saldo atual depois do saque é de: R${conta1.Saldo}");
            Console.WriteLine();

            var valorASerDepositado = 200;
            conta1.Depositar(valorASerDepositado);
            Console.WriteLine($"Valor depositado: R${valorASerDepositado}");
            Console.WriteLine($"O saldo atual depois do depósito é de: R${conta1.Saldo}");
            Console.WriteLine();


            ContaCorrente conta2 = new ContaCorrente();
            conta2.NumeroDaConta = "4567";
            conta2.Saldo = 0;
            conta2.Movimentacoes = new Movimentacao[10];

            var valorParaTransferencia = 500;
            Console.WriteLine($"Valor da transferência: R${valorParaTransferencia}");
            conta1.Transferir(conta2, valorParaTransferencia);
            Console.WriteLine($"O saldo atual depois da transferência é de: R${conta1.Saldo}");
            Console.WriteLine();

            conta1.Extrato();
            Console.WriteLine();

            /*3) Modifique suas classes que acessam e modificam atributos de um Funcionario
             para utilizar as propriedades getters e setters:*/

            Funcionario funcionario = new Funcionario();
            funcionario.Nome = "Jão";
            Console.WriteLine(funcionario.Nome);


            //8)Como garantir que datas como 31/2/2005 não sejam aceitas pela sua classe Data?
            if (Data.DataEhValida("31/02/2005"))
                Console.WriteLine("Data válida");

            else
                Console.WriteLine("Data inválida");


            Console.ReadLine();

        }
    }
}
