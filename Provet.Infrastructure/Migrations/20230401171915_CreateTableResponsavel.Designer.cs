﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Provet.Infrastructure.Configuration;

#nullable disable

namespace Provet.Infrastructure.Migrations
{
    [DbContext(typeof(ContextBase))]
    [Migration("20230401171915_CreateTableResponsavel")]
    partial class CreateTableResponsavel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Provet.Entities.Entities.Responsavel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("RESP_ID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("AtualizadoEm")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("RESP_ATUALIZADO_EM");

                    b.Property<string>("Bairro")
                        .HasColumnType("text")
                        .HasColumnName("RESP_BAIRRO");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasColumnName("RESP_CELULAR");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("RESP_CEP");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("RESP_CIDADE");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("character varying(14)")
                        .HasColumnName("RESP_CPF");

                    b.Property<DateTime?>("CriadoEm")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("RESP_CRIADO_EM");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("RESP_DATA_NASCIMENTO");

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("RESP_EMAIL");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("RESP_ENDERECO");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("RESP_ESTADO");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("RESP_NOME");

                    b.Property<string>("Numero")
                        .HasColumnType("text")
                        .HasColumnName("RESP_NUMERO");

                    b.Property<string>("Observacao")
                        .HasColumnType("text")
                        .HasColumnName("RESP_OBERVACAO");

                    b.Property<string>("Rg")
                        .HasColumnType("text")
                        .HasColumnName("RESP_RG");

                    b.Property<string>("Telefone")
                        .HasColumnType("text")
                        .HasColumnName("RESP_TELEFONE");

                    b.HasKey("Id");

                    b.ToTable("TB_RESPONSAVEL");
                });
#pragma warning restore 612, 618
        }
    }
}