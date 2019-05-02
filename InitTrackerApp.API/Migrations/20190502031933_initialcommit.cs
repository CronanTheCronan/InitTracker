using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InitTrackerApp.API.Migrations
{
    public partial class initialcommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conditions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 75, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Content",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Content", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HeroGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MonsterGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MonstersGroupXref",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MonsterId = table.Column<int>(nullable: false),
                    MonsterExtId = table.Column<int>(nullable: false),
                    GroupId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonstersGroupXref", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    PasswordHash = table.Column<byte[]>(nullable: false),
                    PasswordSalt = table.Column<byte[]>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Heroes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    CreatedByUserId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Heroes_Users",
                        column: x => x.CreatedByUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Monsters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Alignment = table.Column<int>(nullable: false),
                    RecAC = table.Column<int>(nullable: false),
                    RecHP = table.Column<int>(nullable: false),
                    ChallengeRating = table.Column<int>(nullable: false),
                    Homebrew = table.Column<bool>(nullable: false),
                    Content = table.Column<int>(nullable: true),
                    CreatedByUser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monsters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Monsters_User",
                        column: x => x.CreatedByUser,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HeroesExtended",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HeroId = table.Column<int>(nullable: false),
                    ArmorClass = table.Column<int>(nullable: false),
                    CurrentHP = table.Column<int>(nullable: false),
                    MaxHP = table.Column<int>(nullable: false),
                    Condition1 = table.Column<int>(nullable: true),
                    Condition2 = table.Column<int>(nullable: true),
                    Condition3 = table.Column<int>(nullable: true),
                    Condition4 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroesExtended", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeroesExtended_Heroes",
                        column: x => x.HeroId,
                        principalTable: "Heroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MonstersExtended",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MonsterId = table.Column<int>(nullable: false),
                    ArmorClass = table.Column<int>(nullable: false),
                    CurrentHP = table.Column<int>(nullable: false),
                    MaxHP = table.Column<int>(nullable: false),
                    Condition1 = table.Column<int>(nullable: true),
                    Condition2 = table.Column<int>(nullable: true),
                    Condition3 = table.Column<int>(nullable: true),
                    Condition4 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonstersExtended", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonstersExtended_Monsters",
                        column: x => x.MonsterId,
                        principalTable: "Monsters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HeroesGroupXref",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HeroId = table.Column<int>(nullable: false),
                    HeroExtId = table.Column<int>(nullable: false),
                    GroupId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroesGroupXref", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeroesGroupXref_HeroGroups",
                        column: x => x.GroupId,
                        principalTable: "HeroGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HeroesGroupXref_HeroesExtended",
                        column: x => x.HeroExtId,
                        principalTable: "HeroesExtended",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HeroesGroupXref_Heroes",
                        column: x => x.HeroId,
                        principalTable: "Heroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HeroesGroupXref_Users",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_CreatedByUserId",
                table: "Heroes",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HeroesExtended_HeroId",
                table: "HeroesExtended",
                column: "HeroId");

            migrationBuilder.CreateIndex(
                name: "IX_HeroesGroupXref_GroupId",
                table: "HeroesGroupXref",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_HeroesGroupXref_HeroExtId",
                table: "HeroesGroupXref",
                column: "HeroExtId");

            migrationBuilder.CreateIndex(
                name: "IX_HeroesGroupXref_HeroId",
                table: "HeroesGroupXref",
                column: "HeroId");

            migrationBuilder.CreateIndex(
                name: "IX_HeroesGroupXref_UserId",
                table: "HeroesGroupXref",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Monsters_CreatedByUser",
                table: "Monsters",
                column: "CreatedByUser");

            migrationBuilder.CreateIndex(
                name: "IX_MonstersExtended_MonsterId",
                table: "MonstersExtended",
                column: "MonsterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conditions");

            migrationBuilder.DropTable(
                name: "Content");

            migrationBuilder.DropTable(
                name: "HeroesGroupXref");

            migrationBuilder.DropTable(
                name: "MonsterGroups");

            migrationBuilder.DropTable(
                name: "MonstersExtended");

            migrationBuilder.DropTable(
                name: "MonstersGroupXref");

            migrationBuilder.DropTable(
                name: "HeroGroups");

            migrationBuilder.DropTable(
                name: "HeroesExtended");

            migrationBuilder.DropTable(
                name: "Monsters");

            migrationBuilder.DropTable(
                name: "Heroes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
