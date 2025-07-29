using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estacionamento.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddNumeroToVaga : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Numero",
                table: "Vagas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Numero",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Numero",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Numero",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Numero",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Numero",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Numero",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Numero",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Numero",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Numero",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "Numero",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                column: "Numero",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                column: "Numero",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                column: "Numero",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                column: "Numero",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"),
                column: "Numero",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"),
                column: "Numero",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"),
                column: "Numero",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                column: "Numero",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                column: "Numero",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                column: "Numero",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                column: "Numero",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                column: "Numero",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"),
                column: "Numero",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"),
                column: "Numero",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"),
                column: "Numero",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"),
                column: "Numero",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"),
                column: "Numero",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"),
                column: "Numero",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"),
                column: "Numero",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"),
                column: "Numero",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"),
                column: "Numero",
                value: 31);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"),
                column: "Numero",
                value: 32);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"),
                column: "Numero",
                value: 33);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"),
                column: "Numero",
                value: 34);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"),
                column: "Numero",
                value: 35);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"),
                column: "Numero",
                value: 36);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"),
                column: "Numero",
                value: 37);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"),
                column: "Numero",
                value: 38);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"),
                column: "Numero",
                value: 39);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                column: "Numero",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"),
                column: "Numero",
                value: 41);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"),
                column: "Numero",
                value: 42);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"),
                column: "Numero",
                value: 43);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"),
                column: "Numero",
                value: 44);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"),
                column: "Numero",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"),
                column: "Numero",
                value: 46);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"),
                column: "Numero",
                value: 47);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"),
                column: "Numero",
                value: 48);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"),
                column: "Numero",
                value: 49);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"),
                column: "Numero",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"),
                column: "Numero",
                value: 51);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"),
                column: "Numero",
                value: 52);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"),
                column: "Numero",
                value: 53);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"),
                column: "Numero",
                value: 54);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"),
                column: "Numero",
                value: 55);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"),
                column: "Numero",
                value: 56);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"),
                column: "Numero",
                value: 57);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"),
                column: "Numero",
                value: 58);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"),
                column: "Numero",
                value: 59);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"),
                column: "Numero",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"),
                column: "Numero",
                value: 61);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"),
                column: "Numero",
                value: 62);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"),
                column: "Numero",
                value: 63);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"),
                column: "Numero",
                value: 64);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"),
                column: "Numero",
                value: 65);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"),
                column: "Numero",
                value: 66);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"),
                column: "Numero",
                value: 67);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"),
                column: "Numero",
                value: 68);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"),
                column: "Numero",
                value: 69);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"),
                column: "Numero",
                value: 70);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"),
                column: "Numero",
                value: 71);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"),
                column: "Numero",
                value: 72);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"),
                column: "Numero",
                value: 73);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"),
                column: "Numero",
                value: 74);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"),
                column: "Numero",
                value: 75);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"),
                column: "Numero",
                value: 76);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"),
                column: "Numero",
                value: 77);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"),
                column: "Numero",
                value: 78);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"),
                column: "Numero",
                value: 79);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"),
                column: "Numero",
                value: 80);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"),
                column: "Numero",
                value: 81);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"),
                column: "Numero",
                value: 82);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"),
                column: "Numero",
                value: 83);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"),
                column: "Numero",
                value: 84);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                column: "Numero",
                value: 85);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"),
                column: "Numero",
                value: 86);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"),
                column: "Numero",
                value: 87);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"),
                column: "Numero",
                value: 88);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"),
                column: "Numero",
                value: 89);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"),
                column: "Numero",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"),
                column: "Numero",
                value: 91);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"),
                column: "Numero",
                value: 92);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"),
                column: "Numero",
                value: 93);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"),
                column: "Numero",
                value: 94);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"),
                column: "Numero",
                value: 95);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"),
                column: "Numero",
                value: 96);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"),
                column: "Numero",
                value: 97);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"),
                column: "Numero",
                value: 98);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"),
                column: "Numero",
                value: 99);

            migrationBuilder.UpdateData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"),
                column: "Numero",
                value: 100);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Vagas");
        }
    }
}
