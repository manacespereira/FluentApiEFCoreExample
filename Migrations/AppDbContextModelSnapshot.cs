﻿// <auto-generated />
using System;
using FluentApiEFCoreExample;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FluentApiEFCoreExample.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FluentApiEFCoreExample.Entities.Article", b =>
                {
                    b.Property<string>("UId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("LastUpdateAt");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(120);

                    b.Property<string>("UserUId");

                    b.HasKey("UId");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.HasIndex("UserUId");

                    b.ToTable("ARTICLES");
                });

            modelBuilder.Entity("FluentApiEFCoreExample.Entities.ArticleCategory", b =>
                {
                    b.Property<string>("UId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ArticleUId")
                        .IsRequired();

                    b.Property<string>("CategoryUId")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("LastUpdateAt");

                    b.HasKey("UId");

                    b.HasIndex("ArticleUId");

                    b.HasIndex("CategoryUId");

                    b.ToTable("ARTICLES_CATEGORIES");
                });

            modelBuilder.Entity("FluentApiEFCoreExample.Entities.Category", b =>
                {
                    b.Property<string>("UId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("LastUpdateAt");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(45);

                    b.HasKey("UId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("CATEGORIES");
                });

            modelBuilder.Entity("FluentApiEFCoreExample.Entities.User", b =>
                {
                    b.Property<string>("UId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(45);

                    b.Property<DateTime>("LastUpdateAt");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(45);

                    b.HasKey("UId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("USERS");
                });

            modelBuilder.Entity("FluentApiEFCoreExample.Entities.Article", b =>
                {
                    b.HasOne("FluentApiEFCoreExample.Entities.User", "User")
                        .WithMany("Articles")
                        .HasForeignKey("UserUId");
                });

            modelBuilder.Entity("FluentApiEFCoreExample.Entities.ArticleCategory", b =>
                {
                    b.HasOne("FluentApiEFCoreExample.Entities.Article", "Article")
                        .WithMany("CategoryArticles")
                        .HasForeignKey("ArticleUId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FluentApiEFCoreExample.Entities.Category", "Category")
                        .WithMany("CategoryArticles")
                        .HasForeignKey("CategoryUId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
