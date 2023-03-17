﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoApp.Data;

#nullable disable

namespace TodoApp.Migrations
{
    [DbContext(typeof(TodoDBContext))]
    [Migration("20230316042620_defaultValues")]
    partial class defaultValues
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TodoApp.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "For Birthday",
                            DueDate = new DateTime(2023, 3, 17, 12, 26, 20, 226, DateTimeKind.Local).AddTicks(2131),
                            Status = false,
                            Title = "Shopping"
                        },
                        new
                        {
                            Id = 2,
                            Description = "In Jump Training",
                            DueDate = new DateTime(2023, 3, 18, 12, 26, 20, 226, DateTimeKind.Local).AddTicks(2148),
                            Status = false,
                            Title = "Learn C#"
                        },
                        new
                        {
                            Id = 3,
                            Description = "For Jump Training",
                            DueDate = new DateTime(2023, 3, 18, 12, 26, 20, 226, DateTimeKind.Local).AddTicks(2149),
                            Status = false,
                            Title = "Learn MSSQL"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
