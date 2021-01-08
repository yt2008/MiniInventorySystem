using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MiniInventorySystem.Migrations
{
    public partial class AddDesktopLaptopTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Computers");

            migrationBuilder.CreateTable(
                name: "Desktops",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FormFactor = table.Column<string>(type: "TEXT", nullable: true),
                    Processor = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: true),
                    UsbPorts = table.Column<int>(type: "INTEGER", nullable: false),
                    RamSlots = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desktops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Laptops",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FromFactor = table.Column<string>(type: "TEXT", nullable: true),
                    ScreenSize = table.Column<decimal>(type: "TEXT", nullable: false),
                    BatterySize = table.Column<decimal>(type: "TEXT", nullable: false),
                    Processor = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: true),
                    UsbPorts = table.Column<int>(type: "INTEGER", nullable: false),
                    RamSlots = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laptops", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Desktops",
                columns: new[] { "Id", "Brand", "FormFactor", "Processor", "Quantity", "RamSlots", "UsbPorts" },
                values: new object[] { new Guid("f966bc05-c1b0-4325-9426-8ae8153bbf0d"), "Dell", null, "i7", 10, 4, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Desktops");

            migrationBuilder.DropTable(
                name: "Laptops");

            migrationBuilder.CreateTable(
                name: "Computers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: true),
                    FromFactor = table.Column<string>(type: "TEXT", nullable: true),
                    Processor = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    RamSlots = table.Column<int>(type: "INTEGER", nullable: false),
                    UsbPorts = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Computers",
                columns: new[] { "Id", "Brand", "FromFactor", "Processor", "Quantity", "RamSlots", "UsbPorts" },
                values: new object[] { new Guid("53635e30-d945-4d0a-81be-b94586d3efe3"), "Dell", "", "i7", 10, 4, 3 });
        }
    }
}
