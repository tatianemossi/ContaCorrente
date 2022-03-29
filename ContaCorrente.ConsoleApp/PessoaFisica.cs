namespace ContaCorrente.ConsoleApp
{
    public class PessoaFisica
    {
        /*9) Crie a classe PessoaFisica. Queremos ter a garantia de que pessoa física alguma 
        tenha CPF invalido, nem seja criada PessoaFisica sem cpf inicial. (você não precisa 
        escrever o algoritmo de validação de cpf, basta passar o cpf por um método 
        valida(String x).*/

        private string _cpf;

        public string CPF
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        public PessoaFisica(string cpf)
        {            
            CPF = cpf;
        }


        public bool ValidarCPF(string cpf)
        {
            if (cpf != null)
                return true;

            return false;
        }
    }
}
