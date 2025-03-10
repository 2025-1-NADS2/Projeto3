using System;
using System.Collections.Generic; //biblioteca para usar a lista dinâmica

class OrdenarLista
{
    static void Main()
    {
        List<int> lista = new List<int> { 20240809, 20241231, 20240305, 20230618, 20230515, 20230516, 20240622 }; //lista dinâmica que recebe datas no formto aaaaMMdd, pois assim é possivel ordenar pela data mais recente

        while (true)
        {
            Console.WriteLine("Deseja cadastrar uma nova data de evento? (s/n)");
            string escolha = Console.ReadLine();

            if (escolha.ToLower() == "s")
            {
                int novaData = InserirData(); //novaData recebe a data inserida
                lista.Add(novaData); //adiciona a nova data para a lista dinâmica
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

        string[] datasFormatadas = new string[lista.Count]; //datas no formato dia, mês e ano
        
        Ordenar(lista);

        for (int i = 0; i < lista.Count; i++) //lista.count recebe a quantidade de itens da lista dinâmica 
        {
            string dataString = lista[i].ToString(); //transforma a data em string
            string ano = dataString.Substring(0, 4); //ano recebe atraves substring (método de receber partes especícas da string), a partir do caractere 0 contando 4 caracteres para frente
            string mes = dataString.Substring(4, 2); //mes recebe a partir do caractere 4, contando dois para frente
            string dia = dataString.Substring(6, 2); //dia recebe a partir do caractere 6, contando dois para frente
            datasFormatadas[i] = dia + "/" + mes + "/" + ano; //o array datasFormatadas recebe as datas no formato dia/mes/ano em string
        }

        Console.WriteLine("\nDatas cadastradas (ordenadas):");
        for (int i = 0 ; i < lista.Count ; i++){
            Console.WriteLine(datasFormatadas[i]);
        }
    }

    static int InserirData() //função para inserir as datas
    {
        Console.WriteLine("Qual a data do evento? (formato = aaaaMMdd)");
        
        int data;
        
        while (!int.TryParse(Console.ReadLine(), out data)) //se o que for digitado for diferente de um número, o método TryParse (que converte string para int) vai falhar e retornar false
        {
            Console.WriteLine("Formato inválido! Digite a data no formato aaaaMMdd.");
        }
        return data;
    }

    static void Ordenar(List<int> lista) // procedimento de ordenar as datas
    {
        int passos = 0; //quantidades de passos para ordenar a lista
        int N = lista.Count; 
        for (int i = N - 1 ; i > 0 ; i--)
        {
            for (int j = 0 ; j < i ; j++) 
            {
                if (lista[j] < lista[j + 1]) //ordena a lista de forma decrescente, do maior para o menor número
                {
                    int aux = lista[j];
                    lista[j] = lista[j + 1];
                    lista[j + 1] = aux;
                    passos++; //atualiza a quantidade de passos
                }
            }
        }
        Console.WriteLine("Passos realizados para ordenação: " + passos);
    }
}
