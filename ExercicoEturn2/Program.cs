using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicoEturn2
{
    class Program
    {
        static TimeSpan InicioAlmoco = TimeSpan.Parse("12:00");
        static TimeSpan TerminoAlmoco = TimeSpan.Parse("13:00");
        static TimeSpan InicioNetworking = TimeSpan.Parse("17:00");
        static TimeSpan InicioEvento = TimeSpan.Parse("09:00");

        static void Main(string[] args)
        {
            
            Dictionary<int, string> Dicionario = new Dictionary<int, string>();
            string Nome;
            int duracao;

            //Main Aplication
            {
                int totalAcumuladoMinutosEvento = 0;
                do
                {
                    Console.WriteLine("Digite o nome do Evento");
                    Nome = Console.ReadLine();
                    Console.WriteLine("Digite a duração");
                    duracao = Convert.ToInt32(Console.ReadLine());

                    if (totalAcumuladoMinutosEvento + duracao <= 840)
                    {
                        Dicionario.Add(duracao, Nome);
                        totalAcumuladoMinutosEvento += Convert.ToInt32(duracao);
                    }
                    else
                    {
                        Console.WriteLine("Limite de tempo excedido");
                    }

                } while (totalAcumuladoMinutosEvento < 840);
            }

            TimeSpan AddHoraInicio = InicioEvento.Add(TimeSpan.FromMinutes(duracao));




            //Print
            {
                   
            }
            
            
            


            

        }
            


        
    }
}
