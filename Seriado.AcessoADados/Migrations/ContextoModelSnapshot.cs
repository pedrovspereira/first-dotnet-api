﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Seriado.AcessoADados;
using System;

namespace Seriado.AcessoADados.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("Seriado.AcessoADados.Dominio.SeriadoObjeto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AvaliacaCriticos");

                    b.Property<int>("AvaliacaoPublico");

                    b.Property<string>("Categoria");

                    b.Property<float>("Duracao");

                    b.Property<string>("Nome");

                    b.Property<int>("QtdEpisodios");

                    b.Property<int>("Temporada");

                    b.HasKey("Id");

                    b.ToTable("Seriados");
                });
#pragma warning restore 612, 618
        }
    }
}
