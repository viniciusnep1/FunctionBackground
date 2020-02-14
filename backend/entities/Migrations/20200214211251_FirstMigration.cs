using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace entities.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "entity");

            migrationBuilder.EnsureSchema(
                name: "xpto");

            migrationBuilder.EnsureSchema(
                name: "security");

            migrationBuilder.CreateTable(
                name: "xpto",
                schema: "entity",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    total_planned1 = table.Column<double>(nullable: false),
                    total_produced1 = table.Column<double>(nullable: false),
                    total_planned2 = table.Column<double>(nullable: false),
                    total_produced2 = table.Column<double>(nullable: false),
                    total_planned3 = table.Column<double>(nullable: false),
                    total_produced3 = table.Column<double>(nullable: false),
                    total_planned4 = table.Column<double>(nullable: false),
                    total_produced4 = table.Column<double>(nullable: false),
                    total_planned5 = table.Column<double>(nullable: false),
                    total_produced5 = table.Column<double>(nullable: false),
                    total_planned6 = table.Column<double>(nullable: false),
                    total_produced6 = table.Column<double>(nullable: false),
                    total_planned7 = table.Column<double>(nullable: false),
                    total_produced7 = table.Column<double>(nullable: false),
                    total_planned8 = table.Column<double>(nullable: false),
                    total_produced8 = table.Column<double>(nullable: false),
                    total_planned9 = table.Column<double>(nullable: false),
                    total_produced9 = table.Column<double>(nullable: false),
                    total_planned10 = table.Column<double>(nullable: false),
                    total_produced10 = table.Column<double>(nullable: false),
                    total_planned11 = table.Column<double>(nullable: false),
                    total_produced11 = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_xpto", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "aspnetroles",
                schema: "security",
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
                schema: "security",
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
                schema: "security",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
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
                schema: "security",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    desativado = table.Column<bool>(nullable: false),
                    nome = table.Column<string>(nullable: true),
                    codigo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_permissao", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "vol_planned",
                schema: "xpto",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    planned1 = table.Column<double>(nullable: false),
                    planned2 = table.Column<double>(nullable: false),
                    planned3 = table.Column<double>(nullable: false),
                    planned4 = table.Column<double>(nullable: false),
                    planned5 = table.Column<double>(nullable: false),
                    planned6 = table.Column<double>(nullable: false),
                    planned7 = table.Column<double>(nullable: false),
                    planned8 = table.Column<double>(nullable: false),
                    planned9 = table.Column<double>(nullable: false),
                    planned10 = table.Column<double>(nullable: false),
                    planned11 = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_vol_planned", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "vol_produced",
                schema: "xpto",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    produced1 = table.Column<double>(nullable: false),
                    produced2 = table.Column<double>(nullable: false),
                    produced3 = table.Column<double>(nullable: false),
                    produced4 = table.Column<double>(nullable: false),
                    produced5 = table.Column<double>(nullable: false),
                    produced6 = table.Column<double>(nullable: false),
                    produced7 = table.Column<double>(nullable: false),
                    produced8 = table.Column<double>(nullable: false),
                    produced9 = table.Column<double>(nullable: false),
                    produced10 = table.Column<double>(nullable: false),
                    produced11 = table.Column<double>(nullable: false),
                    total = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_vol_produced", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "aspnetroleclaims",
                schema: "security",
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
                        principalSchema: "security",
                        principalTable: "aspnetroles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "aspnetuserclaims",
                schema: "security",
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
                        principalSchema: "security",
                        principalTable: "aspnetusers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "aspnetuserlogins",
                schema: "security",
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
                        principalSchema: "security",
                        principalTable: "aspnetusers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "aspnetuserroles",
                schema: "security",
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
                        principalSchema: "security",
                        principalTable: "aspnetroles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_aspnetuserroles_aspnetusers_user_id",
                        column: x => x.user_id,
                        principalSchema: "security",
                        principalTable: "aspnetusers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "aspnetusertokens",
                schema: "security",
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
                        principalSchema: "security",
                        principalTable: "aspnetusers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "perfil_modulo",
                schema: "security",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
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
                        principalSchema: "security",
                        principalTable: "modulo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_perfil_modulo_aspnetroles_perfil_id",
                        column: x => x.perfil_id,
                        principalSchema: "security",
                        principalTable: "aspnetroles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "modulo_permissao",
                schema: "security",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
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
                        principalSchema: "security",
                        principalTable: "perfil_modulo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_modulo_permissao_permissao_permissao_id",
                        column: x => x.permissao_id,
                        principalSchema: "security",
                        principalTable: "permissao",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_aspnetroleclaims_role_id",
                schema: "security",
                table: "aspnetroleclaims",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "role_name_index",
                schema: "security",
                table: "aspnetroles",
                column: "normalized_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_aspnetuserclaims_user_id",
                schema: "security",
                table: "aspnetuserclaims",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_aspnetuserlogins_user_id",
                schema: "security",
                table: "aspnetuserlogins",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_aspnetuserroles_role_id",
                schema: "security",
                table: "aspnetuserroles",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "email_index",
                schema: "security",
                table: "aspnetusers",
                column: "normalized_email");

            migrationBuilder.CreateIndex(
                name: "user_name_index",
                schema: "security",
                table: "aspnetusers",
                column: "normalized_user_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_modulo_permissao_perfil_modulo_id",
                schema: "security",
                table: "modulo_permissao",
                column: "perfil_modulo_id");

            migrationBuilder.CreateIndex(
                name: "ix_modulo_permissao_permissao_id",
                schema: "security",
                table: "modulo_permissao",
                column: "permissao_id");

            migrationBuilder.CreateIndex(
                name: "ix_perfil_modulo_modulo_id",
                schema: "security",
                table: "perfil_modulo",
                column: "modulo_id");

            migrationBuilder.CreateIndex(
                name: "ix_perfil_modulo_perfil_id",
                schema: "security",
                table: "perfil_modulo",
                column: "perfil_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "xpto",
                schema: "entity");

            migrationBuilder.DropTable(
                name: "aspnetroleclaims",
                schema: "security");

            migrationBuilder.DropTable(
                name: "aspnetuserclaims",
                schema: "security");

            migrationBuilder.DropTable(
                name: "aspnetuserlogins",
                schema: "security");

            migrationBuilder.DropTable(
                name: "aspnetuserroles",
                schema: "security");

            migrationBuilder.DropTable(
                name: "aspnetusertokens",
                schema: "security");

            migrationBuilder.DropTable(
                name: "modulo_permissao",
                schema: "security");

            migrationBuilder.DropTable(
                name: "vol_planned",
                schema: "xpto");

            migrationBuilder.DropTable(
                name: "vol_produced",
                schema: "xpto");

            migrationBuilder.DropTable(
                name: "aspnetusers",
                schema: "security");

            migrationBuilder.DropTable(
                name: "perfil_modulo",
                schema: "security");

            migrationBuilder.DropTable(
                name: "permissao",
                schema: "security");

            migrationBuilder.DropTable(
                name: "modulo",
                schema: "security");

            migrationBuilder.DropTable(
                name: "aspnetroles",
                schema: "security");
        }
    }
}
