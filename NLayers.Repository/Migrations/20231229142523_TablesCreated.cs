using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayers.Repository.Migrations
{
    public partial class TablesCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyInfoTable",
                columns: table => new
                {
                    CompanyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyField = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyInfoTable", x => x.CompanyID);
                });

            migrationBuilder.CreateTable(
                name: "SchoolInformationTable",
                columns: table => new
                {
                    SchoolId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchoolDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolInformationTable", x => x.SchoolId);
                });

            migrationBuilder.CreateTable(
                name: "StudentDepartmentTable",
                columns: table => new
                {
                    Department = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentDepartmentTable", x => x.Department);
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
                name: "SchoolInformationEntityStudentDepartmentEntity",
                columns: table => new
                {
                    SchoolsSchoolId = table.Column<int>(type: "int", nullable: false),
                    StudentDepartmentsDepartment = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolInformationEntityStudentDepartmentEntity", x => new { x.SchoolsSchoolId, x.StudentDepartmentsDepartment });
                    table.ForeignKey(
                        name: "FK_SchoolInformationEntityStudentDepartmentEntity_SchoolInformationTable_SchoolsSchoolId",
                        column: x => x.SchoolsSchoolId,
                        principalTable: "SchoolInformationTable",
                        principalColumn: "SchoolId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SchoolInformationEntityStudentDepartmentEntity_StudentDepartmentTable_StudentDepartmentsDepartment",
                        column: x => x.StudentDepartmentsDepartment,
                        principalTable: "StudentDepartmentTable",
                        principalColumn: "Department",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CertificatesTable",
                columns: table => new
                {
                    CertificateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CertificateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CertificateDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificatesTable", x => x.CertificateID);
                    table.ForeignKey(
                        name: "FK_CertificatesTable_UsersTable_UserID",
                        column: x => x.UserID,
                        principalTable: "UsersTable",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyUserRoleTable",
                columns: table => new
                {
                    UserRoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserRoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserRoleDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    CompanyID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyUserRoleTable", x => x.UserRoleID);
                    table.ForeignKey(
                        name: "FK_CompanyUserRoleTable_CompanyInfoTable_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "CompanyInfoTable",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyUserRoleTable_UsersTable_UserID",
                        column: x => x.UserID,
                        principalTable: "UsersTable",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KnownProgramTable",
                columns: table => new
                {
                    ProgramID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgramName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProgramDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnownProgramTable", x => x.ProgramID);
                    table.ForeignKey(
                        name: "FK_KnownProgramTable_UsersTable_UserID",
                        column: x => x.UserID,
                        principalTable: "UsersTable",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpeakingLanguagesTable",
                columns: table => new
                {
                    LanguageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpeakingLanguagesTable", x => x.LanguageID);
                    table.ForeignKey(
                        name: "FK_SpeakingLanguagesTable_UsersTable_UserID",
                        column: x => x.UserID,
                        principalTable: "UsersTable",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAdressTable",
                columns: table => new
                {
                    AdressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAdressTable", x => x.AdressID);
                    table.ForeignKey(
                        name: "FK_UserAdressTable_UsersTable_UserID",
                        column: x => x.UserID,
                        principalTable: "UsersTable",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserInformationTable",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    UserDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirtDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MSwasDone = table.Column<bool>(type: "bit", nullable: false),
                    Hobies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInformationTable", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_UserInformationTable_UsersTable_UserID",
                        column: x => x.UserID,
                        principalTable: "UsersTable",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserSchoolDepartmentEntity",
                columns: table => new
                {
                    UserDepartmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    SchoolID = table.Column<int>(type: "int", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSchoolDepartmentEntity", x => x.UserDepartmentID);
                    table.ForeignKey(
                        name: "FK_UserSchoolDepartmentEntity_SchoolInformationTable_SchoolID",
                        column: x => x.SchoolID,
                        principalTable: "SchoolInformationTable",
                        principalColumn: "SchoolId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSchoolDepartmentEntity_StudentDepartmentTable_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "StudentDepartmentTable",
                        principalColumn: "Department",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSchoolDepartmentEntity_UsersTable_UserID",
                        column: x => x.UserID,
                        principalTable: "UsersTable",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CertificatesTable_UserID",
                table: "CertificatesTable",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyUserRoleTable_CompanyID",
                table: "CompanyUserRoleTable",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyUserRoleTable_UserID",
                table: "CompanyUserRoleTable",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_KnownProgramTable_UserID",
                table: "KnownProgramTable",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolInformationEntityStudentDepartmentEntity_StudentDepartmentsDepartment",
                table: "SchoolInformationEntityStudentDepartmentEntity",
                column: "StudentDepartmentsDepartment");

            migrationBuilder.CreateIndex(
                name: "IX_SpeakingLanguagesTable_UserID",
                table: "SpeakingLanguagesTable",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserAdressTable_UserID",
                table: "UserAdressTable",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserSchoolDepartmentEntity_DepartmentID",
                table: "UserSchoolDepartmentEntity",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_UserSchoolDepartmentEntity_SchoolID",
                table: "UserSchoolDepartmentEntity",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_UserSchoolDepartmentEntity_UserID",
                table: "UserSchoolDepartmentEntity",
                column: "UserID");
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
                name: "SchoolInformationEntityStudentDepartmentEntity");

            migrationBuilder.DropTable(
                name: "SpeakingLanguagesTable");

            migrationBuilder.DropTable(
                name: "UserAdressTable");

            migrationBuilder.DropTable(
                name: "UserInformationTable");

            migrationBuilder.DropTable(
                name: "UserSchoolDepartmentEntity");

            migrationBuilder.DropTable(
                name: "CompanyInfoTable");

            migrationBuilder.DropTable(
                name: "SchoolInformationTable");

            migrationBuilder.DropTable(
                name: "StudentDepartmentTable");

            migrationBuilder.DropTable(
                name: "UsersTable");
        }
    }
}
