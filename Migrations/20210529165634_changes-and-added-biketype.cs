using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BikeRental.Migrations
{
    public partial class changesandaddedbiketype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Booking",
                table: "Booking");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BikeType",
                table: "BikeType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bike",
                table: "Bike");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Bike");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.RenameTable(
                name: "Booking",
                newName: "Bookings");

            migrationBuilder.RenameTable(
                name: "BikeType",
                newName: "BikeTypes");

            migrationBuilder.RenameTable(
                name: "Bike",
                newName: "Bikes");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customers",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Bikes",
                newName: "BikeId");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 18, 56, 34, 443, DateTimeKind.Local).AddTicks(6368),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 26, 14, 31, 44, 574, DateTimeKind.Local).AddTicks(4276));

            migrationBuilder.AddColumn<int>(
                name: "BikeId",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "BikeTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 29, 18, 56, 34, 432, DateTimeKind.Local).AddTicks(7346),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 26, 14, 31, 44, 573, DateTimeKind.Local).AddTicks(4954));

            migrationBuilder.AddColumn<string>(
                name: "BikeTypeName",
                table: "BikeTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "BikeTypePrice",
                table: "BikeTypes",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "BikeTypeName",
                table: "Bikes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BikeTypes",
                table: "BikeTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bikes",
                table: "Bikes",
                column: "BikeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BikeTypes",
                table: "BikeTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bikes",
                table: "Bikes");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "BikeId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "BikeTypeName",
                table: "BikeTypes");

            migrationBuilder.DropColumn(
                name: "BikeTypePrice",
                table: "BikeTypes");

            migrationBuilder.DropColumn(
                name: "BikeTypeName",
                table: "Bikes");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.RenameTable(
                name: "Bookings",
                newName: "Booking");

            migrationBuilder.RenameTable(
                name: "BikeTypes",
                newName: "BikeType");

            migrationBuilder.RenameTable(
                name: "Bikes",
                newName: "Bike");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Customer",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BikeId",
                table: "Bike",
                newName: "Id");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 26, 14, 31, 44, 575, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Booking",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 26, 14, 31, 44, 574, DateTimeKind.Local).AddTicks(4276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 29, 18, 56, 34, 443, DateTimeKind.Local).AddTicks(6368));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "BikeType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 26, 14, 31, 44, 573, DateTimeKind.Local).AddTicks(4954),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 5, 29, 18, 56, 34, 432, DateTimeKind.Local).AddTicks(7346));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Bike",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 5, 26, 14, 31, 44, 561, DateTimeKind.Local).AddTicks(1233));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Booking",
                table: "Booking",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BikeType",
                table: "BikeType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bike",
                table: "Bike",
                column: "Id");
        }
    }
}
