using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class add_taskitem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaskItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FinishDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TaskItems",
                columns: new[] { "Id", "CreateDate", "Description", "FinishDate", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 11, 10, 20, 36, 59, 384, DateTimeKind.Local).AddTicks(8443), "Описание Задачи 1", null, "Задача 1" },
                    { 2, new DateTime(2026, 11, 10, 20, 36, 59, 384, DateTimeKind.Local).AddTicks(8456), "Описание Задачи 2", null, "Задача 2" },
                    { 3, new DateTime(2026, 11, 10, 20, 36, 59, 384, DateTimeKind.Local).AddTicks(8457), "Описание Задачи 3", null, "Задача 3" },
                    { 4, new DateTime(2026, 11, 10, 20, 36, 59, 384, DateTimeKind.Local).AddTicks(8458), "Описание Задачи 3", null, "Задача 4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskItems");
        }
    }
}
