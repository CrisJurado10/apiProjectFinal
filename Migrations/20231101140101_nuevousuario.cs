
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apiBodega.Migrations
{
    /// <inheritdoc />
    public partial class nuevousuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "usuarios",
                keyColumn: "IdUser",
                keyValue: 2,
                column: "UserMail",
                value: "juanito@gmail.com");

            migrationBuilder.InsertData(
                table: "usuarios",
                columns: new[] { "IdUser", "UserMail", "UserPassword" },
                values: new object[] { 3, "cris1234@gmail.com", "admin1234" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "usuarios",
                keyColumn: "IdUser",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "usuarios",
                keyColumn: "IdUser",
                keyValue: 2,
                column: "UserMail",
                value: "cris1234@gmail.com");
        }
    }
}
