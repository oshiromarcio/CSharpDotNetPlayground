using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }

        public Professor(string nome, int idade) : base(nome, idade)
        {
        }

        public sealed override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {this.Nome}, sou professor e tenho meu salário é de {this.Salario.ToString("C")}.");
        }
    }
}