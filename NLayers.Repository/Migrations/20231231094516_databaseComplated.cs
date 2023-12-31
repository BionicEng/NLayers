using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayers.Repository.Migrations
{
    public partial class databaseComplated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SchoolInformationEntityUserEntity_UsersTable_UsersUserId",
                table: "SchoolInformationEntityUserEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_SpeakingLanguageEntityUserEntity_UsersTable_UsersUserId",
                table: "SpeakingLanguageEntityUserEntity");

            migrationBuilder.RenameColumn(
                name: "UsersUserId",
                table: "SpeakingLanguageEntityUserEntity",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_SpeakingLanguageEntityUserEntity_UsersUserId",
                table: "SpeakingLanguageEntityUserEntity",
                newName: "IX_SpeakingLanguageEntityUserEntity_UserId");

            migrationBuilder.RenameColumn(
                name: "UsersUserId",
                table: "SchoolInformationEntityUserEntity",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_SchoolInformationEntityUserEntity_UsersUserId",
                table: "SchoolInformationEntityUserEntity",
                newName: "IX_SchoolInformationEntityUserEntity_UserId");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "SpeakingLanguagesTable",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "SchoolInformationTable",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SchoolsId",
                table: "SchoolDepartmentTable",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "KnownProgramTable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "CertificatesTable",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 31, 12, 45, 16, 38, DateTimeKind.Local).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "CertificatesTable",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 31, 12, 45, 16, 38, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "CertificatesTable",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 31, 12, 45, 16, 38, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "CertificatesTable",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 31, 12, 45, 16, 38, DateTimeKind.Local).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "CertificatesTable",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 31, 12, 45, 16, 38, DateTimeKind.Local).AddTicks(1919));

            migrationBuilder.InsertData(
                table: "KnownProgramTable",
                columns: new[] { "Id", "CreatedAt", "DeleteAt", "FileName", "FilePath", "ProgramDescription", "ProgramName", "UpdateAt", "UserId" },
                values: new object[,]
                {
                    { 1, null, null, null, null, "Test1", "Test1", null, 2 },
                    { 2, null, null, null, null, "Test2", "Test2", null, 3 },
                    { 3, null, null, null, null, "Test3", "Test3", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "SchoolDepartmentTable",
                columns: new[] { "Id", "DepartmentDescription", "DepartmentName", "SchoolsId" },
                values: new object[,]
                {
                    { 1, "Test1", "Test1", 2 },
                    { 2, "Test2", "Test2", 3 },
                    { 3, "Test3", "Test3", 1 }
                });

            migrationBuilder.InsertData(
                table: "SchoolInformationTable",
                columns: new[] { "Id", "Location", "SchoolDescription", "SchoolName", "UserId" },
                values: new object[,]
                {
                    { 1, "Test1", "Test1", "Test1", 2 },
                    { 2, "Test2", "Test2", "Test2", 3 },
                    { 3, "Test3", "Test3", "Test3", 1 }
                });

            migrationBuilder.InsertData(
                table: "SpeakingLanguagesTable",
                columns: new[] { "Id", "FileName", "FilePath", "LanguageDescription", "LanguageName", "UserId" },
                values: new object[,]
                {
                    { 1, null, null, "Test1", "Test1", 2 },
                    { 2, null, null, "Test2", "Test2", 3 },
                    { 3, null, null, "Test3", "Test3", 1 }
                });

            migrationBuilder.UpdateData(
                table: "UsersTable",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 31, 12, 45, 16, 38, DateTimeKind.Local).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "UsersTable",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 31, 12, 45, 16, 38, DateTimeKind.Local).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "UsersTable",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 31, 12, 45, 16, 38, DateTimeKind.Local).AddTicks(1816));

            migrationBuilder.AddForeignKey(
                name: "FK_SchoolInformationEntityUserEntity_UsersTable_UserId",
                table: "SchoolInformationEntityUserEntity",
                column: "UserId",
                principalTable: "UsersTable",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SpeakingLanguageEntityUserEntity_UsersTable_UserId",
                table: "SpeakingLanguageEntityUserEntity",
                column: "UserId",
                principalTable: "UsersTable",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SchoolInformationEntityUserEntity_UsersTable_UserId",
                table: "SchoolInformationEntityUserEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_SpeakingLanguageEntityUserEntity_UsersTable_UserId",
                table: "SpeakingLanguageEntityUserEntity");

            migrationBuilder.DeleteData(
                table: "KnownProgramTable",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "KnownProgramTable",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "KnownProgramTable",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SchoolDepartmentTable",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SchoolDepartmentTable",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SchoolDepartmentTable",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SchoolInformationTable",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SchoolInformationTable",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SchoolInformationTable",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SpeakingLanguagesTable",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SpeakingLanguagesTable",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SpeakingLanguagesTable",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "SpeakingLanguagesTable");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "SchoolInformationTable");

            migrationBuilder.DropColumn(
                name: "SchoolsId",
                table: "SchoolDepartmentTable");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "KnownProgramTable");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "SpeakingLanguageEntityUserEntity",
                newName: "UsersUserId");

            migrationBuilder.RenameIndex(
                name: "IX_SpeakingLanguageEntityUserEntity_UserId",
                table: "SpeakingLanguageEntityUserEntity",
                newName: "IX_SpeakingLanguageEntityUserEntity_UsersUserId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "SchoolInformationEntityUserEntity",
                newName: "UsersUserId");

            migrationBuilder.RenameIndex(
                name: "IX_SchoolInformationEntityUserEntity_UserId",
                table: "SchoolInformationEntityUserEntity",
                newName: "IX_SchoolInformationEntityUserEntity_UsersUserId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_SchoolInformationEntityUserEntity_UsersTable_UsersUserId",
                table: "SchoolInformationEntityUserEntity",
                column: "UsersUserId",
                principalTable: "UsersTable",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SpeakingLanguageEntityUserEntity_UsersTable_UsersUserId",
                table: "SpeakingLanguageEntityUserEntity",
                column: "UsersUserId",
                principalTable: "UsersTable",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
