using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BahanKiSadi_backend.Migrations
{
    public partial class _user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MiddileName",
                table: "RegistrationDetails",
                newName: "Password");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "RegistrationDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "RegistrationDetails");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "RegistrationDetails",
                newName: "MiddileName");
        }
    }
}
