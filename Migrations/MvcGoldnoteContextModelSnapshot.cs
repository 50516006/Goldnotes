﻿// <auto-generated />
using System;
using Goldnote.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Goldnote.Migrations
{
    [DbContext(typeof(MvcGoldnoteContext))]
    partial class MvcGoldnoteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Goldnote.Models.GoldNote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Change")
                        .HasColumnType("bit");

                    b.Property<string>("CreditCardMachine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Destination")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EditDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EditerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GoldNoteName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GoldNoteSendingPaper")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OnAccounting")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecialOptions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("WithDiscount")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Goldnote");
                });
#pragma warning restore 612, 618
        }
    }
}
