using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicMakerProgram.Migrations
{
    public partial class last : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CanViews_Guests_GUsername",
                table: "CanViews");

            migrationBuilder.DropForeignKey(
                name: "FK_Cellists_Performers_Name",
                table: "Cellists");

            migrationBuilder.DropForeignKey(
                name: "FK_ComposerCanEdits_Admins_AdminUserName",
                table: "ComposerCanEdits");

            migrationBuilder.DropForeignKey(
                name: "FK_ComposerCanEdits_Composers_CName",
                table: "ComposerCanEdits");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupCanEdits_Admins_AdminUserName",
                table: "GroupCanEdits");

            migrationBuilder.DropForeignKey(
                name: "FK_KnowsS_Performers_PerformerName",
                table: "KnowsS");

            migrationBuilder.DropForeignKey(
                name: "FK_KnowsS_Pieces_PieceName",
                table: "KnowsS");

            migrationBuilder.DropForeignKey(
                name: "FK_ManagesS_Admins_AdminUserName",
                table: "ManagesS");

            migrationBuilder.DropForeignKey(
                name: "FK_Performances_Pieces_Piece_name",
                table: "Performances");

            migrationBuilder.DropForeignKey(
                name: "FK_Pianists_Performers_Name",
                table: "Pianists");

            migrationBuilder.DropForeignKey(
                name: "FK_Pieces_Composers_C_name",
                table: "Pieces");

            migrationBuilder.DropForeignKey(
                name: "FK_Quartet_Cellists_CellistObjName",
                table: "Quartet");

            migrationBuilder.DropForeignKey(
                name: "FK_Quartet_Violinists_FViolinistName",
                table: "Quartet");

            migrationBuilder.DropForeignKey(
                name: "FK_Quartet_Violinists_SViolinistName",
                table: "Quartet");

            migrationBuilder.DropForeignKey(
                name: "FK_Quartet_Violists_ViolistObjName",
                table: "Quartet");

            migrationBuilder.DropForeignKey(
                name: "FK_Trios_Cellists_CellistObjName",
                table: "Trios");

            migrationBuilder.DropForeignKey(
                name: "FK_Trios_Pianists_PianistObjName",
                table: "Trios");

            migrationBuilder.DropForeignKey(
                name: "FK_Trios_Violinists_ViolinistObjName",
                table: "Trios");

            migrationBuilder.DropForeignKey(
                name: "FK_Violinists_Performers_Name",
                table: "Violinists");

            migrationBuilder.DropForeignKey(
                name: "FK_Violists_Performers_Name",
                table: "Violists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Violists",
                table: "Violists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Violinists",
                table: "Violinists");

            migrationBuilder.DropIndex(
                name: "IX_Trios_CellistObjName",
                table: "Trios");

            migrationBuilder.DropIndex(
                name: "IX_Trios_PianistObjName",
                table: "Trios");

            migrationBuilder.DropIndex(
                name: "IX_Trios_ViolinistObjName",
                table: "Trios");

            migrationBuilder.DropIndex(
                name: "IX_Quartet_CellistObjName",
                table: "Quartet");

            migrationBuilder.DropIndex(
                name: "IX_Quartet_FViolinistName",
                table: "Quartet");

            migrationBuilder.DropIndex(
                name: "IX_Quartet_SViolinistName",
                table: "Quartet");

            migrationBuilder.DropIndex(
                name: "IX_Quartet_ViolistObjName",
                table: "Quartet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pieces",
                table: "Pieces");

            migrationBuilder.DropIndex(
                name: "IX_Pieces_C_name",
                table: "Pieces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pianists",
                table: "Pianists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Performers",
                table: "Performers");

            migrationBuilder.DropIndex(
                name: "IX_Performances_Piece_name",
                table: "Performances");

            migrationBuilder.DropIndex(
                name: "IX_ManagesS_AdminUserName",
                table: "ManagesS");

            migrationBuilder.DropIndex(
                name: "IX_KnowsS_PerformerName",
                table: "KnowsS");

            migrationBuilder.DropIndex(
                name: "IX_KnowsS_PieceName",
                table: "KnowsS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Guests",
                table: "Guests");

            migrationBuilder.DropIndex(
                name: "IX_GroupCanEdits_AdminUserName",
                table: "GroupCanEdits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Composers",
                table: "Composers");

            migrationBuilder.DropIndex(
                name: "IX_ComposerCanEdits_AdminUserName",
                table: "ComposerCanEdits");

            migrationBuilder.DropIndex(
                name: "IX_ComposerCanEdits_CName",
                table: "ComposerCanEdits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cellists",
                table: "Cellists");

            migrationBuilder.DropIndex(
                name: "IX_CanViews_GUsername",
                table: "CanViews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Admins",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "CellistObjName",
                table: "Trios");

            migrationBuilder.DropColumn(
                name: "PianistObjName",
                table: "Trios");

            migrationBuilder.DropColumn(
                name: "ViolinistObjName",
                table: "Trios");

            migrationBuilder.DropColumn(
                name: "CellistObjName",
                table: "Quartet");

            migrationBuilder.DropColumn(
                name: "FViolinistName",
                table: "Quartet");

            migrationBuilder.DropColumn(
                name: "SViolinistName",
                table: "Quartet");

            migrationBuilder.DropColumn(
                name: "ViolistObjName",
                table: "Quartet");

            migrationBuilder.DropColumn(
                name: "C_name",
                table: "Pieces");

            migrationBuilder.DropColumn(
                name: "Piece_name",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "AdminUserName",
                table: "ManagesS");

            migrationBuilder.DropColumn(
                name: "PerformerName",
                table: "KnowsS");

            migrationBuilder.DropColumn(
                name: "PieceName",
                table: "KnowsS");

            migrationBuilder.DropColumn(
                name: "AdminUserName",
                table: "GroupCanEdits");

            migrationBuilder.DropColumn(
                name: "AdminUserName",
                table: "ComposerCanEdits");

            migrationBuilder.DropColumn(
                name: "CName",
                table: "ComposerCanEdits");

            migrationBuilder.DropColumn(
                name: "GUsername",
                table: "CanViews");

            migrationBuilder.RenameColumn(
                name: "cvID",
                table: "CanViews",
                newName: "CvID");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Violists",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "PerformerID",
                table: "Violists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Violinists",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "PerformerID",
                table: "Violinists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Violinist",
                table: "Trios",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Pianist",
                table: "Trios",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Cellist",
                table: "Trios",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CellistObjPerformerID",
                table: "Trios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PianistObjPerformerID",
                table: "Trios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ViolinistObjPerformerID",
                table: "Trios",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Violist",
                table: "Quartet",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SecondViolin",
                table: "Quartet",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FirstViolin",
                table: "Quartet",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Cellist",
                table: "Quartet",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CellistObjPerformerID",
                table: "Quartet",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FViolinistPerformerID",
                table: "Quartet",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SViolinistPerformerID",
                table: "Quartet",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ViolistObjPerformerID",
                table: "Quartet",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                table: "Pieces",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "PieceID",
                table: "Pieces",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CID",
                table: "Pieces",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Pianists",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "PerformerID",
                table: "Pianists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Performers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "PerformerID",
                table: "Performers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "PieceID",
                table: "Performances",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AdminID",
                table: "ManagesS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PerformerID",
                table: "KnowsS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PieceID",
                table: "KnowsS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Guests",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "GuestID",
                table: "Guests",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AdminID",
                table: "GroupCanEdits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "CName",
                table: "Composers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "CID",
                table: "Composers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AdminID",
                table: "ComposerCanEdits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CID",
                table: "ComposerCanEdits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cellists",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "PerformerID",
                table: "Cellists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GuestID",
                table: "CanViews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "AdminID",
                table: "Admins",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Violists",
                table: "Violists",
                column: "PerformerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Violinists",
                table: "Violinists",
                column: "PerformerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pieces",
                table: "Pieces",
                column: "PieceID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pianists",
                table: "Pianists",
                column: "PerformerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Performers",
                table: "Performers",
                column: "PerformerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Guests",
                table: "Guests",
                column: "GuestID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Composers",
                table: "Composers",
                column: "CID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cellists",
                table: "Cellists",
                column: "PerformerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admins",
                table: "Admins",
                column: "AdminID");

            migrationBuilder.CreateIndex(
                name: "IX_Trios_CellistObjPerformerID",
                table: "Trios",
                column: "CellistObjPerformerID");

            migrationBuilder.CreateIndex(
                name: "IX_Trios_PianistObjPerformerID",
                table: "Trios",
                column: "PianistObjPerformerID");

            migrationBuilder.CreateIndex(
                name: "IX_Trios_ViolinistObjPerformerID",
                table: "Trios",
                column: "ViolinistObjPerformerID");

            migrationBuilder.CreateIndex(
                name: "IX_Quartet_CellistObjPerformerID",
                table: "Quartet",
                column: "CellistObjPerformerID");

            migrationBuilder.CreateIndex(
                name: "IX_Quartet_FViolinistPerformerID",
                table: "Quartet",
                column: "FViolinistPerformerID");

            migrationBuilder.CreateIndex(
                name: "IX_Quartet_SViolinistPerformerID",
                table: "Quartet",
                column: "SViolinistPerformerID");

            migrationBuilder.CreateIndex(
                name: "IX_Quartet_ViolistObjPerformerID",
                table: "Quartet",
                column: "ViolistObjPerformerID");

            migrationBuilder.CreateIndex(
                name: "IX_Pieces_CID",
                table: "Pieces",
                column: "CID");

            migrationBuilder.CreateIndex(
                name: "IX_Performances_PieceID",
                table: "Performances",
                column: "PieceID");

            migrationBuilder.CreateIndex(
                name: "IX_ManagesS_AdminID",
                table: "ManagesS",
                column: "AdminID");

            migrationBuilder.CreateIndex(
                name: "IX_KnowsS_PerformerID",
                table: "KnowsS",
                column: "PerformerID");

            migrationBuilder.CreateIndex(
                name: "IX_KnowsS_PieceID",
                table: "KnowsS",
                column: "PieceID");

            migrationBuilder.CreateIndex(
                name: "IX_GroupCanEdits_AdminID",
                table: "GroupCanEdits",
                column: "AdminID");

            migrationBuilder.CreateIndex(
                name: "IX_ComposerCanEdits_AdminID",
                table: "ComposerCanEdits",
                column: "AdminID");

            migrationBuilder.CreateIndex(
                name: "IX_ComposerCanEdits_CID",
                table: "ComposerCanEdits",
                column: "CID");

            migrationBuilder.CreateIndex(
                name: "IX_CanViews_GuestID",
                table: "CanViews",
                column: "GuestID");

            migrationBuilder.AddForeignKey(
                name: "FK_CanViews_Guests_GuestID",
                table: "CanViews",
                column: "GuestID",
                principalTable: "Guests",
                principalColumn: "GuestID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cellists_Performers_PerformerID",
                table: "Cellists",
                column: "PerformerID",
                principalTable: "Performers",
                principalColumn: "PerformerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ComposerCanEdits_Admins_AdminID",
                table: "ComposerCanEdits",
                column: "AdminID",
                principalTable: "Admins",
                principalColumn: "AdminID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ComposerCanEdits_Composers_CID",
                table: "ComposerCanEdits",
                column: "CID",
                principalTable: "Composers",
                principalColumn: "CID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupCanEdits_Admins_AdminID",
                table: "GroupCanEdits",
                column: "AdminID",
                principalTable: "Admins",
                principalColumn: "AdminID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KnowsS_Performers_PerformerID",
                table: "KnowsS",
                column: "PerformerID",
                principalTable: "Performers",
                principalColumn: "PerformerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KnowsS_Pieces_PieceID",
                table: "KnowsS",
                column: "PieceID",
                principalTable: "Pieces",
                principalColumn: "PieceID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ManagesS_Admins_AdminID",
                table: "ManagesS",
                column: "AdminID",
                principalTable: "Admins",
                principalColumn: "AdminID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Performances_Pieces_PieceID",
                table: "Performances",
                column: "PieceID",
                principalTable: "Pieces",
                principalColumn: "PieceID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pianists_Performers_PerformerID",
                table: "Pianists",
                column: "PerformerID",
                principalTable: "Performers",
                principalColumn: "PerformerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pieces_Composers_CID",
                table: "Pieces",
                column: "CID",
                principalTable: "Composers",
                principalColumn: "CID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Quartet_Cellists_CellistObjPerformerID",
                table: "Quartet",
                column: "CellistObjPerformerID",
                principalTable: "Cellists",
                principalColumn: "PerformerID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Quartet_Violinists_FViolinistPerformerID",
                table: "Quartet",
                column: "FViolinistPerformerID",
                principalTable: "Violinists",
                principalColumn: "PerformerID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Quartet_Violinists_SViolinistPerformerID",
                table: "Quartet",
                column: "SViolinistPerformerID",
                principalTable: "Violinists",
                principalColumn: "PerformerID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Quartet_Violists_ViolistObjPerformerID",
                table: "Quartet",
                column: "ViolistObjPerformerID",
                principalTable: "Violists",
                principalColumn: "PerformerID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trios_Cellists_CellistObjPerformerID",
                table: "Trios",
                column: "CellistObjPerformerID",
                principalTable: "Cellists",
                principalColumn: "PerformerID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trios_Pianists_PianistObjPerformerID",
                table: "Trios",
                column: "PianistObjPerformerID",
                principalTable: "Pianists",
                principalColumn: "PerformerID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trios_Violinists_ViolinistObjPerformerID",
                table: "Trios",
                column: "ViolinistObjPerformerID",
                principalTable: "Violinists",
                principalColumn: "PerformerID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Violinists_Performers_PerformerID",
                table: "Violinists",
                column: "PerformerID",
                principalTable: "Performers",
                principalColumn: "PerformerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Violists_Performers_PerformerID",
                table: "Violists",
                column: "PerformerID",
                principalTable: "Performers",
                principalColumn: "PerformerID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CanViews_Guests_GuestID",
                table: "CanViews");

            migrationBuilder.DropForeignKey(
                name: "FK_Cellists_Performers_PerformerID",
                table: "Cellists");

            migrationBuilder.DropForeignKey(
                name: "FK_ComposerCanEdits_Admins_AdminID",
                table: "ComposerCanEdits");

            migrationBuilder.DropForeignKey(
                name: "FK_ComposerCanEdits_Composers_CID",
                table: "ComposerCanEdits");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupCanEdits_Admins_AdminID",
                table: "GroupCanEdits");

            migrationBuilder.DropForeignKey(
                name: "FK_KnowsS_Performers_PerformerID",
                table: "KnowsS");

            migrationBuilder.DropForeignKey(
                name: "FK_KnowsS_Pieces_PieceID",
                table: "KnowsS");

            migrationBuilder.DropForeignKey(
                name: "FK_ManagesS_Admins_AdminID",
                table: "ManagesS");

            migrationBuilder.DropForeignKey(
                name: "FK_Performances_Pieces_PieceID",
                table: "Performances");

            migrationBuilder.DropForeignKey(
                name: "FK_Pianists_Performers_PerformerID",
                table: "Pianists");

            migrationBuilder.DropForeignKey(
                name: "FK_Pieces_Composers_CID",
                table: "Pieces");

            migrationBuilder.DropForeignKey(
                name: "FK_Quartet_Cellists_CellistObjPerformerID",
                table: "Quartet");

            migrationBuilder.DropForeignKey(
                name: "FK_Quartet_Violinists_FViolinistPerformerID",
                table: "Quartet");

            migrationBuilder.DropForeignKey(
                name: "FK_Quartet_Violinists_SViolinistPerformerID",
                table: "Quartet");

            migrationBuilder.DropForeignKey(
                name: "FK_Quartet_Violists_ViolistObjPerformerID",
                table: "Quartet");

            migrationBuilder.DropForeignKey(
                name: "FK_Trios_Cellists_CellistObjPerformerID",
                table: "Trios");

            migrationBuilder.DropForeignKey(
                name: "FK_Trios_Pianists_PianistObjPerformerID",
                table: "Trios");

            migrationBuilder.DropForeignKey(
                name: "FK_Trios_Violinists_ViolinistObjPerformerID",
                table: "Trios");

            migrationBuilder.DropForeignKey(
                name: "FK_Violinists_Performers_PerformerID",
                table: "Violinists");

            migrationBuilder.DropForeignKey(
                name: "FK_Violists_Performers_PerformerID",
                table: "Violists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Violists",
                table: "Violists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Violinists",
                table: "Violinists");

            migrationBuilder.DropIndex(
                name: "IX_Trios_CellistObjPerformerID",
                table: "Trios");

            migrationBuilder.DropIndex(
                name: "IX_Trios_PianistObjPerformerID",
                table: "Trios");

            migrationBuilder.DropIndex(
                name: "IX_Trios_ViolinistObjPerformerID",
                table: "Trios");

            migrationBuilder.DropIndex(
                name: "IX_Quartet_CellistObjPerformerID",
                table: "Quartet");

            migrationBuilder.DropIndex(
                name: "IX_Quartet_FViolinistPerformerID",
                table: "Quartet");

            migrationBuilder.DropIndex(
                name: "IX_Quartet_SViolinistPerformerID",
                table: "Quartet");

            migrationBuilder.DropIndex(
                name: "IX_Quartet_ViolistObjPerformerID",
                table: "Quartet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pieces",
                table: "Pieces");

            migrationBuilder.DropIndex(
                name: "IX_Pieces_CID",
                table: "Pieces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pianists",
                table: "Pianists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Performers",
                table: "Performers");

            migrationBuilder.DropIndex(
                name: "IX_Performances_PieceID",
                table: "Performances");

            migrationBuilder.DropIndex(
                name: "IX_ManagesS_AdminID",
                table: "ManagesS");

            migrationBuilder.DropIndex(
                name: "IX_KnowsS_PerformerID",
                table: "KnowsS");

            migrationBuilder.DropIndex(
                name: "IX_KnowsS_PieceID",
                table: "KnowsS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Guests",
                table: "Guests");

            migrationBuilder.DropIndex(
                name: "IX_GroupCanEdits_AdminID",
                table: "GroupCanEdits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Composers",
                table: "Composers");

            migrationBuilder.DropIndex(
                name: "IX_ComposerCanEdits_AdminID",
                table: "ComposerCanEdits");

            migrationBuilder.DropIndex(
                name: "IX_ComposerCanEdits_CID",
                table: "ComposerCanEdits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cellists",
                table: "Cellists");

            migrationBuilder.DropIndex(
                name: "IX_CanViews_GuestID",
                table: "CanViews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Admins",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "PerformerID",
                table: "Violists");

            migrationBuilder.DropColumn(
                name: "PerformerID",
                table: "Violinists");

            migrationBuilder.DropColumn(
                name: "CellistObjPerformerID",
                table: "Trios");

            migrationBuilder.DropColumn(
                name: "PianistObjPerformerID",
                table: "Trios");

            migrationBuilder.DropColumn(
                name: "ViolinistObjPerformerID",
                table: "Trios");

            migrationBuilder.DropColumn(
                name: "CellistObjPerformerID",
                table: "Quartet");

            migrationBuilder.DropColumn(
                name: "FViolinistPerformerID",
                table: "Quartet");

            migrationBuilder.DropColumn(
                name: "SViolinistPerformerID",
                table: "Quartet");

            migrationBuilder.DropColumn(
                name: "ViolistObjPerformerID",
                table: "Quartet");

            migrationBuilder.DropColumn(
                name: "PieceID",
                table: "Pieces");

            migrationBuilder.DropColumn(
                name: "CID",
                table: "Pieces");

            migrationBuilder.DropColumn(
                name: "PerformerID",
                table: "Pianists");

            migrationBuilder.DropColumn(
                name: "PerformerID",
                table: "Performers");

            migrationBuilder.DropColumn(
                name: "PieceID",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "AdminID",
                table: "ManagesS");

            migrationBuilder.DropColumn(
                name: "PerformerID",
                table: "KnowsS");

            migrationBuilder.DropColumn(
                name: "PieceID",
                table: "KnowsS");

            migrationBuilder.DropColumn(
                name: "GuestID",
                table: "Guests");

            migrationBuilder.DropColumn(
                name: "AdminID",
                table: "GroupCanEdits");

            migrationBuilder.DropColumn(
                name: "CID",
                table: "Composers");

            migrationBuilder.DropColumn(
                name: "AdminID",
                table: "ComposerCanEdits");

            migrationBuilder.DropColumn(
                name: "CID",
                table: "ComposerCanEdits");

            migrationBuilder.DropColumn(
                name: "PerformerID",
                table: "Cellists");

            migrationBuilder.DropColumn(
                name: "GuestID",
                table: "CanViews");

            migrationBuilder.DropColumn(
                name: "AdminID",
                table: "Admins");

            migrationBuilder.RenameColumn(
                name: "CvID",
                table: "CanViews",
                newName: "cvID");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Violists",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Violinists",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Violinist",
                table: "Trios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Pianist",
                table: "Trios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Cellist",
                table: "Trios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "CellistObjName",
                table: "Trios",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PianistObjName",
                table: "Trios",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ViolinistObjName",
                table: "Trios",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Violist",
                table: "Quartet",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "SecondViolin",
                table: "Quartet",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "FirstViolin",
                table: "Quartet",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Cellist",
                table: "Quartet",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "CellistObjName",
                table: "Quartet",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FViolinistName",
                table: "Quartet",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SViolinistName",
                table: "Quartet",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ViolistObjName",
                table: "Quartet",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PName",
                table: "Pieces",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "C_name",
                table: "Pieces",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Pianists",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Performers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Piece_name",
                table: "Performances",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdminUserName",
                table: "ManagesS",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PerformerName",
                table: "KnowsS",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PieceName",
                table: "KnowsS",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Guests",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "AdminUserName",
                table: "GroupCanEdits",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CName",
                table: "Composers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdminUserName",
                table: "ComposerCanEdits",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CName",
                table: "ComposerCanEdits",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cellists",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GUsername",
                table: "CanViews",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Admins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Violists",
                table: "Violists",
                column: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Violinists",
                table: "Violinists",
                column: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pieces",
                table: "Pieces",
                column: "PName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pianists",
                table: "Pianists",
                column: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Performers",
                table: "Performers",
                column: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Guests",
                table: "Guests",
                column: "Username");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Composers",
                table: "Composers",
                column: "CName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cellists",
                table: "Cellists",
                column: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admins",
                table: "Admins",
                column: "Username");

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
                name: "IX_Pieces_C_name",
                table: "Pieces",
                column: "C_name");

            migrationBuilder.CreateIndex(
                name: "IX_Performances_Piece_name",
                table: "Performances",
                column: "Piece_name");

            migrationBuilder.CreateIndex(
                name: "IX_ManagesS_AdminUserName",
                table: "ManagesS",
                column: "AdminUserName");

            migrationBuilder.CreateIndex(
                name: "IX_KnowsS_PerformerName",
                table: "KnowsS",
                column: "PerformerName");

            migrationBuilder.CreateIndex(
                name: "IX_KnowsS_PieceName",
                table: "KnowsS",
                column: "PieceName");

            migrationBuilder.CreateIndex(
                name: "IX_GroupCanEdits_AdminUserName",
                table: "GroupCanEdits",
                column: "AdminUserName");

            migrationBuilder.CreateIndex(
                name: "IX_ComposerCanEdits_AdminUserName",
                table: "ComposerCanEdits",
                column: "AdminUserName");

            migrationBuilder.CreateIndex(
                name: "IX_ComposerCanEdits_CName",
                table: "ComposerCanEdits",
                column: "CName");

            migrationBuilder.CreateIndex(
                name: "IX_CanViews_GUsername",
                table: "CanViews",
                column: "GUsername");

            migrationBuilder.AddForeignKey(
                name: "FK_CanViews_Guests_GUsername",
                table: "CanViews",
                column: "GUsername",
                principalTable: "Guests",
                principalColumn: "Username",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cellists_Performers_Name",
                table: "Cellists",
                column: "Name",
                principalTable: "Performers",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ComposerCanEdits_Admins_AdminUserName",
                table: "ComposerCanEdits",
                column: "AdminUserName",
                principalTable: "Admins",
                principalColumn: "Username",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ComposerCanEdits_Composers_CName",
                table: "ComposerCanEdits",
                column: "CName",
                principalTable: "Composers",
                principalColumn: "CName",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupCanEdits_Admins_AdminUserName",
                table: "GroupCanEdits",
                column: "AdminUserName",
                principalTable: "Admins",
                principalColumn: "Username",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KnowsS_Performers_PerformerName",
                table: "KnowsS",
                column: "PerformerName",
                principalTable: "Performers",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KnowsS_Pieces_PieceName",
                table: "KnowsS",
                column: "PieceName",
                principalTable: "Pieces",
                principalColumn: "PName",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ManagesS_Admins_AdminUserName",
                table: "ManagesS",
                column: "AdminUserName",
                principalTable: "Admins",
                principalColumn: "Username",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Performances_Pieces_Piece_name",
                table: "Performances",
                column: "Piece_name",
                principalTable: "Pieces",
                principalColumn: "PName",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pianists_Performers_Name",
                table: "Pianists",
                column: "Name",
                principalTable: "Performers",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pieces_Composers_C_name",
                table: "Pieces",
                column: "C_name",
                principalTable: "Composers",
                principalColumn: "CName",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Quartet_Cellists_CellistObjName",
                table: "Quartet",
                column: "CellistObjName",
                principalTable: "Cellists",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Quartet_Violinists_FViolinistName",
                table: "Quartet",
                column: "FViolinistName",
                principalTable: "Violinists",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Quartet_Violinists_SViolinistName",
                table: "Quartet",
                column: "SViolinistName",
                principalTable: "Violinists",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Quartet_Violists_ViolistObjName",
                table: "Quartet",
                column: "ViolistObjName",
                principalTable: "Violists",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trios_Cellists_CellistObjName",
                table: "Trios",
                column: "CellistObjName",
                principalTable: "Cellists",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trios_Pianists_PianistObjName",
                table: "Trios",
                column: "PianistObjName",
                principalTable: "Pianists",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trios_Violinists_ViolinistObjName",
                table: "Trios",
                column: "ViolinistObjName",
                principalTable: "Violinists",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Violinists_Performers_Name",
                table: "Violinists",
                column: "Name",
                principalTable: "Performers",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Violists_Performers_Name",
                table: "Violists",
                column: "Name",
                principalTable: "Performers",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
