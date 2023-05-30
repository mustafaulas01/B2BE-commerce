using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DOGOB2B.DATAACCESS.Migrations
{
    public partial class firstmigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemDim1Code = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainProductGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BottomProductGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PicturePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "Money", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Ayakkabı" },
                    { 2, "Üst Giyim" },
                    { 3, "Aksesuar" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Barcode", "BottomProductGroup", "Gender", "ItemCode", "ItemDim1Code", "ItemName", "MainProductGroup", "PicturePath", "Price", "ProductModel", "Stock" },
                values: new object[,]
                {
                    { 1, "8680544164738", "Boots", "Women", "dgs018-box064", 39, "Women Vegan Leather Gray Ankle Boots - Lost Design", "Shoes", "https://www.dogostore.com/Data/K/D25/1473.jpg", 600m, "Boxford", 14 },
                    { 2, "8680544215942", "Flat Shoes", "Women", "dgs020-myr022", 40, "Women Vegan Leather Beige Sneakers - Call me Hotdog Design", "Shoes", "https://www.dogostore.com/Data/K/D11/7691.jpg", 650m, "Myra", 20 },
                    { 3, "8680544077700", "Boots", "Women", "dgs014-lb008", 38, "Women Vegan Leather Green Long Boots - Koala Hug Design", "Shoes", "https://www.dogostore.com/Data/K/D51/13035.jpg", 750m, "Long Boots", 45 },
                    { 4, "8680544086696", "Boots", "Women", "dgs014-lb034", 39, "Women Vegan Leather Beige Long Boots - Catch Me Baby Design", "Shoes", "https://www.dogostore.com/Data/K/D51/3181.jpg", 750m, "Long Boots", 15 },
                    { 5, "8680544077021", "Boots", "Women", "dgs014-sb017", 38, "Women Vegan Leather Beige Ankle Boots - Purple Blue And Blue Design", "Shoes", "https://www.dogostore.com/Data/K/D21/1194.jpg", 600m, "Short Boots", 23 },
                    { 6, "8680544201259", "Sandals", "Women", "dgs020-hzl025", 40, "Women Vegan Leather Blue Lace Up Sandals - Les Papillons Design", "Shoes", "https://www.dogostore.com/Data/K/D75/5043.jpg", 680m, "Hazel", 11 },
                    { 7, "8680544246588", "Flat Shoes", "Men", "dgs023-acem008", 42, "Men Vegan Leather White Sneakers - Equal Design", "Shoes", "https://www.dogostore.com/Data/K/D24/13763.jpg", 724m, "Ace Sneakers Men", 11 },
                    { 8, "8680544247905", "Flat Shoes", "Men", "dgsnk023-028", 43, "Time Waits for No-one / Dogo Sneakers Men s Shoes", "Shoes", "https://www.dogostore.com/Data/K/D24/14030.jpg", 730m, "Men Sneakers", 31 },
                    { 9, "8680544246632", "Flat Shoes", "Men", "dgs023-acem009", 42, "Men Vegan Leather White Sneakers - Meet me Halfway Design", "Shoes", "https://www.dogostore.com/Data/K/D24/13770.jpg", 724m, "Ace Sneakers Men", 43 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
