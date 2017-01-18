﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolBusAPI.Migrations
{
    public partial class SB1051182 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SBI_SCHOOL_BUS_SBI_USER_INSPECTOR_REF_ID",
                table: "SBI_SCHOOL_BUS");

            migrationBuilder.AlterColumn<int>(
                name: "INSPECTOR_REF_ID",
                table: "SBI_SCHOOL_BUS",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_SBI_SCHOOL_BUS_SBI_USER_INSPECTOR_REF_ID",
                table: "SBI_SCHOOL_BUS",
                column: "INSPECTOR_REF_ID",
                principalTable: "SBI_USER",
                principalColumn: "USER_ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SBI_SCHOOL_BUS_SBI_USER_INSPECTOR_REF_ID",
                table: "SBI_SCHOOL_BUS");

            migrationBuilder.AlterColumn<int>(
                name: "INSPECTOR_REF_ID",
                table: "SBI_SCHOOL_BUS",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SBI_SCHOOL_BUS_SBI_USER_INSPECTOR_REF_ID",
                table: "SBI_SCHOOL_BUS",
                column: "INSPECTOR_REF_ID",
                principalTable: "SBI_USER",
                principalColumn: "USER_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}