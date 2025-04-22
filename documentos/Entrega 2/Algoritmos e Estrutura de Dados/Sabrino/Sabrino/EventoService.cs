using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sabrino;

namespace Sabrino
{
    public class EventoService
    {
        private readonly GerenciadorEventos gerenciador;

        public EventoService(GerenciadorEventos gerenciador)
        {
            this.gerenciador = gerenciador;
        }

        public void CadastrarNovoEvento()
        {
            Console.WriteLine("\nCADASTRAR NOVO EVENTO");

            Console.Write("ID do Evento: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Nome do Evento: ");
            string nome = Console.ReadLine();

            Console.Write("Nome do Palestrante: ");
            string palestrante = Console.ReadLine();

            Console.Write("Data (DD/MM/AAAA): ");
            string data = Console.ReadLine();

            Evento novoEvento = new Evento(id, nome, palestrante, data);

            Console.WriteLine("\nDigite os participantes (um por linha, '0' para encerrar):");
            while (true)
            {
                string participante = Console.ReadLine();
                if (participante == "0") break;
                novoEvento.Participantes.Add(participante);
            }

            gerenciador.AdicionarEvento(novoEvento);
            Console.WriteLine("Evento cadastrado com sucesso!");
        }

        public void ConsultarEvento()
        {
            Console.Write("Digite o ID do evento que deseja buscar: ");
            if (int.TryParse(Console.ReadLine(), out int idBusca))
            {
                gerenciador.OrdenarEventosPorId();
                Evento eventoEncontrado = gerenciador.BuscarEventoPorId(idBusca);

                if (eventoEncontrado != null)
                {
                    Console.WriteLine($"\nEVENTO: {eventoEncontrado.Nome}");
                    Console.WriteLine($"Palestrante: {eventoEncontrado.Palestrante}");
                    Console.WriteLine($"Data: {eventoEncontrado.Data}");
                    Console.WriteLine("Participantes: " + string.Join(", ", eventoEncontrado.Participantes));
                }
                else
                {
                    Console.WriteLine("Evento não encontrado!");
                }
            }
            else
            {
                Console.WriteLine("ID inválido!");
            }
        }
    }
}
