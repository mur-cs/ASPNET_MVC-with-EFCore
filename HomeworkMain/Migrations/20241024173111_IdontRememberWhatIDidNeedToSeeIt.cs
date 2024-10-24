using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeworkMain.Migrations
{
    /// <inheritdoc />
    public partial class IdontRememberWhatIDidNeedToSeeIt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_reviews_books_BookId",
                table: "reviews");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "reviews",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_reviews_books_BookId",
                table: "reviews",
                column: "BookId",
                principalTable: "books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_reviews_books_BookId",
                table: "reviews");

            migrationBuilder.AlterColumn<int>(
                name: "BookId",
                table: "reviews",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_reviews_books_BookId",
                table: "reviews",
                column: "BookId",
                principalTable: "books",
                principalColumn: "Id");
        }
    }
}
