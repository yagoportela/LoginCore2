using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Data.Migrations
{
    public partial class InitialCreateUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Altitude = table.Column<string>(maxLength: 100, nullable: true),
                    City = table.Column<string>(maxLength: 200, nullable: true),
                    Complement = table.Column<string>(maxLength: 200, nullable: true),
                    Countries = table.Column<string>(nullable: true),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    District = table.Column<string>(maxLength: 200, nullable: true),
                    Longitude = table.Column<string>(maxLength: 100, nullable: true),
                    Number = table.Column<string>(maxLength: 20, nullable: true),
                    Obs = table.Column<string>(maxLength: 200, nullable: true),
                    State = table.Column<string>(maxLength: 200, nullable: true),
                    Street = table.Column<string>(maxLength: 200, nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    ZipCode = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    ImgPerfil = table.Column<string>(nullable: true),
                    Tipo = table.Column<int>(nullable: false),
                    UpdateAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddressId = table.Column<Guid>(nullable: true),
                    CNPJ = table.Column<string>(maxLength: 30, nullable: true),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    NomeFantasia = table.Column<string>(maxLength: 200, nullable: true),
                    Phone1 = table.Column<string>(maxLength: 15, nullable: true),
                    Phone2 = table.Column<string>(maxLength: 15, nullable: true),
                    RazaoSocial = table.Column<string>(maxLength: 200, nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Company_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Company_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddressId = table.Column<Guid>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    CPF = table.Column<string>(maxLength: 30, nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    RG = table.Column<string>(maxLength: 30, nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customers_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Workshop",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddressId = table.Column<Guid>(nullable: true),
                    CompanyId = table.Column<Guid>(nullable: true),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    NameWorkshop = table.Column<string>(maxLength: 200, nullable: true),
                    Phone1 = table.Column<string>(maxLength: 15, nullable: true),
                    Phone2 = table.Column<string>(maxLength: 15, nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workshop", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workshop_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Workshop_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Workshop_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Company_AddressId",
                table: "Company",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Company_UserId",
                table: "Company",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AddressId",
                table: "Customers",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserId",
                table: "Customers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_ImgPerfil",
                table: "User",
                column: "ImgPerfil",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Workshop_AddressId",
                table: "Workshop",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Workshop_CompanyId",
                table: "Workshop",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Workshop_UserId",
                table: "Workshop",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Workshop");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
