using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MiniInventorySystem.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Computers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Processor = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: true),
                    UsbPorts = table.Column<int>(type: "INTEGER", nullable: false),
                    RamSlots = table.Column<int>(type: "INTEGER", nullable: false),
                    FromFactor = table.Column<string>(type: "TEXT", nullable: true),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Computers");
        }
    }
}
