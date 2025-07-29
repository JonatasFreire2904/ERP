using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Estacionamento.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaEstacionamentoDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Vagas",
                columns: new[] { "Id", "Codigo", "Ocupada" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), "V001", false },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "V002", false },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "V003", false },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "V004", false },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "V005", false },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "V006", false },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "V007", false },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "V008", false },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "V009", false },
                    { new Guid("00000000-0000-0000-0000-000000000010"), "V010", false },
                    { new Guid("00000000-0000-0000-0000-000000000011"), "V011", false },
                    { new Guid("00000000-0000-0000-0000-000000000012"), "V012", false },
                    { new Guid("00000000-0000-0000-0000-000000000013"), "V013", false },
                    { new Guid("00000000-0000-0000-0000-000000000014"), "V014", false },
                    { new Guid("00000000-0000-0000-0000-000000000015"), "V015", false },
                    { new Guid("00000000-0000-0000-0000-000000000016"), "V016", false },
                    { new Guid("00000000-0000-0000-0000-000000000017"), "V017", false },
                    { new Guid("00000000-0000-0000-0000-000000000018"), "V018", false },
                    { new Guid("00000000-0000-0000-0000-000000000019"), "V019", false },
                    { new Guid("00000000-0000-0000-0000-000000000020"), "V020", false },
                    { new Guid("00000000-0000-0000-0000-000000000021"), "V021", false },
                    { new Guid("00000000-0000-0000-0000-000000000022"), "V022", false },
                    { new Guid("00000000-0000-0000-0000-000000000023"), "V023", false },
                    { new Guid("00000000-0000-0000-0000-000000000024"), "V024", false },
                    { new Guid("00000000-0000-0000-0000-000000000025"), "V025", false },
                    { new Guid("00000000-0000-0000-0000-000000000026"), "V026", false },
                    { new Guid("00000000-0000-0000-0000-000000000027"), "V027", false },
                    { new Guid("00000000-0000-0000-0000-000000000028"), "V028", false },
                    { new Guid("00000000-0000-0000-0000-000000000029"), "V029", false },
                    { new Guid("00000000-0000-0000-0000-000000000030"), "V030", false },
                    { new Guid("00000000-0000-0000-0000-000000000031"), "V031", false },
                    { new Guid("00000000-0000-0000-0000-000000000032"), "V032", false },
                    { new Guid("00000000-0000-0000-0000-000000000033"), "V033", false },
                    { new Guid("00000000-0000-0000-0000-000000000034"), "V034", false },
                    { new Guid("00000000-0000-0000-0000-000000000035"), "V035", false },
                    { new Guid("00000000-0000-0000-0000-000000000036"), "V036", false },
                    { new Guid("00000000-0000-0000-0000-000000000037"), "V037", false },
                    { new Guid("00000000-0000-0000-0000-000000000038"), "V038", false },
                    { new Guid("00000000-0000-0000-0000-000000000039"), "V039", false },
                    { new Guid("00000000-0000-0000-0000-000000000040"), "V040", false },
                    { new Guid("00000000-0000-0000-0000-000000000041"), "V041", false },
                    { new Guid("00000000-0000-0000-0000-000000000042"), "V042", false },
                    { new Guid("00000000-0000-0000-0000-000000000043"), "V043", false },
                    { new Guid("00000000-0000-0000-0000-000000000044"), "V044", false },
                    { new Guid("00000000-0000-0000-0000-000000000045"), "V045", false },
                    { new Guid("00000000-0000-0000-0000-000000000046"), "V046", false },
                    { new Guid("00000000-0000-0000-0000-000000000047"), "V047", false },
                    { new Guid("00000000-0000-0000-0000-000000000048"), "V048", false },
                    { new Guid("00000000-0000-0000-0000-000000000049"), "V049", false },
                    { new Guid("00000000-0000-0000-0000-000000000050"), "V050", false },
                    { new Guid("00000000-0000-0000-0000-000000000051"), "V051", false },
                    { new Guid("00000000-0000-0000-0000-000000000052"), "V052", false },
                    { new Guid("00000000-0000-0000-0000-000000000053"), "V053", false },
                    { new Guid("00000000-0000-0000-0000-000000000054"), "V054", false },
                    { new Guid("00000000-0000-0000-0000-000000000055"), "V055", false },
                    { new Guid("00000000-0000-0000-0000-000000000056"), "V056", false },
                    { new Guid("00000000-0000-0000-0000-000000000057"), "V057", false },
                    { new Guid("00000000-0000-0000-0000-000000000058"), "V058", false },
                    { new Guid("00000000-0000-0000-0000-000000000059"), "V059", false },
                    { new Guid("00000000-0000-0000-0000-000000000060"), "V060", false },
                    { new Guid("00000000-0000-0000-0000-000000000061"), "V061", false },
                    { new Guid("00000000-0000-0000-0000-000000000062"), "V062", false },
                    { new Guid("00000000-0000-0000-0000-000000000063"), "V063", false },
                    { new Guid("00000000-0000-0000-0000-000000000064"), "V064", false },
                    { new Guid("00000000-0000-0000-0000-000000000065"), "V065", false },
                    { new Guid("00000000-0000-0000-0000-000000000066"), "V066", false },
                    { new Guid("00000000-0000-0000-0000-000000000067"), "V067", false },
                    { new Guid("00000000-0000-0000-0000-000000000068"), "V068", false },
                    { new Guid("00000000-0000-0000-0000-000000000069"), "V069", false },
                    { new Guid("00000000-0000-0000-0000-000000000070"), "V070", false },
                    { new Guid("00000000-0000-0000-0000-000000000071"), "V071", false },
                    { new Guid("00000000-0000-0000-0000-000000000072"), "V072", false },
                    { new Guid("00000000-0000-0000-0000-000000000073"), "V073", false },
                    { new Guid("00000000-0000-0000-0000-000000000074"), "V074", false },
                    { new Guid("00000000-0000-0000-0000-000000000075"), "V075", false },
                    { new Guid("00000000-0000-0000-0000-000000000076"), "V076", false },
                    { new Guid("00000000-0000-0000-0000-000000000077"), "V077", false },
                    { new Guid("00000000-0000-0000-0000-000000000078"), "V078", false },
                    { new Guid("00000000-0000-0000-0000-000000000079"), "V079", false },
                    { new Guid("00000000-0000-0000-0000-000000000080"), "V080", false },
                    { new Guid("00000000-0000-0000-0000-000000000081"), "V081", false },
                    { new Guid("00000000-0000-0000-0000-000000000082"), "V082", false },
                    { new Guid("00000000-0000-0000-0000-000000000083"), "V083", false },
                    { new Guid("00000000-0000-0000-0000-000000000084"), "V084", false },
                    { new Guid("00000000-0000-0000-0000-000000000085"), "V085", false },
                    { new Guid("00000000-0000-0000-0000-000000000086"), "V086", false },
                    { new Guid("00000000-0000-0000-0000-000000000087"), "V087", false },
                    { new Guid("00000000-0000-0000-0000-000000000088"), "V088", false },
                    { new Guid("00000000-0000-0000-0000-000000000089"), "V089", false },
                    { new Guid("00000000-0000-0000-0000-000000000090"), "V090", false },
                    { new Guid("00000000-0000-0000-0000-000000000091"), "V091", false },
                    { new Guid("00000000-0000-0000-0000-000000000092"), "V092", false },
                    { new Guid("00000000-0000-0000-0000-000000000093"), "V093", false },
                    { new Guid("00000000-0000-0000-0000-000000000094"), "V094", false },
                    { new Guid("00000000-0000-0000-0000-000000000095"), "V095", false },
                    { new Guid("00000000-0000-0000-0000-000000000096"), "V096", false },
                    { new Guid("00000000-0000-0000-0000-000000000097"), "V097", false },
                    { new Guid("00000000-0000-0000-0000-000000000098"), "V098", false },
                    { new Guid("00000000-0000-0000-0000-000000000099"), "V099", false },
                    { new Guid("00000000-0000-0000-0000-000000000100"), "V100", false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000023"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000024"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000025"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000026"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000027"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000029"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000030"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000032"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000033"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000034"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000035"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000036"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000037"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000038"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000039"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000041"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000042"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000043"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000044"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000045"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000046"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000047"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000048"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000049"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000051"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000052"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000053"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000054"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000055"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000056"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000057"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000058"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000059"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000060"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000061"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000062"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000064"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000065"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000066"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000067"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000070"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000071"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000072"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000073"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000074"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000075"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000076"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000077"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000078"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000079"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000080"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000081"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000082"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000083"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000084"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000086"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000087"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000088"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000089"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000092"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000093"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000094"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000095"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000096"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000097"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000098"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000099"));

            migrationBuilder.DeleteData(
                table: "Vagas",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"));
        }
    }
}
