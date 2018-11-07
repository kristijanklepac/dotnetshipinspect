using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ASPNetCoreIdentityDemo.Migrations
{
    public partial class Inspections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inspections",
                columns: table => new
                {
                    InspectionId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DateOfInspection = table.Column<DateTime>(nullable: false),
                    FollowUpRectified = table.Column<string>(nullable: true),
                    IsmDefiencies = table.Column<int>(nullable: false),
                    MouName = table.Column<string>(nullable: true),
                    NonIsmDefiencies = table.Column<int>(nullable: false),
                    PortOfInspection = table.Column<string>(nullable: true),
                    RefusalOfAccess = table.Column<bool>(nullable: false),
                    ShipName = table.Column<string>(nullable: true),
                    TotalDefiencies = table.Column<int>(nullable: false),
                    VesselDetained = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspections", x => x.InspectionId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inspections");
        }
    }
}
