using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig0005 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FAQs",
                columns: table => new
                {
                    FAQ_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Text = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    SEO_Description = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: true),
                    SEO_Keywords = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAQs", x => x.FAQ_ID);
                });

            migrationBuilder.CreateTable(
                name: "PrivacyPolicies",
                columns: table => new
                {
                    PrivacyPolicy_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Text = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    SEO_Description = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: true),
                    SEO_Keywords = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivacyPolicies", x => x.PrivacyPolicy_ID);
                });

            migrationBuilder.CreateTable(
                name: "settings",
                columns: table => new
                {
                    Settings_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteTitle = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    SiteDescription = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: true),
                    Logo_Img = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    G_Analystics = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Site_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_settings", x => x.Settings_ID);
                });

            migrationBuilder.CreateTable(
                name: "socialLinks",
                columns: table => new
                {
                    SocialLinks_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Facebook = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    Twitter = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    Github = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    Instagram = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    Whatsapp = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    Telegram = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    Spotify = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_socialLinks", x => x.SocialLinks_ID);
                });

            migrationBuilder.CreateTable(
                name: "teams",
                columns: table => new
                {
                    Team_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Mission = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShortBio = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teams", x => x.Team_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FAQs");

            migrationBuilder.DropTable(
                name: "PrivacyPolicies");

            migrationBuilder.DropTable(
                name: "settings");

            migrationBuilder.DropTable(
                name: "socialLinks");

            migrationBuilder.DropTable(
                name: "teams");
        }
    }
}
