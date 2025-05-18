using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Busca_Dupla.Interfaces;
using Busca_Dupla.Models;


namespace Busca_Dupla.Services
{
    public class BuscadorEventosService
    {
        public List<EventoTecnologia> BuscarPorCapacidadeEData(List<EventoTecnologia> eventos, int capacidadeMin, int capacidadeMax, DateTime dataInicio, DateTime dataFim)
        {
            if (eventos == null)
                throw new ArgumentNullException(nameof(eventos));

            var resultados = new List<EventoTecnologia>();

            for (int i = 0; i < eventos.Count; i++)
            {
                var evento = eventos[i];
                if (evento.CapacidadePessoas >= capacidadeMin &&
                    evento.CapacidadePessoas <= capacidadeMax &&
                    evento.Data >= dataInicio &&
                    evento.Data <= dataFim)
                {
                    resultados.Add(evento);
                }
            }

            return resultados;
        }

        public List<EventoTecnologia> BuscarPorTipoEResponsavel(List<EventoTecnologia> eventos, string tipo, string responsavel)
        {
            if (eventos == null)
                throw new ArgumentNullException(nameof(eventos));

            var resultados = new List<EventoTecnologia>();

            for (int i = 0; i < eventos.Count; i++)
            {
                var evento = eventos[i];
                if (evento.Tipo.Equals(tipo, StringComparison.OrdinalIgnoreCase) &&
                    evento.Responsavel.Equals(responsavel, StringComparison.OrdinalIgnoreCase))
                {
                    resultados.Add(evento);
                }
            }

            return resultados;
        }
    }
}
