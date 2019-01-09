﻿// <auto-generated />
using System;
using Core.Lib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Core.Lib.Migrations
{
    [DbContext(typeof(DBcontext))]
    partial class DBcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Lib.Model.Sys_User", b =>
                {
                    b.Property<int>("PKID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("IsInternal");

                    b.Property<DateTime>("LastModifyTime");

                    b.Property<int>("OnFreezed");

                    b.Property<string>("Sys_LoginAccount");

                    b.Property<string>("Sys_LoginPassword");

                    b.Property<string>("Sys_UserName");

                    b.Property<int>("Valid");

                    b.HasKey("PKID");

                    b.ToTable("Sys_User");
                });

            modelBuilder.Entity("Core.Lib.Model.User", b =>
                {
                    b.Property<int>("PKID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("IsInternal");

                    b.Property<DateTime>("LastModifyTime");

                    b.Property<string>("LoginAccount");

                    b.Property<string>("LoginPassword");

                    b.Property<int>("OnFreezed");

                    b.Property<string>("UserName");

                    b.Property<int>("Valid");

                    b.HasKey("PKID");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
