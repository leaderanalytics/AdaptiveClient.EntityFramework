﻿// <auto-generated />
using LeaderAnalytics.AdaptiveClient.EntityFramework.Tests.Artifacts.BackOffice;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace LeaderAnalytics.AdaptiveClient.EntityFramework.Tests.Artifacts.BackOffice.Migrations.MSSQL
{
    [DbContext(typeof(Db_MSSQL))]
    partial class Db_MSSQLModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LeaderAnalytics.AdaptiveClient.EntityFramework.Tests.Artifacts.BackOffice.Account", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("LeaderAnalytics.AdaptiveClient.EntityFramework.Tests.Artifacts.BackOffice.Payment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccountID");

                    b.Property<decimal>("Amount");

                    b.Property<DateTime>("PaymentDate");

                    b.HasKey("ID");

                    b.HasIndex("AccountID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("LeaderAnalytics.AdaptiveClient.EntityFramework.Tests.Artifacts.BackOffice.Payment", b =>
                {
                    b.HasOne("LeaderAnalytics.AdaptiveClient.EntityFramework.Tests.Artifacts.BackOffice.Account", "Account")
                        .WithMany("Payments")
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
