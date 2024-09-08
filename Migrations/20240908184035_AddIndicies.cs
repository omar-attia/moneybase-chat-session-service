﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChatSession.Dal.Migrations
{
    /// <inheritdoc />
    public partial class AddIndicies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Session_ActorId",
                table: "Session",
                column: "ActorId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Session_ActorId",
                table: "Session");
        }
    }
}
