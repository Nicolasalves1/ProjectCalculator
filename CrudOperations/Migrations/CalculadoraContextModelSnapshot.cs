﻿// <auto-generated />
using System;
using CrudOperations.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CrudOperations.Migrations
{
    [DbContext(typeof(CalculadoraContext))]
    partial class CalculadoraContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CrudOperations.Models.Calculadora", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("data")
                        .HasColumnType("datetime2");

                    b.Property<string>("operator_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("result_even_odd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("resultad")
                        .HasColumnType("int");

                    b.Property<string>("resultado_prime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Calculadoras");
                });
#pragma warning restore 612, 618
        }
    }
}
