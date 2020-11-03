using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Program
    {
        static void Main()
        {
            Pessoas p = new Pessoas();
            Pessoas n = new Pessoas();

            Console.Write("Insira o nome: ");
            p.Nome = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Insira a idade: ");
            p.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Insira outro nome: ");
            n.Nome = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Insira outra idade: ");
            n.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if(p.Idade > n.Idade)
            {
                Console.Write("{0} é maior que {1}.", p.Nome, n.Nome);
            }
            if(n.Idade > p.Idade)
            {
                Console.Write("{0} é maior que {1}.", n.Nome, p.Nome);
            }
            else
            {
                Console.Write("{0} e {1} contém a mesma idade.", n.Nome, p.Nome);
            }
            Console.Read();
        }
    }
}
