using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayers.Repository.Migrations
{
    public partial class databaseComplated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificatesTable", x => x.Id);
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
                });

            migrationBuilder.CreateTable(
                name: "CompanyUserRoleTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserRoleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserRoleDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyInfosId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyUserRoleTable", x => x.Id);
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
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnownProgramTable", x => x.Id);
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
                });

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
                name: "CompanyInfoEntityCompanyUserRoleEntity",
                columns: table => new
                {
                    CompanyInfosId = table.Column<int>(type: "int", nullable: false),
                    UserRolesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyInfoEntityCompanyUserRoleEntity", x => new { x.CompanyInfosId, x.UserRolesId });
                    table.ForeignKey(
                        name: "FK_CompanyInfoEntityCompanyUserRoleEntity_CompanyInfoTable_CompanyInfosId",
                        column: x => x.CompanyInfosId,
                        principalTable: "CompanyInfoTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyInfoEntityCompanyUserRoleEntity_CompanyUserRoleTable_UserRolesId",
                        column: x => x.UserRolesId,
                        principalTable: "CompanyUserRoleTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SchoolDepartmentEntitySchoolInformationEntity",
                columns: table => new
                {
                    SchoolsId = table.Column<int>(type: "int", nullable: false),
                    StudentDepartmentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolDepartmentEntitySchoolInformationEntity", x => new { x.SchoolsId, x.StudentDepartmentsId });
                    table.ForeignKey(
                        name: "FK_SchoolDepartmentEntitySchoolInformationEntity_SchoolDepartmentTable_StudentDepartmentsId",
                        column: x => x.StudentDepartmentsId,
                        principalTable: "SchoolDepartmentTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SchoolDepartmentEntitySchoolInformationEntity_SchoolInformationTable_SchoolsId",
                        column: x => x.SchoolsId,
                        principalTable: "SchoolInformationTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CertificateEntityUserEntity",
                columns: table => new
                {
                    CertificatesId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificateEntityUserEntity", x => new { x.CertificatesId, x.UserId });
                    table.ForeignKey(
                        name: "FK_CertificateEntityUserEntity_CertificatesTable_CertificatesId",
                        column: x => x.CertificatesId,
                        principalTable: "CertificatesTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CertificateEntityUserEntity_UsersTable_UserId",
                        column: x => x.UserId,
                        principalTable: "UsersTable",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyInfoEntityUserEntity",
                columns: table => new
                {
                    CompanyInfosId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyInfoEntityUserEntity", x => new { x.CompanyInfosId, x.UserId });
                    table.ForeignKey(
                        name: "FK_CompanyInfoEntityUserEntity_CompanyInfoTable_CompanyInfosId",
                        column: x => x.CompanyInfosId,
                        principalTable: "CompanyInfoTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyInfoEntityUserEntity_UsersTable_UserId",
                        column: x => x.UserId,
                        principalTable: "UsersTable",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KnownProgramEntityUserEntity",
                columns: table => new
                {
                    KnownProgramsId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnownProgramEntityUserEntity", x => new { x.KnownProgramsId, x.UserId });
                    table.ForeignKey(
                        name: "FK_KnownProgramEntityUserEntity_KnownProgramTable_KnownProgramsId",
                        column: x => x.KnownProgramsId,
                        principalTable: "KnownProgramTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KnownProgramEntityUserEntity_UsersTable_UserId",
                        column: x => x.UserId,
                        principalTable: "UsersTable",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SchoolInformationEntityUserEntity",
                columns: table => new
                {
                    SchoolInfosId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolInformationEntityUserEntity", x => new { x.SchoolInfosId, x.UserId });
                    table.ForeignKey(
                        name: "FK_SchoolInformationEntityUserEntity_SchoolInformationTable_SchoolInfosId",
                        column: x => x.SchoolInfosId,
                        principalTable: "SchoolInformationTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SchoolInformationEntityUserEntity_UsersTable_UserId",
                        column: x => x.UserId,
                        principalTable: "UsersTable",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpeakingLanguageEntityUserEntity",
                columns: table => new
                {
                    LanguagesId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpeakingLanguageEntityUserEntity", x => new { x.LanguagesId, x.UserId });
                    table.ForeignKey(
                        name: "FK_SpeakingLanguageEntityUserEntity_SpeakingLanguagesTable_LanguagesId",
                        column: x => x.LanguagesId,
                        principalTable: "SpeakingLanguagesTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpeakingLanguageEntityUserEntity_UsersTable_UserId",
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

            migrationBuilder.InsertData(
                table: "CertificatesTable",
                columns: new[] { "Id", "CertificateDescription", "CertificateName", "CreatedAt", "DeleteAt", "FileName", "FilePath", "UpdateAt", "UserId" },
                values: new object[,]
                {
                    { 1, "Test", "Test1", new DateTime(2023, 12, 31, 13, 27, 18, 871, DateTimeKind.Local).AddTicks(3155), null, "Test", "Test", null, 1 },
                    { 2, "Test", "Test2", new DateTime(2023, 12, 31, 13, 27, 18, 871, DateTimeKind.Local).AddTicks(3157), null, "Test", "Test", null, 1 },
                    { 3, "Test", "Test3", new DateTime(2023, 12, 31, 13, 27, 18, 871, DateTimeKind.Local).AddTicks(3158), null, "Test", "Test", null, 1 },
                    { 4, "Test", "Test4", new DateTime(2023, 12, 31, 13, 27, 18, 871, DateTimeKind.Local).AddTicks(3159), null, "Test", "Test", null, 2 },
                    { 5, "Test", "Test5", new DateTime(2023, 12, 31, 13, 27, 18, 871, DateTimeKind.Local).AddTicks(3160), null, "Test", "Test", null, 3 }
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
                table: "CompanyUserRoleTable",
                columns: new[] { "Id", "CompanyInfosId", "UserRoleDescription", "UserRoleName" },
                values: new object[,]
                {
                    { 1, 1, "Test1", "Test1" },
                    { 2, 5, "Test2", "Test2" },
                    { 3, 5, "Test3", "Test3" },
                    { 4, 4, "Test4", "Test4" },
                    { 5, 4, "Test5", "Test5" },
                    { 6, 1, "Test6", "Test6" },
                    { 7, null, "Test7", "Test7" }
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

            migrationBuilder.InsertData(
                table: "UsersTable",
                columns: new[] { "UserId", "CreatedAt", "DeleteAt", "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Roles", "UpdateAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 31, 13, 27, 18, 871, DateTimeKind.Local).AddTicks(3039), null, "AdminEmail@email.com", "AdminName", "AdminLastName", "Admin", "AdminPhoneNumber", "Admin", null },
                    { 2, new DateTime(2023, 12, 31, 13, 27, 18, 871, DateTimeKind.Local).AddTicks(3052), null, "Email1@email.com", "FirstName1", "LastName1", "Password1", "PhoneNumber1", "User", null },
                    { 3, new DateTime(2023, 12, 31, 13, 27, 18, 871, DateTimeKind.Local).AddTicks(3053), null, "Email2@email.com", "FirstName2", "LastName2", "Password2", "PhoneNumber2", "User", null }
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

            migrationBuilder.CreateIndex(
                name: "IX_CertificateEntityUserEntity_UserId",
                table: "CertificateEntityUserEntity",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyInfoEntityCompanyUserRoleEntity_UserRolesId",
                table: "CompanyInfoEntityCompanyUserRoleEntity",
                column: "UserRolesId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyInfoEntityUserEntity_UserId",
                table: "CompanyInfoEntityUserEntity",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_KnownProgramEntityUserEntity_UserId",
                table: "KnownProgramEntityUserEntity",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolDepartmentEntitySchoolInformationEntity_StudentDepartmentsId",
                table: "SchoolDepartmentEntitySchoolInformationEntity",
                column: "StudentDepartmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolInformationEntityUserEntity_UserId",
                table: "SchoolInformationEntityUserEntity",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SpeakingLanguageEntityUserEntity_UserId",
                table: "SpeakingLanguageEntityUserEntity",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CertificateEntityUserEntity");

            migrationBuilder.DropTable(
                name: "CompanyInfoEntityCompanyUserRoleEntity");

            migrationBuilder.DropTable(
                name: "CompanyInfoEntityUserEntity");

            migrationBuilder.DropTable(
                name: "KnownProgramEntityUserEntity");

            migrationBuilder.DropTable(
                name: "SchoolDepartmentEntitySchoolInformationEntity");

            migrationBuilder.DropTable(
                name: "SchoolInformationEntityUserEntity");

            migrationBuilder.DropTable(
                name: "SpeakingLanguageEntityUserEntity");

            migrationBuilder.DropTable(
                name: "UserAdressTable");

            migrationBuilder.DropTable(
                name: "UserInformationTable");

            migrationBuilder.DropTable(
                name: "CertificatesTable");

            migrationBuilder.DropTable(
                name: "CompanyUserRoleTable");

            migrationBuilder.DropTable(
                name: "CompanyInfoTable");

            migrationBuilder.DropTable(
                name: "KnownProgramTable");

            migrationBuilder.DropTable(
                name: "SchoolDepartmentTable");

            migrationBuilder.DropTable(
                name: "SchoolInformationTable");

            migrationBuilder.DropTable(
                name: "SpeakingLanguagesTable");

            migrationBuilder.DropTable(
                name: "UsersTable");
        }
    }
}
