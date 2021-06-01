using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BikeRental.Migrations
{
    public partial class BikeDBCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 26, 20, 41, 19, 840, DateTimeKind.Local).AddTicks(9235),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 26, 14, 31, 44, 575, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Booking",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 26, 20, 41, 19, 839, DateTimeKind.Local).AddTicks(8486),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 26, 14, 31, 44, 574, DateTimeKind.Local).AddTicks(4276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "BikeType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 26, 20, 41, 19, 838, DateTimeKind.Local).AddTicks(6632),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 26, 14, 31, 44, 573, DateTimeKind.Local).AddTicks(4954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bike",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 26, 20, 41, 19, 822, DateTimeKind.Local).AddTicks(681),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 26, 14, 31, 44, 561, DateTimeKind.Local).AddTicks(1233));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 26, 14, 31, 44, 575, DateTimeKind.Local).AddTicks(5542),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 26, 20, 41, 19, 840, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Booking",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 26, 14, 31, 44, 574, DateTimeKind.Local).AddTicks(4276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 26, 20, 41, 19, 839, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "BikeType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 26, 14, 31, 44, 573, DateTimeKind.Local).AddTicks(4954),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 26, 20, 41, 19, 838, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bike",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 26, 14, 31, 44, 561, DateTimeKind.Local).AddTicks(1233),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 26, 20, 41, 19, 822, DateTimeKind.Local).AddTicks(681));
        }
    }
}
