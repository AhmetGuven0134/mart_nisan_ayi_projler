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
                    urunID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    urunAd = table.Column<string>(type: "TEXT", nullable: false),
                    urunAciklama = table.Column<string>(type: "TEXT", nullable: false),
                    urunResim = table.Column<string>(type: "TEXT", nullable: false),
                    urunFiyat = table.Column<double>(type: "REAL", nullable: false),
                    urunStok = table.Column<int>(type: "INTEGER", nullable: false),
                    kategoriID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_urunlistesi", x => x.urunID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "listesi");
        }
    }
}
