using System;
// CLASSE PRINCIPAL QUE IRÁ TESTAR AS FUNCIONALIDADES
class MainPrincipal{
  static void Main(){
  var sistema = new SistemaDashboard();
  
  // Criando usuários
  var usuario1 = new Usuario { Id = 1, Nome = "Larissa", CPF = "12345678900", Email = "larissa@email.com", TipoUsuario = TipoUsuario.Comum };
  var usuario2 = new Usuario { Id = 2, Nome = "Ana", CPF = "98765432100", Email = "ana@email.com", TipoUsuario = TipoUsuario.Comum };
  
  sistema.CadastrarUsuario(usuario1);
  sistema.CadastrarUsuario(usuario2);
  
  // Criando evento
  var evento = new Evento { Id = 1, Nome = "Workshop de C#", DataInicio = DateTime.Now, Vagas = 10, TotalInscritos = 0, Status = StatusEvento.Planejado };
  sistema.CriarEvento(evento);
  
  // Listando eventos
  sistema.ListarEventos();
  
  // Inscrição do usuário no evento
  sistema.InscreverUsuario(1, 1);
  
  // Gerar token (Pegamos o primeiro usuário inscrito)
  var token = evento.Participacoes[0].TokenIngresso;
  Console.WriteLine($"Token Gerado: {token}");
  
  // Confirmar presença usando o token
  sistema.ConfirmarPresenca(1, token);
  }
}
