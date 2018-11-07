using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ASPNetCoreIdentityDemo.Migrations
{
    public partial class Tokyo1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TokyoWgbLists",
                columns: table => new
                {
                    TokyoWgbListId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BmBmthBhBvhr = table.Column<string>(nullable: true),
                    WgbFlag = table.Column<string>(nullable: true),
                    WorGorB = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TokyoWgbLists", x => x.TokyoWgbListId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TokyoWgbLists_WgbFlag",
                table: "TokyoWgbLists",
                column: "WgbFlag",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TokyoWgbLists");
        }
    }
}
