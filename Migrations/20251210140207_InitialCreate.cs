using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnet_store.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KategoriAdi = table.Column<string>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sliderlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Baslik = table.Column<string>(type: "TEXT", nullable: true),
                    Aciklama = table.Column<string>(type: "TEXT", nullable: true),
                    Resim = table.Column<string>(type: "TEXT", nullable: true),
                    Index = table.Column<int>(type: "INTEGER", nullable: false),
                    Aktif = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliderlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UrunAdi = table.Column<string>(type: "TEXT", nullable: true),
                    Fiyat = table.Column<double>(type: "REAL", nullable: false),
                    Resim = table.Column<string>(type: "TEXT", nullable: true),
                    Aciklama = table.Column<string>(type: "TEXT", nullable: true),
                    Aktif = table.Column<bool>(type: "INTEGER", nullable: false),
                    Anasayfa = table.Column<bool>(type: "INTEGER", nullable: false),
                    KategoriId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Urunler_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "Id", "KategoriAdi", "Url" },
                values: new object[,]
                {
                    { 1, "Telefon", "telefon" },
                    { 2, "Elektronik", "elektronik" },
                    { 3, "Akıllı Saat", "beyaz-esya" },
                    { 4, "Giyim", "giyim" },
                    { 5, "Kozmetik", "kozmetik" },
                    { 6, "Kategori 1", "kategori-1" },
                    { 7, "Kategori 2", "kategori-2" },
                    { 8, "Kategori 3", "kategori-3" },
                    { 9, "Kategori 4", "kategori-4" },
                    { 10, "Kategori 5", "kategori-5" }
                });

            migrationBuilder.InsertData(
                table: "Sliderlar",
                columns: new[] { "Id", "Aciklama", "Aktif", "Baslik", "Index", "Resim" },
                values: new object[,]
                {
                    { 1, "Slider 1 Açıklama", true, "Slider 1 Başlık", 0, "slider-1.jpeg" },
                    { 2, "Slider 2 Açıklama", true, "Slider 2 Başlık", 1, "slider-2.jpeg" },
                    { 3, "Slider 3 Açıklama", true, "Slider 3 Başlık", 2, "slider-3.jpeg" }
                });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "Id", "Aciklama", "Aktif", "Anasayfa", "Fiyat", "KategoriId", "Resim", "UrunAdi" },
                values: new object[,]
                {
                    { 1, "Apple Watch 7 harika bir akıllı saat.", false, true, 10000.0, 3, "1.jpeg", "Apple Watch 7" },
                    { 2, "Apple Watch 8 harika bir akıllı saat.", true, true, 20000.0, 3, "2.jpeg", "Apple Watch 8" },
                    { 3, "Apple Watch 9 harika bir akıllı saat.", true, true, 30000.0, 3, "3.jpeg", "Apple Watch 9" },
                    { 4, "Apple Watch 10 harika bir akıllı saat.", false, false, 40000.0, 2, "4.jpeg", "Apple Watch 10" },
                    { 5, "Apple Watch 11 harika bir akıllı saat.", true, true, 50000.0, 3, "5.jpeg", "Apple Watch 11" },
                    { 6, "Apple iPhone SE harika bir telefon.", true, false, 60000.0, 2, "6.jpeg", "Apple iPhone SE" },
                    { 7, "Apple iPhone 13 Pro Max harika bir telefon.", true, false, 90000.0, 1, "7.jpeg", "Apple iPhone 13 Pro Max" },
                    { 8, "Apple iPhone 13 harika bir telefon.", true, true, 70000.0, 1, "8.jpeg", "Apple iPhone 13" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_KategoriId",
                table: "Urunler",
                column: "KategoriId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sliderlar");

            migrationBuilder.DropTable(
                name: "Urunler");

            migrationBuilder.DropTable(
                name: "Kategoriler");
        }
    }
}
