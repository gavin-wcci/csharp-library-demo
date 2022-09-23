﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using csharp_library_demo;

#nullable disable

namespace csharp_library_demo.Migrations
{
    [DbContext(typeof(LibraryContext))]
    partial class LibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("csharp_library_demo.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "RB",
                            LastName = "Whitaker"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Kathy",
                            LastName = "Sierra"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Burt",
                            LastName = "Bates"
                        });
                });

            modelBuilder.Entity("csharp_library_demo.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CampusId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CampusId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CampusId = 1,
                            Title = "C# Player's Guide"
                        },
                        new
                        {
                            Id = 2,
                            CampusId = 2,
                            Title = "Head First Java"
                        });
                });

            modelBuilder.Entity("csharp_library_demo.Models.BookAuthor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BookId");

                    b.ToTable("BookAuthors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            BookId = 1
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            BookId = 2
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 3,
                            BookId = 2
                        });
                });

            modelBuilder.Entity("csharp_library_demo.Models.BookHashTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("HashtagId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("HashtagId");

                    b.ToTable("BookHashTags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            HashtagId = 1
                        },
                        new
                        {
                            Id = 2,
                            BookId = 1,
                            HashtagId = 3
                        },
                        new
                        {
                            Id = 3,
                            BookId = 2,
                            HashtagId = 2
                        },
                        new
                        {
                            Id = 4,
                            BookId = 2,
                            HashtagId = 3
                        });
                });

            modelBuilder.Entity("csharp_library_demo.Models.Campus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Campuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Location = "Cleveland"
                        },
                        new
                        {
                            Id = 2,
                            Location = "Columbus"
                        });
                });

            modelBuilder.Entity("csharp_library_demo.Models.HashTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HashTags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "C#"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Java"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Programming"
                        });
                });

            modelBuilder.Entity("csharp_library_demo.Models.Book", b =>
                {
                    b.HasOne("csharp_library_demo.Models.Campus", "Campus")
                        .WithMany("Books")
                        .HasForeignKey("CampusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Campus");
                });

            modelBuilder.Entity("csharp_library_demo.Models.BookAuthor", b =>
                {
                    b.HasOne("csharp_library_demo.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("csharp_library_demo.Models.Book", "Book")
                        .WithMany("Authors")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("csharp_library_demo.Models.BookHashTag", b =>
                {
                    b.HasOne("csharp_library_demo.Models.Book", "Book")
                        .WithMany("HashTags")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("csharp_library_demo.Models.HashTag", "HashTag")
                        .WithMany("Books")
                        .HasForeignKey("HashtagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("HashTag");
                });

            modelBuilder.Entity("csharp_library_demo.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("csharp_library_demo.Models.Book", b =>
                {
                    b.Navigation("Authors");

                    b.Navigation("HashTags");
                });

            modelBuilder.Entity("csharp_library_demo.Models.Campus", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("csharp_library_demo.Models.HashTag", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}