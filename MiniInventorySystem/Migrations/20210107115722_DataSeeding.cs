using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MiniInventorySystem.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Computers",
                columns: new[] { "Id", "Brand", "FromFactor", "Processor", "Quantity", "RamSlots", "UsbPorts" },
                values: new object[] { new Guid("53635e30-d945-4d0a-81be-b94586d3efe3"), "Dell", "", "i7", 10, 4, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: new Guid("53635e30-d945-4d0a-81be-b94586d3efe3"));
        }
    }
}
