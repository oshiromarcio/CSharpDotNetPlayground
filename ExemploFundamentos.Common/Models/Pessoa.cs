
namespace ExemploFundamentos.Common.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public void Deconstruct(out string nome, out int idade) {
            nome = this.Nome;
            idade = this.Idade;
        }

        private string _nome;
        private int _idade;

        public string Nome
        {
            get =>_nome.ToUpper();

            set {
                if (value == "" || value == null) {
                    throw new Exception("O nome não pode ser vazio.");
                }
                this._nome = value;
            }
        }
        public int Idade
        {
            get =>_idade;

            set {
                if (value < 0) {
                    throw new Exception("A idade não pode ser menor que zero.");
                }
                this._idade = value;
            }
        }


        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {this.Nome} e tenho {this.Idade} anos.");
        }
    }
}