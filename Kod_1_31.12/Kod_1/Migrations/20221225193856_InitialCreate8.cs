using Microsoft.EntityFrameworkCore.Migrations;

namespace Kod_1.Migrations
{
    public partial class InitialCreate8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "Kullanıcılar");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kullanıcılar",
                table: "Kullanıcılar",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Kullanıcılar",
                table: "Kullanıcılar");

            migrationBuilder.RenameTable(
                name: "Kullanıcılar",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");
        }
    }
}
