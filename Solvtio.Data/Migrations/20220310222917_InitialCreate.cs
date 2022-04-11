using Microsoft.EntityFrameworkCore.Migrations;

namespace Solvtio.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "LightsOutSetting",
            //    columns: table => new
            //    {
            //        SettingName = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        SettingValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_LightsOutSetting", x => x.SettingName);
            //    });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(name: "LightsOutSetting");
        }
    }
}
