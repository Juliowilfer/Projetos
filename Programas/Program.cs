using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal cinco;
            decimal tres;
            decimal seis;
            decimal dois;
            decimal resultado;

            Console.WriteLine("Informe a primeira nota");
            cinco = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota");
            tres = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe a terceira nota");
            seis = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("informe a quarta nota");
            dois = Convert.ToDecimal(Console.ReadLine());

            resultado = (cinco + tres + seis + dois) / 4;

            Console.WriteLine(
                "A soma das notas " + cinco + " e "
                + tres + " e " + seis + " e " + dois +
                " é " + resultado

            );
        }
    }
}
