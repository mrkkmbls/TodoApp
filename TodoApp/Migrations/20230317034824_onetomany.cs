using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApp.Migrations
{
    public partial class onetomany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UseruId",
                table: "Todos",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2023, 3, 18, 11, 48, 24, 592, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(2023, 3, 19, 11, 48, 24, 592, DateTimeKind.Local).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DueDate",
                value: new DateTime(2023, 3, 19, 11, 48, 24, 592, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.CreateIndex(
                name: "IX_Todos_UseruId",
                table: "Todos",
                column: "UseruId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Users_UseruId",
                table: "Todos",
                column: "UseruId",
                principalTable: "Users",
                principalColumn: "uId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Users_UseruId",
                table: "Todos");

            migrationBuilder.DropIndex(
                name: "IX_Todos_UseruId",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "UseruId",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2023, 3, 18, 11, 39, 45, 407, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(2023, 3, 19, 11, 39, 45, 407, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DueDate",
                value: new DateTime(2023, 3, 19, 11, 39, 45, 407, DateTimeKind.Local).AddTicks(8253));
        }
    }
}
