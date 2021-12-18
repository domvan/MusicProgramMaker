using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicMakerProgram.Migrations
{
    public partial class updatePKs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_GroupPerforms");

            migrationBuilder.DropTable(
                name: "_Knows");

            migrationBuilder.DropTable(
                name: "_Manages");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "canViews");

            migrationBuilder.DropTable(
                name: "Cellists");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "composerCanEdits");

            migrationBuilder.DropTable(
                name: "GroupCanEdits");

            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "Levels");

            migrationBuilder.DropTable(
                name: "Performers");

            migrationBuilder.DropTable(
                name: "Pianists");

            migrationBuilder.DropTable(
                name: "Programs");

            migrationBuilder.DropTable(
                name: "Quartet");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Trios");

            migrationBuilder.DropTable(
                name: "Violinists");

            migrationBuilder.DropTable(
                name: "Violists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pieces",
                table: "Pieces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Composers",
                table: "Composers");

            migrationBuilder.RenameTable(
                name: "Pieces",
                newName: "Piece");

            migrationBuilder.RenameTable(
                name: "Composers",
                newName: "Composer");

            migrationBuilder.RenameColumn(
                name: "piece_name",
                table: "Performances",
                newName: "Piece_name");

            migrationBuilder.RenameColumn(
                name: "perf_name",
                table: "Performances",
                newName: "Perf_name");

            migrationBuilder.RenameColumn(
                name: "pID",
                table: "Performances",
                newName: "PID");

            migrationBuilder.RenameColumn(
                name: "perfID",
                table: "Performances",
                newName: "PerfID");

            migrationBuilder.RenameColumn(
                name: "musicSheetLink",
                table: "Piece",
                newName: "MusicSheetLink");

            migrationBuilder.RenameColumn(
                name: "info",
                table: "Piece",
                newName: "Info");

            migrationBuilder.RenameColumn(
                name: "genre",
                table: "Piece",
                newName: "Genre");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "Piece",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "c_name",
                table: "Piece",
                newName: "C_name");

            migrationBuilder.RenameColumn(
                name: "pName",
                table: "Piece",
                newName: "PName");

            migrationBuilder.RenameColumn(
                name: "period",
                table: "Composer",
                newName: "Period");

            migrationBuilder.RenameColumn(
                name: "bio",
                table: "Composer",
                newName: "Bio");

            migrationBuilder.RenameColumn(
                name: "cName",
                table: "Composer",
                newName: "CName");

            migrationBuilder.AlterColumn<string>(
                name: "Piece_name",
                table: "Performances",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "C_name",
                table: "Piece",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Piece",
                table: "Piece",
                column: "PName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Composer",
                table: "Composer",
                column: "CName");

            migrationBuilder.CreateTable(
                name: "MusicProgram",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumPerformers = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicProgram", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Performances_PID",
                table: "Performances",
                column: "PID");

            migrationBuilder.CreateIndex(
                name: "IX_Performances_Piece_name",
                table: "Performances",
                column: "Piece_name");

            migrationBuilder.CreateIndex(
                name: "IX_Piece_C_name",
                table: "Piece",
                column: "C_name");

            migrationBuilder.AddForeignKey(
                name: "FK_Performances_MusicProgram_PID",
                table: "Performances",
                column: "PID",
                principalTable: "MusicProgram",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Performances_Piece_Piece_name",
                table: "Performances",
                column: "Piece_name",
                principalTable: "Piece",
                principalColumn: "PName",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Piece_Composer_C_name",
                table: "Piece",
                column: "C_name",
                principalTable: "Composer",
                principalColumn: "CName",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Performances_MusicProgram_PID",
                table: "Performances");

            migrationBuilder.DropForeignKey(
                name: "FK_Performances_Piece_Piece_name",
                table: "Performances");

            migrationBuilder.DropForeignKey(
                name: "FK_Piece_Composer_C_name",
                table: "Piece");

            migrationBuilder.DropTable(
                name: "MusicProgram");

            migrationBuilder.DropIndex(
                name: "IX_Performances_PID",
                table: "Performances");

            migrationBuilder.DropIndex(
                name: "IX_Performances_Piece_name",
                table: "Performances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Piece",
                table: "Piece");

            migrationBuilder.DropIndex(
                name: "IX_Piece_C_name",
                table: "Piece");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Composer",
                table: "Composer");

            migrationBuilder.RenameTable(
                name: "Piece",
                newName: "Pieces");

            migrationBuilder.RenameTable(
                name: "Composer",
                newName: "Composers");

            migrationBuilder.RenameColumn(
                name: "Piece_name",
                table: "Performances",
                newName: "piece_name");

            migrationBuilder.RenameColumn(
                name: "Perf_name",
                table: "Performances",
                newName: "perf_name");

            migrationBuilder.RenameColumn(
                name: "PID",
                table: "Performances",
                newName: "pID");

            migrationBuilder.RenameColumn(
                name: "PerfID",
                table: "Performances",
                newName: "perfID");

            migrationBuilder.RenameColumn(
                name: "MusicSheetLink",
                table: "Pieces",
                newName: "musicSheetLink");

            migrationBuilder.RenameColumn(
                name: "Info",
                table: "Pieces",
                newName: "info");

            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "Pieces",
                newName: "genre");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Pieces",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "C_name",
                table: "Pieces",
                newName: "c_name");

            migrationBuilder.RenameColumn(
                name: "PName",
                table: "Pieces",
                newName: "pName");

            migrationBuilder.RenameColumn(
                name: "Period",
                table: "Composers",
                newName: "period");

            migrationBuilder.RenameColumn(
                name: "Bio",
                table: "Composers",
                newName: "bio");

            migrationBuilder.RenameColumn(
                name: "CName",
                table: "Composers",
                newName: "cName");

            migrationBuilder.AlterColumn<string>(
                name: "piece_name",
                table: "Performances",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "c_name",
                table: "Pieces",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pieces",
                table: "Pieces",
                column: "pName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Composers",
                table: "Composers",
                column: "cName");

            migrationBuilder.CreateTable(
                name: "_GroupPerforms",
                columns: table => new
                {
                    gpID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gID = table.Column<int>(type: "int", nullable: false),
                    perfID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GroupPerforms", x => x.gpID);
                });

            migrationBuilder.CreateTable(
                name: "_Knows",
                columns: table => new
                {
                    KnowsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    performerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pieceName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Knows", x => x.KnowsID);
                });

            migrationBuilder.CreateTable(
                name: "_Manages",
                columns: table => new
                {
                    ManagesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adminUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    classID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Manages", x => x.ManagesID);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.username);
                });

            migrationBuilder.CreateTable(
                name: "canViews",
                columns: table => new
                {
                    cvID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gUsername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_canViews", x => x.cvID);
                });

            migrationBuilder.CreateTable(
                name: "Cellists",
                columns: table => new
                {
                    name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cellists", x => x.name);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    classID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numberOfStudents = table.Column<int>(type: "int", nullable: false),
                    tName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.classID);
                });

            migrationBuilder.CreateTable(
                name: "composerCanEdits",
                columns: table => new
                {
                    cceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adminUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_composerCanEdits", x => x.cceID);
                });

            migrationBuilder.CreateTable(
                name: "GroupCanEdits",
                columns: table => new
                {
                    gceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adminUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupCanEdits", x => x.gceID);
                });

            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.username);
                });

            migrationBuilder.CreateTable(
                name: "Levels",
                columns: table => new
                {
                    levelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    yearsOfExpirience = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Levels", x => x.levelID);
                });

            migrationBuilder.CreateTable(
                name: "Performers",
                columns: table => new
                {
                    name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    classID = table.Column<int>(type: "int", nullable: false),
                    levelID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Performers", x => x.name);
                });

            migrationBuilder.CreateTable(
                name: "Pianists",
                columns: table => new
                {
                    name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pianists", x => x.name);
                });

            migrationBuilder.CreateTable(
                name: "Programs",
                columns: table => new
                {
                    ProgID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumPerformers = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programs", x => x.ProgID);
                });

            migrationBuilder.CreateTable(
                name: "Quartet",
                columns: table => new
                {
                    gID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cellist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    firstViolin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    secondViolin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    violist = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quartet", x => x.gID);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    tID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    school = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.tID);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    teamID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    age = table.Column<int>(type: "int", nullable: false),
                    bio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.teamID);
                });

            migrationBuilder.CreateTable(
                name: "Trios",
                columns: table => new
                {
                    gID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cellist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pianist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    violinist = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trios", x => x.gID);
                });

            migrationBuilder.CreateTable(
                name: "Violinists",
                columns: table => new
                {
                    name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Violinists", x => x.name);
                });

            migrationBuilder.CreateTable(
                name: "Violists",
                columns: table => new
                {
                    name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Violists", x => x.name);
                });
        }
    }
}
