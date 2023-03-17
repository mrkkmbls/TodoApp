using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApp.Migrations
{
    public partial class defaultValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Description", "DueDate", "Status", "Title" },
                values: new object[] { 1, "For Birthday", new DateTime(2023, 3, 17, 12, 26, 20, 226, DateTimeKind.Local).AddTicks(2131), false, "Shopping" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Description", "DueDate", "Status", "Title" },
                values: new object[] { 2, "In Jump Training", new DateTime(2023, 3, 18, 12, 26, 20, 226, DateTimeKind.Local).AddTicks(2148), false, "Learn C#" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Description", "DueDate", "Status", "Title" },
                values: new object[] { 3, "For Jump Training", new DateTime(2023, 3, 18, 12, 26, 20, 226, DateTimeKind.Local).AddTicks(2149), false, "Learn MSSQL" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
