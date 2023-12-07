using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Musicians",
                columns: table => new
                {
                    MusicianId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MusicianName = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    Website = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musicians", x => x.MusicianId);
                });

            migrationBuilder.CreateTable(
                name: "Discographys",
                columns: table => new
                {
                    DiscographyId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RecordName = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    ReleaseDate = table.Column<int>(type: "INTEGER", nullable: false),
                    MusicianId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discographys", x => x.DiscographyId);
                    table.ForeignKey(
                        name: "FK_Discographys_Musicians_MusicianId",
                        column: x => x.MusicianId,
                        principalTable: "Musicians",
                        principalColumn: "MusicianId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Instruments",
                columns: table => new
                {
                    InstrumentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InstrumentName = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    MusicianId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instruments", x => x.InstrumentId);
                    table.ForeignKey(
                        name: "FK_Instruments_Musicians_MusicianId",
                        column: x => x.MusicianId,
                        principalTable: "Musicians",
                        principalColumn: "MusicianId");
                });

            migrationBuilder.CreateTable(
                name: "MusicianInstruments",
                columns: table => new
                {
                    MusicianInstrumentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MusicianId = table.Column<int>(type: "INTEGER", nullable: false),
                    InstrumentId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicianInstruments", x => x.MusicianInstrumentId);
                    table.ForeignKey(
                        name: "FK_MusicianInstruments_Instruments_InstrumentId",
                        column: x => x.InstrumentId,
                        principalTable: "Instruments",
                        principalColumn: "InstrumentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MusicianInstruments_Musicians_MusicianId",
                        column: x => x.MusicianId,
                        principalTable: "Musicians",
                        principalColumn: "MusicianId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Discographys_MusicianId",
                table: "Discographys",
                column: "MusicianId");

            migrationBuilder.CreateIndex(
                name: "IX_Instruments_MusicianId",
                table: "Instruments",
                column: "MusicianId");

            migrationBuilder.CreateIndex(
                name: "IX_MusicianInstruments_InstrumentId",
                table: "MusicianInstruments",
                column: "InstrumentId");

            migrationBuilder.CreateIndex(
                name: "IX_MusicianInstruments_MusicianId",
                table: "MusicianInstruments",
                column: "MusicianId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Discographys");

            migrationBuilder.DropTable(
                name: "MusicianInstruments");

            migrationBuilder.DropTable(
                name: "Instruments");

            migrationBuilder.DropTable(
                name: "Musicians");
        }
    }
}
