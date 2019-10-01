﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project.Infra.Data.Context;

namespace Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191001122455_InitialCreateUsers")]
    partial class InitialCreateUsers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Project.Domain.Entities.AddressEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Altitude")
                        .HasMaxLength(100);

                    b.Property<string>("City")
                        .HasMaxLength(200);

                    b.Property<string>("Complement")
                        .HasMaxLength(200);

                    b.Property<string>("Countries");

                    b.Property<DateTime?>("CreateAt");

                    b.Property<string>("District")
                        .HasMaxLength(200);

                    b.Property<string>("Longitude")
                        .HasMaxLength(100);

                    b.Property<string>("Number")
                        .HasMaxLength(20);

                    b.Property<string>("Obs")
                        .HasMaxLength(200);

                    b.Property<string>("State")
                        .HasMaxLength(200);

                    b.Property<string>("Street")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("UpdateAt");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Project.Domain.Entities.CompanyEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AddressId");

                    b.Property<string>("CNPJ")
                        .HasMaxLength(30);

                    b.Property<DateTime?>("CreateAt");

                    b.Property<string>("NomeFantasia")
                        .HasMaxLength(200);

                    b.Property<string>("Phone1")
                        .HasMaxLength(15);

                    b.Property<string>("Phone2")
                        .HasMaxLength(15);

                    b.Property<string>("RazaoSocial")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("UpdateAt");

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("UserId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("Project.Domain.Entities.CustomersEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AddressId");

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<DateTime?>("CreateAt");

                    b.Property<string>("RG")
                        .HasMaxLength(30);

                    b.Property<DateTime?>("UpdateAt");

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("UserId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Project.Domain.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreateAt");

                    b.Property<string>("ImgPerfil");

                    b.Property<int>("Tipo");

                    b.Property<DateTime?>("UpdateAt");

                    b.HasKey("Id");

                    b.HasIndex("ImgPerfil")
                        .IsUnique();

                    b.ToTable("User");
                });

            modelBuilder.Entity("Project.Domain.Entities.WorkshopEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AddressId");

                    b.Property<Guid?>("CompanyId");

                    b.Property<DateTime?>("CreateAt");

                    b.Property<string>("NameWorkshop")
                        .HasMaxLength(200);

                    b.Property<string>("Phone1")
                        .HasMaxLength(15);

                    b.Property<string>("Phone2")
                        .HasMaxLength(15);

                    b.Property<DateTime?>("UpdateAt");

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("UserId");

                    b.ToTable("Workshop");
                });

            modelBuilder.Entity("Project.Domain.Entities.CompanyEntity", b =>
                {
                    b.HasOne("Project.Domain.Entities.AddressEntity", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("Project.Domain.Entities.UserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Project.Domain.Entities.CustomersEntity", b =>
                {
                    b.HasOne("Project.Domain.Entities.AddressEntity", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("Project.Domain.Entities.UserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Project.Domain.Entities.WorkshopEntity", b =>
                {
                    b.HasOne("Project.Domain.Entities.AddressEntity", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("Project.Domain.Entities.CompanyEntity", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("Project.Domain.Entities.UserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}