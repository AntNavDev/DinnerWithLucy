using Microsoft.EntityFrameworkCore.Migrations;

namespace DinnerWithLucy.Migrations
{
    public partial class RecipeTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Recipe",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Recipe");
        }
    }
}
