using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductCatalog.Migrations;

/// <inheritdoc />
public partial class Mappings : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_Products_Categories_CategoryId",
            table: "Products");

        migrationBuilder.DropPrimaryKey(
            name: "PK_Products",
            table: "Products");

        migrationBuilder.DropPrimaryKey(
            name: "PK_Categories",
            table: "Categories");

        migrationBuilder.RenameTable(
            name: "Products",
            newName: "Product");

        migrationBuilder.RenameTable(
            name: "Categories",
            newName: "Category");

        migrationBuilder.RenameIndex(
            name: "IX_Products_CategoryId",
            table: "Product",
            newName: "IX_Product_CategoryId");

        migrationBuilder.AlterColumn<string>(
            name: "Title",
            table: "Product",
            type: "varchar(120)",
            maxLength: 120,
            nullable: false,
            oldClrType: typeof(string),
            oldType: "nvarchar(max)");

        migrationBuilder.AlterColumn<decimal>(
            name: "Price",
            table: "Product",
            type: "money",
            nullable: false,
            oldClrType: typeof(decimal),
            oldType: "decimal(18,2)");

        migrationBuilder.AlterColumn<string>(
            name: "Image",
            table: "Product",
            type: "varchar(1024)",
            maxLength: 1024,
            nullable: false,
            oldClrType: typeof(string),
            oldType: "nvarchar(max)");

        migrationBuilder.AlterColumn<string>(
            name: "Description",
            table: "Product",
            type: "varchar(1024)",
            maxLength: 1024,
            nullable: false,
            oldClrType: typeof(string),
            oldType: "nvarchar(max)");

        migrationBuilder.AlterColumn<string>(
            name: "Title",
            table: "Category",
            type: "varchar(120)",
            maxLength: 120,
            nullable: false,
            oldClrType: typeof(string),
            oldType: "nvarchar(max)");

        migrationBuilder.AddPrimaryKey(
            name: "PK_Product",
            table: "Product",
            column: "Id");

        migrationBuilder.AddPrimaryKey(
            name: "PK_Category",
            table: "Category",
            column: "Id");

        migrationBuilder.AddForeignKey(
            name: "FK_Product_Category_CategoryId",
            table: "Product",
            column: "CategoryId",
            principalTable: "Category",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_Product_Category_CategoryId",
            table: "Product");

        migrationBuilder.DropPrimaryKey(
            name: "PK_Product",
            table: "Product");

        migrationBuilder.DropPrimaryKey(
            name: "PK_Category",
            table: "Category");

        migrationBuilder.RenameTable(
            name: "Product",
            newName: "Products");

        migrationBuilder.RenameTable(
            name: "Category",
            newName: "Categories");

        migrationBuilder.RenameIndex(
            name: "IX_Product_CategoryId",
            table: "Products",
            newName: "IX_Products_CategoryId");

        migrationBuilder.AlterColumn<string>(
            name: "Title",
            table: "Products",
            type: "nvarchar(max)",
            nullable: false,
            oldClrType: typeof(string),
            oldType: "varchar(120)",
            oldMaxLength: 120);

        migrationBuilder.AlterColumn<decimal>(
            name: "Price",
            table: "Products",
            type: "decimal(18,2)",
            nullable: false,
            oldClrType: typeof(decimal),
            oldType: "money");

        migrationBuilder.AlterColumn<string>(
            name: "Image",
            table: "Products",
            type: "nvarchar(max)",
            nullable: false,
            oldClrType: typeof(string),
            oldType: "varchar(1024)",
            oldMaxLength: 1024);

        migrationBuilder.AlterColumn<string>(
            name: "Description",
            table: "Products",
            type: "nvarchar(max)",
            nullable: false,
            oldClrType: typeof(string),
            oldType: "varchar(1024)",
            oldMaxLength: 1024);

        migrationBuilder.AlterColumn<string>(
            name: "Title",
            table: "Categories",
            type: "nvarchar(max)",
            nullable: false,
            oldClrType: typeof(string),
            oldType: "varchar(120)",
            oldMaxLength: 120);

        migrationBuilder.AddPrimaryKey(
            name: "PK_Products",
            table: "Products",
            column: "Id");

        migrationBuilder.AddPrimaryKey(
            name: "PK_Categories",
            table: "Categories",
            column: "Id");

        migrationBuilder.AddForeignKey(
            name: "FK_Products_Categories_CategoryId",
            table: "Products",
            column: "CategoryId",
            principalTable: "Categories",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    }
}
