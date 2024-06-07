using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp133
{
    internal class Funcionario
    {
        private string _nome;
        public int HorasTrabalhada { get; private set; }
        public double ValorHora { get; private set; }

        public Funcionario(string nome, int horastrabalhadas, double valorhora)
        {
            _nome = nome;
            HorasTrabalhada = horastrabalhadas;
            ValorHora = valorhora;
        }

        public double SalarioMes()
        {
            return HorasTrabalhada * ValorHora;
        }
        public string Nome       
           {   
            get { return _nome;
            }
            set
            {
                if (value != null && value.Length > 2)
                {
                    Nome = value;
                }
            }
        }
        public override string ToString()
        {
            return "Funcionario: " + Nome
                + ", Horas trabalhadas nesse mês: " + HorasTrabalhada + " Horas" 
                + ", valor hora funcionario: " + ValorHora.ToString("f2 ")
                + " Salario Mês: " + SalarioMes().ToString("f2");
        }
    }
}
