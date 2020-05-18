using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MitechCenter.vn.Migrations
{
    public partial class MitechCenterDatabaseCretion_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cImage",
                table: "Course",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 1,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 18, 17, 18, 4, 742, DateTimeKind.Local).AddTicks(8117), new DateTime(2020, 5, 18, 17, 18, 4, 743, DateTimeKind.Local).AddTicks(9363) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 2,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 18, 17, 18, 4, 744, DateTimeKind.Local).AddTicks(97), new DateTime(2020, 5, 18, 17, 18, 4, 744, DateTimeKind.Local).AddTicks(133) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 3,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 18, 17, 18, 4, 744, DateTimeKind.Local).AddTicks(254), new DateTime(2020, 5, 18, 17, 18, 4, 744, DateTimeKind.Local).AddTicks(257) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 4,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 18, 17, 18, 4, 744, DateTimeKind.Local).AddTicks(260), new DateTime(2020, 5, 18, 17, 18, 4, 744, DateTimeKind.Local).AddTicks(263) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 5,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 18, 17, 18, 4, 744, DateTimeKind.Local).AddTicks(265), new DateTime(2020, 5, 18, 17, 18, 4, 744, DateTimeKind.Local).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 6,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 18, 17, 18, 4, 744, DateTimeKind.Local).AddTicks(272), new DateTime(2020, 5, 18, 17, 18, 4, 744, DateTimeKind.Local).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 7,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 18, 17, 18, 4, 744, DateTimeKind.Local).AddTicks(277), new DateTime(2020, 5, 18, 17, 18, 4, 744, DateTimeKind.Local).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 8,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 18, 17, 18, 4, 744, DateTimeKind.Local).AddTicks(281), new DateTime(2020, 5, 18, 17, 18, 4, 744, DateTimeKind.Local).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 9,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 18, 17, 18, 4, 744, DateTimeKind.Local).AddTicks(284), new DateTime(2020, 5, 18, 17, 18, 4, 744, DateTimeKind.Local).AddTicks(285) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 10,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 18, 17, 18, 4, 744, DateTimeKind.Local).AddTicks(287), new DateTime(2020, 5, 18, 17, 18, 4, 744, DateTimeKind.Local).AddTicks(288) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 11,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 18, 17, 18, 4, 744, DateTimeKind.Local).AddTicks(291), new DateTime(2020, 5, 18, 17, 18, 4, 744, DateTimeKind.Local).AddTicks(292) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cImage",
                table: "Course");

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 1,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 1, 15, 4, 3, 447, DateTimeKind.Local).AddTicks(3043), new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(4495) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 2,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5122), new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 3,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5157), new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5159) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 4,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5161), new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5163) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 5,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5164), new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5166) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 6,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5167), new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5169) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 7,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5171), new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 8,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5174), new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 9,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5177), new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5178) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 10,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5180), new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 11,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5184), new DateTime(2020, 5, 1, 15, 4, 3, 448, DateTimeKind.Local).AddTicks(5185) });
        }
    }
}
