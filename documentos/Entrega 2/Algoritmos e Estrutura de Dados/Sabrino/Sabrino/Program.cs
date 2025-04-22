using System;
using System.Collections.Generic;
using Sabrino;

namespace Sabrino
{
    public class Program
    {
        static void Main()
        {
            var gerenciador = new GerenciadorEventos();
            var service = new EventoService(gerenciador);

            CadastrarEventosIniciais(gerenciador);

            var interfaceUsuario = new InterfaceUsuario(service);

            interfaceUsuario.Iniciar();
        }

        static void CadastrarEventosIniciais(GerenciadorEventos gerenciador)
        {
            var workshop = new Evento(1, "Workshop de C#", "Sabrino", "15/05/2025");
            workshop.Participantes.Add("João");
            workshop.Participantes.Add("Maria");
            workshop.Participantes.Add("Carlos");
            gerenciador.AdicionarEvento(workshop);

            var palestraIA = new Evento(3, "Introdução à IA", "Lucy Mari", "20/05/2025");
            palestraIA.Participantes.Add("Ana");
            palestraIA.Participantes.Add("Pedro");
            gerenciador.AdicionarEvento(palestraIA);

            var seminarioCloud = new Evento(2, "Microsoft Azure", "Victor", "10/05/2025");
            seminarioCloud.Participantes.Add("Fernanda");
            seminarioCloud.Participantes.Add("Ricardo");
            seminarioCloud.Participantes.Add("Beatriz");
            gerenciador.AdicionarEvento(seminarioCloud);
        }
    }
}
