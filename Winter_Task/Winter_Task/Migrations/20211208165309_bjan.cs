using Microsoft.EntityFrameworkCore.Migrations;

namespace Winter_Task.Migrations
{
    public partial class bjan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductComments_ProductComments_ParentProductCommentId",
                table: "ProductComments");

            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "ProductCategories",
                newName: "ProductCategoryName");

            migrationBuilder.AlterColumn<int>(
                name: "ParentProductCommentId",
                table: "ProductComments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductComments_ProductComments_ParentProductCommentId",
                table: "ProductComments",
                column: "ParentProductCommentId",
                principalTable: "ProductComments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductComments_ProductComments_ParentProductCommentId",
                table: "ProductComments");

            migrationBuilder.RenameColumn(
                name: "ProductCategoryName",
                table: "ProductCategories",
                newName: "ProductName");

            migrationBuilder.AlterColumn<int>(
                name: "ParentProductCommentId",
                table: "ProductComments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductComments_ProductComments_ParentProductCommentId",
                table: "ProductComments",
                column: "ParentProductCommentId",
                principalTable: "ProductComments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
