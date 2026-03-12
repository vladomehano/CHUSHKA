using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kursovProekt.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderOn",
                table: "Orders",
                newName: "OrderedOn");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderedOn",
                table: "Orders",
                newName: "OrderOn");
        }
    }
}
