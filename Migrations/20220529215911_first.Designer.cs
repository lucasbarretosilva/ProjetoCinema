﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoCinema.Data;

namespace ProjetoCinema.Migrations
{
    [DbContext(typeof(ProjetoCinemaContext))]
    [Migration("20220529215911_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjetoCinema.Models.Compra", b =>
                {
                    b.Property<int>("CompraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("MeiaEntrada")
                        .HasColumnType("bit");

                    b.Property<int>("SessaoId")
                        .HasColumnType("int");

                    b.HasKey("CompraId");

                    b.HasIndex("SessaoId");

                    b.ToTable("Compra");
                });

            modelBuilder.Entity("ProjetoCinema.Models.Filme", b =>
                {
                    b.Property<int>("FilmeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Dublado")
                        .HasColumnType("bit");

                    b.Property<string>("FilmeNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Legendado")
                        .HasColumnType("bit");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.HasKey("FilmeId");

                    b.ToTable("Filme");
                });

            modelBuilder.Entity("ProjetoCinema.Models.Sala", b =>
                {
                    b.Property<int>("SalaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Disponivel")
                        .HasColumnType("bit");

                    b.Property<int>("QuantidadeAssentos")
                        .HasColumnType("int");

                    b.HasKey("SalaId");

                    b.ToTable("Sala");
                });

            modelBuilder.Entity("ProjetoCinema.Models.Sessao", b =>
                {
                    b.Property<int>("SessaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FilmeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Horario")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumeroSessao")
                        .HasColumnType("int");

                    b.Property<int>("SalaId")
                        .HasColumnType("int");

                    b.HasKey("SessaoId");

                    b.HasIndex("FilmeId");

                    b.HasIndex("SalaId");

                    b.ToTable("Sessao");
                });

            modelBuilder.Entity("ProjetoCinema.Models.Compra", b =>
                {
                    b.HasOne("ProjetoCinema.Models.Sessao", "Sessao")
                        .WithMany()
                        .HasForeignKey("SessaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sessao");
                });

            modelBuilder.Entity("ProjetoCinema.Models.Sessao", b =>
                {
                    b.HasOne("ProjetoCinema.Models.Filme", "Filme")
                        .WithMany()
                        .HasForeignKey("FilmeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoCinema.Models.Sala", "Sala")
                        .WithMany()
                        .HasForeignKey("SalaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Filme");

                    b.Navigation("Sala");
                });
#pragma warning restore 612, 618
        }
    }
}
