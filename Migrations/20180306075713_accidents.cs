using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ASPNetCoreIdentityDemo.Migrations
{
    public partial class accidents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accidents",
                columns: table => new
                {
                    AccidentId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AccidentDate = table.Column<DateTime>(nullable: false),
                    ChiefEngineer = table.Column<string>(nullable: true),
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
                    DescriptionOfEvent = table.Column<string>(nullable: true),
                    LeassonLearned = table.Column<string>(nullable: true),
                    Master = table.Column<string>(nullable: true),
                    Place = table.Column<string>(nullable: true),
                    PreventiveAction = table.Column<string>(nullable: true),
                    PreventiveDoneDate = table.Column<DateTime>(nullable: false),
                    PreventiveDueDate = table.Column<DateTime>(nullable: false),
                    PreventiveRectified = table.Column<bool>(nullable: false),
                    PreventiveUpload = table.Column<string>(nullable: true),
                    Rca = table.Column<string>(nullable: true),
                    ShipNameId = table.Column<string>(nullable: true),
                    TypeOfEvent = table.Column<string>(nullable: true),
                    TypeOfOccurence = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accidents", x => x.AccidentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accidents");
        }
    }
}
