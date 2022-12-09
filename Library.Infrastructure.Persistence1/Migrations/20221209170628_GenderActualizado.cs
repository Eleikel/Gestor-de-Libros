using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Infrastructure.Persistence.Migrations
{
    public partial class GenderActualizado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Books_GenderId",
                table: "Books");

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenderId",
                table: "Books",
                column: "GenderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Books_GenderId",
                table: "Books");

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenderId",
                table: "Books",
                column: "GenderId",
                unique: true);
        }
    }
}
