using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sabrino;

namespace Sabrino
{
    public class GerenciadorEventos
    {
        private List<Evento> eventos;

        public GerenciadorEventos()
        {
            eventos = new List<Evento>();
        }

        public void AdicionarEvento(Evento evento)
        {
            eventos.Add(evento);
        }

        public void OrdenarEventosPorId()
        {
            eventos.Sort((x, y) => x.Id.CompareTo(y.Id));
        }

        public Evento BuscarEventoPorId(int id)
        {
            return eventos.Find(e => e.Id == id);
        }

        public List<Evento> ObterTodosEventos()
        {
            return new List<Evento>(eventos);
        }
    }
}
