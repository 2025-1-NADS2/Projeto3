using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sabrino;

namespace Sabrino
{
    public class InterfaceUsuario
    {
        private readonly EventoService eventoService;

        public InterfaceUsuario(EventoService service)
        {
            eventoService = service;
        }

        public void Iniciar()
        {
            string interacao = "";

            do
            {
                Console.WriteLine("\nVocê deseja cadastrar um novo evento ou consultar um já cadastrado?");
                Console.WriteLine("(Para cadastrar digite 0 e para consultar digite 1)");

                if (int.TryParse(Console.ReadLine(), out int escolha))
                {
                    switch (escolha)
                    {
                        case 0:
                            eventoService.CadastrarNovoEvento();
                            break;
                        case 1:
                            eventoService.ConsultarEvento();
                            break;
                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida!");
                }

                Console.WriteLine("\nDeseja efetuar nova interação? (S/N)");
                interacao = Console.ReadLine().ToUpper();
            } while (interacao != "N");
        }
    }
}
