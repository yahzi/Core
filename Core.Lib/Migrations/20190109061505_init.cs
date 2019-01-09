using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Core.Lib.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserPassword",
                table: "User",
                newName: "LoginPassword");

            migrationBuilder.RenameColumn(
                name: "UserAccount",
                table: "User",
                newName: "LoginAccount");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "IsInternal",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifyTime",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "OnFreezed",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Valid",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Sys_User",
                columns: table => new
                {
                    PKID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Valid = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    LastModifyTime = table.Column<DateTime>(nullable: false),
                    Sys_UserName = table.Column<string>(nullable: true),
                    Sys_LoginAccount = table.Column<string>(nullable: true),
                    Sys_LoginPassword = table.Column<string>(nullable: true),
                    OnFreezed = table.Column<int>(nullable: false),
                    IsInternal = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_User", x => x.PKID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sys_User");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "User");

            migrationBuilder.DropColumn(
                name: "IsInternal",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LastModifyTime",
                table: "User");

            migrationBuilder.DropColumn(
                name: "OnFreezed",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Valid",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "LoginPassword",
                table: "User",
                newName: "UserPassword");

            migrationBuilder.RenameColumn(
                name: "LoginAccount",
                table: "User",
                newName: "UserAccount");
        }
    }
}
