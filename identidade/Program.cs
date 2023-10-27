using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace identidade
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome;
            decimal altura;
            decimal peso;
            decimal idade;
            string sexo;

            Console.WriteLine("Informe o seu nome");
            nome = Console.ReadLine();

            Console.WriteLine("Informe a sua altura");
            altura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe o seu peso");
            peso = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("informe a sua idade");
            idade = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("informe o seu sexo");
            sexo = Console.ReadLine();



        }
    }
}
