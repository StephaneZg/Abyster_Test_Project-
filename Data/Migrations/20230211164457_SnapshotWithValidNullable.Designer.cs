﻿// <auto-generated />
using System;
using Abyster_Test_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AbysterTestProject.Data.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230211164457_SnapshotWithValidNullable")]
    partial class SnapshotWithValidNullable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("Abyster_Test_Project.Domain.Account_Journals.AccountJournal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("account_journal_id");

                    b.Property<int>("account_id")
                        .HasColumnType("INTEGER");

                    b.Property<double>("amount")
                        .HasColumnType("REAL");

                    b.Property<double>("balanceAfter")
                        .HasColumnType("REAL");

                    b.Property<double>("balanceBefore")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("DateTime");

                    b.Property<string>("createdBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("DateTime");

                    b.Property<string>("updatedBy")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("account_id");

                    b.ToTable("AccountJournals");
                });

            modelBuilder.Entity("Abyster_Test_Project.Domain.Accounts.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("account_id");

                    b.Property<int>("category_id")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("DateTime");

                    b.Property<string>("createdBy")
                        .HasColumnType("TEXT");

                    b.Property<long>("montant")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("DateTime");

                    b.Property<string>("updatedBy")
                        .HasColumnType("TEXT");

                    b.Property<int>("user_id")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("category_id");

                    b.HasIndex("user_id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Abyster_Test_Project.Domain.Categorys.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("category_id");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("DateTime");

                    b.Property<string>("createdBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("libelle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("DateTime");

                    b.Property<string>("updatedBy")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Abyster_Test_Project.Domain.Roles.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("role_id");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("DateTime");

                    b.Property<string>("createdBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("libelle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("DateTime");

                    b.Property<string>("updatedBy")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Abyster_Test_Project.Domain.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("user_id");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("DateTime");

                    b.Property<string>("createdBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("emailAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("isActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Boolean")
                        .HasDefaultValue(true);

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("refreshToken")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("refreshTokenExpireTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("token")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("DateTime");

                    b.Property<string>("updatedBy")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.Property<int>("rolesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("usersId")
                        .HasColumnType("INTEGER");

                    b.HasKey("rolesId", "usersId");

                    b.HasIndex("usersId");

                    b.ToTable("RoleUser");
                });

            modelBuilder.Entity("Abyster_Test_Project.Domain.Account_Journals.AccountJournal", b =>
                {
                    b.HasOne("Abyster_Test_Project.Domain.Accounts.Account", "account")
                        .WithMany()
                        .HasForeignKey("account_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("account");
                });

            modelBuilder.Entity("Abyster_Test_Project.Domain.Accounts.Account", b =>
                {
                    b.HasOne("Abyster_Test_Project.Domain.Categorys.Category", "category")
                        .WithMany()
                        .HasForeignKey("category_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Abyster_Test_Project.Domain.Users.User", "user")
                        .WithMany()
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");

                    b.Navigation("user");
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.HasOne("Abyster_Test_Project.Domain.Roles.Role", null)
                        .WithMany()
                        .HasForeignKey("rolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Abyster_Test_Project.Domain.Users.User", null)
                        .WithMany()
                        .HasForeignKey("usersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
