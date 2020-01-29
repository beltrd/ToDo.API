using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDo.API.Migrations
{
    public partial class init_ConnectContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GroupConnect",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GroupName = table.Column<string>(nullable: true),
                    Connection = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupConnect", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "GroupConnect",
                columns: new[] { "Id", "Connection", "GroupName" },
                values: new object[] { 1, "server=localhost;port=3306;database=diegoDB1;user=diego_web;password=xQvy1Jc502rFbldI7ZoivIWk;", "diego1" });

            migrationBuilder.InsertData(
                table: "GroupConnect",
                columns: new[] { "Id", "Connection", "GroupName" },
                values: new object[] { 2, "server=localhost;port=3306;database=diegoDB2;user=diego_web;password=xQvy1Jc502rFbldI7ZoivIWk;", "diego2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupConnect");
        }
    }
}
