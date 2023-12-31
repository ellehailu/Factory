﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Factory.Migrations
{
    public partial class AddInstallationDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "InstallationDate",
                table: "Machines",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InstallationDate",
                table: "Machines");
        }
    }
}
