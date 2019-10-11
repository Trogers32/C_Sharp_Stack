﻿// <auto-generated />
using System;
using ChefsDishes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChefsDishes.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20191011225630_five")]
    partial class five
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ChefsDishes.Models.Chef", b =>
                {
                    b.Property<int>("ChefId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Age");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("FName")
                        .IsRequired();

                    b.Property<string>("LName")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("dishes");

                    b.HasKey("ChefId");

                    b.ToTable("Chefs");
                });
#pragma warning restore 612, 618
        }
    }
}
