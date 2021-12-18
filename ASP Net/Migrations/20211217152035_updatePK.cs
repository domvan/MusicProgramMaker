using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicMakerProgram.Migrations
{
    public partial class updatePK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "MusicProgram",
                newName: "PID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PID",
                table: "MusicProgram",
                newName: "Id");
        }
    }
}
