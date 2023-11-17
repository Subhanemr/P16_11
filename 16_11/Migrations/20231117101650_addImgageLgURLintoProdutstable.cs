using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _16_11.Migrations
{
    /// <inheritdoc />
    public partial class addImgageLgURLintoProdutstable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgageLgURL",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgageLgURL",
                table: "Products");
        }
    }
}
