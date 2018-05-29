namespace CamadaDeDados.Banco
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class bancoFEC : DbContext
    {
        public bancoFEC()
            : base("name=bancoFEC")
        {
        }

        public virtual DbSet<acessar> acessars { get; set; }
        public virtual DbSet<artigo> artigos { get; set; }
        public virtual DbSet<categoria_problema> categoria_problema { get; set; }
        public virtual DbSet<clinica> clinicas { get; set; }
        public virtual DbSet<fisioterapeuta> fisioterapeutas { get; set; }
        public virtual DbSet<mensagem> mensagems { get; set; }
        public virtual DbSet<paciente> pacientes { get; set; }
        public virtual DbSet<pai> pais { get; set; }
        public virtual DbSet<video> videos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<artigo>()
                .Property(e => e.titulo_artDic)
                .IsUnicode(false);
           
            modelBuilder.Entity<artigo>()
                .Property(e => e.conteudo_artDic)
                .IsUnicode(false);

            modelBuilder.Entity<categoria_problema>()
                .Property(e => e.nome_cat)
                .IsUnicode(false);

            modelBuilder.Entity<categoria_problema>()
                .HasMany(e => e.artigos)
                .WithRequired(e => e.categoria_problema)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<categoria_problema>()
                .HasMany(e => e.videos)
                .WithRequired(e => e.categoria_problema)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<clinica>()
                .Property(e => e.nome_cli)
                .IsUnicode(false);

            modelBuilder.Entity<clinica>()
                .Property(e => e.endereco_cli)
                .IsUnicode(false);

            modelBuilder.Entity<clinica>()
                .Property(e => e.tel_cli)
                .IsUnicode(false);

            modelBuilder.Entity<clinica>()
                .Property(e => e.cep_cli)
                .IsUnicode(false);

            modelBuilder.Entity<clinica>()
                .Property(e => e.cnpj_cli)
                .IsUnicode(false);

            modelBuilder.Entity<clinica>()
                .HasMany(e => e.fisioterapeutas)
                .WithMany(e => e.clinicas)
                .Map(m => m.ToTable("trabalhar").MapLeftKey("id_cli").MapRightKey("id_fis"));

            modelBuilder.Entity<fisioterapeuta>()
                .Property(e => e.nome_fis)
                .IsUnicode(false);

            modelBuilder.Entity<fisioterapeuta>()
                .Property(e => e.email_fis)
                .IsUnicode(false);

            modelBuilder.Entity<fisioterapeuta>()
                .Property(e => e.senha_fis)
                .IsUnicode(false);

            modelBuilder.Entity<fisioterapeuta>()
                .Property(e => e.dados_fis)
                .IsUnicode(false);

            modelBuilder.Entity<fisioterapeuta>()
                .Property(e => e.cel_fis)
                .IsUnicode(false);

            modelBuilder.Entity<fisioterapeuta>()
                .Property(e => e.cpf_fis)
                .IsUnicode(false);

            modelBuilder.Entity<fisioterapeuta>()
                .Property(e => e.rg_fis)
                .IsUnicode(false);

            modelBuilder.Entity<fisioterapeuta>()
                .HasMany(e => e.artigos)
                .WithRequired(e => e.fisioterapeuta)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<fisioterapeuta>()
                .HasMany(e => e.mensagems)
                .WithRequired(e => e.fisioterapeuta)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<fisioterapeuta>()
                .HasMany(e => e.videos)
                .WithRequired(e => e.fisioterapeuta)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<fisioterapeuta>()
                .HasMany(e => e.pacientes)
                .WithMany(e => e.fisioterapeutas)
                .Map(m => m.ToTable("consultar").MapLeftKey("id_fis").MapRightKey("id_pac"));

            modelBuilder.Entity<mensagem>()
                .Property(e => e.titulo_mensagem)
                .IsUnicode(false);

            modelBuilder.Entity<mensagem>()
                .Property(e => e.conteudo_mensagem)
                .IsUnicode(false);

            modelBuilder.Entity<paciente>()
                .Property(e => e.nome_pac)
                .IsUnicode(false);

            modelBuilder.Entity<paciente>()
                .Property(e => e.email_pac)
                .IsUnicode(false);

            modelBuilder.Entity<paciente>()
                .Property(e => e.senha_pac)
                .IsUnicode(false);

            modelBuilder.Entity<paciente>()
                .Property(e => e.dados_pac)
                .IsUnicode(false);

            modelBuilder.Entity<paciente>()
                .Property(e => e.tel_pac)
                .IsUnicode(false);

            modelBuilder.Entity<paciente>()
                .Property(e => e.cel_pac)
                .IsUnicode(false);

            modelBuilder.Entity<paciente>()
                .Property(e => e.cpf_pac)
                .IsUnicode(false);

            modelBuilder.Entity<paciente>()
                .Property(e => e.endereco_pac)
                .IsUnicode(false);

            modelBuilder.Entity<paciente>()
                .Property(e => e.rg_pac)
                .IsUnicode(false);

            modelBuilder.Entity<paciente>()
                .Property(e => e.cep_pac)
                .IsUnicode(false);

            modelBuilder.Entity<pai>()
                .Property(e => e.nome_pais)
                .IsUnicode(false);

            modelBuilder.Entity<pai>()
                .Property(e => e.sigla_pais)
                .IsUnicode(false);

            modelBuilder.Entity<pai>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<pai>()
                .HasMany(e => e.clinicas)
                .WithRequired(e => e.pai)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<video>()
                .Property(e => e.titulo_video)
                .IsUnicode(false);

            modelBuilder.Entity<video>()
                .Property(e => e.url_video)
                .IsUnicode(false);

            modelBuilder.Entity<video>()
                .Property(e => e.descricao_video)
                .IsUnicode(false);
        }
    }
}
