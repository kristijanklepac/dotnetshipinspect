using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ASPNetCoreIdentityDemo.Migrations
{
    public partial class ismandrca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IsmDeficiencies",
                columns: table => new
                {
                    IsmDeficiencyId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AccidentalDamage = table.Column<bool>(nullable: false),
                    Actions = table.Column<string>(nullable: true),
                    ControlAction = table.Column<string>(nullable: true),
                    ControlDoneDate = table.Column<DateTime>(nullable: false),
                    ControlDueDate = table.Column<DateTime>(nullable: false),
                    ControlRectified = table.Column<bool>(nullable: false),
                    ControlUpload = table.Column<string>(nullable: true),
                    CorrectiveAction = table.Column<string>(nullable: true),
                    CorrectiveDoneDate = table.Column<DateTime>(nullable: false),
                    CorrectiveDueDate = table.Column<DateTime>(nullable: false),
                    CorrectiveRectified = table.Column<bool>(nullable: false),
                    CorrectiveUpload = table.Column<string>(nullable: true),
                    DeficiencyCode = table.Column<string>(nullable: true),
                    DescriptionOfDeficiency = table.Column<string>(nullable: true),
                    GroupCode = table.Column<string>(nullable: true),
                    InspectionId = table.Column<int>(nullable: false),
                    PreventiveAction = table.Column<string>(nullable: true),
                    PreventiveDoneDate = table.Column<DateTime>(nullable: false),
                    PreventiveDueDate = table.Column<DateTime>(nullable: false),
                    PreventiveRectified = table.Column<bool>(nullable: false),
                    PreventiveUpload = table.Column<string>(nullable: true),
                    Rca = table.Column<string>(nullable: true),
                    RcaText = table.Column<string>(nullable: true),
                    Ro = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsmDeficiencies", x => x.IsmDeficiencyId);
                });

            migrationBuilder.CreateTable(
                name: "RcaCodes",
                columns: table => new
                {
                    RcaCodeId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CodeDescription = table.Column<string>(nullable: true),
                    DefaultCodeId = table.Column<int>(nullable: false),
                    RelatedRootCodeId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RcaCodes", x => x.RcaCodeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IsmDeficiencies");

            migrationBuilder.DropTable(
                name: "RcaCodes");
        }
    }
}
