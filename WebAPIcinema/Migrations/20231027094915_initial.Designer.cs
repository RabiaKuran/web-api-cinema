﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPIcinema.Model.Context;

#nullable disable

namespace WebAPIcinema.Migrations
{
    [DbContext(typeof(FilmDbContext))]
    [Migration("20231027094915_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebAPIcinema.Model.Entity.Film", b =>
                {
                    b.Property<int>("filmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("filmId"));

                    b.Property<string>("filmIsmi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("filmTuru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("hIciFiyat")
                        .HasColumnType("real");

                    b.Property<float>("hSonuFiyat")
                        .HasColumnType("real");

                    b.Property<DateTime>("vizyonTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("filmId");

                    b.ToTable("Film");
                });
#pragma warning restore 612, 618
        }
    }
}
