using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MiniInventorySystem.Migrations
{
    public partial class MoveUsbPortsRamSlotsToDesktopEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Desktops",
                keyColumn: "Id",
                keyValue: new Guid("f966bc05-c1b0-4325-9426-8ae8153bbf0d"));

            migrationBuilder.DropColumn(
                name: "FromFactor",
                table: "Laptops");

            migrationBuilder.DropColumn(
                name: "RamSlots",
                table: "Laptops");

            migrationBuilder.DropColumn(
                name: "UsbPorts",
                table: "Laptops");

            migrationBuilder.RenameColumn(
                name: "BatterySize",
                table: "Laptops",
                newName: "BatteryCapacity");

            migrationBuilder.InsertData(
                table: "Desktops",
                columns: new[] { "Id", "Brand", "FormFactor", "Processor", "Quantity", "RamSlots", "UsbPorts" },
                values: new object[] { new Guid("d681a355-b25b-441d-9798-5291069cb2a4"), "Dell", null, "i7", 10, 4, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Desktops",
                keyColumn: "Id",
                keyValue: new Guid("d681a355-b25b-441d-9798-5291069cb2a4"));

            migrationBuilder.RenameColumn(
                name: "BatteryCapacity",
                table: "Laptops",
                newName: "BatterySize");

            migrationBuilder.AddColumn<string>(
                name: "FromFactor",
                table: "Laptops",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RamSlots",
                table: "Laptops",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsbPorts",
                table: "Laptops",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Desktops",
                columns: new[] { "Id", "Brand", "FormFactor", "Processor", "Quantity", "RamSlots", "UsbPorts" },
                values: new object[] { new Guid("f966bc05-c1b0-4325-9426-8ae8153bbf0d"), "Dell", null, "i7", 10, 4, 3 });
        }
    }
}
