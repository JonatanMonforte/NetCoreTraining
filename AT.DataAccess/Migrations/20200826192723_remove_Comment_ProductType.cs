using Microsoft.EntityFrameworkCore.Migrations;

namespace AT.DataAccess.Migrations
{
    public partial class remove_Comment_ProductType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "ProductTypes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "ProductTypes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
