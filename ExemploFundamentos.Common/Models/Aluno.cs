using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public sealed class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public Aluno(string nome, int idade) : base(nome, idade)
        {
        }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {this.Nome}, sou aluno e minha nota é {this.Nota}.");
        }
    }
}