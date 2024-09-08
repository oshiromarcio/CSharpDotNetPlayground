using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class Diretor : Professor
    {
        public Diretor(string nome, int idade) : base(nome, idade)
        {
        }
    }
}