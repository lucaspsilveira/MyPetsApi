// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyPets.Database;

#nullable disable

namespace MyPets.Migrations
{
    [DbContext(typeof(MyPetsDatabaseContext))]
    [Migration("20220519223711_AddedType")]
    partial class AddedType
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("MyPets.Pet", b =>
                {
                    b.Property<Guid>("PetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PetType")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("PetId");

                    b.ToTable("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}
