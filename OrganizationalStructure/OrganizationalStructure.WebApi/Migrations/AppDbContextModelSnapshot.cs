﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OrganizationalStructure.Infrastructure;

#nullable disable

namespace OrganizationalStructure.WebApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("OrganizationalStructure.Domain.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("DepartmentDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("department_name");

                    b.Property<int?>("ManagingDepartmentId")
                        .HasColumnType("integer")
                        .HasColumnName("managing_dept_id");

                    b.HasKey("Id");

                    b.HasIndex("ManagingDepartmentId");

                    b.ToTable("department", (string)null);
                });

            modelBuilder.Entity("OrganizationalStructure.Domain.Department", b =>
                {
                    b.HasOne("OrganizationalStructure.Domain.Department", "ManagingDepartment")
                        .WithMany()
                        .HasForeignKey("ManagingDepartmentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("ManagingDepartment");
                });
#pragma warning restore 612, 618
        }
    }
}
