using Microsoft.EntityFrameworkCore.Migrations;

namespace RetailerWebApplication.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Retailer",
                columns: table => new
                {
                    RetailerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RetailerFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RetailerLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RetailerShopAddres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Retailer", x => x.RetailerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Retailer");
        }
    }
}
