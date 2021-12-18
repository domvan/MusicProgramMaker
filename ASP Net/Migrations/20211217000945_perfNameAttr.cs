using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicMakerProgram.Migrations
{
    public partial class perfNameAttr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "perf_name",
                table: "Performances",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "perf_name",
                table: "Performances");
        }
    }
}
