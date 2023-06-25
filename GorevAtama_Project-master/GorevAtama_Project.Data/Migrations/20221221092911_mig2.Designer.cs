﻿// <auto-generated />
using GorevAtama_Project.Data.Concrete.EfCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GorevAtama_Project.Data.Migrations
{
    [DbContext(typeof(GorevAtama_ProjectContext))]
    [Migration("20221221092911_mig2")]
    partial class mig2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GorevAtama_Project.Entity.Islem", b =>
                {
                    b.Property<int>("IslemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IslemAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IslemZorluk")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IslemID");

                    b.ToTable("Islems");
                });

            modelBuilder.Entity("GorevAtama_Project.Entity.Personel", b =>
                {
                    b.Property<int>("PersonelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IslemID")
                        .HasColumnType("int");

                    b.Property<string>("PersonelAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonelSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RolID")
                        .HasColumnType("int");

                    b.HasKey("PersonelID");

                    b.HasIndex("IslemID");

                    b.HasIndex("RolID");

                    b.ToTable("Personels");
                });

            modelBuilder.Entity("GorevAtama_Project.Entity.Rol", b =>
                {
                    b.Property<int>("RolID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RolAd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RolID");

                    b.ToTable("Rols");
                });

            modelBuilder.Entity("GorevAtama_Project.Entity.Personel", b =>
                {
                    b.HasOne("GorevAtama_Project.Entity.Islem", "Islem")
                        .WithMany("Personels")
                        .HasForeignKey("IslemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GorevAtama_Project.Entity.Rol", "Rol")
                        .WithMany("Personels")
                        .HasForeignKey("RolID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Islem");

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("GorevAtama_Project.Entity.Islem", b =>
                {
                    b.Navigation("Personels");
                });

            modelBuilder.Entity("GorevAtama_Project.Entity.Rol", b =>
                {
                    b.Navigation("Personels");
                });
#pragma warning restore 612, 618
        }
    }
}
