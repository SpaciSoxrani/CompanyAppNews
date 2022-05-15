﻿// <auto-generated />
using System;
using CompanyApp.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CompanyApp.Infrastructure.Migrations
{
    [DbContext(typeof(CompanyAppContext))]
    [Migration("20220513090608_v4")]
    partial class v4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.2.22153.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CompanyApp.Core.Domain.Models.EventPlace", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Prediction")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Probability")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("EventPlace");
                });

            modelBuilder.Entity("CompanyApp.Core.Domain.Models.MainTitle", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Prediction")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Probability")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("MainTitle");
                });

            modelBuilder.Entity("CompanyApp.Core.Domain.Models.MusicEvent", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Genre")
                        .HasColumnType("text");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Prediction")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<double>("Probability")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("eventPlaceId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("eventPlaceId");

                    b.ToTable("MusEvent");
                });

            modelBuilder.Entity("CompanyApp.Core.Domain.Models.MusicEvent", b =>
                {
                    b.HasOne("CompanyApp.Core.Domain.Models.EventPlace", "eventPlace")
                        .WithMany()
                        .HasForeignKey("eventPlaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("eventPlace");
                });
#pragma warning restore 612, 618
        }
    }
}
