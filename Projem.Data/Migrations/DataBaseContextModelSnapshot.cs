﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projem.Data;

#nullable disable

namespace Projem.Data.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Projem.Entities.Arac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Fiyati")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("KasaTipi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("MarkaId")
                        .HasColumnType("int");

                    b.Property<int>("ModelYili")
                        .HasColumnType("int");

                    b.Property<string>("Modeli")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Notlar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Renk")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Resim1")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Resim2")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Resim3")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("SatistaMi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("MarkaId");

                    b.ToTable("Araclar");
                });

            modelBuilder.Entity("Projem.Entities.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("AktifMi")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("EklenmeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("KullaniciAdi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("RolId");

                    b.ToTable("Kullanicilar");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adi = "Admin",
                            AktifMi = true,
                            EklenmeTarihi = new DateTime(2024, 4, 24, 1, 20, 24, 625, DateTimeKind.Local).AddTicks(1365),
                            Email = "admin@panelim.com",
                            KullaniciAdi = "admin",
                            RolId = 1,
                            Sifre = "1234561",
                            Soyadi = "admin",
                            Telefon = "5522531723"
                        });
                });

            modelBuilder.Entity("Projem.Entities.Marka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Markalar");
                });

            modelBuilder.Entity("Projem.Entities.Musteri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Adres")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("AracId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Notlar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TcNo")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Telefon")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("AracId");

                    b.ToTable("Musteriler");
                });

            modelBuilder.Entity("Projem.Entities.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Roller");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adi = "Admin"
                        });
                });

            modelBuilder.Entity("Projem.Entities.Satis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AracId")
                        .HasColumnType("int");

                    b.Property<int>("MusteriId")
                        .HasColumnType("int");

                    b.Property<decimal>("SatisFiyati")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("SatisTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AracId");

                    b.HasIndex("MusteriId");

                    b.ToTable("Satislar");
                });

            modelBuilder.Entity("Projem.Entities.Servis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AracPlaka")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("AracSorunu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GarantiKapsamindaMi")
                        .HasColumnType("bit");

                    b.Property<string>("KasaTipi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Marka")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Model")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Notlar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SaseNo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("ServisUcreti")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ServiseGelisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ServistenCikisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("YapilanIslemler")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Servisler");
                });

            modelBuilder.Entity("Projem.Entities.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("Baslik")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Gorsel")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Link")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Sliders");
                });

            modelBuilder.Entity("Projem.Entities.Arac", b =>
                {
                    b.HasOne("Projem.Entities.Marka", "Marka")
                        .WithMany()
                        .HasForeignKey("MarkaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marka");
                });

            modelBuilder.Entity("Projem.Entities.Kullanici", b =>
                {
                    b.HasOne("Projem.Entities.Rol", "Rol")
                        .WithMany()
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("Projem.Entities.Musteri", b =>
                {
                    b.HasOne("Projem.Entities.Arac", "Arac")
                        .WithMany()
                        .HasForeignKey("AracId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Arac");
                });

            modelBuilder.Entity("Projem.Entities.Satis", b =>
                {
                    b.HasOne("Projem.Entities.Arac", "Arac")
                        .WithMany()
                        .HasForeignKey("AracId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projem.Entities.Musteri", "Musteri")
                        .WithMany()
                        .HasForeignKey("MusteriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Arac");

                    b.Navigation("Musteri");
                });
#pragma warning restore 612, 618
        }
    }
}
