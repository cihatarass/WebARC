using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    About_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Text = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Seo_Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Seo_Keywords = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.About_ID);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Blog_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Author = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    Seo_Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Seo_Keywords = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Blog_ID);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Contact_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Map = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Mail1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Gsm = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Gsm1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Pbx = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Contact_ID);
                });

            migrationBuilder.CreateTable(
                name: "HeadSliders",
                columns: table => new
                {
                    Slider_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SubTitle = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Text = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeadSliders", x => x.Slider_ID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Product_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SubBrand = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Text = table.Column<string>(type: "nvarchar(1200)", maxLength: 1200, nullable: true),
                    Feature = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Stock = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Seo_Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Seo_Keywords = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Product_ID);
                });

            migrationBuilder.CreateTable(
                name: "References",
                columns: table => new
                {
                    Reference_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    PersonName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Project = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_References", x => x.Reference_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "HeadSliders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "References");
        }
    }
}
