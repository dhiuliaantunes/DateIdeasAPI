﻿// <auto-generated />
using DateIdeas.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DateIdeas.Migrations
{
    [DbContext(typeof(PostgreSQLContext))]
    partial class PostgreSQLContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("DateIdeas.DateIdeas", b =>
                {
                    b.Property<int>("DateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Date")
                        .HasColumnType("text");

                    b.Property<bool>("RainyDay")
                        .HasColumnType("boolean");

                    b.Property<bool>("SunnyDay")
                        .HasColumnType("boolean");

                    b.HasKey("DateId");

                    b.ToTable("DateIdeas");

                    b.HasData(
                        new
                        {
                            DateId = 1,
                            Date = "passear",
                            RainyDay = false,
                            SunnyDay = false
                        },
                        new
                        {
                            DateId = 2,
                            Date = "comer",
                            RainyDay = false,
                            SunnyDay = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
