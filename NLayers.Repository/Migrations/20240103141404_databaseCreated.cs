using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayers.Repository.Migrations
{
    public partial class databaseCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsersTable",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Roles = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersTable", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "CertificatesTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CertificateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificateDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificatesTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CertificatesTable_UsersTable_UserId",
                        column: x => x.UserId,
                        principalTable: "UsersTable",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyInfoTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyField = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyInfoTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyInfoTable_UsersTable_UserId",
                        column: x => x.UserId,
                        principalTable: "UsersTable",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KnownProgramTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgramName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgramDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnownProgramTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KnownProgramTable_UsersTable_UserId",
                        column: x => x.UserId,
                        principalTable: "UsersTable",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SchoolInformationTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolInformationTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SchoolInformationTable_UsersTable_UserId",
                        column: x => x.UserId,
                        principalTable: "UsersTable",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpeakingLanguagesTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpeakingLanguagesTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpeakingLanguagesTable_UsersTable_UserId",
                        column: x => x.UserId,
                        principalTable: "UsersTable",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);

        });

            migrationBuilder.CreateTable(
                name: "UserAdressTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAdressTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAdressTable_UsersTable_Id",
                        column: x => x.Id,
                        principalTable: "UsersTable",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserInformationTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    UserDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirtDay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MSwasDone = table.Column<bool>(type: "bit", nullable: true),
                    Hobies = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInformationTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserInformationTable_UsersTable_Id",
                        column: x => x.Id,
                        principalTable: "UsersTable",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyUserRoleTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserRoleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserRoleDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyInfoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyUserRoleTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyUserRoleTable_CompanyInfoTable_CompanyInfoId",
                        column: x => x.CompanyInfoId,
                        principalTable: "CompanyInfoTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
        });

            migrationBuilder.CreateTable(
                name: "SchoolDepartmentTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolDepartmentTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SchoolDepartmentTable_SchoolInformationTable_SchoolsId",
                        column: x => x.SchoolsId,
                        principalTable: "SchoolInformationTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "UsersTable",
                columns: new[] { "UserId", "CreatedAt", "DeleteAt", "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Roles", "UpdateAt" },
                values: new object[] { 1, new DateTime(2024, 1, 3, 17, 14, 4, 94, DateTimeKind.Local).AddTicks(3995), null, "AdminEmail@email.com", "AdminName", "AdminLastName", "Admin", "AdminPhoneNumber", "Admin", null });

            migrationBuilder.InsertData(
                table: "UsersTable",
                columns: new[] { "UserId", "CreatedAt", "DeleteAt", "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Roles", "UpdateAt" },
                values: new object[] { 2, new DateTime(2024, 1, 3, 17, 14, 4, 94, DateTimeKind.Local).AddTicks(4005), null, "Email1@email.com", "FirstName1", "LastName1", "Password1", "PhoneNumber1", "User", null });

            migrationBuilder.InsertData(
                table: "UsersTable",
                columns: new[] { "UserId", "CreatedAt", "DeleteAt", "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Roles", "UpdateAt" },
                values: new object[] { 3, new DateTime(2024, 1, 3, 17, 14, 4, 94, DateTimeKind.Local).AddTicks(4006), null, "Email2@email.com", "FirstName2", "LastName2", "Password2", "PhoneNumber2", "User", null });

            migrationBuilder.InsertData(
                table: "CertificatesTable",
                columns: new[] { "Id", "CertificateDescription", "CertificateName", "CreatedAt", "DeleteAt", "FileName", "FilePath", "UpdateAt", "UserId" },
                values: new object[,]
                {
                    { 1, "Test", "Test1", new DateTime(2024, 1, 3, 17, 14, 4, 94, DateTimeKind.Local).AddTicks(4083), null, "Test", "Test", null, 1 },
                    { 2, "Test", "Test2", new DateTime(2024, 1, 3, 17, 14, 4, 94, DateTimeKind.Local).AddTicks(4084), null, "Test", "Test", null, 1 },
                    { 3, "Test", "Test3", new DateTime(2024, 1, 3, 17, 14, 4, 94, DateTimeKind.Local).AddTicks(4085), null, "Test", "Test", null, 1 },
                    { 4, "Test", "Test4", new DateTime(2024, 1, 3, 17, 14, 4, 94, DateTimeKind.Local).AddTicks(4112), null, "Test", "Test", null, 2 },
                    { 5, "Test", "Test5", new DateTime(2024, 1, 3, 17, 14, 4, 94, DateTimeKind.Local).AddTicks(4113), null, "Test", "Test", null, 3 }
                });

            migrationBuilder.InsertData(
                table: "CompanyInfoTable",
                columns: new[] { "Id", "CompanyAddress", "CompanyDescription", "CompanyField", "CompanyName", "FileName", "FilePath", "UserId" },
                values: new object[,]
                {
                    { 1, "Test1", "Test1", "Test1", "Test1", "Test1", "Test1", 1 },
                    { 2, "Test2", "Test2", "Test2", "Test2", "Test2", "Test2", 1 },
                    { 3, "Test3", "Test3", "Test3", "Test3", "Test3", "Test3", 1 },
                    { 4, "Test4", "Test4", "Test4", "Test4", "Test4", "Test4", 2 },
                    { 5, "Test5", "Test5", "Test5", "Test5", "Test5", "Test5", 3 }
                });

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

            migrationBuilder.InsertData(
                table: "UserAdressTable",
                columns: new[] { "Id", "CityName", "Country", "PostalCode", "State", "StreetName" },
                values: new object[,]
                {
                    { 1, "Ankara/Sincan", "Türkiye", "12345", "A Mah", "12345" },
                    { 2, "Ankara/Yenimahalle", "Türkiye", "12345", "B Mah", "12345" },
                    { 3, "Ankara/Ostim", "Türkiye", "12345", "C Mah", "12345" }
                });

            migrationBuilder.InsertData(
                table: "UserInformationTable",
                columns: new[] { "Id", "BirtDay", "FileName", "FilePath", "Gender", "Hobies", "MSwasDone", "UserDescription" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Male", "Hobies A", true, "Description A" },
                    { 2, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Male", "Hobies b", true, "Description b" },
                    { 3, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Male", "Hobies c", true, "Description c" }
                });

            migrationBuilder.InsertData(
                table: "CompanyUserRoleTable",
                columns: new[] { "Id", "CompanyInfoId", "UserRoleDescription", "UserRoleName" },
                values: new object[,]
                {
                    { 1, 1, "Test1", "Test1" },
                    { 2, 2, "Test2", "Test2" },
                    { 3, 3, "Test3", "Test3" },
                    { 4, 4, "Test4", "Test4" },
                    { 5, 5, "Test5", "Test5" },
                    { 6, 1, "Test6", "Test6" },
                    { 7, 1, "Test7", "Test7" }
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

            migrationBuilder.CreateIndex(
                name: "IX_CertificatesTable_UserId",
                table: "CertificatesTable",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyInfoTable_UserId",
                table: "CompanyInfoTable",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyUserRoleTable_CompanyInfoId",
                table: "CompanyUserRoleTable",
                column: "CompanyInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_KnownProgramTable_UserId",
                table: "KnownProgramTable",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolDepartmentTable_SchoolsId",
                table: "SchoolDepartmentTable",
                column: "SchoolsId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolInformationTable_UserId",
                table: "SchoolInformationTable",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SpeakingLanguagesTable_UserId",
                table: "SpeakingLanguagesTable",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CertificatesTable");

            migrationBuilder.DropTable(
                name: "CompanyUserRoleTable");

            migrationBuilder.DropTable(
                name: "KnownProgramTable");

            migrationBuilder.DropTable(
                name: "SchoolDepartmentTable");

            migrationBuilder.DropTable(
                name: "SpeakingLanguagesTable");

            migrationBuilder.DropTable(
                name: "UserAdressTable");

            migrationBuilder.DropTable(
                name: "UserInformationTable");

            migrationBuilder.DropTable(
                name: "CompanyInfoTable");

            migrationBuilder.DropTable(
                name: "SchoolInformationTable");

            migrationBuilder.DropTable(
                name: "UsersTable");
        }
    }
}
