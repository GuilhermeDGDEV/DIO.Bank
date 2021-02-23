using System;

namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta(TipoConta.PessoaFisica, 0, 0, "Guilherme");
            Console.WriteLine(c1.ToString());
        }
    }
}
