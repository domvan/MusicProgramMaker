using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicMakerProgram.Migrations
{
    public partial class mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Violists");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Violinists");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Pianists");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Cellists");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Violists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Violinists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Pianists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Cellists",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
