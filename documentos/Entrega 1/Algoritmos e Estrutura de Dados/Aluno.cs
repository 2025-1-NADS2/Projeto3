using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Evento
    {
        public int Data;
        public string NomeDoEvento;
        public string Endereco;
        public string Horario;
        public string nomePalestrante;

        public int GetData () 
        { 
            return Data; 
        }

        public void SetData(int novaData)
        {
            Data = novaData;
        }

        public string GetNomoDoEvento() 
        {
            return NomeDoEvento;
        }

        public void SetNomeDoEvento(string novoNomeDoEvento) 
        {
            NomeDoEvento = novoNomeDoEvento;
        }

        public string GetEndereco()
        {
            return Endereco;
        }

        public void SetEndereco(string novoEndereco)
        {
            Endereco = novoEndereco;
        }

        public string GetHorario()
        {
            return Horario;
        }

        public void SetHorario(string novoHorario)
        {
            Horario = novoHorario;
        }

        public string GetNomeDoPalestrante()
        {
            return nomePalestrante;
        }

        public void SetNomeDoPalestrante(string novoNomeDoPalestrante)
        {
            nomePalestrante = novoNomeDoPalestrante;
        }

        public Evento(int _Data, string _NomeDoEvento, string _Endereco, string _Horario, string _nomePalestrante)
        {
            this.Data = _Data;
            this.NomeDoEvento = _NomeDoEvento;
            this.Endereco = _Endereco;
            this.Horario = _Horario;
            this.nomePalestrante = _nomePalestrante;
        }

        public Boolean Maior(Evento other)
        {
            Boolean result = false;
            if (other != null)
            {
                if (this.Data<other.Data)
                //if (this.NomeDoEvento.CompareTo(other.NomeDoEvento)>0)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
