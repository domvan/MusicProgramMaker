using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicMakerProgram.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Performances_MusicProgram_PID",
                table: "Performances");

            migrationBuilder.DropIndex(
                name: "IX_Performances_PID",
                table: "Performances");

            migrationBuilder.AddColumn<int>(
                name: "MusicProgramPID",
                table: "Performances",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Performances_MusicProgramPID",
                table: "Performances",
                column: "MusicProgramPID");

            migrationBuilder.AddForeignKey(
                name: "FK_Performances_MusicProgram_MusicProgramPID",
                table: "Performances",
                column: "MusicProgramPID",
                principalTable: "MusicProgram",
                principalColumn: "PID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Performances_MusicProgram_MusicProgramPID",
                table: "Performances");

            migrationBuilder.DropIndex(
                name: "IX_Performances_MusicProgramPID",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "MusicProgramPID",
                table: "Performances");

            migrationBuilder.CreateIndex(
                name: "IX_Performances_PID",
                table: "Performances",
                column: "PID");

            migrationBuilder.AddForeignKey(
                name: "FK_Performances_MusicProgram_PID",
                table: "Performances",
                column: "PID",
                principalTable: "MusicProgram",
                principalColumn: "PID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
