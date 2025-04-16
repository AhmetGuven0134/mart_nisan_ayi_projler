using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace urun.Migrations
{
    /// <inheritdoc />
    public partial class yeni : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kitaplistesi",
                columns: table => new
                {
                    kitapID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    kitapAd = table.Column<string>(type: "TEXT", nullable: false),
                    kitapAciklama = table.Column<string>(type: "TEXT", nullable: false),
                    kitapResim = table.Column<string>(type: "TEXT", nullable: false),
                    kitapFiyat = table.Column<double>(type: "REAL", nullable: false),
                    kitapStok = table.Column<int>(type: "INTEGER", nullable: false),
                    kategoriID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kitaplistesi", x => x.kitapID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "kitaplistesi");
        }
    }
}
