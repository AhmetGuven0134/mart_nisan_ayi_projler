﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using urun.Models;

#nullable disable

namespace urun.Migrations
{
    [DbContext(typeof(UrunContext))]
    [Migration("20250408094607_yeni")]
    partial class yeni
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.3");

            modelBuilder.Entity("urun.Models.Urunler", b =>
                {
                    b.Property<int>("urunID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("kategoriID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("urunAciklama")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("urunAd")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("urunFiyat")
                        .HasColumnType("REAL");

                    b.Property<string>("urunResim")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("urunStok")
                        .HasColumnType("INTEGER");

                    b.HasKey("urunID");

                    b.ToTable("urunlistesi");
                });
#pragma warning restore 612, 618
        }
    }
}
