﻿// <auto-generated />
using LeaderAnalytics.AdaptiveClient.EntityFramework.Tests.Artifacts.StoreFront;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace LeaderAnalytics.AdaptiveClient.EntityFramework.Tests.Artifacts.StoreFront.Migrations.MSSQL
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

            modelBuilder.Entity("LeaderAnalytics.AdaptiveClient.EntityFramework.Tests.Artifacts.StoreFront.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccountID");

                    b.Property<decimal>("Amount");

                    b.Property<int?>("ProductID");

                    b.HasKey("ID");

                    b.HasIndex("ProductID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("LeaderAnalytics.AdaptiveClient.EntityFramework.Tests.Artifacts.StoreFront.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("LeaderAnalytics.AdaptiveClient.EntityFramework.Tests.Artifacts.StoreFront.Order", b =>
                {
                    b.HasOne("LeaderAnalytics.AdaptiveClient.EntityFramework.Tests.Artifacts.StoreFront.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("ProductID");
                });
#pragma warning restore 612, 618
        }
    }
}