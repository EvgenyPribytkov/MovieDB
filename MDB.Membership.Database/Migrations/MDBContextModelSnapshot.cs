﻿// <auto-generated />
using System;
using MDB.Membership.Database.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MDB.Membership.Database.Migrations
{
    [DbContext(typeof(MDBContext))]
    partial class MDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MDB.Membership.Database.Entities.Director", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Directors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Alex Garland"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Steven Spielberg"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Denis Villeneuve"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Steven Spielberg"
                        });
                });

            modelBuilder.Entity("MDB.Membership.Database.Entities.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BackgroundImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("DirectorId")
                        .HasColumnType("int");

                    b.Property<string>("FilmUrl")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<bool>("Free")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Released")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("DirectorId");

                    b.ToTable("Films");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BackgroundImageUrl = "/images/film1back.jpg",
                            Description = "A coder at a tech company wins a week-long retreat at the compound of his company's CEO, where he's tasked with testing a new artificial intelligence.",
                            DirectorId = 1,
                            FilmUrl = "https://www.youtube.com/embed/EoQuVnKhxaM",
                            Free = false,
                            ImageUrl = "/images/film1.jpg",
                            Released = new DateTime(1982, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Ex Machina"
                        },
                        new
                        {
                            Id = 2,
                            BackgroundImageUrl = "/images/film2back.jpg",
                            Description = "Science, sabotage and prehistoric DNA collide when cloned dinosaurs escape their enclosures at a top-secret theme park and begin preying on the guests.",
                            DirectorId = 1,
                            FilmUrl = "https://www.youtube.com/embed/E8WaFvwtphY",
                            Free = false,
                            ImageUrl = "/images/film2.jpg",
                            Released = new DateTime(1993, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Jurassic Park"
                        },
                        new
                        {
                            Id = 3,
                            BackgroundImageUrl = "/images/film3back.jpg",
                            Description = "The contents of a hidden grave draw the interest of an industrial titan and send Officer K, an LAPD blade runner, on a quest to find a missing legend.",
                            DirectorId = 1,
                            FilmUrl = "https://www.youtube.com/embed/gCcx85zbxz4",
                            Free = false,
                            ImageUrl = "/images/film3.jpg",
                            Released = new DateTime(2017, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Blade Runner 2049"
                        },
                        new
                        {
                            Id = 4,
                            BackgroundImageUrl = "/images/film4back.jpg",
                            Description = "Four years after the mayhem at Jurassic Park, a research team descends upon a secret second island where the cloned dinosaurs roam free.",
                            DirectorId = 1,
                            FilmUrl = "https://www.youtube.com/embed/RxrvaneULkE",
                            Free = false,
                            ImageUrl = "/images/film4.jpg",
                            Released = new DateTime(1997, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Lost World: Jurassic Park"
                        });
                });

            modelBuilder.Entity("MDB.Membership.Database.Entities.FilmGenre", b =>
                {
                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("FilmId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("FilmGenres", (string)null);

                    b.HasData(
                        new
                        {
                            FilmId = 1,
                            GenreId = 2
                        },
                        new
                        {
                            FilmId = 2,
                            GenreId = 1
                        },
                        new
                        {
                            FilmId = 3,
                            GenreId = 1
                        },
                        new
                        {
                            FilmId = 2,
                            GenreId = 2
                        },
                        new
                        {
                            FilmId = 3,
                            GenreId = 2
                        },
                        new
                        {
                            FilmId = 4,
                            GenreId = 1
                        },
                        new
                        {
                            FilmId = 4,
                            GenreId = 2
                        });
                });

            modelBuilder.Entity("MDB.Membership.Database.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sci-Fi"
                        });
                });

            modelBuilder.Entity("MDB.Membership.Database.Entities.SimilarFilm", b =>
                {
                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.Property<int>("SimilarFilmId")
                        .HasColumnType("int");

                    b.HasKey("FilmId", "SimilarFilmId");

                    b.HasIndex("SimilarFilmId");

                    b.ToTable("SimilarFilms");

                    b.HasData(
                        new
                        {
                            FilmId = 1,
                            SimilarFilmId = 3
                        },
                        new
                        {
                            FilmId = 2,
                            SimilarFilmId = 4
                        });
                });

            modelBuilder.Entity("MDB.Membership.Database.Entities.Film", b =>
                {
                    b.HasOne("MDB.Membership.Database.Entities.Director", "Director")
                        .WithMany("Films")
                        .HasForeignKey("DirectorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Director");
                });

            modelBuilder.Entity("MDB.Membership.Database.Entities.FilmGenre", b =>
                {
                    b.HasOne("MDB.Membership.Database.Entities.Film", "Film")
                        .WithMany()
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MDB.Membership.Database.Entities.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Film");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("MDB.Membership.Database.Entities.SimilarFilm", b =>
                {
                    b.HasOne("MDB.Membership.Database.Entities.Film", "Film")
                        .WithMany("SimilarFilms")
                        .HasForeignKey("FilmId")
                        .IsRequired();

                    b.HasOne("MDB.Membership.Database.Entities.Film", "Similar")
                        .WithMany()
                        .HasForeignKey("SimilarFilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Film");

                    b.Navigation("Similar");
                });

            modelBuilder.Entity("MDB.Membership.Database.Entities.Director", b =>
                {
                    b.Navigation("Films");
                });

            modelBuilder.Entity("MDB.Membership.Database.Entities.Film", b =>
                {
                    b.Navigation("SimilarFilms");
                });
#pragma warning restore 612, 618
        }
    }
}
