using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GymOrganization.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddUsersRolesSeedsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("2f32ee00-8974-4215-8fd8-07e0befaf890"), null, "Admin", "ADMIN" },
                    { new Guid("4a1999ca-3693-4f60-afbe-22a77fef2f09"), null, "Coach", "COACH" },
                    { new Guid("b7612d57-bb44-4913-8c7f-8a6aba4fe3d5"), null, "Client", "CLIENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("1e9deac9-7e9d-46d6-997a-32efdf6d5f6c"), 0, "3511c688-8cd9-41ac-bfb0-09afcd866ded", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "asmith@example.com", false, "Alice", "Smith", false, null, "ASMITH@EXAMPLE.COM", "ASMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMEV5CN7h4sg4CHu5fjOt1B0I2FbNfCVk2+qOiwbWMcobp5hC+InnXhA0Za0oW0GQw==", "+1-555-999-1212", false, "570f74d9-82fc-4d68-beb0-835ee8dffb3a", false, "asmith@example.com" },
                    { new Guid("87d8fde7-99da-4a9c-9cfc-64bfc84d7196"), 0, "97fd35e1-e412-40db-a262-4e4dcdf07375", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bjohnson@example.com", false, "Bob", "Johnson", false, null, "BJOHNSON@EXAMPLE.COM", "BJOHNSON@EXAMPLE.COM", "AQAAAAIAAYagAAAAEI5MOcBrWZCBhMG+GrUA5+Sw/20g9POzQRAZNW1AeDvUHcJnQWUjpwUnHxcNPGnNjQ==", "+1-555-555-1212", false, "0b3dc11d-023c-4b26-bfe4-b46daeb9fe06", false, "bjohnson@example.com" },
                    { new Guid("af690bfe-f82e-4856-b8dc-1075a5f5c6b9"), 0, "fcf0fc69-74a2-45c5-b8ea-fdb08a407a9c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tlee@example.com", false, "Tom", "Lee", false, null, "TLEE@EXAMPLE.COM", "TLEE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEsHuZU46PQn0H4XVREZtqg47lTOIvwoIEqfRfSeVKKLqA+j4locrDaxG0rWIXnHvQ==", "+1-555-444-1212", false, "b7ac58f8-d3d7-4349-a906-eb09f8c6c167", false, "tlee@example.com" },
                    { new Guid("d4a4a0ca-d7cb-4e8f-8c58-34535c9eab5b"), 0, "d2ec8156-f8b9-4dd9-a6f9-d71fd2717288", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jdoe@example.com", false, "Jane", "Doe", false, null, "JDOE@EXAMPLE.COM", "JDOE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOoLHCJXt53KUp6J3KEPefCV4rujv2eddxfygfY2cZQd0yZcYPKEvqjED4eZBmM8Zw==", "+1-555-987-6543", false, "de0504f0-497a-4c7c-9b61-2558cd1411c4", false, "jdoe@example.com" },
                    { new Guid("e563aa88-86b1-4c69-a0f8-496b53c9ac26"), 0, "226f3afa-8726-4744-a564-072ff91a91b7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jsmith@example.com", false, "John", "Smith", false, null, "JSMITH@EXAMPLE.COM", "JSMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAENKTwbAxJimwGDlPS3+r8hThiWvLr1kOZxoh9lsJ0U4+iNT4cMeTur4xhTTeidoE5A==", "+1-555-123-4567", false, "17aaa421-da27-4ea6-bfc1-ce988d2d5897", false, "jsmith@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("b7612d57-bb44-4913-8c7f-8a6aba4fe3d5"), new Guid("1e9deac9-7e9d-46d6-997a-32efdf6d5f6c") },
                    { new Guid("4a1999ca-3693-4f60-afbe-22a77fef2f09"), new Guid("87d8fde7-99da-4a9c-9cfc-64bfc84d7196") },
                    { new Guid("b7612d57-bb44-4913-8c7f-8a6aba4fe3d5"), new Guid("af690bfe-f82e-4856-b8dc-1075a5f5c6b9") },
                    { new Guid("2f32ee00-8974-4215-8fd8-07e0befaf890"), new Guid("d4a4a0ca-d7cb-4e8f-8c58-34535c9eab5b") },
                    { new Guid("4a1999ca-3693-4f60-afbe-22a77fef2f09"), new Guid("e563aa88-86b1-4c69-a0f8-496b53c9ac26") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b7612d57-bb44-4913-8c7f-8a6aba4fe3d5"), new Guid("1e9deac9-7e9d-46d6-997a-32efdf6d5f6c") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("4a1999ca-3693-4f60-afbe-22a77fef2f09"), new Guid("87d8fde7-99da-4a9c-9cfc-64bfc84d7196") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b7612d57-bb44-4913-8c7f-8a6aba4fe3d5"), new Guid("af690bfe-f82e-4856-b8dc-1075a5f5c6b9") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2f32ee00-8974-4215-8fd8-07e0befaf890"), new Guid("d4a4a0ca-d7cb-4e8f-8c58-34535c9eab5b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("4a1999ca-3693-4f60-afbe-22a77fef2f09"), new Guid("e563aa88-86b1-4c69-a0f8-496b53c9ac26") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2f32ee00-8974-4215-8fd8-07e0befaf890"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4a1999ca-3693-4f60-afbe-22a77fef2f09"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b7612d57-bb44-4913-8c7f-8a6aba4fe3d5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1e9deac9-7e9d-46d6-997a-32efdf6d5f6c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("87d8fde7-99da-4a9c-9cfc-64bfc84d7196"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("af690bfe-f82e-4856-b8dc-1075a5f5c6b9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d4a4a0ca-d7cb-4e8f-8c58-34535c9eab5b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e563aa88-86b1-4c69-a0f8-496b53c9ac26"));
        }
    }
}
