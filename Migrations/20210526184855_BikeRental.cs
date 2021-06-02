using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BikeRental.Migrations
{
    public partial class BikeRental : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 26, 20, 48, 55, 131, DateTimeKind.Local).AddTicks(8304),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 26, 14, 31, 44, 575, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Booking",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 26, 20, 48, 55, 130, DateTimeKind.Local).AddTicks(5657),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 26, 14, 31, 44, 574, DateTimeKind.Local).AddTicks(4276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "BikeType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 26, 20, 48, 55, 129, DateTimeKind.Local).AddTicks(2077),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 26, 14, 31, 44, 573, DateTimeKind.Local).AddTicks(4954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bike",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 26, 20, 48, 55, 112, DateTimeKind.Local).AddTicks(2249),
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
                oldDefaultValue: new DateTime(2021, 5, 26, 20, 48, 55, 131, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Booking",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 26, 14, 31, 44, 574, DateTimeKind.Local).AddTicks(4276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 26, 20, 48, 55, 130, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "BikeType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 26, 14, 31, 44, 573, DateTimeKind.Local).AddTicks(4954),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 26, 20, 48, 55, 129, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bike",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 26, 14, 31, 44, 561, DateTimeKind.Local).AddTicks(1233),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 26, 20, 48, 55, 112, DateTimeKind.Local).AddTicks(2249));
        }
    }
}
