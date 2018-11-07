using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ASPNetCoreIdentityDemo.Migrations
{
    public partial class pmoudefcodes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParisMouDeficiencyCodes",
                columns: table => new
                {
                    ParisMouDeficiencyCodeId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DefectiveItem = table.Column<string>(nullable: true),
                    ThetisCode = table.Column<int>(nullable: false),
                    ThetisGroup = table.Column<string>(nullable: true),
                    ThetisSubGroup = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParisMouDeficiencyCodes", x => x.ParisMouDeficiencyCodeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ParisMouDeficiencyCodes_ThetisCode",
                table: "ParisMouDeficiencyCodes",
                column: "ThetisCode",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParisMouDeficiencyCodes");
        }
    }
}
