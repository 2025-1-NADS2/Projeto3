using System.Runtime.Intrinsics.X86;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Ordenar(Evento[] eventos)
        {
            int N=eventos.Length;
            for (int i = N - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (eventos[j].Maior(eventos[j + 1]))
                    {
                        Evento aux = eventos[j];
                        eventos[j] = eventos[j + 1];
                        eventos[j + 1] = aux;
                    }
                }
            }
        }
        static void printEvento(Evento[] eventos, string[] datasFormatadas)
        {
            for (int i = 0; i < eventos.Length; i++)
            {
                Console.WriteLine(" Data: " + datasFormatadas[i]);
                Console.WriteLine(" Nome do Evento: " + eventos[i].NomeDoEvento);
                Console.WriteLine(" Endereço: " + eventos[i].Endereco);
                Console.WriteLine(" Horário: " + eventos[i].Horario);
                Console.WriteLine(" Nome do Palestrante: " + eventos[i].nomePalestrante);
                Console.WriteLine("");
            }
        }


        static void Main(string[] args)
        {
            Evento[] eventos = new Evento[5];

            eventos[0] = new Evento(20240809, "Criando Solto", "Rua da Glória, 24", "12:00", "Eduardo Savino");
            eventos[1] = new Evento(20230618, "Impulso Criativo", "Josué Carmino Bruno, 267", "09:00", "Jose Buesso");
            eventos[2] = new Evento(20241231, "Boas Práticas", "Rua da Mina, 28", "18:30", "Francisco Escobar");
            eventos[3] = new Evento(20230516, "Soft Skills - Um aprendizado", "Estrada da Árvore, 982", "15:43", "Vinicius Lima");
            eventos[4] = new Evento(20250410, "Lucy Mari - Quem é ela?", "Praça do Carmo, 398", "22:00", "Lucy Mari");

            string[] datasFormatadas = new string[eventos.Length];

            
            Ordenar(eventos);

            for (int i = 0; i < eventos.Length; i++)
            {
                string dataString = eventos[i].Data.ToString();
                string ano = dataString.Substring(0, 4);
                string mes = dataString.Substring(4, 2);
                string dia = dataString.Substring(6, 2);
                datasFormatadas[i] = dia + "/" + mes + "/" + ano;
            }
            Console.WriteLine("ORDENADA E FORMATADA...");
            printEvento(eventos, datasFormatadas);
        }
    }
}