using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ExemploFundamentos.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set;}


        public void Apresentar(string @class)//@ permite usar uma palavra reservada como nome de variável
        {
            Nome = "josé carlos";
            Idade = 23;
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}