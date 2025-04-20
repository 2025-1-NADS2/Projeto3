using Microsoft.EntityFrameworkCore;
using Dashboard_API.Model;

namespace Dashboard_API.Data
{
    // classe que representa a conexão com o banco de dados
    // lê, grava, atualiza e exclui dados no banco
    public class DashboardContext : DbContext
    {
        // DbSet representa a tabela Usuarios no banco.
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Participacao> Participacoes { get; set; }
        public DbSet<FotosEventos> FotosEventos { get; set; }

        // DbContextOptions: recebe as configurações de conexão
        public DashboardContext(DbContextOptions<DashboardContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuração da entidade Usuario
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(u => u.IdUsuario); // Define a chave primária
                entity.Property(u => u.Nome).IsRequired(); // Definir o Nome como obrigatório
                entity.Property(u => u.Cpf).IsRequired();  // Definir o Cpf como obrigatório
                entity.Property(u => u.Email).IsRequired();  // Definir o Email como obrigatório
                entity.Property(u => u.Senha).IsRequired();  // Definir a Senha como obrigatória
                entity.HasMany(u => u.Eventos).WithOne(e => e.Responsavel).HasForeignKey(e => e.ResponsavelId); // Uma pessoa pode criar vários eventos, mas cada evento tem só um responsável.
                entity.HasMany(u => u.Participacoes).WithOne(p => p.Usuario).HasForeignKey(p => p.UsuarioId);  // chave estrangeira

                // Configuração da entidade Evento
                modelBuilder.Entity<Evento>(entity =>
            {
                entity.HasKey(e => e.IdEvento); // Define a chave primária
                entity.Property(e => e.Nome).IsRequired();  // Definir Nome como obrigatório
                entity.Property(e => e.Objetivo).IsRequired();  // Definir Objetivo como obrigatório
                entity.Property(e => e.PalavrasChave).IsRequired();  // Definir PalavrasChave como obrigatório
                entity.HasMany(e => e.Participacoes).WithOne(p => p.Evento).HasForeignKey(p => p.EventoId); // chave estrangeira
                entity.HasMany(e => e.Fotos).WithOne(f => f.Evento).HasForeignKey(f => f.EventoId);

            });

            // Configuração da entidade Participacao
            modelBuilder.Entity<Participacao>(entity =>
            {
                entity.HasKey(p => p.IdParticipacao); // Define a chave primária
                entity.Property(p => p.TokenIngresso).IsRequired();  // Definir TokenIngresso como obrigatório
                entity.HasOne(p => p.Usuario).WithMany(u => u.Participacoes).HasForeignKey(p => p.UsuarioId);
                entity.HasOne(p => p.Evento).WithMany(e => e.Participacoes).HasForeignKey(p => p.EventoId);
            });

            // Configuração da entidade FotosEventos
            modelBuilder.Entity<FotosEventos>(entity =>
            {
                entity.HasKey(f => f.IdFotos); // Define a chave primária
                entity.Property(f => f.UrlImagem).IsRequired(); // Definir UrlImagem como obrigatória
                entity.HasOne(f => f.Evento).WithMany(e => e.Fotos).HasForeignKey(f => f.EventoId);
            });
        }
    }
}