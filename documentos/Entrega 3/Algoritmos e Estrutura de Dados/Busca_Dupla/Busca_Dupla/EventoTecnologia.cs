using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busca_Dupla.Models;

public class EventoTecnologia
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int CapacidadePessoas { get; set; }
    public string Responsavel { get; set; }
    public DateTime Data { get; set; }
    public string Tipo { get; set; }

    public EventoTecnologia(int id, string nome, int capacidade, string responsavel, DateTime data, string tipo)
    {
        Id = id;
        Nome = nome;
        CapacidadePessoas = capacidade;
        Responsavel = responsavel;
        Data = data;
        Tipo = tipo;
    }

    public override string ToString()
    {
        return $"[{Tipo}] {Nome} | Capacidade: {CapacidadePessoas} pessoas | Responsável: {Responsavel} | Data: {Data.ToShortDateString()}";
    }
}
