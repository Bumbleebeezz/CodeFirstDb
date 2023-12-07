using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstDb.Migrations
{
    /// <inheritdoc />
    public partial class _13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Author_AuthorID",
                table: "Blogs");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_AuthorID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "AuthorID",
                table: "Blogs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorID",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    AuthorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.AuthorID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_AuthorID",
                table: "Blogs",
                column: "AuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Author_AuthorID",
                table: "Blogs",
                column: "AuthorID",
                principalTable: "Author",
                principalColumn: "AuthorID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
