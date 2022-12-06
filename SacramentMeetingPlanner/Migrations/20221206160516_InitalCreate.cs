using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SacramentMeetingPlanner.Migrations
{
    public partial class InitalCreate : Migration
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
                name: "Speaker",
                columns: table => new
                {
                    SpeakerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpeakerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Topic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SacramentMeetingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speaker", x => x.SpeakerId);
                });

            migrationBuilder.CreateTable(
                name: "SacramentMeeting",
                columns: table => new
                {
                    SacramentMeetingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Presiding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Conducting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningHymnId = table.Column<int>(type: "int", nullable: false),
                    Invocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SacramentalHymnId = table.Column<int>(type: "int", nullable: false),
                    IntermediateHymnId = table.Column<int>(type: "int", nullable: true),
                    ClosingHymnId = table.Column<int>(type: "int", nullable: true),
                    Benediction = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SacramentMeeting", x => x.SacramentMeetingId);
                    table.ForeignKey(
                        name: "FK_SacramentMeeting_Hymn_ClosingHymnId",
                        column: x => x.ClosingHymnId,
                        principalTable: "Hymn",
                        principalColumn: "HymnId");
                    table.ForeignKey(
                        name: "FK_SacramentMeeting_Hymn_IntermediateHymnId",
                        column: x => x.IntermediateHymnId,
                        principalTable: "Hymn",
                        principalColumn: "HymnId");
                    table.ForeignKey(
                        name: "FK_SacramentMeeting_Hymn_OpeningHymnId",
                        column: x => x.OpeningHymnId,
                        principalTable: "Hymn",
                        principalColumn: "HymnId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SacramentMeeting_Hymn_SacramentalHymnId",
                        column: x => x.SacramentalHymnId,
                        principalTable: "Hymn",
                        principalColumn: "HymnId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SacramentMeeting_ClosingHymnId",
                table: "SacramentMeeting",
                column: "ClosingHymnId");

            migrationBuilder.CreateIndex(
                name: "IX_SacramentMeeting_IntermediateHymnId",
                table: "SacramentMeeting",
                column: "IntermediateHymnId");

            migrationBuilder.CreateIndex(
                name: "IX_SacramentMeeting_OpeningHymnId",
                table: "SacramentMeeting",
                column: "OpeningHymnId");

            migrationBuilder.CreateIndex(
                name: "IX_SacramentMeeting_SacramentalHymnId",
                table: "SacramentMeeting",
                column: "SacramentalHymnId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SacramentMeeting");

            migrationBuilder.DropTable(
                name: "Speaker");

            migrationBuilder.DropTable(
                name: "Hymn");
        }
    }
}
