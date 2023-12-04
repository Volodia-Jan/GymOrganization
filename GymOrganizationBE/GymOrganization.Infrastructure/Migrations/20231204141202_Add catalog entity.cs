using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GymOrganization.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Addcatalogentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CatalogItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ShortName = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogItems", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e9deac9-7e9d-46d6-997a-32efdf6d5f6c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b9c1ccb-66e5-46b0-961d-4640c63c5692", "AQAAAAIAAYagAAAAENO7f0y8xwrIkfaD18Myd9I3i5fW+UlIlN2By5AFuK3m1lbDMYNUSO30QhXMxETNxA==", "85689bdf-bb3a-49ca-823f-8245048c4766" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("87d8fde7-99da-4a9c-9cfc-64bfc84d7196"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12083a79-ee49-429b-8375-7539ccb31215", "AQAAAAIAAYagAAAAELzqlJbrjGn9v6bfe21XNrHDbjDz3+RR8yKHq8WtjU9REI5wNdbxvnq0HlPc54PdEw==", "34395ab6-9a94-4c6f-9638-6e199a9165a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("af690bfe-f82e-4856-b8dc-1075a5f5c6b9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66f2ebf1-90df-4ee6-89db-fb59d5b2d819", "AQAAAAIAAYagAAAAEE3l2q6o2/bM99lp8+xUrAKyvehWjB+u7qvZo7nqlTOw83X145g2G4DNMhSvAjRI0g==", "9dc3566b-e761-4c47-b17f-04cb84205d52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d4a4a0ca-d7cb-4e8f-8c58-34535c9eab5b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "990a5f9d-6ca6-4895-99d1-b8907970bd21", "AQAAAAIAAYagAAAAECLyTUL+Yk/Tqct2aaAflttkGsWA0Mv75JeSf2svuk0Gf/UX8mkTrvKovCFw+vJZew==", "f7cc212d-1fab-40f1-b7ed-c2dbc3d9a7f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e563aa88-86b1-4c69-a0f8-496b53c9ac26"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a9bb2dc-fd86-4d36-b819-a6423b3016df", "AQAAAAIAAYagAAAAEPFl1WjFq8adcY44o2Qiyw+VnnXRM9ygG11bruyAHl4uzoR6daZaJbFVQvGXg+MQvw==", "5899b002-6ebc-411c-ac42-f1f214717792" });

            migrationBuilder.InsertData(
                table: "CatalogItems",
                columns: new[] { "Id", "Description", "Price", "ShortName" },
                values: new object[,]
                {
                    { new Guid("583842e8-ee0a-4f2f-bc52-68b68602aef0"), "Особистий тренувальний сеанс з сертифікованим тренером.", 350.0, "Тренування з Тренером" },
                    { new Guid("8ef93f07-0d22-4f0d-8a5b-8b0d34d5fde8"), "Одне заняття на наших оживляючих йога-класах.", 80.0, "Йога - Одноразове Відвідування" },
                    { new Guid("c20d7354-5b9a-4c41-8bf0-6f0f50aecc49"), "Доступ до тренажерного залу та занять на один місяць.", 1500.0, "Щомісячний Абонемент" },
                    { new Guid("d8719de1-7386-4848-aafe-c11439a61c12"), "Доступ до тренажерного залу на один день.", 150.0, "Одноразове Відвідування" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatalogItems");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e9deac9-7e9d-46d6-997a-32efdf6d5f6c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3511c688-8cd9-41ac-bfb0-09afcd866ded", "AQAAAAIAAYagAAAAEMEV5CN7h4sg4CHu5fjOt1B0I2FbNfCVk2+qOiwbWMcobp5hC+InnXhA0Za0oW0GQw==", "570f74d9-82fc-4d68-beb0-835ee8dffb3a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("87d8fde7-99da-4a9c-9cfc-64bfc84d7196"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97fd35e1-e412-40db-a262-4e4dcdf07375", "AQAAAAIAAYagAAAAEI5MOcBrWZCBhMG+GrUA5+Sw/20g9POzQRAZNW1AeDvUHcJnQWUjpwUnHxcNPGnNjQ==", "0b3dc11d-023c-4b26-bfe4-b46daeb9fe06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("af690bfe-f82e-4856-b8dc-1075a5f5c6b9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fcf0fc69-74a2-45c5-b8ea-fdb08a407a9c", "AQAAAAIAAYagAAAAEEsHuZU46PQn0H4XVREZtqg47lTOIvwoIEqfRfSeVKKLqA+j4locrDaxG0rWIXnHvQ==", "b7ac58f8-d3d7-4349-a906-eb09f8c6c167" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d4a4a0ca-d7cb-4e8f-8c58-34535c9eab5b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2ec8156-f8b9-4dd9-a6f9-d71fd2717288", "AQAAAAIAAYagAAAAEOoLHCJXt53KUp6J3KEPefCV4rujv2eddxfygfY2cZQd0yZcYPKEvqjED4eZBmM8Zw==", "de0504f0-497a-4c7c-9b61-2558cd1411c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e563aa88-86b1-4c69-a0f8-496b53c9ac26"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "226f3afa-8726-4744-a564-072ff91a91b7", "AQAAAAIAAYagAAAAENKTwbAxJimwGDlPS3+r8hThiWvLr1kOZxoh9lsJ0U4+iNT4cMeTur4xhTTeidoE5A==", "17aaa421-da27-4ea6-bfc1-ce988d2d5897" });
        }
    }
}
