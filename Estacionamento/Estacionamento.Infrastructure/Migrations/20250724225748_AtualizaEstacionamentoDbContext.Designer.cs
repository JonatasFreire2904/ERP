﻿// <auto-generated />
using System;
using Estacionamento.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Estacionamento.Infrastructure.Migrations
{
    [DbContext(typeof(EstacionamentoDbContext))]
    [Migration("20250724225748_AtualizaEstacionamentoDbContext")]
    partial class AtualizaEstacionamentoDbContext
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.7");

            modelBuilder.Entity("Estacionamento.Domain.Entities.Carro", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Carros");
                });

            modelBuilder.Entity("Estacionamento.Domain.Entities.Ocupacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CarroId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Entrada")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Saida")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("VagaId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CarroId");

                    b.HasIndex("VagaId")
                        .IsUnique();

                    b.ToTable("Ocupacoes");
                });

            modelBuilder.Entity("Estacionamento.Domain.Entities.Vaga", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Ocupada")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Vagas");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            Codigo = "V001",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            Codigo = "V002",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000003"),
                            Codigo = "V003",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000004"),
                            Codigo = "V004",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000005"),
                            Codigo = "V005",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000006"),
                            Codigo = "V006",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000007"),
                            Codigo = "V007",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000008"),
                            Codigo = "V008",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000009"),
                            Codigo = "V009",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000010"),
                            Codigo = "V010",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000011"),
                            Codigo = "V011",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000012"),
                            Codigo = "V012",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000013"),
                            Codigo = "V013",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000014"),
                            Codigo = "V014",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000015"),
                            Codigo = "V015",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000016"),
                            Codigo = "V016",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000017"),
                            Codigo = "V017",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000018"),
                            Codigo = "V018",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000019"),
                            Codigo = "V019",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000020"),
                            Codigo = "V020",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000021"),
                            Codigo = "V021",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000022"),
                            Codigo = "V022",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000023"),
                            Codigo = "V023",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000024"),
                            Codigo = "V024",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000025"),
                            Codigo = "V025",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000026"),
                            Codigo = "V026",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000027"),
                            Codigo = "V027",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000028"),
                            Codigo = "V028",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000029"),
                            Codigo = "V029",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000030"),
                            Codigo = "V030",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000031"),
                            Codigo = "V031",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000032"),
                            Codigo = "V032",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000033"),
                            Codigo = "V033",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000034"),
                            Codigo = "V034",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000035"),
                            Codigo = "V035",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000036"),
                            Codigo = "V036",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000037"),
                            Codigo = "V037",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000038"),
                            Codigo = "V038",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000039"),
                            Codigo = "V039",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000040"),
                            Codigo = "V040",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000041"),
                            Codigo = "V041",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000042"),
                            Codigo = "V042",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000043"),
                            Codigo = "V043",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000044"),
                            Codigo = "V044",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000045"),
                            Codigo = "V045",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000046"),
                            Codigo = "V046",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000047"),
                            Codigo = "V047",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000048"),
                            Codigo = "V048",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000049"),
                            Codigo = "V049",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000050"),
                            Codigo = "V050",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000051"),
                            Codigo = "V051",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000052"),
                            Codigo = "V052",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000053"),
                            Codigo = "V053",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000054"),
                            Codigo = "V054",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000055"),
                            Codigo = "V055",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000056"),
                            Codigo = "V056",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000057"),
                            Codigo = "V057",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000058"),
                            Codigo = "V058",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000059"),
                            Codigo = "V059",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000060"),
                            Codigo = "V060",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000061"),
                            Codigo = "V061",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000062"),
                            Codigo = "V062",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000063"),
                            Codigo = "V063",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000064"),
                            Codigo = "V064",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000065"),
                            Codigo = "V065",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000066"),
                            Codigo = "V066",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000067"),
                            Codigo = "V067",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000068"),
                            Codigo = "V068",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000069"),
                            Codigo = "V069",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000070"),
                            Codigo = "V070",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000071"),
                            Codigo = "V071",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000072"),
                            Codigo = "V072",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000073"),
                            Codigo = "V073",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000074"),
                            Codigo = "V074",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000075"),
                            Codigo = "V075",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000076"),
                            Codigo = "V076",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000077"),
                            Codigo = "V077",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000078"),
                            Codigo = "V078",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000079"),
                            Codigo = "V079",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000080"),
                            Codigo = "V080",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000081"),
                            Codigo = "V081",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000082"),
                            Codigo = "V082",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000083"),
                            Codigo = "V083",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000084"),
                            Codigo = "V084",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000085"),
                            Codigo = "V085",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000086"),
                            Codigo = "V086",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000087"),
                            Codigo = "V087",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000088"),
                            Codigo = "V088",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000089"),
                            Codigo = "V089",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000090"),
                            Codigo = "V090",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000091"),
                            Codigo = "V091",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000092"),
                            Codigo = "V092",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000093"),
                            Codigo = "V093",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000094"),
                            Codigo = "V094",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000095"),
                            Codigo = "V095",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000096"),
                            Codigo = "V096",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000097"),
                            Codigo = "V097",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000098"),
                            Codigo = "V098",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000099"),
                            Codigo = "V099",
                            Ocupada = false
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000100"),
                            Codigo = "V100",
                            Ocupada = false
                        });
                });

            modelBuilder.Entity("Estacionamento.Domain.Entities.Ocupacao", b =>
                {
                    b.HasOne("Estacionamento.Domain.Entities.Carro", "Carro")
                        .WithMany()
                        .HasForeignKey("CarroId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Estacionamento.Domain.Entities.Vaga", "Vaga")
                        .WithOne("OcupacaoAtual")
                        .HasForeignKey("Estacionamento.Domain.Entities.Ocupacao", "VagaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Carro");

                    b.Navigation("Vaga");
                });

            modelBuilder.Entity("Estacionamento.Domain.Entities.Vaga", b =>
                {
                    b.Navigation("OcupacaoAtual");
                });
#pragma warning restore 612, 618
        }
    }
}
