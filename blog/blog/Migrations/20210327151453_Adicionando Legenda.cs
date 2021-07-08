using Microsoft.EntityFrameworkCore.Migrations;

namespace blog.Migrations
{
    public partial class AdicionandoLegenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Legend",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Legend",
                table: "Posts");
        }
    }
}
