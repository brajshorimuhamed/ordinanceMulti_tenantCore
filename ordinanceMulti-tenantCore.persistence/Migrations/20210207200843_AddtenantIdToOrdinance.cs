using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ordinanceMulti_tenantCore.persistence.Migrations
{
    public partial class AddtenantIdToOrdinance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TenandId",
                table: "Ordinances",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12BC2784-B550-5876-98A8-74A621C6E6B8",
                column: "ConcurrencyStamp",
                value: "17270ec8-f9b3-47f9-ae83-120e42ab4f89");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4FFB4345-CA1C-5050-AB1F-3AE2BE5E46D5",
                column: "ConcurrencyStamp",
                value: "e9da996d-c1dc-4fb7-8fc8-dad7dcec9dce");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9A6EA564-7238-5CD6-BD64-DA142DD43FF5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3bc0f111-6bea-4539-a647-b9300cdc167f", "AQAAAAEAACcQAAAAEOqHkWnJP/ubhweK8dCKZ+3b0E/3P0Q1gd3LcLDZoHamAduJL2fmHdEBW2aZ5d7l3w==", "1acf80e3-80f3-4385-a9e0-e25cd3c2d300" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenandId",
                table: "Ordinances");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12BC2784-B550-5876-98A8-74A621C6E6B8",
                column: "ConcurrencyStamp",
                value: "a1ee66ef-910a-44ee-a73f-1eca3efb2dee");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4FFB4345-CA1C-5050-AB1F-3AE2BE5E46D5",
                column: "ConcurrencyStamp",
                value: "fcb02060-c458-4c6b-a0ad-2f6e56665bba");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9A6EA564-7238-5CD6-BD64-DA142DD43FF5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c68952dc-f47d-456c-8740-dce05242ae4f", "AQAAAAEAACcQAAAAEA+kjyU3NB1Pt6qLYpnQ2z9EwbIoLrTTWJrSj4Ep34aFEfqT1ivuR1B+Z5y281kKjQ==", "9cb2892e-b264-443d-beb9-f5525339fde0" });
        }
    }
}
