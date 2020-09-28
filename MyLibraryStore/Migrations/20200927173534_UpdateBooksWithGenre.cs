using Microsoft.EntityFrameworkCore.Migrations;

namespace MyLibraryStore.Migrations
{
    public partial class UpdateBooksWithGenre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Books",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Books");
        }
    }
}
