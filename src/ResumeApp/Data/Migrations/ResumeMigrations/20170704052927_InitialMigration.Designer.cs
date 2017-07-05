using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ResumeApp.Data;

namespace ResumeApp.Data.Migrations.ResumeMigrations
{
    [DbContext(typeof(ResumeContext))]
    [Migration("20170704052927_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("ResumeApp.Models.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Biography");

                    b.Property<string>("City");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Phone");

                    b.Property<string>("State");

                    b.HasKey("ID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ResumeApp.Models.Job", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompanyName");

                    b.Property<string>("Description");

                    b.Property<int?>("EmployeeID");

                    b.Property<DateTime?>("EndDate");

                    b.Property<string>("ImageUrl");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("ResumeApp.Models.Skill", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int?>("EmployeeID");

                    b.Property<string>("Name");

                    b.Property<int>("Proficiency");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("ResumeApp.Models.Job", b =>
                {
                    b.HasOne("ResumeApp.Models.Employee", "Employee")
                        .WithMany("Jobs")
                        .HasForeignKey("EmployeeID");
                });

            modelBuilder.Entity("ResumeApp.Models.Skill", b =>
                {
                    b.HasOne("ResumeApp.Models.Employee", "Employee")
                        .WithMany("Skills")
                        .HasForeignKey("EmployeeID");
                });
        }
    }
}
