using Microsoft.EntityFrameworkCore.Migrations;

namespace pfe.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comptes",
                columns: table => new
                {
                    CompteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lib = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DB = table.Column<bool>(type: "bit", nullable: false),
                    CR = table.Column<bool>(type: "bit", nullable: false),
                    TypeCompte = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompteDB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OuvertDB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OuvertCR = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comptes", x => x.CompteId);
                });

            migrationBuilder.CreateTable(
                name: "DepBancaires",
                columns: table => new
                {
                    DepBanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NCH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tiers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Montant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MVT = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepBancaires", x => x.DepBanId);
                });

            migrationBuilder.CreateTable(
                name: "DepCaisses",
                columns: table => new
                {
                    DepCaiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tiers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Montant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MVT = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepCaisses", x => x.DepCaiId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentDetails",
                columns: table => new
                {
                    PaymentDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardOwnerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentDetails", x => x.PaymentDetailId);
                });

            migrationBuilder.CreateTable(
                name: "RecBancaires",
                columns: table => new
                {
                    DepBanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NCH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tiers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Montant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MVT = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecBancaires", x => x.DepBanId);
                });

            migrationBuilder.CreateTable(
                name: "RecCaisses",
                columns: table => new
                {
                    DepCaiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tiers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Montant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MVT = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecCaisses", x => x.DepCaiId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comptes");

            migrationBuilder.DropTable(
                name: "DepBancaires");

            migrationBuilder.DropTable(
                name: "DepCaisses");

            migrationBuilder.DropTable(
                name: "PaymentDetails");

            migrationBuilder.DropTable(
                name: "RecBancaires");

            migrationBuilder.DropTable(
                name: "RecCaisses");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
