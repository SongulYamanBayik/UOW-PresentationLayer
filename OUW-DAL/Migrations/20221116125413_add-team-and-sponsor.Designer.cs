﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OUW_DAL.Concrete;

namespace OUW_DAL.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221116125413_add-team-and-sponsor")]
    partial class addteamandsponsor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OUW_EL.Concrete.BankAccountDetail", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<string>("AccountNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("BankAccountDetails");
                });

            modelBuilder.Entity("OUW_EL.Concrete.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("OUW_EL.Concrete.Sponsor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SponsorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Sponsors");
                });

            modelBuilder.Entity("OUW_EL.Concrete.Team", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TeamName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("SponsorTeam", b =>
                {
                    b.Property<int>("SponsorsID")
                        .HasColumnType("int");

                    b.Property<int>("TeamsID")
                        .HasColumnType("int");

                    b.HasKey("SponsorsID", "TeamsID");

                    b.HasIndex("TeamsID");

                    b.ToTable("SponsorTeam");
                });

            modelBuilder.Entity("OUW_EL.Concrete.BankAccountDetail", b =>
                {
                    b.HasOne("OUW_EL.Concrete.Customer", "Customer")
                        .WithOne("BankAccountDetail")
                        .HasForeignKey("OUW_EL.Concrete.BankAccountDetail", "ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("SponsorTeam", b =>
                {
                    b.HasOne("OUW_EL.Concrete.Sponsor", null)
                        .WithMany()
                        .HasForeignKey("SponsorsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OUW_EL.Concrete.Team", null)
                        .WithMany()
                        .HasForeignKey("TeamsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OUW_EL.Concrete.Customer", b =>
                {
                    b.Navigation("BankAccountDetail");
                });
#pragma warning restore 612, 618
        }
    }
}