using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HNKWebAPI.Migrations
{
    public partial class AddTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoleInd",
                table: "UserRoleMaps");

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "UserRoleMaps",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartName = table.Column<string>(nullable: true),
                    DepartLeader = table.Column<string>(nullable: true),
                    DepartNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartID);
                });

            migrationBuilder.CreateTable(
                name: "RewardRecords",
                columns: table => new
                {
                    RecordID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(nullable: false),
                    AwardReason = table.Column<string>(nullable: true),
                    AwardClass = table.Column<string>(nullable: true),
                    AwardState = table.Column<string>(nullable: true),
                    AwardMoney = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    PunishMoney = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    AwardDate = table.Column<string>(nullable: true),
                    CancelDate = table.Column<string>(nullable: true),
                    ApproveDepart = table.Column<string>(nullable: true),
                    Approver = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RewardRecords", x => x.RecordID);
                });

            migrationBuilder.CreateTable(
                name: "StaffInfos",
                columns: table => new
                {
                    StaffID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SetAccountID = table.Column<string>(nullable: true),
                    DepartID = table.Column<int>(nullable: false),
                    EmployeeNo = table.Column<string>(nullable: true),
                    EmployeeName = table.Column<string>(nullable: true),
                    EmployeeNamePY = table.Column<string>(nullable: true),
                    EmployeeIDNumber = table.Column<string>(nullable: true),
                    EmployeeGender = table.Column<string>(nullable: true),
                    BirthDate = table.Column<string>(nullable: true),
                    MaritalStatus = table.Column<string>(nullable: true),
                    Photo = table.Column<byte[]>(nullable: true),
                    EmployeeNation = table.Column<string>(nullable: true),
                    EmployeePhone = table.Column<string>(nullable: true),
                    EmployeePost = table.Column<string>(nullable: true),
                    EmployeeTitle = table.Column<string>(nullable: true),
                    PoliticalStatus = table.Column<string>(nullable: true),
                    EmployeeEducation = table.Column<string>(nullable: true),
                    EmployeeMajor = table.Column<string>(nullable: true),
                    GraduSchool = table.Column<string>(nullable: true),
                    JoinDate = table.Column<string>(nullable: true),
                    EmployeeType = table.Column<string>(nullable: true),
                    HomeAddress = table.Column<string>(nullable: true),
                    SignDate = table.Column<string>(nullable: true),
                    ExpireDate = table.Column<string>(nullable: true),
                    AccumAccount = table.Column<string>(nullable: true),
                    IsQuit = table.Column<bool>(nullable: false),
                    QuitDate = table.Column<string>(nullable: true),
                    QuitReason = table.Column<string>(nullable: true),
                    EmployeeRemark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffInfos", x => x.StaffID);
                });

            migrationBuilder.CreateTable(
                name: "TitleRecords",
                columns: table => new
                {
                    TitleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleName = table.Column<string>(nullable: true),
                    EmployeeNo = table.Column<string>(nullable: true),
                    TitleObtainDate = table.Column<string>(nullable: true),
                    ObtainType = table.Column<string>(nullable: true),
                    EmployUnit = table.Column<string>(nullable: true),
                    EmployTitle = table.Column<string>(nullable: true),
                    EmployBegin = table.Column<string>(nullable: true),
                    EmployEnd = table.Column<string>(nullable: true),
                    EnglishClass = table.Column<string>(nullable: true),
                    EnglishDate = table.Column<string>(nullable: true),
                    ComputerClass = table.Column<string>(nullable: true),
                    ComputerDate = table.Column<string>(nullable: true),
                    TitleRemark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TitleRecords", x => x.TitleID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "RewardRecords");

            migrationBuilder.DropTable(
                name: "StaffInfos");

            migrationBuilder.DropTable(
                name: "TitleRecords");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "UserRoleMaps");

            migrationBuilder.AddColumn<int>(
                name: "RoleInd",
                table: "UserRoleMaps",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
