using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicMakerProgram.Migrations
{
    public partial class lastMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Teachers_TID",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Classes_TID",
                table: "Classes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Classes_TID",
                table: "Classes",
                column: "TID");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Teachers_TID",
                table: "Classes",
                column: "TID",
                principalTable: "Teachers",
                principalColumn: "TID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
