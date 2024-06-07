﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using koncert.Models;

#nullable disable

namespace koncert.Migrations
{
    [DbContext(typeof(koncertDbContext))]
    partial class koncertDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("koncert.Models.Entities.Announcement", b =>
                {
                    b.Property<int>("AnnouncementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnnouncementId"), 1L, 1);

                    b.Property<int>("ConcertId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AnnouncementId");

                    b.HasIndex("ConcertId");

                    b.ToTable("Announcements");
                });

            modelBuilder.Entity("koncert.Models.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("koncert.Models.Entities.Chapter", b =>
                {
                    b.Property<int>("ChapterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChapterId"), 1L, 1);

                    b.Property<int>("ConcertId")
                        .HasColumnType("int");

                    b.Property<int?>("ContentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ChapterId");

                    b.HasIndex("ContentId");

                    b.ToTable("Chapters");
                });

            modelBuilder.Entity("koncert.Models.Entities.Concert", b =>
                {
                    b.Property<int>("ConcertId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConcertId"), 1L, 1);

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsConcertOfTheMonth")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRecommended")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ConcertId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Concerts");
                });

            modelBuilder.Entity("koncert.Models.Entities.Content", b =>
                {
                    b.Property<int>("ContentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContentId"), 1L, 1);

                    b.Property<int>("ConcertId")
                        .HasColumnType("int");

                    b.HasKey("ContentId");

                    b.HasIndex("ConcertId");

                    b.ToTable("Contents");
                });

            modelBuilder.Entity("koncert.Models.Entities.Description", b =>
                {
                    b.Property<int>("DescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DescriptionId"), 1L, 1);

                    b.Property<int>("ConcertId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DescriptionId");

                    b.HasIndex("ConcertId")
                        .IsUnique();

                    b.ToTable("Descriptions");
                });

            modelBuilder.Entity("koncert.Models.Entities.Faq", b =>
                {
                    b.Property<int>("FaqId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FaqId"), 1L, 1);

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ConcertId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FaqId");

                    b.HasIndex("ConcertId");

                    b.ToTable("Faq");
                });

            modelBuilder.Entity("koncert.Models.Entities.NoteOneDescription", b =>
                {
                    b.Property<int>("NoteOneDescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NoteOneDescriptionId"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DescriptionId")
                        .HasColumnType("int");

                    b.HasKey("NoteOneDescriptionId");

                    b.HasIndex("DescriptionId");

                    b.ToTable("NoteOneDescription");
                });

            modelBuilder.Entity("koncert.Models.Entities.NoteThreeOther", b =>
                {
                    b.Property<int>("NoteThreeOtherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NoteThreeOtherId"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DescriptionId")
                        .HasColumnType("int");

                    b.HasKey("NoteThreeOtherId");

                    b.HasIndex("DescriptionId");

                    b.ToTable("NoteThreeOther");
                });

            modelBuilder.Entity("koncert.Models.Entities.NoteTwoSell", b =>
                {
                    b.Property<int>("NoteTwoSellId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NoteTwoSellId"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DescriptionId")
                        .HasColumnType("int");

                    b.HasKey("NoteTwoSellId");

                    b.HasIndex("DescriptionId");

                    b.ToTable("NoteTwoSell");
                });

            modelBuilder.Entity("koncert.Models.Entities.Place", b =>
                {
                    b.Property<int>("PlaceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlaceId"), 1L, 1);

                    b.Property<int>("ChapterId")
                        .HasColumnType("int");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlaceId");

                    b.HasIndex("ChapterId");

                    b.ToTable("Places");
                });

            modelBuilder.Entity("koncert.Models.Entities.Announcement", b =>
                {
                    b.HasOne("koncert.Models.Entities.Concert", null)
                        .WithMany("Announcements")
                        .HasForeignKey("ConcertId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("koncert.Models.Entities.Chapter", b =>
                {
                    b.HasOne("koncert.Models.Entities.Content", null)
                        .WithMany("chapters")
                        .HasForeignKey("ContentId");
                });

            modelBuilder.Entity("koncert.Models.Entities.Concert", b =>
                {
                    b.HasOne("koncert.Models.Entities.Category", "Category")
                        .WithMany("Concerts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("koncert.Models.Entities.Content", b =>
                {
                    b.HasOne("koncert.Models.Entities.Concert", null)
                        .WithMany("ConcertContent")
                        .HasForeignKey("ConcertId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("koncert.Models.Entities.Description", b =>
                {
                    b.HasOne("koncert.Models.Entities.Concert", null)
                        .WithOne("Description")
                        .HasForeignKey("koncert.Models.Entities.Description", "ConcertId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("koncert.Models.Entities.Faq", b =>
                {
                    b.HasOne("koncert.Models.Entities.Concert", null)
                        .WithMany("Faq")
                        .HasForeignKey("ConcertId");
                });

            modelBuilder.Entity("koncert.Models.Entities.NoteOneDescription", b =>
                {
                    b.HasOne("koncert.Models.Entities.Description", null)
                        .WithMany("NoteOneDescription")
                        .HasForeignKey("DescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("koncert.Models.Entities.NoteThreeOther", b =>
                {
                    b.HasOne("koncert.Models.Entities.Description", null)
                        .WithMany("NoteThreeOther")
                        .HasForeignKey("DescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("koncert.Models.Entities.NoteTwoSell", b =>
                {
                    b.HasOne("koncert.Models.Entities.Description", null)
                        .WithMany("NoteTwoSell")
                        .HasForeignKey("DescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("koncert.Models.Entities.Place", b =>
                {
                    b.HasOne("koncert.Models.Entities.Chapter", null)
                        .WithMany("Places")
                        .HasForeignKey("ChapterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("koncert.Models.Entities.Category", b =>
                {
                    b.Navigation("Concerts");
                });

            modelBuilder.Entity("koncert.Models.Entities.Chapter", b =>
                {
                    b.Navigation("Places");
                });

            modelBuilder.Entity("koncert.Models.Entities.Concert", b =>
                {
                    b.Navigation("Announcements");

                    b.Navigation("ConcertContent");

                    b.Navigation("Description")
                        .IsRequired();

                    b.Navigation("Faq");
                });

            modelBuilder.Entity("koncert.Models.Entities.Content", b =>
                {
                    b.Navigation("chapters");
                });

            modelBuilder.Entity("koncert.Models.Entities.Description", b =>
                {
                    b.Navigation("NoteOneDescription");

                    b.Navigation("NoteThreeOther");

                    b.Navigation("NoteTwoSell");
                });
#pragma warning restore 612, 618
        }
    }
}
