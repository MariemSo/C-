using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductsAndCategories.Migrations
{
    public partial class secondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Associations_Categories_CategoryId1",
                table: "Associations");

            migrationBuilder.DropForeignKey(
                name: "FK_Associations_Products_ProductId1",
                table: "Associations");

            migrationBuilder.DropIndex(
                name: "IX_Associations_CategoryId1",
                table: "Associations");

            migrationBuilder.DropIndex(
                name: "IX_Associations_ProductId1",
                table: "Associations");

            migrationBuilder.DropColumn(
                name: "CategoryId1",
                table: "Associations");

            migrationBuilder.DropColumn(
                name: "ProductId1",
                table: "Associations");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Associations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Associations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Associations_CategoryId",
                table: "Associations",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Associations_ProductId",
                table: "Associations",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Associations_Categories_CategoryId",
                table: "Associations",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Associations_Products_ProductId",
                table: "Associations",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Associations_Categories_CategoryId",
                table: "Associations");

            migrationBuilder.DropForeignKey(
                name: "FK_Associations_Products_ProductId",
                table: "Associations");

            migrationBuilder.DropIndex(
                name: "IX_Associations_CategoryId",
                table: "Associations");

            migrationBuilder.DropIndex(
                name: "IX_Associations_ProductId",
                table: "Associations");

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "Associations",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryId",
                table: "Associations",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId1",
                table: "Associations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId1",
                table: "Associations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Associations_CategoryId1",
                table: "Associations",
                column: "CategoryId1");

            migrationBuilder.CreateIndex(
                name: "IX_Associations_ProductId1",
                table: "Associations",
                column: "ProductId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Associations_Categories_CategoryId1",
                table: "Associations",
                column: "CategoryId1",
                principalTable: "Categories",
                principalColumn: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Associations_Products_ProductId1",
                table: "Associations",
                column: "ProductId1",
                principalTable: "Products",
                principalColumn: "ProductId");
        }
    }
}
