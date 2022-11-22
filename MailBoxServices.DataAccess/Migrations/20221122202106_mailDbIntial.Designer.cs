﻿// <auto-generated />
using MailBoxServices.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MailBoxServices.DataAccess.Migrations
{
    [DbContext(typeof(MailBoxDbContext))]
    [Migration("20221122202106_mailDbIntial")]
    partial class mailDbIntial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MailBoxServices.Entities.MAIL_BOX", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CONTENT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ISREAD")
                        .HasColumnType("bit");

                    b.Property<string>("SUBJECT")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("MailBox");
                });
#pragma warning restore 612, 618
        }
    }
}