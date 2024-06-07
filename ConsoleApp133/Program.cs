using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp133
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ficha funcionario");

            Console.WriteLine("Nome do funcionario: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Horas mensal trabalhadas: ");
            int horastrabalhadas = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor hora do funcionario;");
            double valorhora = double.Parse(Console.ReadLine());
   
            Funcionario F = new Funcionario(nome,horastrabalhadas,valorhora);
            F.SalarioMes();

            Console.WriteLine(F);
            Console.ReadLine();
        }
    }
}
