using Microsoft.EntityFrameworkCore.Migrations;


namespace TantsuvõistlusMVC.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Võistlus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tantsupaari_Nimi = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Voor1 = table.Column<int>(type: "int", nullable: false),
                    Voor2 = table.Column<int>(type: "int", nullable: false),
                    Voor3 = table.Column<int>(type: "int", nullable: false),
                    KeskmineHinne = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Võistlus", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Võistlus");
        }
    }
}
