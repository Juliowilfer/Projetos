using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Criar um script que solicite 2 numeros ao usuario
               e ao final mostre a soma dos valores.
            */

            // Define as variaveis
            decimal numero_um;
            decimal numero_dois;
            decimal soma;
            decimal multiplicacao;
            decimal subtracao;
            decimal divisao;

            Console.WriteLine("SOMA APP 3000");

            Console.WriteLine("informe o primeiro numero: ");
            numero_um = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("informe o segundo numero");
            numero_dois = Convert.ToDecimal(Console.ReadLine());

            soma = numero_um + numero_dois;
            multiplicacao = numero_um * numero_dois;
            subtracao = numero_um - numero_dois;
            divisao = numero_um / numero_dois;

            Console.WriteLine(
                "A soma do numero " + numero_um + " e "
                + numero_dois + " é: " + soma
            );

            Console.WriteLine(
                "A multiplicacao do numero " + numero_um + " e "
                + numero_dois + " é " + multiplicacao
            );

            Console.WriteLine(
               "A subtracao do numero " + numero_um + " e "
               + numero_dois + " é " + subtracao
            );

            Console.WriteLine(
                "A divisao do numero " + numero_um + " e "
                + numero_dois + " é " + divisao
            );
        }
    }
}
