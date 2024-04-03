﻿// <auto-generated />
using System;
using CA_EFHastaneOtomasyon.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CA_EFHastaneOtomasyon.Migrations
{
    [DbContext(typeof(EFHastaneOtomasyonContext))]
    [Migration("20240403195340_initialDatabase")]
    partial class initialDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CA_EFHastaneOtomasyon.Models.Entities.Hastalar", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("HastaAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HastaSoyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tckn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Hastalars");
                });

            modelBuilder.Entity("CA_EFHastaneOtomasyon.Models.Entities.TahlilSonuclari", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("HastalarId")
                        .HasColumnType("int");

                    b.Property<string>("TahlilDosyaLinki")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TahlilZamani")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("HastalarId");

                    b.ToTable("TahlilSonuclaris");
                });

            modelBuilder.Entity("CA_EFHastaneOtomasyon.Models.Entities.TahlilSonuclari", b =>
                {
                    b.HasOne("CA_EFHastaneOtomasyon.Models.Entities.Hastalar", "Hasta")
                        .WithMany("TahlilSonuclaris")
                        .HasForeignKey("HastalarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hasta");
                });

            modelBuilder.Entity("CA_EFHastaneOtomasyon.Models.Entities.Hastalar", b =>
                {
                    b.Navigation("TahlilSonuclaris");
                });
#pragma warning restore 612, 618
        }
    }
}
