namespace ContaCorrente.ConsoleApp
{
    /*1) Adicione o modificador de visibilidade (private, se necessário) para cada
     atributo e método da classe Funcionario. Tente criar um Funcionario no Main e modificar
    ou ler um de seus atributos privados. O que acontece? 
    R.: Não se faz possível, pois como é private, é inascessível.
     */

    public class Funcionario
    {
        private string _nome;

        /*5) Adicione um atributo na classe Funcionario de tipo int que se chama
         identificador. Esse identificador deve ter um valor único para cada instância do tipo
        Funcionario:*/        
        private static int identificador = 1;


        /*4) Faça com que sua classe Funcionario possa receber, opcionalmente, o nome do
         Funcionario durante a criação do objeto. Utilize construtores para obter esse resultado:*/
        public Funcionario(string nome)
        {
            Nome = nome;
            Funcionario.identificador = identificador +1;
        }

        public Funcionario()
        {
            /*4) Por que você precisa do construtor sem argumentos para que a passagem do
            nome seja opcional? 
            R.: Porque se eu passar somente com o parâmetro, o nome obrigatoriamente terá que 
            ser informado na criação do funcionário, ou seja, não será opcional.             
             */

            Funcionario.identificador = identificador + 1;
        }


        // 2) Crie as propriedades getters e setters necessários da sua classe Funcionario:         
         
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }


        /*5) Crie um getter para o identificador. Devemos ter um setter?
        R.: Não, pois não devemos setar um valor, visto que quem fará isso será o construtor da
        classe, apenas pegaremos a informação.*/
        public int BuscaTotalIdentificadores
        {
            get { return Funcionario.identificador; }
        }
    }
}
