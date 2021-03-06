// <auto-generated />
using System;
using MachineService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MachineService.Migrations
{
    [DbContext(typeof(MachineServiceContext))]
    [Migration("20211130143617_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MachineService.Models.Machine", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("DateReleased")
                        .HasColumnType("datetime2");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ServiceID")
                        .HasColumnType("int");

                    b.Property<bool>("UnderService")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("ServiceID");

                    b.ToTable("Machine");
                });

            modelBuilder.Entity("MachineService.Models.Service", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("MachineID")
                        .HasColumnType("int");

                    b.Property<decimal>("TimeInDays")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("ID");

                    b.HasIndex("MachineID");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("MachineService.Models.Machine", b =>
                {
                    b.HasOne("MachineService.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceID");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("MachineService.Models.Service", b =>
                {
                    b.HasOne("MachineService.Models.Machine", "Machine")
                        .WithMany()
                        .HasForeignKey("MachineID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Machine");
                });
#pragma warning restore 612, 618
        }
    }
}
