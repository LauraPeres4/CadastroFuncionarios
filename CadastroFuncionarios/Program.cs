using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 1 para empregado assalariado, 2 para comissionado e 3 para horista: ");
            int empregado = int.Parse(Console.ReadLine());

            string res = "S";
            int funcionario = 0;
            int total = 0;
            double media = 0;
            double sal = 0;
            while (res == "S") ;
            {
                

                if (empregado == 1)
                {
                    Console.WriteLine("Informe o salário fixo: ");
                    double salfixo = double.Parse(Console.ReadLine());

                    Console.WriteLine("Agora informe o valor do desconto: ");
                    double desconto = double.Parse(Console.ReadLine());

                    sal = salfixo - desconto;
                    Console.WriteLine("O salário será de: " + sal);
                    funcionario += 1;
                   
                }
                else if(empregado == 2)
                {
                    Console.WriteLine("Informe o total das vendas: ");
                    double vendas = double.Parse(Console.ReadLine());

                    Console.WriteLine("Informe o percentual de comissão sobre as vendas: ");
                    double percentual = double.Parse(Console.ReadLine());

                    sal = vendas * (percentual / 100);
                    Console.WriteLine("O salário será de: " +  sal);
                    funcionario += 1;

                }
                else if (empregado == 3)
                {
                    Console.WriteLine("Informe a quantidade de horas trabalhadas: ");
                    int horas = int.Parse(Console.ReadLine());

                    Console.WriteLine("Informe o valor por hora trabalhada: ");
                    double valorhora = double.Parse(Console.ReadLine());

                    sal = horas * valorhora;
                    Console.WriteLine("O salário será de: " +  sal);
                    funcionario += 1;
                }
                else
                {
                    Console.WriteLine("Opção Inválida.");
                }

                Console.WriteLine("O salário será de: " + sal);
                Console.WriteLine("Deseja cadastrar mais funcionários? [S/N]");



                

                
            }


            Console.ReadKey();

        }
    }
}
