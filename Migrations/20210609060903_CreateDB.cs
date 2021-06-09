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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 6, 9, 8, 9, 3, 205, DateTimeKind.Local).AddTicks(6135))
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
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 6, 9, 8, 9, 3, 212, DateTimeKind.Local).AddTicks(7533))
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
                values: new object[,]
                {
                    { 1, "Passar bra vid längre sträckor eller om du vill ha lite extra hjälp i uppförsbackarna. Elmotorn hjälper dig upp till 25km/h.", "https://www.electricbike.com/wp-content/uploads/2020/08/Celebrity3.jpg", "Elcykel", 299f },
                    { 2, "Elegant kvalitetscykel. Ram med lågt insteg.", "https://images.unsplash.com/flagged/photo-1561273560-469573e7e290?ixid=MnwxMjA3fDB8MHxzZWFyY2h8OTZ8fGJpa2UlMjByaWRpbmd8ZW58MHx8MHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60", "Stadscykel", 249f },
                    { 3, "Vill du köra i lite tuffare terräng eller off-road passar denna cykel perfekt.", "https://images.unsplash.com/photo-1588935365434-fa1578152e18?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MjR8fG1vdW50YWluJTIwYmlrZXxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60", "Mountainbike", 269f },
                    { 4, "Klart att barnen ska med cykellturen. Vi har barncyklar.", "https://image.freepik.com/free-photo/back-view-little-child-blue-coat-riding-bicycle_85672-2742.jpg", "Barncykel", 179f }
                });

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
