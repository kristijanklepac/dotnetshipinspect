using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ASPNetCoreIdentityDemo.Migrations
{
    public partial class Ships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ships",
                columns: table => new
                {
                    ShipId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClassOrganization = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    CountryFlag = table.Column<string>(nullable: true),
                    GT = table.Column<string>(nullable: true),
                    ImoNumber = table.Column<int>(nullable: false),
                    OfficialNr = table.Column<string>(nullable: true),
                    RecognizedOrganization = table.Column<string>(nullable: true),
                    TypeOfShip = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ships", x => x.ShipId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ships");
        }
    }
}
