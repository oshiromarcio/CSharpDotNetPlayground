using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(decimal valor)
        {
            this.Saldo += valor;
        }
    }
}