using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayers.Repository.Migrations
{
    public partial class databaseCreated2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CertificatesTable",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 17, 52, 13, 962, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "CertificatesTable",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 17, 52, 13, 962, DateTimeKind.Local).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "CertificatesTable",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 17, 52, 13, 962, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "CertificatesTable",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 17, 52, 13, 962, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "CertificatesTable",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 17, 52, 13, 962, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "UsersTable",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 17, 52, 13, 962, DateTimeKind.Local).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "UsersTable",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 17, 52, 13, 962, DateTimeKind.Local).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "UsersTable",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 17, 52, 13, 962, DateTimeKind.Local).AddTicks(8583));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CertificatesTable",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 17, 14, 4, 94, DateTimeKind.Local).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "CertificatesTable",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 17, 14, 4, 94, DateTimeKind.Local).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "CertificatesTable",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 17, 14, 4, 94, DateTimeKind.Local).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "CertificatesTable",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 17, 14, 4, 94, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "CertificatesTable",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 17, 14, 4, 94, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "UsersTable",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 17, 14, 4, 94, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "UsersTable",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 17, 14, 4, 94, DateTimeKind.Local).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "UsersTable",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 3, 17, 14, 4, 94, DateTimeKind.Local).AddTicks(4006));
        }
    }
}
