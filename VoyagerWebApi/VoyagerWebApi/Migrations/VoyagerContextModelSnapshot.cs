﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VoyagerWebApi.Contexts;

#nullable disable

namespace VoyagerWebApi.Migrations
{
    [DbContext(typeof(VoyagerContext))]
    partial class VoyagerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VoyagerWebApi.Domains.Atividade", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("Concluida")
                        .HasColumnType("BIT");

                    b.Property<DateTime?>("DataAtividade")
                        .HasColumnType("DATETIME");

                    b.Property<string>("DescricaoAtividade")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("IdPlanejamento")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdViagem")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("IdPlanejamento");

                    b.ToTable("Atividades");
                });

            modelBuilder.Entity("VoyagerWebApi.Domains.Avaliacoes", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdPostagemViagem")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("StatusAvaliacao")
                        .HasColumnType("INT");

                    b.HasKey("ID");

                    b.HasIndex("IdPostagemViagem");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Avaliacao");
                });

            modelBuilder.Entity("VoyagerWebApi.Domains.Comentarios", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comenario")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("IdPostagemViagem")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("IdPostagemViagem");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Comentario");
                });

            modelBuilder.Entity("VoyagerWebApi.Domains.EnderecosUsuario", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cep")
                        .HasMaxLength(8)
                        .HasColumnType("VARCHAR(8)");

                    b.Property<string>("Cidade")
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("Estado")
                        .HasColumnType("CHAR(2)");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Logradouro")
                        .HasColumnType("VARCHAR(255)");

                    b.HasKey("ID");

                    b.HasIndex("IdUsuario")
                        .IsUnique();

                    b.ToTable("EnderecoUsuario");
                });

            modelBuilder.Entity("VoyagerWebApi.Domains.EnderecosViagem", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CidadeDestino")
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("CidadeOrigem")
                        .HasColumnType("VARCHAR(200)");

                    b.Property<Guid>("IdViagem")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PaisDestino")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("PaisOrigem")
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("ID");

                    b.HasIndex("IdViagem")
                        .IsUnique();

                    b.ToTable("EnderecosViagem");
                });

            modelBuilder.Entity("VoyagerWebApi.Domains.GaleriaImagens", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdPostagemViagem")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Media")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("IdPostagemViagem");

                    b.ToTable("GaleriaImagem");
                });

            modelBuilder.Entity("VoyagerWebApi.Domains.PostagensViagens", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("IdViagem")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Titulo")
                        .HasColumnType("VARCHAR(255)");

                    b.HasKey("ID");

                    b.HasIndex("IdViagem");

                    b.ToTable("PostagemViagem");
                });

            modelBuilder.Entity("VoyagerWebApi.Domains.StatusViagens", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("ID");

                    b.ToTable("StatusViagem");
                });

            modelBuilder.Entity("VoyagerWebApi.Domains.TiposViagem", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TipoViagem")
                        .HasColumnType("VARCHAR(255)");

                    b.HasKey("ID");

                    b.ToTable("TipoViagem");
                });

            modelBuilder.Entity("VoyagerWebApi.Domains.Usuarios", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bio")
                        .HasColumnType("TEXT");

                    b.Property<int?>("CodRecupSenha")
                        .HasColumnType("INT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(150)");

                    b.Property<string>("Foto")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("VoyagerWebApi.Domains.Viagens", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataFinal")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime?>("DataInicial")
                        .HasColumnType("DATETIME");

                    b.Property<Guid>("IdStatusViagem")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdTipoViagem")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("IdStatusViagem");

                    b.HasIndex("IdTipoViagem");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Viagem");
                });

            modelBuilder.Entity("VoyagerWebApi.Domains.Atividade", b =>
                {
                    b.HasOne("VoyagerWebApi.Domains.Viagens", "Viagem")
                        .WithMany("Atividades")
                        .HasForeignKey("IdPlanejamento");

                    b.Navigation("Viagem");
                });

            modelBuilder.Entity("VoyagerWebApi.Domains.Avaliacoes", b =>
                {
                    b.HasOne("VoyagerWebApi.Domains.PostagensViagens", "PostagemViagem")
                        .WithMany("Avaliacoes")
                        .HasForeignKey("IdPostagemViagem")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("VoyagerWebApi.Domains.Usuarios", "Usuario")
                        .WithMany("Avaliacoes")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("PostagemViagem");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("VoyagerWebApi.Domains.Comentarios", b =>
                {
                    b.HasOne("VoyagerWebApi.Domains.PostagensViagens", "PostagemViagem")
                        .WithMany("Comentarios")
                        .HasForeignKey("IdPostagemViagem")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("VoyagerWebApi.Domains.Usuarios", "Usuario")
                        .WithMany("Comentarios")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("PostagemViagem");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("VoyagerWebApi.Domains.EnderecosUsuario", b =>
                {
                    b.HasOne("VoyagerWebApi.Domains.Usuarios", "Usuario")
                        .WithOne("EnderecoUsuario")
                        .HasForeignKey("VoyagerWebApi.Domains.EnderecosUsuario", "IdUsuario")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("VoyagerWebApi.Domains.EnderecosViagem", b =>
                {
                    b.HasOne("VoyagerWebApi.Domains.Viagens", "Viagem")
                        .WithOne("Endereco")
                        .HasForeignKey("VoyagerWebApi.Domains.EnderecosViagem", "IdViagem")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Viagem");
                });

            modelBuilder.Entity("VoyagerWebApi.Domains.GaleriaImagens", b =>
                {
                    b.HasOne("VoyagerWebApi.Domains.PostagensViagens", "PostagemViagenm")
                        .WithMany("GaleriaImagens")
                        .HasForeignKey("IdPostagemViagem")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("PostagemViagenm");
                });

            modelBuilder.Entity("VoyagerWebApi.Domains.PostagensViagens", b =>
                {
                    b.HasOne("VoyagerWebApi.Domains.Viagens", "Viagem")
                        .WithMany()
                        .HasForeignKey("IdViagem")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Viagem");
                });

            modelBuilder.Entity("VoyagerWebApi.Domains.Viagens", b =>
                {
                    b.HasOne("VoyagerWebApi.Domains.StatusViagens", "StatusViagem")
                        .WithMany("Viagens")
                        .HasForeignKey("IdStatusViagem")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("VoyagerWebApi.Domains.TiposViagem", "TipoViagem")
                        .WithMany("Viagens")
                        .HasForeignKey("IdTipoViagem")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("VoyagerWebApi.Domains.Usuarios", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("StatusViagem");

                    b.Navigation("TipoViagem");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("VoyagerWebApi.Domains.PostagensViagens", b =>
                {
                    b.Navigation("Avaliacoes");

                    b.Navigation("Comentarios");

                    b.Navigation("GaleriaImagens");
                });

            modelBuilder.Entity("VoyagerWebApi.Domains.StatusViagens", b =>
                {
                    b.Navigation("Viagens");
                });

            modelBuilder.Entity("VoyagerWebApi.Domains.TiposViagem", b =>
                {
                    b.Navigation("Viagens");
                });

            modelBuilder.Entity("VoyagerWebApi.Domains.Usuarios", b =>
                {
                    b.Navigation("Avaliacoes");

                    b.Navigation("Comentarios");

                    b.Navigation("EnderecoUsuario");
                });

            modelBuilder.Entity("VoyagerWebApi.Domains.Viagens", b =>
                {
                    b.Navigation("Atividades");

                    b.Navigation("Endereco");
                });
#pragma warning restore 612, 618
        }
    }
}
