using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ASPNetCoreIdentityDemo.Migrations
{
    public partial class RecOrg1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RecognizedOrganizations",
                columns: table => new
                {
                    RecognizedOrganizationId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RecognizedOrganizationInitials = table.Column<string>(nullable: true),
                    RecognizedOrganizationName = table.Column<string>(nullable: true),
                    RoCarribeanMou = table.Column<string>(nullable: true),
                    RoIndianOceanMou = table.Column<string>(nullable: true),
                    RoMediterraneanMou = table.Column<string>(nullable: true),
                    RoParisMou = table.Column<string>(nullable: true),
                    RoRiyadhMou = table.Column<string>(nullable: true),
                    RoTokyoMou = table.Column<string>(nullable: true),
                    RoUsCoastGuardMou = table.Column<string>(nullable: true),
                    RoVinaDelMarMou = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecognizedOrganizations", x => x.RecognizedOrganizationId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecognizedOrganizations");
        }
    }
}
