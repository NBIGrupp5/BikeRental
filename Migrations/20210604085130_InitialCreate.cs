using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BikeRental.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 4, 10, 51, 29, 968, DateTimeKind.Local).AddTicks(1345),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 2, 16, 22, 57, 35, DateTimeKind.Local).AddTicks(3782));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "BikeTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 4, 10, 51, 29, 953, DateTimeKind.Local).AddTicks(9633),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 2, 16, 22, 57, 28, DateTimeKind.Local).AddTicks(5687));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 2, 16, 22, 57, 35, DateTimeKind.Local).AddTicks(3782),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 4, 10, 51, 29, 968, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "BikeTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 6, 2, 16, 22, 57, 28, DateTimeKind.Local).AddTicks(5687),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 6, 4, 10, 51, 29, 953, DateTimeKind.Local).AddTicks(9633));
        }
    }
}
