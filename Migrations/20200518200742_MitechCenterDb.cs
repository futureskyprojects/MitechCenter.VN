using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MitechCenter.vn.Migrations
{
    public partial class MitechCenterDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "fFullname",
                table: "Feedback",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 1,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 19, 3, 7, 41, 361, DateTimeKind.Local).AddTicks(4284), new DateTime(2020, 5, 19, 3, 7, 41, 363, DateTimeKind.Local).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 2,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 19, 3, 7, 41, 363, DateTimeKind.Local).AddTicks(6489), new DateTime(2020, 5, 19, 3, 7, 41, 363, DateTimeKind.Local).AddTicks(6523) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 3,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 19, 3, 7, 41, 363, DateTimeKind.Local).AddTicks(6548), new DateTime(2020, 5, 19, 3, 7, 41, 363, DateTimeKind.Local).AddTicks(6552) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 4,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 19, 3, 7, 41, 363, DateTimeKind.Local).AddTicks(6556), new DateTime(2020, 5, 19, 3, 7, 41, 363, DateTimeKind.Local).AddTicks(6559) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 5,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 19, 3, 7, 41, 363, DateTimeKind.Local).AddTicks(6562), new DateTime(2020, 5, 19, 3, 7, 41, 363, DateTimeKind.Local).AddTicks(6565) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 6,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 19, 3, 7, 41, 363, DateTimeKind.Local).AddTicks(6568), new DateTime(2020, 5, 19, 3, 7, 41, 363, DateTimeKind.Local).AddTicks(6571) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 7,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 19, 3, 7, 41, 363, DateTimeKind.Local).AddTicks(6573), new DateTime(2020, 5, 19, 3, 7, 41, 363, DateTimeKind.Local).AddTicks(6576) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 8,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 19, 3, 7, 41, 363, DateTimeKind.Local).AddTicks(6579), new DateTime(2020, 5, 19, 3, 7, 41, 363, DateTimeKind.Local).AddTicks(6582) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 9,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 19, 3, 7, 41, 363, DateTimeKind.Local).AddTicks(6585), new DateTime(2020, 5, 19, 3, 7, 41, 363, DateTimeKind.Local).AddTicks(6587) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 10,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 19, 3, 7, 41, 363, DateTimeKind.Local).AddTicks(6591), new DateTime(2020, 5, 19, 3, 7, 41, 363, DateTimeKind.Local).AddTicks(6594) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 11,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 19, 3, 7, 41, 363, DateTimeKind.Local).AddTicks(6597), new DateTime(2020, 5, 19, 3, 7, 41, 363, DateTimeKind.Local).AddTicks(6599) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "fFullname",
                table: "Feedback",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 1,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 18, 21, 49, 6, 852, DateTimeKind.Local).AddTicks(8924), new DateTime(2020, 5, 18, 21, 49, 6, 854, DateTimeKind.Local).AddTicks(1568) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 2,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 18, 21, 49, 6, 854, DateTimeKind.Local).AddTicks(2600), new DateTime(2020, 5, 18, 21, 49, 6, 854, DateTimeKind.Local).AddTicks(2636) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 3,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 18, 21, 49, 6, 854, DateTimeKind.Local).AddTicks(2661), new DateTime(2020, 5, 18, 21, 49, 6, 854, DateTimeKind.Local).AddTicks(2664) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 4,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 18, 21, 49, 6, 854, DateTimeKind.Local).AddTicks(2668), new DateTime(2020, 5, 18, 21, 49, 6, 854, DateTimeKind.Local).AddTicks(2671) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 5,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 18, 21, 49, 6, 854, DateTimeKind.Local).AddTicks(2675), new DateTime(2020, 5, 18, 21, 49, 6, 854, DateTimeKind.Local).AddTicks(2677) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 6,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 18, 21, 49, 6, 854, DateTimeKind.Local).AddTicks(2682), new DateTime(2020, 5, 18, 21, 49, 6, 854, DateTimeKind.Local).AddTicks(2685) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 7,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 18, 21, 49, 6, 854, DateTimeKind.Local).AddTicks(2688), new DateTime(2020, 5, 18, 21, 49, 6, 854, DateTimeKind.Local).AddTicks(2691) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 8,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 18, 21, 49, 6, 854, DateTimeKind.Local).AddTicks(2695), new DateTime(2020, 5, 18, 21, 49, 6, 854, DateTimeKind.Local).AddTicks(2699) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 9,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 18, 21, 49, 6, 854, DateTimeKind.Local).AddTicks(2702), new DateTime(2020, 5, 18, 21, 49, 6, 854, DateTimeKind.Local).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 10,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 18, 21, 49, 6, 854, DateTimeKind.Local).AddTicks(2709), new DateTime(2020, 5, 18, 21, 49, 6, 854, DateTimeKind.Local).AddTicks(2711) });

            migrationBuilder.UpdateData(
                table: "StaticElement",
                keyColumn: "eId",
                keyValue: 11,
                columns: new[] { "createAt", "updateAt" },
                values: new object[] { new DateTime(2020, 5, 18, 21, 49, 6, 854, DateTimeKind.Local).AddTicks(2715), new DateTime(2020, 5, 18, 21, 49, 6, 854, DateTimeKind.Local).AddTicks(2718) });
        }
    }
}
