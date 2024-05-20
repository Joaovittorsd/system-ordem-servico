﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ordemServico.Database;

#nullable disable

namespace ordemServico.Migrations
{
    [DbContext(typeof(GsoContext))]
    [Migration("20240516191714_CriandoTabelaItemOrdemServico")]
    partial class CriandoTabelaItemOrdemServico
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("ordemServico.Model.ChamadaModel", b =>
                {
                    b.Property<int>("IdChamada")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdChamada"));

                    b.Property<string>("Chamada")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdChamada");

                    b.ToTable("Chamadas");
                });

            modelBuilder.Entity("ordemServico.Model.ItemOrdemDeServicoModel", b =>
                {
                    b.Property<int>("IdItemOrdemServico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdItemOrdemServico"));

                    b.Property<string>("AcaoTomada")
                        .HasColumnType("longtext");

                    b.Property<string>("Observacao")
                        .HasColumnType("longtext");

                    b.Property<int>("OrdemServicoId")
                        .HasColumnType("int");

                    b.Property<string>("ProblemaEncontrado")
                        .HasColumnType("longtext");

                    b.HasKey("IdItemOrdemServico");

                    b.HasIndex("OrdemServicoId");

                    b.ToTable("itensOrdensServicos");
                });

            modelBuilder.Entity("ordemServico.Model.OrdemServicoModel", b =>
                {
                    b.Property<int>("IdOrdemServico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdOrdemServico"));

                    b.Property<int>("ChamadaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAbertura")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataFechamento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("HorimetroKm")
                        .HasColumnType("longtext");

                    b.Property<int>("SolicitanteId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int>("VeiculoId")
                        .HasColumnType("int");

                    b.HasKey("IdOrdemServico");

                    b.HasIndex("ChamadaId");

                    b.HasIndex("SolicitanteId");

                    b.HasIndex("UsuarioId");

                    b.HasIndex("VeiculoId");

                    b.ToTable("OrdensServicos");
                });

            modelBuilder.Entity("ordemServico.Model.SolicitanteModel", b =>
                {
                    b.Property<int>("IdSolicitante")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdSolicitante"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdSolicitante");

                    b.ToTable("Solicitantes");
                });

            modelBuilder.Entity("ordemServico.Model.UsuarioModel", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdUsuario"));

                    b.Property<string>("Departamento")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ordemServico.Model.VeiculoModel", b =>
                {
                    b.Property<int>("IdVeiculo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdVeiculo"));

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Prefixo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdVeiculo");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("ordemServico.Model.ItemOrdemDeServicoModel", b =>
                {
                    b.HasOne("ordemServico.Model.OrdemServicoModel", "OrdemServico")
                        .WithMany()
                        .HasForeignKey("OrdemServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrdemServico");
                });

            modelBuilder.Entity("ordemServico.Model.OrdemServicoModel", b =>
                {
                    b.HasOne("ordemServico.Model.ChamadaModel", "Chamada")
                        .WithMany()
                        .HasForeignKey("ChamadaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ordemServico.Model.SolicitanteModel", "Solicitante")
                        .WithMany()
                        .HasForeignKey("SolicitanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ordemServico.Model.UsuarioModel", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ordemServico.Model.VeiculoModel", "Veiculo")
                        .WithMany()
                        .HasForeignKey("VeiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chamada");

                    b.Navigation("Solicitante");

                    b.Navigation("Usuario");

                    b.Navigation("Veiculo");
                });
#pragma warning restore 612, 618
        }
    }
}
