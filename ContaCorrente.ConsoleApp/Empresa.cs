namespace ContaCorrente.ConsoleApp
{
    public class Empresa
    {
        /*6) Crie as propriedades getters e setters da sua classe Empresa e
         coloque seus atributos como private. */

        private string _nome;
        private Funcionario[] _funcionarios;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public Funcionario BuscarFuncionario(int posicao)
        {
            return _funcionarios[posicao];
        }

        /*7) Na classe Empresa, em vez de criar um array de tamanho fixo,
        receba como parâmetro no construtor o tamanho do array de Funcionario. Agora, com
        esse construtor, o que acontece se tentarmos dar new Empresa() sem passar argumento
        algum? Por quê?
        R.: É obrigatório passar o tamanho do array de funcionários para poder criar uma empresa.*/

        public Empresa(int tamanhoArrayFuncionarios)
        {
            _funcionarios = new Funcionario[tamanhoArrayFuncionarios];
        }
    }
}
