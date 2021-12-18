using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicMakerProgram.Migrations
{
    public partial class addSP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SoloPerformsS",
                columns: table => new
                {
                    SpID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PerformerID = table.Column<int>(type: "int", nullable: false),
                    PerfID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoloPerformsS", x => x.SpID);
                    table.ForeignKey(
                        name: "FK_SoloPerformsS_Performances_PerfID",
                        column: x => x.PerfID,
                        principalTable: "Performances",
                        principalColumn: "PerfID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SoloPerformsS_Performers_PerformerID",
                        column: x => x.PerformerID,
                        principalTable: "Performers",
                        principalColumn: "PerformerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SoloPerformsS_PerfID",
                table: "SoloPerformsS",
                column: "PerfID");

            migrationBuilder.CreateIndex(
                name: "IX_SoloPerformsS_PerformerID",
                table: "SoloPerformsS",
                column: "PerformerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SoloPerformsS");
        }
    }
}
