﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using paylive.Console.DbContext;

namespace paylive.Console.Migrations
{
    [DbContext(typeof(LiveContext))]
    [Migration("20170401051720_dbc")]
    partial class dbc
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752");

            modelBuilder.Entity("paylive.Console.DbContext.WebImConfig", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DateBody");

                    b.HasKey("Id");

                    b.ToTable("WebImConfig");
                });
        }
    }
}
