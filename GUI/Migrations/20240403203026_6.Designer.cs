﻿// <auto-generated />
using GUI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GUI.Migrations
{
    [DbContext(typeof(DrinkDB))]
    [Migration("20240403203026_6")]
    partial class _6
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("API_BazaDanych.Drink", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AlternateDrink")
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<string>("Glass")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ingredients")
                        .HasColumnType("TEXT");

                    b.Property<string>("Instructions")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAlcoholic")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Measuers")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SearchID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Tags")
                        .HasColumnType("TEXT");

                    b.Property<bool>("detailed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("drinkPIC")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Drinks");
                });
#pragma warning restore 612, 618
        }
    }
}
