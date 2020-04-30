using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MitechCenter.vn.Migrations
{
    public partial class MitechCenterDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NewsCategory",
                columns: table => new
                {
                    ncId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ncName = table.Column<string>(nullable: true),
                    ncDescription = table.Column<string>(nullable: true),
                    createAt = table.Column<DateTime>(nullable: false),
                    updateAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsCategory", x => x.ncId);
                });

            migrationBuilder.CreateTable(
                name: "StaticElement",
                columns: table => new
                {
                    eId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    eKey = table.Column<string>(nullable: true),
                    eData = table.Column<string>(nullable: true),
                    eDescription = table.Column<string>(nullable: true),
                    createAt = table.Column<DateTime>(nullable: false),
                    updateAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaticElement", x => x.eId);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    tId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tDisplayName = table.Column<string>(nullable: true),
                    tAvatar = table.Column<string>(nullable: true),
                    createAt = table.Column<DateTime>(nullable: false),
                    updateAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.tId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    uId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(nullable: true),
                    encryptPassword = table.Column<string>(nullable: true),
                    displayName = table.Column<string>(nullable: true),
                    avatar = table.Column<string>(nullable: true),
                    role = table.Column<int>(nullable: false),
                    createAt = table.Column<DateTime>(nullable: false),
                    updateAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.uId);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    cId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tId = table.Column<int>(nullable: false),
                    cName = table.Column<string>(nullable: true),
                    cPrice = table.Column<float>(nullable: false),
                    cLearningTime = table.Column<string>(nullable: true),
                    cDescription = table.Column<string>(nullable: true),
                    cDetail = table.Column<string>(nullable: true),
                    cSchedule = table.Column<string>(nullable: true),
                    createAt = table.Column<DateTime>(nullable: false),
                    updateAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.cId);
                    table.ForeignKey(
                        name: "FK_Course_Teacher_tId",
                        column: x => x.tId,
                        principalTable: "Teacher",
                        principalColumn: "tId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AboutUs",
                columns: table => new
                {
                    auId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    auTitle = table.Column<string>(nullable: true),
                    auContent = table.Column<string>(nullable: true),
                    uId = table.Column<int>(nullable: false),
                    createAt = table.Column<DateTime>(nullable: false),
                    updateAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUs", x => x.auId);
                    table.ForeignKey(
                        name: "FK_AboutUs_User_uId",
                        column: x => x.uId,
                        principalTable: "User",
                        principalColumn: "uId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    fId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fFullname = table.Column<int>(nullable: false),
                    fAddress = table.Column<string>(nullable: true),
                    fPhone = table.Column<string>(nullable: true),
                    fEmail = table.Column<string>(nullable: true),
                    fContent = table.Column<string>(nullable: true),
                    fReplyByUserId = table.Column<int>(nullable: true),
                    createAt = table.Column<DateTime>(nullable: false),
                    updateAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.fId);
                    table.ForeignKey(
                        name: "FK_Feedback_User_fReplyByUserId",
                        column: x => x.fReplyByUserId,
                        principalTable: "User",
                        principalColumn: "uId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    nId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ncId = table.Column<int>(nullable: false),
                    uId = table.Column<int>(nullable: false),
                    nTitle = table.Column<string>(nullable: true),
                    nDescription = table.Column<string>(nullable: true),
                    nContent = table.Column<string>(nullable: true),
                    nTags = table.Column<string>(nullable: true),
                    nFeatureImage = table.Column<string>(nullable: true),
                    createAt = table.Column<DateTime>(nullable: false),
                    updateAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.nId);
                    table.ForeignKey(
                        name: "FK_News_NewsCategory_ncId",
                        column: x => x.ncId,
                        principalTable: "NewsCategory",
                        principalColumn: "ncId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_News_User_uId",
                        column: x => x.uId,
                        principalTable: "User",
                        principalColumn: "uId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "FK_AboutUs_Id_Index",
                table: "AboutUs",
                column: "auId");

            migrationBuilder.CreateIndex(
                name: "IX_AboutUs_uId",
                table: "AboutUs",
                column: "uId");

            migrationBuilder.CreateIndex(
                name: "FK_Course_Id_Index",
                table: "Course",
                column: "cId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_tId",
                table: "Course",
                column: "tId");

            migrationBuilder.CreateIndex(
                name: "FK_Feedback_Id_Index",
                table: "Feedback",
                column: "fId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_fReplyByUserId",
                table: "Feedback",
                column: "fReplyByUserId");

            migrationBuilder.CreateIndex(
                name: "FK_News_Id_Index",
                table: "News",
                column: "nId");

            migrationBuilder.CreateIndex(
                name: "IX_News_ncId",
                table: "News",
                column: "ncId");

            migrationBuilder.CreateIndex(
                name: "IX_News_uId",
                table: "News",
                column: "uId");

            migrationBuilder.CreateIndex(
                name: "FK_NewsCategory_Id_Index",
                table: "NewsCategory",
                column: "ncId");

            migrationBuilder.CreateIndex(
                name: "FK_ElementTbl_Id_Index",
                table: "StaticElement",
                column: "eId");

            migrationBuilder.CreateIndex(
                name: "FK_Teacher_Id_Index",
                table: "Teacher",
                column: "tId");

            migrationBuilder.CreateIndex(
                name: "FK_User_Id_Index",
                table: "User",
                column: "uId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutUs");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "StaticElement");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropTable(
                name: "NewsCategory");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
