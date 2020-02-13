using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace entities.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "entidades");

            migrationBuilder.EnsureSchema(
                name: "xpto");

            migrationBuilder.EnsureSchema(
                name: "seguranca");

            migrationBuilder.CreateTable(
                name: "xpto",
                schema: "entidades",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    data_criacao = table.Column<DateTime>(nullable: false),
                    data_atualizacao = table.Column<DateTime>(nullable: true),
                    data_exclusao = table.Column<DateTime>(nullable: true),
                    ativo = table.Column<bool>(nullable: false),
                    total_dados_vol_planejado1 = table.Column<double>(nullable: false),
                    total_dados_vol_produzido1 = table.Column<double>(nullable: false),
                    total_dados_vol_planejado2 = table.Column<double>(nullable: false),
                    total_dados_vol_produzido2 = table.Column<double>(nullable: false),
                    total_dados_vol_planejado3 = table.Column<double>(nullable: false),
                    total_dados_vol_produzido3 = table.Column<double>(nullable: false),
                    total_dados_vol_planejado4 = table.Column<double>(nullable: false),
                    total_dados_vol_produzido4 = table.Column<double>(nullable: false),
                    total_dados_vol_planejado5 = table.Column<double>(nullable: false),
                    total_dados_vol_produzido5 = table.Column<double>(nullable: false),
                    total_dados_vol_planejado6 = table.Column<double>(nullable: false),
                    total_dados_vol_produzido6 = table.Column<double>(nullable: false),
                    total_dados_vol_planejado7 = table.Column<double>(nullable: false),
                    total_dados_vol_produzido7 = table.Column<double>(nullable: false),
                    total_dados_vol_planejado8 = table.Column<double>(nullable: false),
                    total_dados_vol_produzido8 = table.Column<double>(nullable: false),
                    total_dados_vol_planejado9 = table.Column<double>(nullable: false),
                    total_dados_vol_produzido9 = table.Column<double>(nullable: false),
                    total_dados_vol_planejado10 = table.Column<double>(nullable: false),
                    total_dados_vol_produzido10 = table.Column<double>(nullable: false),
                    total_dados_vol_planejado11 = table.Column<double>(nullable: false),
                    total_dados_vol_produzido11 = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_xpto", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "aspnetroles",
                schema: "seguranca",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    normalized_name = table.Column<string>(maxLength: 256, nullable: true),
                    concurrency_stamp = table.Column<string>(nullable: true),
                    name = table.Column<string>(maxLength: 256, nullable: true),
                    data_criacao = table.Column<DateTime>(nullable: false),
                    data_alteracao = table.Column<DateTime>(nullable: false),
                    desativado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_aspnetroles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "aspnetusers",
                schema: "seguranca",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    user_name = table.Column<string>(maxLength: 256, nullable: true),
                    normalized_user_name = table.Column<string>(maxLength: 256, nullable: true),
                    normalized_email = table.Column<string>(maxLength: 256, nullable: true),
                    email_confirmed = table.Column<bool>(nullable: false),
                    password_hash = table.Column<string>(nullable: true),
                    security_stamp = table.Column<string>(nullable: true),
                    concurrency_stamp = table.Column<string>(nullable: true),
                    phone_number = table.Column<string>(nullable: true),
                    phone_number_confirmed = table.Column<bool>(nullable: false),
                    two_factor_enabled = table.Column<bool>(nullable: false),
                    lockout_end = table.Column<DateTimeOffset>(nullable: true),
                    lockout_enabled = table.Column<bool>(nullable: false),
                    access_failed_count = table.Column<int>(nullable: false),
                    nome = table.Column<string>(maxLength: 40, nullable: false),
                    email = table.Column<string>(maxLength: 256, nullable: true),
                    cpj_cnpj = table.Column<string>(maxLength: 14, nullable: true),
                    data_criacao = table.Column<DateTime>(nullable: false),
                    data_alteracao = table.Column<DateTime>(nullable: false),
                    desativado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_aspnetusers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "modulo",
                schema: "seguranca",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    data_criacao = table.Column<DateTime>(nullable: false),
                    data_atualizacao = table.Column<DateTime>(nullable: true),
                    data_exclusao = table.Column<DateTime>(nullable: true),
                    ativo = table.Column<bool>(nullable: false),
                    desativado = table.Column<bool>(nullable: false),
                    nome = table.Column<string>(nullable: true),
                    codigo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_modulo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "permissao",
                schema: "seguranca",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    data_criacao = table.Column<DateTime>(nullable: false),
                    data_atualizacao = table.Column<DateTime>(nullable: true),
                    data_exclusao = table.Column<DateTime>(nullable: true),
                    ativo = table.Column<bool>(nullable: false),
                    desativado = table.Column<bool>(nullable: false),
                    nome = table.Column<string>(nullable: true),
                    codigo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_permissao", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "volume_planejado",
                schema: "xpto",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    dados_vol_planejado1 = table.Column<double>(nullable: false),
                    dados_vol_planejado2 = table.Column<double>(nullable: false),
                    dados_vol_planejado3 = table.Column<double>(nullable: false),
                    dados_vol_planejado4 = table.Column<double>(nullable: false),
                    dados_vol_planejado5 = table.Column<double>(nullable: false),
                    dados_vol_planejado6 = table.Column<double>(nullable: false),
                    dados_vol_planejado7 = table.Column<double>(nullable: false),
                    dados_vol_planejado8 = table.Column<double>(nullable: false),
                    dados_vol_planejado9 = table.Column<double>(nullable: false),
                    dados_vol_planejado10 = table.Column<double>(nullable: false),
                    dados_vol_planejado11 = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_volume_planejado", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "volume_produzido",
                schema: "xpto",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    dados_vol_produzido1 = table.Column<double>(nullable: false),
                    dados_vol_produzido2 = table.Column<double>(nullable: false),
                    dados_vol_produzido3 = table.Column<double>(nullable: false),
                    dados_vol_produzido4 = table.Column<double>(nullable: false),
                    dados_vol_produzido5 = table.Column<double>(nullable: false),
                    dados_vol_produzido6 = table.Column<double>(nullable: false),
                    dados_vol_produzido7 = table.Column<double>(nullable: false),
                    dados_vol_produzido8 = table.Column<double>(nullable: false),
                    dados_vol_produzido9 = table.Column<double>(nullable: false),
                    dados_vol_produzido10 = table.Column<double>(nullable: false),
                    dados_vol_produzido11 = table.Column<double>(nullable: false),
                    total = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_volume_produzido", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "aspnetroleclaims",
                schema: "seguranca",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    role_id = table.Column<Guid>(nullable: false),
                    claim_type = table.Column<string>(nullable: true),
                    claim_value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_aspnetroleclaims", x => x.id);
                    table.ForeignKey(
                        name: "fk_aspnetroleclaims_aspnetroles_role_id",
                        column: x => x.role_id,
                        principalSchema: "seguranca",
                        principalTable: "aspnetroles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "aspnetuserclaims",
                schema: "seguranca",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    user_id = table.Column<Guid>(nullable: false),
                    claim_type = table.Column<string>(nullable: true),
                    claim_value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_aspnetuserclaims", x => x.id);
                    table.ForeignKey(
                        name: "fk_aspnetuserclaims_aspnetusers_user_id",
                        column: x => x.user_id,
                        principalSchema: "seguranca",
                        principalTable: "aspnetusers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "aspnetuserlogins",
                schema: "seguranca",
                columns: table => new
                {
                    login_provider = table.Column<string>(nullable: false),
                    provider_key = table.Column<string>(nullable: false),
                    provider_display_name = table.Column<string>(nullable: true),
                    user_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_aspnetuserlogins", x => new { x.login_provider, x.provider_key });
                    table.ForeignKey(
                        name: "fk_aspnetuserlogins_aspnetusers_user_id",
                        column: x => x.user_id,
                        principalSchema: "seguranca",
                        principalTable: "aspnetusers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "aspnetuserroles",
                schema: "seguranca",
                columns: table => new
                {
                    user_id = table.Column<Guid>(nullable: false),
                    role_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_aspnetuserroles", x => new { x.user_id, x.role_id });
                    table.ForeignKey(
                        name: "fk_aspnetuserroles_aspnetroles_role_id",
                        column: x => x.role_id,
                        principalSchema: "seguranca",
                        principalTable: "aspnetroles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_aspnetuserroles_aspnetusers_user_id",
                        column: x => x.user_id,
                        principalSchema: "seguranca",
                        principalTable: "aspnetusers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "aspnetusertokens",
                schema: "seguranca",
                columns: table => new
                {
                    user_id = table.Column<Guid>(nullable: false),
                    login_provider = table.Column<string>(nullable: false),
                    name = table.Column<string>(nullable: false),
                    value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_aspnetusertokens", x => new { x.user_id, x.login_provider, x.name });
                    table.ForeignKey(
                        name: "fk_aspnetusertokens_aspnetusers_user_id",
                        column: x => x.user_id,
                        principalSchema: "seguranca",
                        principalTable: "aspnetusers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "perfil_modulo",
                schema: "seguranca",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    data_criacao = table.Column<DateTime>(nullable: false),
                    data_atualizacao = table.Column<DateTime>(nullable: true),
                    data_exclusao = table.Column<DateTime>(nullable: true),
                    ativo = table.Column<bool>(nullable: false),
                    desativado = table.Column<bool>(nullable: false),
                    perfil_id = table.Column<Guid>(nullable: false),
                    modulo_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_perfil_modulo", x => x.id);
                    table.ForeignKey(
                        name: "fk_perfil_modulo_modulo_modulo_id",
                        column: x => x.modulo_id,
                        principalSchema: "seguranca",
                        principalTable: "modulo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_perfil_modulo_aspnetroles_perfil_id",
                        column: x => x.perfil_id,
                        principalSchema: "seguranca",
                        principalTable: "aspnetroles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "modulo_permissao",
                schema: "seguranca",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    data_criacao = table.Column<DateTime>(nullable: false),
                    data_atualizacao = table.Column<DateTime>(nullable: true),
                    data_exclusao = table.Column<DateTime>(nullable: true),
                    ativo = table.Column<bool>(nullable: false),
                    desativado = table.Column<bool>(nullable: false),
                    perfil_modulo_id = table.Column<Guid>(nullable: false),
                    permissao_id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_modulo_permissao", x => x.id);
                    table.ForeignKey(
                        name: "fk_modulo_permissao_perfil_modulo_perfil_modulo_id",
                        column: x => x.perfil_modulo_id,
                        principalSchema: "seguranca",
                        principalTable: "perfil_modulo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_modulo_permissao_permissao_permissao_id",
                        column: x => x.permissao_id,
                        principalSchema: "seguranca",
                        principalTable: "permissao",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_aspnetroleclaims_role_id",
                schema: "seguranca",
                table: "aspnetroleclaims",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "role_name_index",
                schema: "seguranca",
                table: "aspnetroles",
                column: "normalized_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_aspnetuserclaims_user_id",
                schema: "seguranca",
                table: "aspnetuserclaims",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_aspnetuserlogins_user_id",
                schema: "seguranca",
                table: "aspnetuserlogins",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_aspnetuserroles_role_id",
                schema: "seguranca",
                table: "aspnetuserroles",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "email_index",
                schema: "seguranca",
                table: "aspnetusers",
                column: "normalized_email");

            migrationBuilder.CreateIndex(
                name: "user_name_index",
                schema: "seguranca",
                table: "aspnetusers",
                column: "normalized_user_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_modulo_permissao_perfil_modulo_id",
                schema: "seguranca",
                table: "modulo_permissao",
                column: "perfil_modulo_id");

            migrationBuilder.CreateIndex(
                name: "ix_modulo_permissao_permissao_id",
                schema: "seguranca",
                table: "modulo_permissao",
                column: "permissao_id");

            migrationBuilder.CreateIndex(
                name: "ix_perfil_modulo_modulo_id",
                schema: "seguranca",
                table: "perfil_modulo",
                column: "modulo_id");

            migrationBuilder.CreateIndex(
                name: "ix_perfil_modulo_perfil_id",
                schema: "seguranca",
                table: "perfil_modulo",
                column: "perfil_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "xpto",
                schema: "entidades");

            migrationBuilder.DropTable(
                name: "aspnetroleclaims",
                schema: "seguranca");

            migrationBuilder.DropTable(
                name: "aspnetuserclaims",
                schema: "seguranca");

            migrationBuilder.DropTable(
                name: "aspnetuserlogins",
                schema: "seguranca");

            migrationBuilder.DropTable(
                name: "aspnetuserroles",
                schema: "seguranca");

            migrationBuilder.DropTable(
                name: "aspnetusertokens",
                schema: "seguranca");

            migrationBuilder.DropTable(
                name: "modulo_permissao",
                schema: "seguranca");

            migrationBuilder.DropTable(
                name: "volume_planejado",
                schema: "xpto");

            migrationBuilder.DropTable(
                name: "volume_produzido",
                schema: "xpto");

            migrationBuilder.DropTable(
                name: "aspnetusers",
                schema: "seguranca");

            migrationBuilder.DropTable(
                name: "perfil_modulo",
                schema: "seguranca");

            migrationBuilder.DropTable(
                name: "permissao",
                schema: "seguranca");

            migrationBuilder.DropTable(
                name: "modulo",
                schema: "seguranca");

            migrationBuilder.DropTable(
                name: "aspnetroles",
                schema: "seguranca");
        }
    }
}
