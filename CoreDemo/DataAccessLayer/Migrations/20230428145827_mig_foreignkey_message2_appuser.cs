using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_foreignkey_message2_appuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message2s_Writers_ReceiverID",
                table: "Message2s");

            migrationBuilder.DropForeignKey(
                name: "FK_Message2s_Writers_SenderID",
                table: "Message2s");

            migrationBuilder.AddForeignKey(
                name: "FK_Message2s_AspNetUsers_ReceiverID",
                table: "Message2s",
                column: "ReceiverID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Message2s_AspNetUsers_SenderID",
                table: "Message2s",
                column: "SenderID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message2s_AspNetUsers_ReceiverID",
                table: "Message2s");

            migrationBuilder.DropForeignKey(
                name: "FK_Message2s_AspNetUsers_SenderID",
                table: "Message2s");

            migrationBuilder.AddForeignKey(
                name: "FK_Message2s_Writers_ReceiverID",
                table: "Message2s",
                column: "ReceiverID",
                principalTable: "Writers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Message2s_Writers_SenderID",
                table: "Message2s",
                column: "SenderID",
                principalTable: "Writers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
