using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SacramentMeetingPlanner.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hymn",
                columns: table => new
                {
                    HymnId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HymnTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HymnNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hymn", x => x.HymnId);
                });

            migrationBuilder.CreateTable(
                name: "SacramentMeeting",
                columns: table => new
                {
                    SacramentMeetingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Presiding = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Conducting = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpeningHymnHymnId = table.Column<int>(type: "int", nullable: false),
                    Invocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SacramentalHymnHymnId = table.Column<int>(type: "int", nullable: false),
                    IntermediateHymnHymnId = table.Column<int>(type: "int", nullable: false),
                    ClosingHymnHymnId = table.Column<int>(type: "int", nullable: false),
                    Benediction = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SacramentMeeting", x => x.SacramentMeetingId);
                    table.ForeignKey(
                        name: "FK_SacramentMeeting_Hymn_ClosingHymnHymnId",
                        column: x => x.ClosingHymnHymnId,
                        principalTable: "Hymn",
                        principalColumn: "HymnId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SacramentMeeting_Hymn_IntermediateHymnHymnId",
                        column: x => x.IntermediateHymnHymnId,
                        principalTable: "Hymn",
                        principalColumn: "HymnId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SacramentMeeting_Hymn_OpeningHymnHymnId",
                        column: x => x.OpeningHymnHymnId,
                        principalTable: "Hymn",
                        principalColumn: "HymnId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SacramentMeeting_Hymn_SacramentalHymnHymnId",
                        column: x => x.SacramentalHymnHymnId,
                        principalTable: "Hymn",
                        principalColumn: "HymnId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SacramentMeeting_ClosingHymnHymnId",
                table: "SacramentMeeting",
                column: "ClosingHymnHymnId");

            migrationBuilder.CreateIndex(
                name: "IX_SacramentMeeting_IntermediateHymnHymnId",
                table: "SacramentMeeting",
                column: "IntermediateHymnHymnId");

            migrationBuilder.CreateIndex(
                name: "IX_SacramentMeeting_OpeningHymnHymnId",
                table: "SacramentMeeting",
                column: "OpeningHymnHymnId");

            migrationBuilder.CreateIndex(
                name: "IX_SacramentMeeting_SacramentalHymnHymnId",
                table: "SacramentMeeting",
                column: "SacramentalHymnHymnId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SacramentMeeting");

            migrationBuilder.DropTable(
                name: "Hymn");
        }
    }
}
