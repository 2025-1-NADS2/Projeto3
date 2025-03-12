using System;
using System.Collections.Generic;
using System.Linq;

// CLASSE FUNCIONALIDADES
public class SistemaDashboard{
  private List eventos;
  private List usuarios;
  
  public SistemaDashboard()
  {
    eventos = new List();
    usuarios = new List();
  }
  
  // Criar um novo evento
  public void CriarEvento(Evento novoEvento)
  {
    eventos.Add(novoEvento);
    Console.WriteLine($"Evento '{novoEvento.Nome}' criado com sucesso!");
  }
  
  // Listar eventos
  public void ListarEventos()
  {
    Console.WriteLine("\nLista de Eventos:");
    foreach (var evento in eventos)
    {
      Console.WriteLine($"ID: {evento.Id} - Nome: {evento.Nome} - Status: {evento.Status}");
    }
  }
  
  // Cadastrar usuário
  public void CadastrarUsuario(Usuario novoUsuario)
  {
    usuarios.Add(novoUsuario);
    Console.WriteLine($"Usuário '{novoUsuario.Nome}' cadastrado com sucesso!");
  }
  
  // Inscrição em evento
  public void InscreverUsuario(int usuarioId, int eventoId)
  {
    var usuario = usuarios.FirstOrDefault(u => u.Id == usuarioId);
    var evento = eventos.FirstOrDefault(e => e.Id == eventoId);
    
    if (usuario == null || evento == null)
    {
      Console.WriteLine("Usuário ou Evento não encontrado.");
      return;
    }
    
    if (evento.TotalInscritos >= evento.Vagas)
    {
      Console.WriteLine("Evento lotado! Inscrição não permitida.");
      return;
    }
    
    evento.Participacoes.Add(new Participacao{
      Usuario = usuario,
      Evento = evento,
      TokenIngresso = Guid.NewGuid().ToString(),
      Presente = false
    });
    
    evento.TotalInscritos++;
    Console.WriteLine($"Usuário '{usuario.Nome}' inscrito no evento '{evento.Nome}'.");
  }
  
  // Confirmar presença no evento
  public void ConfirmarPresenca(int eventoId, string token)
  {
    var evento = eventos.FirstOrDefault(e => e.Id == eventoId);
    if (evento == null)
    {
      Console.WriteLine("Evento não encontrado.");
      return;
    }
    
    var participacao = evento.Participacoes.FirstOrDefault(p => p.TokenIngresso == token);
    if (participacao == null)
    {
      Console.WriteLine("Token inválido! Presença não confirmada.");
      return;
    }
    
    participacao.Presente = true;
    Console.WriteLine($"Presença confirmada para {participacao.Usuario.Nome} no evento {evento.Nome}.");
  }
}
