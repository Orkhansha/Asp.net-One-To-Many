using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework.Migrations
{
    public partial class CreateInstaSliderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Say",
                table: "Say");

            migrationBuilder.RenameTable(
                name: "Say",
                newName: "Says");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Says",
                table: "Says",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "InstaSliders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstaSliders", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InstaSliders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Says",
                table: "Says");

            migrationBuilder.RenameTable(
                name: "Says",
                newName: "Say");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Say",
                table: "Say",
                column: "Id");
        }
    }
}
