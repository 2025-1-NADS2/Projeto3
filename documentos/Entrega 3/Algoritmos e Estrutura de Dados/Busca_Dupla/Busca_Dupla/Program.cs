using Busca_Dupla.Models;
using Busca_Dupla.Services;
//using Busca_Dupla.Interfaces;
using System;
using System.Collections.Generic;


namespace Busca_Dupla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // configuração do serviço
            var buscadorService = new BuscadorEventosService();

            // improtando a função e criando lista de eventos de tecnologia
            List<EventoTecnologia> eventos = CriarListaEventos();


            // caso eu queria buscar pelo número mínimo e máximo de pessoas, e por data de inicio e fim
            Console.WriteLine("Eventos com capacidade entre 50 e 200 pessoas em Janeiro 2023:");
            var resultadosCapacidade = buscadorService.BuscarPorCapacidadeEData(
                eventos,
                capacidadeMin: 50,
                capacidadeMax: 200,
                dataInicio: new DateTime(2023, 1, 1),
                dataFim: new DateTime(2023, 1, 31));

            ExibirResultados(resultadosCapacidade);



            // caso eu queria buscar pelo nome do responsável e o tipo de evento essa é a estrutura, por exemplo um workshop do Carlos Silva
            Console.WriteLine("\nWorkshops organizados por Carlos Silva:");
            var resultadosTipoResponsavel = buscadorService.BuscarPorTipoEResponsavel(
                eventos,
                tipo: "Workshop",
                responsavel: "Carlos Silva");

            ExibirResultados(resultadosTipoResponsavel);
        }


        // aqui são dados criados dos eventos de suporte para funcionamento do código, mas que poderiam ser recebidos de um banco
        private static List<EventoTecnologia> CriarListaEventos()
        {
            return new List<EventoTecnologia>
            {
                new EventoTecnologia(1, "Azure Fundamentals", 100, "Ana Souza", new DateTime(2023, 1, 10), "Workshop"),
                new EventoTecnologia(2, "IA para Devs", 150, "Carlos Silva", new DateTime(2023, 1, 15), "Workshop"),
                new EventoTecnologia(3, "DevOps Day", 300, "Maria Oliveira", new DateTime(2023, 2, 5), "Palestra"),
                new EventoTecnologia(4, "Hackathon Inovação", 200, "Carlos Silva", new DateTime(2023, 1, 20), "Hackathon"),
                new EventoTecnologia(5, ".NET Conference", 80, "Pedro Rocha", new DateTime(2023, 1, 25), "Palestra"),
                new EventoTecnologia(6, "React Advanced", 120, "Carlos Silva", new DateTime(2023, 2, 10), "Workshop")
            };
        }

        // função para imprimir os resultados
        private static void ExibirResultados(List<EventoTecnologia> resultados)
        {
            if (resultados.Count == 0)
            {
                Console.WriteLine("Nenhum evento encontrado.");
                return;
            }

            for (int i = 0; i < resultados.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {resultados[i]}");
            }
        }
    }
}
