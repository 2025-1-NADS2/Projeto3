using System;
using System.Collections.Generic;

class OrdenarLista
{
    static void Main()
    {
        List<int> lista = new List<int> { 20240809, 20241231, 20240305, 20230618, 20230515, 20230516, 20240622 };
        string[] datasFormatadas = new string[lista.Count];

        while (true)
        {
            Console.WriteLine("Deseja cadastrar uma nova data de evento? (s/n)");
            string escolha = Console.ReadLine();

            if (escolha.ToLower() == "s")
            {
                int novaData = InserirData();
                lista.Add(novaData);
            }
            else if (escolha.ToLower() == "n")
            {
                Console.WriteLine("Fim dos cadastros.");
                break;
            }
            else
            {
                Console.WriteLine("Invalida! Tente s para sim ou n para não.");
            }
        }

        Ordenar(lista);

        for (int i = 0; i < lista.Count; i++)
        {
            string dataString = lista[i].ToString();
            string ano = dataString.Substring(0, 4);
            string mes = dataString.Substring(4, 2);
            string dia = dataString.Substring(6, 2);
            datasFormatadas[i] = dia + "/" + mes + "/" + ano;
        }

        Console.WriteLine("\nDatas cadastradas (ordenadas):");
        for (int i = 0 ; i < lista.Count ; i++){
            Console.WriteLine(datasFormatadas[i]);
        }
    }

    static int InserirData()
    {
        Console.WriteLine("Qual a data do evento? (formato = aaaaMMdd)");
        
        int data;
        
        while (!int.TryParse(Console.ReadLine(), out data))
        {
            Console.WriteLine("Formato inválido! Digite a data no formato aaaaMMdd.");
        }
        return data;
    }

    static void Ordenar(List<int> lista)
    {
        int passos = 0;
        int N = lista.Count;
        for (int i = N - 1 ; i > 0 ; i--)
        {
            for (int j = 0 ; j < i ; j++)
            {
                if (lista[j] < lista[j + 1])
                {
                    int aux = lista[j];
                    lista[j] = lista[j + 1];
                    lista[j + 1] = aux;
                    passos++;
                }
            }
        }
        Console.WriteLine("Passos realizados para ordenação: " + passos);
    }
}