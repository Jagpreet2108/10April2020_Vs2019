﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _10April2020_1.Models;

namespace _10April2020_1.Migrations
{
    [DbContext(typeof(CustomerContext))]
    [Migration("20200410064850_MyMigration")]
    partial class MyMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_10April2020_1.Models.Customer", b =>
                {
                    b.Property<int>("CId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CPin")
                        .HasColumnType("int")
                        .HasMaxLength(4);

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.HasKey("CId");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            CId = 1,
                            CName = "Sameer",
                            CPin = 1122,
                            DOB = new DateTime(2020, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CId = 2,
                            CName = "Zoya",
                            CPin = 1111,
                            DOB = new DateTime(2020, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CId = 3,
                            CName = "Chetna",
                            CPin = 2222,
                            DOB = new DateTime(2020, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CId = 4,
                            CName = "Kartik",
                            CPin = 3322,
                            DOB = new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}