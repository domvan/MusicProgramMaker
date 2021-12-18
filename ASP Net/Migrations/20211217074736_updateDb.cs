using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicMakerProgram.Migrations
{
    public partial class updateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Composers",
                columns: table => new
                {
                    cName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    period = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Composers", x => x.cName);
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
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Pieces",
                columns: table => new
                {
                    pName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    info = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date = table.Column<int>(type: "int", nullable: false),
                    genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    musicSheetLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pieces", x => x.pName);
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
                    firstViolin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    secondViolin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    violist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cellist = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    school = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    age = table.Column<int>(type: "int", nullable: false)
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
                    violinist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cellist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pianist = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Composers");

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
                name: "Pieces");

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
        }
    }
}
