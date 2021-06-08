using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BikeRental.Migrations
{
    public partial class CreateSchoolDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 7, 12, 33, 34, 125, DateTimeKind.Local).AddTicks(6175),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 7, 11, 36, 24, 484, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "BikeTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 7, 12, 33, 34, 111, DateTimeKind.Local).AddTicks(6146),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 7, 11, 36, 24, 477, DateTimeKind.Local).AddTicks(7533));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 7, 11, 36, 24, 484, DateTimeKind.Local).AddTicks(8385),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 7, 12, 33, 34, 125, DateTimeKind.Local).AddTicks(6175));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "BikeTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 7, 11, 36, 24, 477, DateTimeKind.Local).AddTicks(7533),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 7, 12, 33, 34, 111, DateTimeKind.Local).AddTicks(6146));
        }
    }
}
