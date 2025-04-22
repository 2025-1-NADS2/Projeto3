using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sabrino;

namespace Sabrino
{
    public class Evento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Palestrante { get; set; }
        public string Data { get; set; }
        public List<string> Participantes { get; set; }

        public Evento(int id, string nome, string palestrante, string data)
        {
            Id = id;
            Nome = nome;
            Palestrante = palestrante;
            Data = data;
            Participantes = new List<string>();
        }
    }
}
