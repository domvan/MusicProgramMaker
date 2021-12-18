using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicMakerProgram.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Performances_MusicProgram_MusicProgramPID",
                table: "Performances");

            migrationBuilder.DropForeignKey(
                name: "FK_Performances_Piece_Piece_name",
                table: "Performances");

            migrationBuilder.DropForeignKey(
                name: "FK_Piece_Composer_C_name",
                table: "Piece");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Piece",
                table: "Piece");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MusicProgram",
                table: "MusicProgram");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Composer",
                table: "Composer");

            migrationBuilder.RenameTable(
                name: "Piece",
                newName: "Pieces");

            migrationBuilder.RenameTable(
                name: "MusicProgram",
                newName: "Programs");

            migrationBuilder.RenameTable(
                name: "Composer",
                newName: "Composers");

            migrationBuilder.RenameIndex(
                name: "IX_Piece_C_name",
                table: "Pieces",
                newName: "IX_Pieces_C_name");

            migrationBuilder.AlterColumn<string>(
                name: "C_name",
                table: "Pieces",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pieces",
                table: "Pieces",
                column: "PName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Programs",
                table: "Programs",
                column: "PID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Composers",
                table: "Composers",
                column: "CName");

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Username);
                });

            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.Username);
                });

            migrationBuilder.CreateTable(
                name: "Levels",
                columns: table => new
                {
                    LevelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YearsOfExpirience = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Levels", x => x.LevelID);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    School = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TID);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamID);
                });

            migrationBuilder.CreateTable(
                name: "ComposerCanEdits",
                columns: table => new
                {
                    CceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminUserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComposerCanEdits", x => x.CceID);
                    table.ForeignKey(
                        name: "FK_ComposerCanEdits_Admins_AdminUserName",
                        column: x => x.AdminUserName,
                        principalTable: "Admins",
                        principalColumn: "Username",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComposerCanEdits_Composers_CName",
                        column: x => x.CName,
                        principalTable: "Composers",
                        principalColumn: "CName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CanViews",
                columns: table => new
                {
                    cvID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GUsername = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CanViews", x => x.cvID);
                    table.ForeignKey(
                        name: "FK_CanViews_Guests_GUsername",
                        column: x => x.GUsername,
                        principalTable: "Guests",
                        principalColumn: "Username",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CanViews_Programs_PId",
                        column: x => x.PId,
                        principalTable: "Programs",
                        principalColumn: "PID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ClassID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfStudents = table.Column<int>(type: "int", nullable: false),
                    TID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.ClassID);
                    table.ForeignKey(
                        name: "FK_Classes_Teachers_TID",
                        column: x => x.TID,
                        principalTable: "Teachers",
                        principalColumn: "TID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupCanEdits",
                columns: table => new
                {
                    GceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminUserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupCanEdits", x => x.GceID);
                    table.ForeignKey(
                        name: "FK_GroupCanEdits_Admins_AdminUserName",
                        column: x => x.AdminUserName,
                        principalTable: "Admins",
                        principalColumn: "Username",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupCanEdits_Teams_GID",
                        column: x => x.GID,
                        principalTable: "Teams",
                        principalColumn: "TeamID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupPerformsS",
                columns: table => new
                {
                    GpID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GID = table.Column<int>(type: "int", nullable: false),
                    PerfID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupPerformsS", x => x.GpID);
                    table.ForeignKey(
                        name: "FK_GroupPerformsS_Performances_PerfID",
                        column: x => x.PerfID,
                        principalTable: "Performances",
                        principalColumn: "PerfID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupPerformsS_Teams_GID",
                        column: x => x.GID,
                        principalTable: "Teams",
                        principalColumn: "TeamID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ManagesS",
                columns: table => new
                {
                    ManagesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminUserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClassID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagesS", x => x.ManagesID);
                    table.ForeignKey(
                        name: "FK_ManagesS_Admins_AdminUserName",
                        column: x => x.AdminUserName,
                        principalTable: "Admins",
                        principalColumn: "Username",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ManagesS_Classes_ClassID",
                        column: x => x.ClassID,
                        principalTable: "Classes",
                        principalColumn: "ClassID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Performers",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassID = table.Column<int>(type: "int", nullable: false),
                    LevelID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Performers", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Performers_Classes_ClassID",
                        column: x => x.ClassID,
                        principalTable: "Classes",
                        principalColumn: "ClassID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Performers_Levels_LevelID",
                        column: x => x.LevelID,
                        principalTable: "Levels",
                        principalColumn: "LevelID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cellists",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cellists", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Cellists_Performers_Name",
                        column: x => x.Name,
                        principalTable: "Performers",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KnowsS",
                columns: table => new
                {
                    KnowsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PerformerName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PieceName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnowsS", x => x.KnowsID);
                    table.ForeignKey(
                        name: "FK_KnowsS_Performers_PerformerName",
                        column: x => x.PerformerName,
                        principalTable: "Performers",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KnowsS_Pieces_PieceName",
                        column: x => x.PieceName,
                        principalTable: "Pieces",
                        principalColumn: "PName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pianists",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pianists", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Pianists_Performers_Name",
                        column: x => x.Name,
                        principalTable: "Performers",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Violinists",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Violinists", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Violinists_Performers_Name",
                        column: x => x.Name,
                        principalTable: "Performers",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Violists",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Violists", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Violists_Performers_Name",
                        column: x => x.Name,
                        principalTable: "Performers",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trios",
                columns: table => new
                {
                    GID = table.Column<int>(type: "int", nullable: false),
                    Violinist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViolinistObjName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Cellist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CellistObjName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Pianist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PianistObjName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trios", x => x.GID);
                    table.ForeignKey(
                        name: "FK_Trios_Cellists_CellistObjName",
                        column: x => x.CellistObjName,
                        principalTable: "Cellists",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Trios_Pianists_PianistObjName",
                        column: x => x.PianistObjName,
                        principalTable: "Pianists",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Trios_Teams_GID",
                        column: x => x.GID,
                        principalTable: "Teams",
                        principalColumn: "TeamID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trios_Violinists_ViolinistObjName",
                        column: x => x.ViolinistObjName,
                        principalTable: "Violinists",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Quartet",
                columns: table => new
                {
                    GID = table.Column<int>(type: "int", nullable: false),
                    FirstViolin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FViolinistName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SecondViolin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SViolinistName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Violist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViolistObjName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Cellist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CellistObjName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quartet", x => x.GID);
                    table.ForeignKey(
                        name: "FK_Quartet_Cellists_CellistObjName",
                        column: x => x.CellistObjName,
                        principalTable: "Cellists",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Quartet_Teams_GID",
                        column: x => x.GID,
                        principalTable: "Teams",
                        principalColumn: "TeamID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Quartet_Violinists_FViolinistName",
                        column: x => x.FViolinistName,
                        principalTable: "Violinists",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Quartet_Violinists_SViolinistName",
                        column: x => x.SViolinistName,
                        principalTable: "Violinists",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Quartet_Violists_ViolistObjName",
                        column: x => x.ViolistObjName,
                        principalTable: "Violists",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CanViews_GUsername",
                table: "CanViews",
                column: "GUsername");

            migrationBuilder.CreateIndex(
                name: "IX_CanViews_PId",
                table: "CanViews",
                column: "PId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_TID",
                table: "Classes",
                column: "TID");

            migrationBuilder.CreateIndex(
                name: "IX_ComposerCanEdits_AdminUserName",
                table: "ComposerCanEdits",
                column: "AdminUserName");

            migrationBuilder.CreateIndex(
                name: "IX_ComposerCanEdits_CName",
                table: "ComposerCanEdits",
                column: "CName");

            migrationBuilder.CreateIndex(
                name: "IX_GroupCanEdits_AdminUserName",
                table: "GroupCanEdits",
                column: "AdminUserName");

            migrationBuilder.CreateIndex(
                name: "IX_GroupCanEdits_GID",
                table: "GroupCanEdits",
                column: "GID");

            migrationBuilder.CreateIndex(
                name: "IX_GroupPerformsS_GID",
                table: "GroupPerformsS",
                column: "GID");

            migrationBuilder.CreateIndex(
                name: "IX_GroupPerformsS_PerfID",
                table: "GroupPerformsS",
                column: "PerfID");

            migrationBuilder.CreateIndex(
                name: "IX_KnowsS_PerformerName",
                table: "KnowsS",
                column: "PerformerName");

            migrationBuilder.CreateIndex(
                name: "IX_KnowsS_PieceName",
                table: "KnowsS",
                column: "PieceName");

            migrationBuilder.CreateIndex(
                name: "IX_ManagesS_AdminUserName",
                table: "ManagesS",
                column: "AdminUserName");

            migrationBuilder.CreateIndex(
                name: "IX_ManagesS_ClassID",
                table: "ManagesS",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_Performers_ClassID",
                table: "Performers",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_Performers_LevelID",
                table: "Performers",
                column: "LevelID");

            migrationBuilder.CreateIndex(
                name: "IX_Quartet_CellistObjName",
                table: "Quartet",
                column: "CellistObjName");

            migrationBuilder.CreateIndex(
                name: "IX_Quartet_FViolinistName",
                table: "Quartet",
                column: "FViolinistName");

            migrationBuilder.CreateIndex(
                name: "IX_Quartet_SViolinistName",
                table: "Quartet",
                column: "SViolinistName");

            migrationBuilder.CreateIndex(
                name: "IX_Quartet_ViolistObjName",
                table: "Quartet",
                column: "ViolistObjName");

            migrationBuilder.CreateIndex(
                name: "IX_Trios_CellistObjName",
                table: "Trios",
                column: "CellistObjName");

            migrationBuilder.CreateIndex(
                name: "IX_Trios_PianistObjName",
                table: "Trios",
                column: "PianistObjName");

            migrationBuilder.CreateIndex(
                name: "IX_Trios_ViolinistObjName",
                table: "Trios",
                column: "ViolinistObjName");

            migrationBuilder.AddForeignKey(
                name: "FK_Performances_Pieces_Piece_name",
                table: "Performances",
                column: "Piece_name",
                principalTable: "Pieces",
                principalColumn: "PName",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Performances_Programs_MusicProgramPID",
                table: "Performances",
                column: "MusicProgramPID",
                principalTable: "Programs",
                principalColumn: "PID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pieces_Composers_C_name",
                table: "Pieces",
                column: "C_name",
                principalTable: "Composers",
                principalColumn: "CName",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Performances_Pieces_Piece_name",
                table: "Performances");

            migrationBuilder.DropForeignKey(
                name: "FK_Performances_Programs_MusicProgramPID",
                table: "Performances");

            migrationBuilder.DropForeignKey(
                name: "FK_Pieces_Composers_C_name",
                table: "Pieces");

            migrationBuilder.DropTable(
                name: "CanViews");

            migrationBuilder.DropTable(
                name: "ComposerCanEdits");

            migrationBuilder.DropTable(
                name: "GroupCanEdits");

            migrationBuilder.DropTable(
                name: "GroupPerformsS");

            migrationBuilder.DropTable(
                name: "KnowsS");

            migrationBuilder.DropTable(
                name: "ManagesS");

            migrationBuilder.DropTable(
                name: "Quartet");

            migrationBuilder.DropTable(
                name: "Trios");

            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Violists");

            migrationBuilder.DropTable(
                name: "Cellists");

            migrationBuilder.DropTable(
                name: "Pianists");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Violinists");

            migrationBuilder.DropTable(
                name: "Performers");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Levels");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Programs",
                table: "Programs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pieces",
                table: "Pieces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Composers",
                table: "Composers");

            migrationBuilder.RenameTable(
                name: "Programs",
                newName: "MusicProgram");

            migrationBuilder.RenameTable(
                name: "Pieces",
                newName: "Piece");

            migrationBuilder.RenameTable(
                name: "Composers",
                newName: "Composer");

            migrationBuilder.RenameIndex(
                name: "IX_Pieces_C_name",
                table: "Piece",
                newName: "IX_Piece_C_name");

            migrationBuilder.AlterColumn<string>(
                name: "C_name",
                table: "Piece",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MusicProgram",
                table: "MusicProgram",
                column: "PID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Piece",
                table: "Piece",
                column: "PName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Composer",
                table: "Composer",
                column: "CName");

            migrationBuilder.AddForeignKey(
                name: "FK_Performances_MusicProgram_MusicProgramPID",
                table: "Performances",
                column: "MusicProgramPID",
                principalTable: "MusicProgram",
                principalColumn: "PID",
                onDelete: ReferentialAction.Restrict);

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
    }
}
