using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Consultation.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MyMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UMID = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserType = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Bulletin",
                columns: table => new
                {
                    BulletinID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Author = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Content = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DatePublished = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FileCount = table.Column<int>(type: "int", nullable: false),
                    IsArchived = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bulletin", x => x.BulletinID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DepartmentName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    NotificationNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NotificationMessage = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NotificationType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.NotificationNumber);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SchoolYear",
                columns: table => new
                {
                    SchoolYearID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Year1 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Year2 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SchoolYearStatus = table.Column<int>(type: "int", nullable: false),
                    Semester = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolYear", x => x.SchoolYearID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ActionLog",
                columns: table => new
                {
                    ActionLogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Time = table.Column<TimeOnly>(type: "time(6)", nullable: false),
                    UsersId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionLog", x => x.ActionLogID);
                    table.ForeignKey(
                        name: "FK_ActionLog_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AdminName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsersID = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.AdminID);
                    table.ForeignKey(
                        name: "FK_Admin_AspNetUsers_UsersID",
                        column: x => x.UsersID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Program",
                columns: table => new
                {
                    ProgramID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProgramName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Program", x => x.ProgramID);
                    table.ForeignKey(
                        name: "FK_Program_Department_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Faculty",
                columns: table => new
                {
                    FacultyID = table.Column<int>(type: "int", nullable: false),
                    FacultyUMID = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FacultyName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FacultyEmail = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsersID = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SchoolYearID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty", x => x.FacultyID);
                    table.ForeignKey(
                        name: "FK_Faculty_AspNetUsers_UsersID",
                        column: x => x.UsersID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Faculty_SchoolYear_SchoolYearID",
                        column: x => x.SchoolYearID,
                        principalTable: "SchoolYear",
                        principalColumn: "SchoolYearID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    StudentUMID = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StudentName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    yearLevel = table.Column<int>(type: "int", nullable: false),
                    ProgramID = table.Column<int>(type: "int", nullable: false),
                    SchoolYearID = table.Column<int>(type: "int", nullable: false),
                    UsersID = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                    table.ForeignKey(
                        name: "FK_Students_AspNetUsers_UsersID",
                        column: x => x.UsersID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Program_ProgramID",
                        column: x => x.ProgramID,
                        principalTable: "Program",
                        principalColumn: "ProgramID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_SchoolYear_SchoolYearID",
                        column: x => x.SchoolYearID,
                        principalTable: "SchoolYear",
                        principalColumn: "SchoolYearID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FacultySchedule",
                columns: table => new
                {
                    FacultyScheduleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TimeStart = table.Column<TimeOnly>(type: "time(6)", nullable: false),
                    TimeEnd = table.Column<TimeOnly>(type: "time(6)", nullable: false),
                    Day = table.Column<int>(type: "int", nullable: false),
                    FacultyID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacultySchedule", x => x.FacultyScheduleID);
                    table.ForeignKey(
                        name: "FK_FacultySchedule_Faculty_FacultyID",
                        column: x => x.FacultyID,
                        principalTable: "Faculty",
                        principalColumn: "FacultyID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ConsultationRequest",
                columns: table => new
                {
                    ConsultationID = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateSchedule = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    StartedTime = table.Column<TimeOnly>(type: "time(6)", nullable: false),
                    EndedTime = table.Column<TimeOnly>(type: "time(6)", nullable: false),
                    Concern = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DisapprovedReason = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SubjectCode = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ProgramName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    FacultyID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultationRequest", x => x.ConsultationID);
                    table.ForeignKey(
                        name: "FK_ConsultationRequest_Faculty_FacultyID",
                        column: x => x.FacultyID,
                        principalTable: "Faculty",
                        principalColumn: "FacultyID");
                    table.ForeignKey(
                        name: "FK_ConsultationRequest_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EnrolledCourse",
                columns: table => new
                {
                    EnrolledCourseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CourseName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CourseCode = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SchoolYearID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    FacultyID = table.Column<int>(type: "int", nullable: false),
                    ProgramCourse = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnrolledCourse", x => x.EnrolledCourseID);
                    table.ForeignKey(
                        name: "FK_EnrolledCourse_Faculty_FacultyID",
                        column: x => x.FacultyID,
                        principalTable: "Faculty",
                        principalColumn: "FacultyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EnrolledCourse_SchoolYear_SchoolYearID",
                        column: x => x.SchoolYearID,
                        principalTable: "SchoolYear",
                        principalColumn: "SchoolYearID");
                    table.ForeignKey(
                        name: "FK_EnrolledCourse_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UMID", "UserName", "UserType" },
                values: new object[,]
                {
                    { "0A52E15B-95E6-40FE-9110-9A44817BFF39", 0, "8d3ef0d9-b045-4b8f-a18f-15f2cbfa219b", "CheleyBalsomo.8998@umindanao.edu.ph", true, false, null, "CHELEYBALSOMO.8998@UMINDANAO.EDU.PH", "CHELEY BALSOMO", "AQAAAAIAAYagAAAAEOzC6u68+xooBv4xh3I9Y9jNNzy1GaSf+kugS/L4Wv48pLIAzPizJaPm5IuML5xz5A==", null, false, "5a54c967-0b1f-4c38-bda7-5f94e4c1a3f4", false, "899812", "Cheley Balsomo", 1 },
                    { "1226920F-9508-44B3-845A-ABABBBCBCF5D", 0, "8d3ef0d9-b045-4b8f-a18f-15f2cbfa219b", "ReggieSoylon.6850@umindanao.edu.ph", true, false, null, "REGGIESOYLON.6850@UMINDANAO.EDU.PH", "REGGIE SOYLON", "AQAAAAIAAYagAAAAEBNHrXTZW6ZcK/t6xom6OSbzuS0/1yk5l9cOJY79QHHGcTEgv2BA+/uiBvy8T+xdaQ==", null, false, "5a54c967-0b1f-4c38-bda7-5f94e4c1a3f4", false, "685043", "Reggie Soylon", 1 },
                    { "273F528F-5330-411F-9C6B-01543D6249C3", 0, "8d3ef0d9-b045-4b8f-a18f-15f2cbfa219b", "CedricSetimo.550200@umindanao.edu.ph", true, false, null, "CEDRICSETIMO.550200@UMINDANAO.EDU.PH", "CEDRIC SETIMO", "AQAAAAIAAYagAAAAECycirCs23vYzEIB3Hunh1vRIBRJDk1ysQKXP0fpcAPvTWbrDdzE0avPCOhDFobBwg==", null, false, "5a54c967-0b1f-4c38-bda7-5f94e4c1a3f4", false, "550200", "Cedric Setimo", 1 },
                    { "53D8F920-EBEC-4DF3-8C53-21F6D123F0D9", 0, "8d3ef0d9-b045-4b8f-a18f-15f2cbfa219b", "ReyMateo.550200@umindanao.edu.ph", true, false, null, "REYMATEO.550200@UMINDANAO.EDU.PH", "REY MATEO", "AQAAAAIAAYagAAAAEEOppKNFV7xmVF5XG7xpLjyQ3Q+Uv+7MooRqN4YlOgYsnDHsRRkVHB7vByqJY2DlJg==", null, false, "5a54c967-0b1f-4c38-bda7-5f94e4c1a3f4", false, "321033", "Rey Mateo", 2 },
                    { "59CF8531-68E4-466B-BAEC-45305FE16A14", 0, "8d3ef0d9-b045-4b8f-a18f-15f2cbfa219b", "ChristopherDestajo.9241@umindanao.edu.ph", true, false, null, "CHRISTOPHERDESTAJO.9241@UMINDANAO.EDU.PH", "CHRISTOPHER DESTAJO", "AQAAAAIAAYagAAAAEALOpqzteavv7ztwnhL59athCkBq27xIeT25pIVdST/2B7Xl9EdFoyD+/eesf0DQEA==", null, false, "5a54c967-0b1f-4c38-bda7-5f94e4c1a3f4", false, "924132", "Christopher Destajo", 1 },
                    { "6B187E9D-FD71-4F1D-AFDF-EA1D91E818EF", 0, "8d3ef0d9-b045-4b8f-a18f-15f2cbfa219b", "RaineIsid.550200@umindanao.edu.ph", true, false, null, "RAINEISID.550200@UMINDANAO.EDU.PH", "RAINE ISID", "AQAAAAIAAYagAAAAEAMvIqmQdvSOTMYQ7+AIb3VKY9wNjxOTfX2I7OC5KAuKCt5+63NDJQ9I+3cJCCBbZQ==", null, false, "5a54c967-0b1f-4c38-bda7-5f94e4c1a3f4", false, "444533", "Raine Isid", 3 },
                    { "78B4AF2A-672F-43C5-B819-5F0B407B7187", 0, "8d3ef0d9-b045-4b8f-a18f-15f2cbfa219b", "JeanelleLabsan.7971@umindanao.edu.ph", true, false, null, "JEANELLELABSAN.7971@UMINDANAO.EDU.PH", "JEANELLE LABSAN", "AQAAAAIAAYagAAAAEK7zgOJItPB7mbNGGfPt+icupjZpR7xZUwu1jpvz7RVHUXC/ppkoczNE7Vg6oxYVMg==", null, false, "5a54c967-0b1f-4c38-bda7-5f94e4c1a3f4", false, "797132", "Jeanelle Labsan", 2 },
                    { "D0B26692-E380-4374-985F-239B56D06C20", 0, "8d3ef0d9-b045-4b8f-a18f-15f2cbfa219b", "EllaineMusni.550200@umindanao.edu.ph", true, false, null, "ELLAINEMUSNI.550200@UMINDANAO.EDU.PH", "ELLAINE MUSNI", "AQAAAAIAAYagAAAAELi+iMyYyLnVGnzAvjnGGQ3WdqnzQ9DF37h1UFn4IrqUcOc0h0VXGclSffXLNGneiw==", null, false, "5a54c967-0b1f-4c38-bda7-5f94e4c1a3f4", false, "547343", "Ellaine Musni", 1 },
                    { "D81B4D15-B3CD-47D5-96B0-44EF8E39E538", 0, "8d3ef0d9-b045-4b8f-a18f-15f2cbfa219b", "JiverDejiga.3210@umindanao.edu.ph", true, false, null, "JIVERDEJIGA.3210@UMINDANAO.EDU.PH", "JIVER DEJIGA", "AQAAAAIAAYagAAAAEA+CC8nM0W5oNdYH07lXmAgOqjkyztd8714SYIsegn/37L25RQj6jAwohDdZYbsgbg==", null, false, "5a54c967-0b1f-4c38-bda7-5f94e4c1a3f4", false, "54321", "Jiver Dejiga", 3 }
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentID", "DepartmentName", "Description" },
                values: new object[,]
                {
                    { 1, "CASE", "College of Arts and Sciences Education" },
                    { 2, "CBAE", "College of Business Administration Education" },
                    { 3, "CEE", "College of Engineering Education" }
                });

            migrationBuilder.InsertData(
                table: "Notification",
                columns: new[] { "NotificationNumber", "NotificationMessage", "NotificationType" },
                values: new object[,]
                {
                    { 1, "Hello World", 1 },
                    { 2, "Hi World", 2 },
                    { 3, "Jiver Gwapo", 1 }
                });

            migrationBuilder.InsertData(
                table: "SchoolYear",
                columns: new[] { "SchoolYearID", "SchoolYearStatus", "Semester", "Year1", "Year2" },
                values: new object[,]
                {
                    { 1, 1, 1, "2024", "2025" },
                    { 2, 1, 2, "2024", "2025" },
                    { 3, 1, 3, "2024", "2025" }
                });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "AdminID", "AdminName", "UsersID" },
                values: new object[,]
                {
                    { 1, "Raine Isid", "6B187E9D-FD71-4F1D-AFDF-EA1D91E818EF" },
                    { 2, "Jiver Dejiga", "D81B4D15-B3CD-47D5-96B0-44EF8E39E538" }
                });

            migrationBuilder.InsertData(
                table: "Faculty",
                columns: new[] { "FacultyID", "FacultyEmail", "FacultyName", "FacultyUMID", "SchoolYearID", "UsersID" },
                values: new object[,]
                {
                    { 1, "ReyMateo.550200@umindanao.edu.ph", "Rey Mateo", "321033", 1, "53D8F920-EBEC-4DF3-8C53-21F6D123F0D9" },
                    { 2, "JeanelleLabsan.7971@umindanao.edu.ph", "Jeanelle Labsan", "797132", 2, "78B4AF2A-672F-43C5-B819-5F0B407B7187" }
                });

            migrationBuilder.InsertData(
                table: "Program",
                columns: new[] { "ProgramID", "DepartmentID", "Description", "ProgramName" },
                values: new object[,]
                {
                    { 1, 3, "Mechanical Engineering", "ME" },
                    { 2, 3, "Civil Engineering", "CE" },
                    { 3, 3, "Computer Engineering", "CPE" },
                    { 4, 3, "Electrical Engineering", "EE" },
                    { 5, 3, "Electronics Engineering", "ECE" }
                });

            migrationBuilder.InsertData(
                table: "FacultySchedule",
                columns: new[] { "FacultyScheduleID", "Day", "FacultyID", "TimeEnd", "TimeStart" },
                values: new object[,]
                {
                    { 1, 1, 1, new TimeOnly(16, 0, 0), new TimeOnly(15, 0, 0) },
                    { 2, 5, 2, new TimeOnly(12, 0, 0), new TimeOnly(11, 0, 0) },
                    { 3, 2, 1, new TimeOnly(15, 0, 0), new TimeOnly(14, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "Email", "ProgramID", "SchoolYearID", "StudentName", "StudentUMID", "UsersID", "yearLevel" },
                values: new object[,]
                {
                    { 1, "CedricSetimo.550200@umindanao.edu.ph", 3, 1, "Cedric Setimo", "550200", "273F528F-5330-411F-9C6B-01543D6249C3", 3 },
                    { 2, "EllaineMusni.550200@umindanao.edu.ph", 3, 1, "Ellaine Musni", "547343", "D0B26692-E380-4374-985F-239B56D06C20", 3 }
                });

            migrationBuilder.InsertData(
                table: "ConsultationRequest",
                columns: new[] { "ConsultationID", "Concern", "DateRequested", "DateSchedule", "DisapprovedReason", "EndedTime", "FacultyID", "ProgramName", "StartedTime", "Status", "StudentID", "SubjectCode" },
                values: new object[,]
                {
                    { 1, "Need help with calculus problems", new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeOnly(10, 0, 0), 1, "ME", new TimeOnly(9, 0, 0), 1, 1, "MATH101" },
                    { 2, "Need help with data structures", new DateTime(2025, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeOnly(14, 30, 0), 1, "CPE", new TimeOnly(13, 30, 0), 1, 2, "CS202" },
                    { 3, "Follow-up on previous consultation", new DateTime(2025, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Faculty unavailable", new TimeOnly(16, 0, 0), 2, "CE", new TimeOnly(15, 0, 0), 3, 1, "PHY303" }
                });

            migrationBuilder.InsertData(
                table: "EnrolledCourse",
                columns: new[] { "EnrolledCourseID", "CourseCode", "CourseName", "FacultyID", "ProgramCourse", "SchoolYearID", "StudentID" },
                values: new object[,]
                {
                    { 1, "CEE101", "Engineering Calculus 1", 1, "ECE", 1, 1 },
                    { 2, "CEE102/L", "PHYSICS 1 FOR ENGINEERS (CALCULUS BASED)", 2, "CE", 1, 1 },
                    { 3, "CEE108", "Statics of Rigid Bodies", 2, "CE", 1, 1 },
                    { 4, "CEE108", "Statics of Rigid Bodies", 2, "ME", 1, 2 },
                    { 5, "CEE103", "Engineering Calculus 2", 2, "CHE", 2, 1 },
                    { 6, "CEE101", "Thermodyanmics 2", 1, "ME", 2, 1 },
                    { 7, "CPE221/L", "Data Structure and Algorithms", 2, "CPE", 2, 1 },
                    { 8, "CEE104", "Differential Equation", 2, "EE", 3, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActionLog_UsersId",
                table: "ActionLog",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Admin_UsersID",
                table: "Admin",
                column: "UsersID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ConsultationRequest_FacultyID",
                table: "ConsultationRequest",
                column: "FacultyID");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultationRequest_StudentID",
                table: "ConsultationRequest",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_EnrolledCourse_FacultyID",
                table: "EnrolledCourse",
                column: "FacultyID");

            migrationBuilder.CreateIndex(
                name: "IX_EnrolledCourse_SchoolYearID",
                table: "EnrolledCourse",
                column: "SchoolYearID");

            migrationBuilder.CreateIndex(
                name: "IX_EnrolledCourse_StudentID",
                table: "EnrolledCourse",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Faculty_SchoolYearID",
                table: "Faculty",
                column: "SchoolYearID");

            migrationBuilder.CreateIndex(
                name: "IX_Faculty_UsersID",
                table: "Faculty",
                column: "UsersID");

            migrationBuilder.CreateIndex(
                name: "IX_FacultySchedule_FacultyID",
                table: "FacultySchedule",
                column: "FacultyID");

            migrationBuilder.CreateIndex(
                name: "IX_Program_DepartmentID",
                table: "Program",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ProgramID",
                table: "Students",
                column: "ProgramID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SchoolYearID",
                table: "Students",
                column: "SchoolYearID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UsersID",
                table: "Students",
                column: "UsersID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActionLog");

            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Bulletin");

            migrationBuilder.DropTable(
                name: "ConsultationRequest");

            migrationBuilder.DropTable(
                name: "EnrolledCourse");

            migrationBuilder.DropTable(
                name: "FacultySchedule");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Faculty");

            migrationBuilder.DropTable(
                name: "Program");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "SchoolYear");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
