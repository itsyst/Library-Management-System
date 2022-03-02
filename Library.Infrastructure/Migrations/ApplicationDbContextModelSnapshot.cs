﻿// <auto-generated />
using System;
using Library.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Library.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Library.Domain.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Laurelli Rolf"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Jordan B Peterson"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Annmarie Palm"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Dale Carnegie"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Bo Gustafsson"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Brian Tracy "
                        },
                        new
                        {
                            Id = 7,
                            Name = "Stephen Denning"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Geoff Watts"
                        },
                        new
                        {
                            Id = 9,
                            Name = "David J Anderson"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Rashina Hoda"
                        },
                        new
                        {
                            Id = 11,
                            Name = "William Shakespeare"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Villiam Skakspjut"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Robert C. Martin"
                        });
                });

            modelBuilder.Entity("Library.Domain.BookCopy", b =>
                {
                    b.Property<int>("BookCopyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookCopyId"), 1L, 1);

                    b.Property<int>("DetailsId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.HasKey("BookCopyId");

                    b.HasIndex("DetailsId");

                    b.ToTable("BookCopies");

                    b.HasData(
                        new
                        {
                            BookCopyId = 1,
                            DetailsId = 1,
                            IsAvailable = true
                        },
                        new
                        {
                            BookCopyId = 2,
                            DetailsId = 2,
                            IsAvailable = true
                        },
                        new
                        {
                            BookCopyId = 3,
                            DetailsId = 3,
                            IsAvailable = true
                        },
                        new
                        {
                            BookCopyId = 4,
                            DetailsId = 4,
                            IsAvailable = true
                        },
                        new
                        {
                            BookCopyId = 5,
                            DetailsId = 5,
                            IsAvailable = true
                        },
                        new
                        {
                            BookCopyId = 6,
                            DetailsId = 6,
                            IsAvailable = true
                        },
                        new
                        {
                            BookCopyId = 7,
                            DetailsId = 7,
                            IsAvailable = true
                        },
                        new
                        {
                            BookCopyId = 9,
                            DetailsId = 12,
                            IsAvailable = true
                        },
                        new
                        {
                            BookCopyId = 10,
                            DetailsId = 12,
                            IsAvailable = true
                        },
                        new
                        {
                            BookCopyId = 11,
                            DetailsId = 5,
                            IsAvailable = true
                        },
                        new
                        {
                            BookCopyId = 12,
                            DetailsId = 4,
                            IsAvailable = true
                        },
                        new
                        {
                            BookCopyId = 13,
                            DetailsId = 8,
                            IsAvailable = true
                        },
                        new
                        {
                            BookCopyId = 14,
                            DetailsId = 1,
                            IsAvailable = true
                        },
                        new
                        {
                            BookCopyId = 15,
                            DetailsId = 7,
                            IsAvailable = true
                        },
                        new
                        {
                            BookCopyId = 16,
                            DetailsId = 11,
                            IsAvailable = true
                        },
                        new
                        {
                            BookCopyId = 17,
                            DetailsId = 11,
                            IsAvailable = true
                        },
                        new
                        {
                            BookCopyId = 18,
                            DetailsId = 2,
                            IsAvailable = true
                        },
                        new
                        {
                            BookCopyId = 19,
                            DetailsId = 9,
                            IsAvailable = true
                        },
                        new
                        {
                            BookCopyId = 20,
                            DetailsId = 9,
                            IsAvailable = true
                        },
                        new
                        {
                            BookCopyId = 21,
                            DetailsId = 13,
                            IsAvailable = true
                        },
                        new
                        {
                            BookCopyId = 22,
                            DetailsId = 5,
                            IsAvailable = true
                        },
                        new
                        {
                            BookCopyId = 24,
                            DetailsId = 10,
                            IsAvailable = true
                        },
                        new
                        {
                            BookCopyId = 25,
                            DetailsId = 10,
                            IsAvailable = true
                        },
                        new
                        {
                            BookCopyId = 26,
                            DetailsId = 13,
                            IsAvailable = true
                        },
                        new
                        {
                            BookCopyId = 27,
                            DetailsId = 13,
                            IsAvailable = true
                        });
                });

            modelBuilder.Entity("Library.Domain.BookCopyLoan", b =>
                {
                    b.Property<int>("BookCopyId")
                        .HasColumnType("int");

                    b.Property<int>("LoanId")
                        .HasColumnType("int");

                    b.HasKey("BookCopyId", "LoanId");

                    b.HasIndex("LoanId");

                    b.ToTable("BookCopyLoans");

                    b.HasData(
                        new
                        {
                            BookCopyId = 4,
                            LoanId = 1
                        },
                        new
                        {
                            BookCopyId = 1,
                            LoanId = 2
                        },
                        new
                        {
                            BookCopyId = 2,
                            LoanId = 3
                        },
                        new
                        {
                            BookCopyId = 3,
                            LoanId = 4
                        },
                        new
                        {
                            BookCopyId = 5,
                            LoanId = 5
                        },
                        new
                        {
                            BookCopyId = 6,
                            LoanId = 6
                        },
                        new
                        {
                            BookCopyId = 1,
                            LoanId = 5
                        },
                        new
                        {
                            BookCopyId = 2,
                            LoanId = 5
                        },
                        new
                        {
                            BookCopyId = 3,
                            LoanId = 1
                        },
                        new
                        {
                            BookCopyId = 12,
                            LoanId = 1
                        },
                        new
                        {
                            BookCopyId = 7,
                            LoanId = 2
                        });
                });

            modelBuilder.Entity("Library.Domain.BookDetails", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("AuthorID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AuthorID");

                    b.ToTable("BookDetails");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AuthorID = 1,
                            Description = "Arguably Shakespeare's greatest tragedy",
                            ISBN = "1472518381",
                            Title = "Hamlet"
                        },
                        new
                        {
                            ID = 2,
                            AuthorID = 1,
                            Description = "King Lear is a tragedy written by William Shakespeare. It depicts the gradual descent into madness of the title character, after he disposes of his kingdom by giving bequests to two of his three daughters egged on by their continual flattery, bringing tragic consequences for all.",
                            ISBN = "9780141012292",
                            Title = "King Lear"
                        },
                        new
                        {
                            ID = 3,
                            AuthorID = 2,
                            Description = "An intense drama of love, deception, jealousy and destruction.",
                            ISBN = "1853260185",
                            Title = "Othello"
                        },
                        new
                        {
                            ID = 4,
                            AuthorID = 4,
                            Description = "I Affärsmannaskap har Rolf Laurelli summerat sin långa erfarenhet av konsten att göra affärer. Med boken hoppas han kunna locka fram dina affärsinstinkter.",
                            ISBN = "9789147107483",
                            Title = "Affärsmannaskap för ingenjörer, jurister och alla andra specialister"
                        },
                        new
                        {
                            ID = 5,
                            AuthorID = 5,
                            Description = "12 Rules for Life offers a deeply rewarding antidote to the chaos in our lives: eternal truths applied to our modern problems. ",
                            ISBN = "9780345816023",
                            Title = "12 Rules For Life "
                        },
                        new
                        {
                            ID = 6,
                            AuthorID = 6,
                            Description = "Denna eminenta bok handlar om hur man ska behandla sina affärskontakter för att de ska känna sig trygga med dig som affärspartner. ",
                            ISBN = "9789147122103",
                            Title = "Business behavior"
                        },
                        new
                        {
                            ID = 7,
                            AuthorID = 7,
                            Description = "Dale Carnegie had an understanding of human nature that will never be outdated. Financial success, Carnegie believed, is due 15 percent to professional knowledge and 85 percent to the ability to express ideas, to assume leadership, and to arouse enthusiasm among people.",
                            ISBN = "9781439199190",
                            Title = "How to Win Friends and Influence People"
                        },
                        new
                        {
                            ID = 8,
                            AuthorID = 8,
                            Description = "I Affärsmannaskap har Rolf Laurelli summerat sin långa erfarenhet av konsten att göra affärer. Med boken hoppas han kunna locka fram dina affärsinstinkter.",
                            ISBN = "9789186293321",
                            Title = "Förhandla : från strikta regler till dirty tricks"
                        },
                        new
                        {
                            ID = 9,
                            AuthorID = 9,
                            Description = "Tracy teaches readers how to utilize the six key negotiating styles ",
                            ISBN = "9780814433195",
                            Title = "Negotiation "
                        },
                        new
                        {
                            ID = 13,
                            AuthorID = 13,
                            Description = "The Age of Agile helps readers master the three laws of Agile Management (team, customer, network)",
                            ISBN = "9780814439098",
                            Title = "THE AGE OF AGILE "
                        },
                        new
                        {
                            ID = 10,
                            AuthorID = 10,
                            Description = "The basics of being a ScrumMaster are fairly straightforward: Facilitate the Scrum process and remove impediments. ",
                            ISBN = "9780957587403",
                            Title = "Scrum Mastery "
                        },
                        new
                        {
                            ID = 11,
                            AuthorID = 11,
                            Description = "Optimize the effectiveness of your business, to produce fit-for-purpose products and services that delight your customers, making them loyal to your brand and increasing your share, revenues and margins.",
                            ISBN = "9780984521401",
                            Title = "Kanban "
                        },
                        new
                        {
                            ID = 12,
                            AuthorID = 12,
                            Description = "This  book constitutes the research workshops, doctoral symposium and panel summaries presented at the 20th International Conference on Agile Software Development",
                            ISBN = "9783030301255",
                            Title = " Agile Processes in Software Engineering and Extreme Programming"
                        });
                });

            modelBuilder.Entity("Library.Domain.Loan", b =>
                {
                    b.Property<int>("LoanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoanId"), 1L, 1);

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Fee")
                        .HasColumnType("float");

                    b.Property<int>("MemberID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("LoanId");

                    b.HasIndex("MemberID");

                    b.ToTable("Loans");

                    b.HasData(
                        new
                        {
                            LoanId = 1,
                            DueDate = new DateTime(2022, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fee = 0.0,
                            MemberID = 3,
                            ReturnDate = new DateTime(2022, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2022, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            LoanId = 2,
                            DueDate = new DateTime(2022, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fee = 24.0,
                            MemberID = 1,
                            ReturnDate = new DateTime(2022, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            LoanId = 3,
                            DueDate = new DateTime(2022, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fee = 0.0,
                            MemberID = 2,
                            ReturnDate = new DateTime(2022, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            LoanId = 4,
                            DueDate = new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fee = 0.0,
                            MemberID = 2,
                            ReturnDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2022, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            LoanId = 5,
                            DueDate = new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fee = 0.0,
                            MemberID = 4,
                            ReturnDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2022, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            LoanId = 6,
                            DueDate = new DateTime(2022, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fee = 0.0,
                            MemberID = 5,
                            ReturnDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Library.Domain.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("SSN")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.HasKey("Id");

                    b.ToTable("Members");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Daniel Graham",
                            SSN = "19855666-0001"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Eric Howell",
                            SSN = "19555666-0002"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Patricia Lebsack",
                            SSN = "19555666-0003"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Kalle Runolfsdottir",
                            SSN = "19555666-0004"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Linus Reichert",
                            SSN = "19555666-0005"
                        });
                });

            modelBuilder.Entity("Library.Domain.BookCopy", b =>
                {
                    b.HasOne("Library.Domain.BookDetails", "Details")
                        .WithMany("Copies")
                        .HasForeignKey("DetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Details");
                });

            modelBuilder.Entity("Library.Domain.BookCopyLoan", b =>
                {
                    b.HasOne("Library.Domain.BookCopy", "BookCopy")
                        .WithMany("BookCopyLoans")
                        .HasForeignKey("BookCopyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Domain.Loan", "Loan")
                        .WithMany("BookCopyLoans")
                        .HasForeignKey("LoanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookCopy");

                    b.Navigation("Loan");
                });

            modelBuilder.Entity("Library.Domain.BookDetails", b =>
                {
                    b.HasOne("Library.Domain.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("Library.Domain.Loan", b =>
                {
                    b.HasOne("Library.Domain.Member", "Member")
                        .WithMany("Loans")
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Library.Domain.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Library.Domain.BookCopy", b =>
                {
                    b.Navigation("BookCopyLoans");
                });

            modelBuilder.Entity("Library.Domain.BookDetails", b =>
                {
                    b.Navigation("Copies");
                });

            modelBuilder.Entity("Library.Domain.Loan", b =>
                {
                    b.Navigation("BookCopyLoans");
                });

            modelBuilder.Entity("Library.Domain.Member", b =>
                {
                    b.Navigation("Loans");
                });
#pragma warning restore 612, 618
        }
    }
}
