﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParksDirectory.Models;

#nullable disable

namespace ParksDirectory.Migrations
{
    [DbContext(typeof(ParksDirectoryContext))]
    [Migration("20230331203732_UpdateParkModel")]
    partial class UpdateParkModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ParksDirectory.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Activities")
                        .HasColumnType("longtext");

                    b.Property<string>("Classification")
                        .HasColumnType("longtext");

                    b.Property<string>("Facilities")
                        .HasColumnType("longtext");

                    b.Property<string>("Location")
                        .HasColumnType("longtext");

                    b.Property<string>("MajorLandmarks")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("YearFounded")
                        .HasColumnType("int");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            Activities = "Hiking, camping, birding, fishing, skiing, snowshoeing, snowboarding, sledding",
                            Classification = "national park",
                            Facilities = "Summer tent and RV camping, electric hookups, seasonal laundry, flush toilets, and showers",
                            Location = "Oregon",
                            MajorLandmarks = "Crater Lake, Wizard Island",
                            Name = "Crater Lake",
                            YearFounded = 1902
                        },
                        new
                        {
                            ParkId = 2,
                            Activities = "Biking, camping, fishing, horseback riding, hiking, boating, swimming, skiing, snowshoeing",
                            Classification = "national monument",
                            Facilities = "Tent and RV camping, flush toilets at some campgrounds",
                            Location = "Oregon",
                            MajorLandmarks = "Lava Butte, Lava River Cave, Lava Cast Forest, Newberry Caldera, Big Obsidian Flow, Paulina Peak, East Lake, Paulina Lake",
                            Name = "Newberry National Volcanic Monument",
                            YearFounded = 1990
                        },
                        new
                        {
                            ParkId = 3,
                            Activities = "Rock climbing, hiking, horseback riding, biking, camping, kayaking",
                            Classification = "state park",
                            Facilities = "Walk-in camping, showers, restrooms",
                            Location = "Oregon",
                            MajorLandmarks = "Smith Rock",
                            Name = "Smith Rock State Park",
                            YearFounded = 1960
                        },
                        new
                        {
                            ParkId = 4,
                            Activities = "Hiking, camping, biking, swimming",
                            Classification = "state park",
                            Facilities = "Yurts, cabins, tent camping, showers, flush toilets",
                            Location = "Oregon",
                            MajorLandmarks = "Deschutes River Trail",
                            Name = "Tumalo State Park",
                            YearFounded = 1954
                        },
                        new
                        {
                            ParkId = 5,
                            Activities = "Biking, camping, hiking, horseback riding, boating, swimming, skiing, snowboarding, sledding, caving",
                            Classification = "national forest",
                            Facilities = "Varies by site",
                            Location = "Oregon",
                            MajorLandmarks = "Mount Jefferson, Mount Washington, the Three Sisters, Lava Lands, Metolius River, Cascade Lakes",
                            Name = "Deschutes National Forest",
                            YearFounded = 1908
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
