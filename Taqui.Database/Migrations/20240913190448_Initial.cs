using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taqui.Database.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_TAQUI_CLIENTE",
                columns: table => new
                {
                    ID_USUARIO = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    DS_USER = table.Column<string>(type: "varchar2(200)", maxLength: 200, nullable: false),
                    DS_SENHA = table.Column<string>(type: "varchar2(200)", maxLength: 100, nullable: false),
                    DS_EMAIL = table.Column<string>(type: "varchar2(200)", maxLength: 100, nullable: false),
                    DS_CPF = table.Column<string>(type: "char(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_TAQUI_CLIENTE", x => x.ID_USUARIO);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_TAQUI_CLIENTE");
        }
    }
}
