using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IDbContextImplementation.Migrations
{
    /// <inheritdoc />
    public partial class PrimaryKeyAddedToEntitiesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Entities",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Entities",
                table: "Entities",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Entities",
                table: "Entities");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Entities");
        }
    }
}
