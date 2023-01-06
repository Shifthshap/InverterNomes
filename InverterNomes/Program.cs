using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverterNomes
{
    class Program
    {
        static void Main(string[] args)
        {

            string n1, n2, n3, n4, aux;

            Console.Write("Digite o nome #1: ");
            n1 = Console.ReadLine();

            Console.Write("Digite o nome #2: ");
            n2 = Console.ReadLine();

            Console.Write("Digite o nome #3: ");
            n3 = Console.ReadLine();

            Console.Write("Digite o nome #4: ");
            n4 = Console.ReadLine();

            //mecanismo de inversão de nome

            aux = n1;
            n1 = n4;
            n4 = aux;
            aux = n2;
            n2 = n3;
            n3 = aux;
            
            Console.WriteLine();
            Console.WriteLine("Nomes inseridos na sequência invertida: ");
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);

            Console.ReadKey();

        }
    }
}
