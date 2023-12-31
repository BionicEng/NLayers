using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayers.Repository.Migrations
{
    public partial class CompanyUserRoleSeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CertificatesTable",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 31, 12, 22, 13, 290, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "CertificatesTable",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 31, 12, 22, 13, 290, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "CertificatesTable",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 31, 12, 22, 13, 290, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "CertificatesTable",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 31, 12, 22, 13, 290, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "CertificatesTable",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 31, 12, 22, 13, 290, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "CompanyUserRoleTable",
                keyColumn: "Id",
                keyValue: 2,
                column: "CompanyInfosId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CompanyUserRoleTable",
                keyColumn: "Id",
                keyValue: 3,
                column: "CompanyInfosId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "CompanyUserRoleTable",
                keyColumn: "Id",
                keyValue: 4,
                column: "CompanyInfosId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "CompanyUserRoleTable",
                keyColumn: "Id",
                keyValue: 5,
                column: "CompanyInfosId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "UsersTable",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 31, 12, 22, 13, 290, DateTimeKind.Local).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "UsersTable",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 31, 12, 22, 13, 290, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "UsersTable",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 31, 12, 22, 13, 290, DateTimeKind.Local).AddTicks(8424));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CertificatesTable",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 31, 12, 19, 57, 125, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "CertificatesTable",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 31, 12, 19, 57, 125, DateTimeKind.Local).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "CertificatesTable",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 31, 12, 19, 57, 125, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "CertificatesTable",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 31, 12, 19, 57, 125, DateTimeKind.Local).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "CertificatesTable",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 31, 12, 19, 57, 125, DateTimeKind.Local).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "CompanyUserRoleTable",
                keyColumn: "Id",
                keyValue: 2,
                column: "CompanyInfosId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CompanyUserRoleTable",
                keyColumn: "Id",
                keyValue: 3,
                column: "CompanyInfosId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CompanyUserRoleTable",
                keyColumn: "Id",
                keyValue: 4,
                column: "CompanyInfosId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CompanyUserRoleTable",
                keyColumn: "Id",
                keyValue: 5,
                column: "CompanyInfosId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "UsersTable",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 31, 12, 19, 57, 125, DateTimeKind.Local).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "UsersTable",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 31, 12, 19, 57, 125, DateTimeKind.Local).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "UsersTable",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 31, 12, 19, 57, 125, DateTimeKind.Local).AddTicks(6513));
        }
    }
}
