﻿// <auto-generated />
using Hospital_Class_Library.Graphical_Editor.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Hospital_Class_Library.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Hospital_Class_Library.Graphical_Editor.Models.Building", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Buildings");

                    b.HasData(
                        new
                        {
                            Id = "b1",
                            Description = "The administrative center of Oasis Healthcare",
                            Name = "Oasis Main Building"
                        },
                        new
                        {
                            Id = "b2",
                            Description = "The treatment facility of Oasis Healthcare",
                            Name = "Oasis Treatment Center"
                        });
                });

            modelBuilder.Entity("Hospital_Class_Library.Graphical_Editor.Models.Room", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("BuildingId")
                        .HasColumnType("text");

                    b.Property<int>("Floor")
                        .HasColumnType("integer");

                    b.Property<int>("FreeBeds")
                        .HasColumnType("integer");

                    b.Property<double>("Height")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<double>("Width")
                        .HasColumnType("double precision");

                    b.Property<double>("X")
                        .HasColumnType("double precision");

                    b.Property<double>("Y")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            BuildingId = "b1",
                            Floor = 0,
                            FreeBeds = 0,
                            Height = 220.0,
                            Name = "0A",
                            Status = 1,
                            Type = 4,
                            Width = 228.0,
                            X = 422.0,
                            Y = 187.0
                        },
                        new
                        {
                            Id = "2",
                            BuildingId = "b1",
                            Floor = 0,
                            FreeBeds = 0,
                            Height = 217.0,
                            Name = "0B",
                            Status = 1,
                            Type = 4,
                            Width = 229.0,
                            X = 422.0,
                            Y = 683.0
                        },
                        new
                        {
                            Id = "3",
                            BuildingId = "b1",
                            Floor = 0,
                            FreeBeds = 0,
                            Height = 254.0,
                            Name = "0C",
                            Status = 1,
                            Type = 4,
                            Width = 209.0,
                            X = 651.0,
                            Y = 596.0
                        },
                        new
                        {
                            Id = "4",
                            BuildingId = "b1",
                            Floor = 0,
                            FreeBeds = 1,
                            Height = 170.0,
                            Name = "0A",
                            Status = 1,
                            Type = 0,
                            Width = 210.0,
                            X = 1182.0,
                            Y = 237.0
                        },
                        new
                        {
                            Id = "5",
                            BuildingId = "b1",
                            Floor = 0,
                            FreeBeds = 1,
                            Height = 170.0,
                            Name = "0B",
                            Status = 1,
                            Type = 0,
                            Width = 210.0,
                            X = 650.0,
                            Y = 237.0
                        },
                        new
                        {
                            Id = "6",
                            BuildingId = "b1",
                            Floor = 0,
                            FreeBeds = 1,
                            Height = 170.0,
                            Name = "0A",
                            Status = 1,
                            Type = 1,
                            Width = 322.0,
                            X = 861.0,
                            Y = 237.0
                        },
                        new
                        {
                            Id = "7",
                            BuildingId = "b1",
                            Floor = 0,
                            FreeBeds = 1,
                            Height = 154.0,
                            Name = "0A",
                            Status = 1,
                            Type = 3,
                            Width = 202.0,
                            X = 1190.0,
                            Y = 696.0
                        },
                        new
                        {
                            Id = "8",
                            BuildingId = "b1",
                            Floor = 0,
                            FreeBeds = 1,
                            Height = 154.0,
                            Name = "0B",
                            Status = 1,
                            Type = 3,
                            Width = 202.0,
                            X = 1190.0,
                            Y = 541.0
                        },
                        new
                        {
                            Id = "9",
                            BuildingId = "b1",
                            Floor = 0,
                            FreeBeds = 0,
                            Height = 138.0,
                            Name = "Men Restroom",
                            Status = 1,
                            Type = 5,
                            Width = 106.0,
                            X = 422.0,
                            Y = 407.0
                        },
                        new
                        {
                            Id = "10",
                            BuildingId = "b1",
                            Floor = 0,
                            FreeBeds = 0,
                            Height = 138.0,
                            Name = "Women Restroom",
                            Status = 1,
                            Type = 5,
                            Width = 106.0,
                            X = 422.0,
                            Y = 544.0
                        },
                        new
                        {
                            Id = "11",
                            BuildingId = "b1",
                            Floor = 0,
                            FreeBeds = 0,
                            Height = 69.0,
                            Name = "L",
                            Status = 1,
                            Type = 6,
                            Width = 69.0,
                            X = 581.0,
                            Y = 407.0
                        },
                        new
                        {
                            Id = "12",
                            BuildingId = "b1",
                            Floor = 0,
                            FreeBeds = 0,
                            Height = 134.0,
                            Name = "S1",
                            Status = 1,
                            Type = 7,
                            Width = 69.0,
                            X = 581.0,
                            Y = 548.0
                        },
                        new
                        {
                            Id = "13",
                            BuildingId = "b1",
                            Floor = 1,
                            FreeBeds = 0,
                            Height = 220.0,
                            Name = "1A",
                            Status = 1,
                            Type = 4,
                            Width = 228.0,
                            X = 422.0,
                            Y = 187.0
                        },
                        new
                        {
                            Id = "14",
                            BuildingId = "b1",
                            Floor = 1,
                            FreeBeds = 0,
                            Height = 217.0,
                            Name = "1B",
                            Status = 1,
                            Type = 4,
                            Width = 229.0,
                            X = 422.0,
                            Y = 683.0
                        },
                        new
                        {
                            Id = "15",
                            BuildingId = "b1",
                            Floor = 1,
                            FreeBeds = 0,
                            Height = 254.0,
                            Name = "1C",
                            Status = 1,
                            Type = 4,
                            Width = 209.0,
                            X = 651.0,
                            Y = 596.0
                        },
                        new
                        {
                            Id = "16",
                            BuildingId = "b1",
                            Floor = 1,
                            FreeBeds = 1,
                            Height = 170.0,
                            Name = "1A",
                            Status = 1,
                            Type = 0,
                            Width = 210.0,
                            X = 1182.0,
                            Y = 237.0
                        },
                        new
                        {
                            Id = "17",
                            BuildingId = "b1",
                            Floor = 1,
                            FreeBeds = 1,
                            Height = 170.0,
                            Name = "1B",
                            Status = 1,
                            Type = 0,
                            Width = 210.0,
                            X = 650.0,
                            Y = 237.0
                        },
                        new
                        {
                            Id = "18",
                            BuildingId = "b1",
                            Floor = 1,
                            FreeBeds = 1,
                            Height = 170.0,
                            Name = "1A",
                            Status = 1,
                            Type = 1,
                            Width = 322.0,
                            X = 861.0,
                            Y = 237.0
                        },
                        new
                        {
                            Id = "19",
                            BuildingId = "b1",
                            Floor = 1,
                            FreeBeds = 1,
                            Height = 154.0,
                            Name = "1A",
                            Status = 1,
                            Type = 3,
                            Width = 202.0,
                            X = 1190.0,
                            Y = 696.0
                        },
                        new
                        {
                            Id = "20",
                            BuildingId = "b1",
                            Floor = 1,
                            FreeBeds = 1,
                            Height = 154.0,
                            Name = "1B",
                            Status = 1,
                            Type = 3,
                            Width = 202.0,
                            X = 1190.0,
                            Y = 541.0
                        },
                        new
                        {
                            Id = "21",
                            BuildingId = "b1",
                            Floor = 1,
                            FreeBeds = 0,
                            Height = 138.0,
                            Name = "Men Restroom",
                            Status = 1,
                            Type = 5,
                            Width = 106.0,
                            X = 422.0,
                            Y = 407.0
                        },
                        new
                        {
                            Id = "22",
                            BuildingId = "b1",
                            Floor = 1,
                            FreeBeds = 0,
                            Height = 138.0,
                            Name = "Women Restroom",
                            Status = 1,
                            Type = 5,
                            Width = 106.0,
                            X = 422.0,
                            Y = 544.0
                        },
                        new
                        {
                            Id = "23",
                            BuildingId = "b1",
                            Floor = 1,
                            FreeBeds = 0,
                            Height = 69.0,
                            Name = "L",
                            Status = 1,
                            Type = 6,
                            Width = 69.0,
                            X = 581.0,
                            Y = 407.0
                        },
                        new
                        {
                            Id = "24",
                            BuildingId = "b1",
                            Floor = 1,
                            FreeBeds = 0,
                            Height = 134.0,
                            Name = "S1",
                            Status = 1,
                            Type = 7,
                            Width = 69.0,
                            X = 581.0,
                            Y = 548.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
