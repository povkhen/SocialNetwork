using Microsoft.EntityFrameworkCore.Migrations;

namespace Messager.Migrations
{
    public partial class Add_Nickname_to_Conversation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NickName",
                table: "Conversations",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NickName",
                table: "Conversations");
        }
    }
}
