using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_DataBase_KillTeamWarhammer40k.Migrations
{
    /// <inheritdoc />
    public partial class PoprawianieRelacjiIPol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeaponWeaponAbility");

            migrationBuilder.DropTable(
                name: "WeaponAbilityDbSet");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "UniversalEquipmentDbSet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "StrategyPloyDbSet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WeaponsName",
                table: "OperativeDbSet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "FirefightPloyDbSet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "FactionRuleDbSet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "FactionEquipmentDbSet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "WeaponAbilityDescription",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WeaponId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponAbilityDescription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeaponAbilityDescription_WeaponDbSet_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "WeaponDbSet",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_WeaponAbilityDescription_WeaponId",
                table: "WeaponAbilityDescription",
                column: "WeaponId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeaponAbilityDescription");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "UniversalEquipmentDbSet");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "StrategyPloyDbSet");

            migrationBuilder.DropColumn(
                name: "WeaponsName",
                table: "OperativeDbSet");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "FirefightPloyDbSet");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "FactionRuleDbSet");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "FactionEquipmentDbSet");

            migrationBuilder.CreateTable(
                name: "WeaponAbilityDbSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponAbilityDbSet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeaponWeaponAbility",
                columns: table => new
                {
                    WeaponAbilitiesId = table.Column<int>(type: "int", nullable: false),
                    WeaponsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponWeaponAbility", x => new { x.WeaponAbilitiesId, x.WeaponsId });
                    table.ForeignKey(
                        name: "FK_WeaponWeaponAbility_WeaponAbilityDbSet_WeaponAbilitiesId",
                        column: x => x.WeaponAbilitiesId,
                        principalTable: "WeaponAbilityDbSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeaponWeaponAbility_WeaponDbSet_WeaponsId",
                        column: x => x.WeaponsId,
                        principalTable: "WeaponDbSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WeaponWeaponAbility_WeaponsId",
                table: "WeaponWeaponAbility",
                column: "WeaponsId");
        }
    }
}
