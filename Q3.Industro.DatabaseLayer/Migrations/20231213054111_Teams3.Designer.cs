﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Q3.Industro.DataLayer.Data;

namespace Q3.Industro.DataLayer.Migrations
{
    [DbContext(typeof(IndustroDbContext))]
    [Migration("20231213054111_Teams3")]
    partial class Teams3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Q3.Industro.ModelLayer.Models.Projects.ProjectInformation", b =>
                {
                    b.Property<int>("Projectid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProjectImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ProjectShow")
                        .HasColumnType("bit");

                    b.HasKey("Projectid");

                    b.ToTable("ProjectTable");
                });

            modelBuilder.Entity("Q3.Industro.ModelLayer.Models.Services.ServiceInformation", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ServiceDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ServiceShow")
                        .HasColumnType("bit");

                    b.HasKey("ServiceId");

                    b.ToTable("ServiceInformations");
                });

            modelBuilder.Entity("Q3.Industro.ModelLayer.Models.Teams.TeamInformation", b =>
                {
                    b.Property<int>("teamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("teamDuration")
                        .HasColumnType("float");

                    b.Property<string>("teamHead")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("teamImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("teamMember")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("teamPosition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("teamShow")
                        .HasColumnType("bit");

                    b.HasKey("teamId");

                    b.ToTable("TeamTable");
                });

            modelBuilder.Entity("Q3.Industro.ModelLayer.Models.Testimonials.TestimonialInformation", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClientDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientProf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ClientShow")
                        .HasColumnType("bit");

                    b.HasKey("ClientId");

                    b.ToTable("TestimonialTable");
                });
#pragma warning restore 612, 618
        }
    }
}
