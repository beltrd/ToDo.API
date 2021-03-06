﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDo.API.Infrastructure;

namespace ToDo.API.Migrations
{
    [DbContext(typeof(ConnectContext))]
    partial class ConnectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ToDo.API.Models.GroupConnect", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Connection");

                    b.Property<string>("GroupName");

                    b.HasKey("Id");

                    b.ToTable("GroupConnect");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Connection = "server=localhost;port=3306;database=diegoDB1;user=diego_web;password=xQvy1Jc502rFbldI7ZoivIWk;",
                            GroupName = "diego1"
                        },
                        new
                        {
                            Id = 2,
                            Connection = "server=localhost;port=3306;database=diegoDB2;user=diego_web;password=xQvy1Jc502rFbldI7ZoivIWk;",
                            GroupName = "diego2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
