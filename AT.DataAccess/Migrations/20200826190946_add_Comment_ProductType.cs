using Microsoft.EntityFrameworkCore.Migrations;

namespace AT.DataAccess.Migrations
{
    public partial class add_Comment_ProductType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "ProductTypes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "ProductTypes");
        }
    }
}
