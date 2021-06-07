using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BikeRental.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BikeTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BikeTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BikeTypePrice = table.Column<float>(type: "real", nullable: false),
                    BikeTypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BikeTypeImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 6, 7, 10, 19, 4, 527, DateTimeKind.Local).AddTicks(8120))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BikeTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    BikeId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 6, 7, 10, 19, 4, 534, DateTimeKind.Local).AddTicks(8522))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Bikes",
                columns: table => new
                {
                    BikeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FrameNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BikeTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bikes", x => x.BikeId);
                    table.ForeignKey(
                        name: "FK_Bikes_BikeTypes_BikeTypeId",
                        column: x => x.BikeTypeId,
                        principalTable: "BikeTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BikeTypes",
                columns: new[] { "Id", "BikeTypeDescription", "BikeTypeImage", "BikeTypeName", "BikeTypePrice" },
                values: new object[] { 1, "Passar bra vid längre sträckor eller om du vill ha lite extra hjälp i uppförsbackarna. Elmotorn hjälper dig upp till 25km/h.", "https://s3-eu-west-1.amazonaws.com/static.wm3.se/sites/531/media/219863_medium_161179_medium_cykel1_%281%29.png", "Elcykel", 399f });

            migrationBuilder.InsertData(
                table: "Bikes",
                columns: new[] { "BikeId", "BikeTypeId", "FrameNumber" },
                values: new object[] { 1, 1, "1234" });

            migrationBuilder.CreateIndex(
                name: "IX_Bikes_BikeTypeId",
                table: "Bikes",
                column: "BikeTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bikes");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "BikeTypes");
        }
    }
}
