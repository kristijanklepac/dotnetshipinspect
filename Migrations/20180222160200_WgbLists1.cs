using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ASPNetCoreIdentityDemo.Migrations
{
    public partial class WgbLists1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "WgbFlag",
                table: "WgbLists",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WgbLists_WgbFlag",
                table: "WgbLists",
                column: "WgbFlag",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_WgbLists_WgbFlag",
                table: "WgbLists");

            migrationBuilder.AlterColumn<string>(
                name: "WgbFlag",
                table: "WgbLists",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
