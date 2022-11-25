using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MailBoxServices.DataAccess.Migrations
{
    public partial class mailBoxIntial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MailBox",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MAIL_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUBJECT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CONTENT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DATE_TIME = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ISREAD = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailBox", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MailBox");
        }
    }
}
