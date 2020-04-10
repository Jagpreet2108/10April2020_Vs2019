using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _10April2020_1.Migrations
{
    public partial class MyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CName = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: false),
                    CPin = table.Column<int>(maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CId);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CId", "CName", "CPin", "DOB" },
                values: new object[,]
                {
                    { 1, "Sameer", 1122, new DateTime(2020, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Zoya", 1111, new DateTime(2020, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Chetna", 2222, new DateTime(2020, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Kartik", 3322, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
