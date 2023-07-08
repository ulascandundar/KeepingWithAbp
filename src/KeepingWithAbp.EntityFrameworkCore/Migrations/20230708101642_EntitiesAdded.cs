using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KeepingWithAbp.Migrations
{
    /// <inheritdoc />
    public partial class EntitiesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppBranches",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "Varchar", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "Varchar", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "Varchar", maxLength: 200, nullable: false),
                    Status = table.Column<bool>(type: "Boolean", nullable: false),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppBranches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppPeriods",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "Varchar", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "Varchar", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "Varchar", maxLength: 200, nullable: false),
                    Status = table.Column<bool>(type: "Boolean", nullable: false),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppPeriods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppSpecialCodes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "Varchar", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "Varchar", maxLength: 50, nullable: false),
                    SpecialCodeType = table.Column<short>(type: "Smallint", nullable: false),
                    CardType = table.Column<short>(type: "Smallint", nullable: false),
                    Description = table.Column<string>(type: "Varchar", maxLength: 200, nullable: false),
                    Status = table.Column<bool>(type: "Boolean", nullable: false),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSpecialCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppBanks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "Varchar", maxLength: 20, nullable: false),
                    Varchar = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "Uuid", nullable: false),
                    SpecialCode2Id = table.Column<Guid>(type: "Uuid", nullable: false),
                    Description = table.Column<string>(type: "Varchar", maxLength: 200, nullable: false),
                    Status = table.Column<bool>(type: "Boolean", nullable: false),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppBanks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppBanks_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppBanks_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppCurrents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "Varchar", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "Varchar", maxLength: 50, nullable: false),
                    TaxAdministration = table.Column<string>(type: "Varchar", maxLength: 50, nullable: false),
                    TaxNo = table.Column<string>(type: "Varchar", maxLength: 50, nullable: false),
                    Telephone = table.Column<string>(type: "Varchar", maxLength: 150, nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "Uuid", nullable: false),
                    SpecialCode2Id = table.Column<Guid>(type: "Uuid", nullable: false),
                    Description = table.Column<string>(type: "Varchar", maxLength: 200, nullable: false),
                    Status = table.Column<bool>(type: "Boolean", nullable: false),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCurrents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppCurrents_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppCurrents_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppSafes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "Varchar", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "Varchar", maxLength: 50, nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "Uuid", nullable: false),
                    SpecialCode2Id = table.Column<Guid>(type: "Uuid", nullable: false),
                    BranchId = table.Column<Guid>(type: "Uuid", nullable: false),
                    Description = table.Column<string>(type: "Varchar", maxLength: 200, nullable: false),
                    Status = table.Column<bool>(type: "Boolean", nullable: false),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSafes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppSafes_AppBranches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "AppBranches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppSafes_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppSafes_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppUnits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "Varchar", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "Varchar", maxLength: 50, nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "Uuid", nullable: false),
                    SpecialCode2Id = table.Column<Guid>(type: "Uuid", nullable: false),
                    Description = table.Column<string>(type: "Varchar", maxLength: 200, nullable: false),
                    Status = table.Column<bool>(type: "Boolean", nullable: false),
                    UnitId = table.Column<Guid>(type: "uuid", nullable: true),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUnits_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppUnits_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppUnits_AppUnits_UnitId",
                        column: x => x.UnitId,
                        principalTable: "AppUnits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppWarehouses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "Varchar", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "Varchar", maxLength: 50, nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "Uuid", nullable: false),
                    SpecialCode2Id = table.Column<Guid>(type: "Uuid", nullable: false),
                    BranchId = table.Column<Guid>(type: "Uuid", nullable: false),
                    Description = table.Column<string>(type: "Varchar", maxLength: 200, nullable: false),
                    Status = table.Column<bool>(type: "Boolean", nullable: false),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppWarehouses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppWarehouses_AppBranches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "AppBranches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppWarehouses_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppWarehouses_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppBankBranches",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "Varchar", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "Varchar", maxLength: 50, nullable: false),
                    BankId = table.Column<Guid>(type: "Uuid", nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "Uuid", nullable: false),
                    SpecialCode2Id = table.Column<Guid>(type: "Uuid", nullable: false),
                    Description = table.Column<string>(type: "Varchar", maxLength: 200, nullable: false),
                    Status = table.Column<bool>(type: "Boolean", nullable: false),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppBankBranches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppBankBranches_AppBanks_BankId",
                        column: x => x.BankId,
                        principalTable: "AppBanks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppBankBranches_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppBankBranches_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppBills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BillType = table.Column<short>(type: "Smallint", nullable: false),
                    BillNo = table.Column<string>(type: "Varchar", maxLength: 16, nullable: false),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    GrossAmount = table.Column<decimal>(type: "Money", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "Money", nullable: false),
                    ExcludesVat = table.Column<decimal>(type: "Money", nullable: false),
                    VatAmount = table.Column<decimal>(type: "Money", nullable: false),
                    NetAmount = table.Column<decimal>(type: "Money", nullable: false),
                    NumberOfMoves = table.Column<int>(type: "Integer", nullable: false),
                    CurrentId = table.Column<Guid>(type: "Uuid", nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "Uuid", nullable: false),
                    SpecialCode2Id = table.Column<Guid>(type: "Uuid", nullable: false),
                    BranchId = table.Column<Guid>(type: "Uuid", nullable: false),
                    PeriodId = table.Column<Guid>(type: "Uuid", nullable: false),
                    Description = table.Column<string>(type: "Varchar", maxLength: 200, nullable: false),
                    Status = table.Column<bool>(type: "Boolean", nullable: false),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppBills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppBills_AppBranches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "AppBranches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppBills_AppCurrents_CurrentId",
                        column: x => x.CurrentId,
                        principalTable: "AppCurrents",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppBills_AppPeriods_PeriodId",
                        column: x => x.PeriodId,
                        principalTable: "AppPeriods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppBills_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppBills_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppExpenses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "Varchar", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "Varchar", maxLength: 50, nullable: false),
                    VatRate = table.Column<int>(type: "Integer", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "Money", nullable: false),
                    Barcode = table.Column<string>(type: "Varchar", maxLength: 128, nullable: false),
                    UnitId = table.Column<Guid>(type: "Uuid", nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "Uuid", nullable: false),
                    SpecialCode2Id = table.Column<Guid>(type: "Uuid", nullable: false),
                    Description = table.Column<string>(type: "Varchar", maxLength: 200, nullable: false),
                    Status = table.Column<bool>(type: "Boolean", nullable: false),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppExpenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppExpenses_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppExpenses_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppExpenses_AppUnits_UnitId",
                        column: x => x.UnitId,
                        principalTable: "AppUnits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppLabors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "Varchar", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "Varchar", maxLength: 50, nullable: false),
                    VatRate = table.Column<int>(type: "Integer", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "Money", nullable: false),
                    Barcode = table.Column<string>(type: "Varchar", maxLength: 128, nullable: false),
                    UnitId = table.Column<Guid>(type: "Uuid", nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "Uuid", nullable: false),
                    SpecialCode2Id = table.Column<Guid>(type: "Uuid", nullable: false),
                    Description = table.Column<string>(type: "Varchar", maxLength: 200, nullable: false),
                    Status = table.Column<bool>(type: "Boolean", nullable: false),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppLabors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppLabors_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppLabors_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppLabors_AppUnits_UnitId",
                        column: x => x.UnitId,
                        principalTable: "AppUnits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppStocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "Varchar", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "Varchar", maxLength: 50, nullable: false),
                    VatRate = table.Column<int>(type: "Integer", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "Money", nullable: false),
                    Barcode = table.Column<string>(type: "text", nullable: false),
                    UnitId = table.Column<Guid>(type: "uuid", nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "Uuid", nullable: false),
                    SpecialCode2Id = table.Column<Guid>(type: "Uuid", nullable: false),
                    Description = table.Column<string>(type: "Varchar", maxLength: 200, nullable: false),
                    Status = table.Column<bool>(type: "Boolean", nullable: false),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppStocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStocks_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStocks_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStocks_AppUnits_UnitId",
                        column: x => x.UnitId,
                        principalTable: "AppUnits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppCompanyParameters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "Uuid", nullable: false),
                    BranchId = table.Column<Guid>(type: "Uuid", nullable: false),
                    PeriodId = table.Column<Guid>(type: "Uuid", nullable: false),
                    WarehouseId = table.Column<Guid>(type: "Uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCompanyParameters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppCompanyParameters_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppCompanyParameters_AppBranches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "AppBranches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppCompanyParameters_AppPeriods_PeriodId",
                        column: x => x.PeriodId,
                        principalTable: "AppPeriods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppCompanyParameters_AppWarehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "AppWarehouses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppBankAccounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "Varchar", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "Varchar", maxLength: 50, nullable: false),
                    BankAccountType = table.Column<short>(type: "Smallint", nullable: false),
                    AccountNo = table.Column<string>(type: "Varchar", maxLength: 20, nullable: false),
                    IbanNo = table.Column<string>(type: "Varchar", maxLength: 26, nullable: false),
                    BankBranchId = table.Column<Guid>(type: "Uuid", nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "Uuid", nullable: false),
                    SpecialCode2Id = table.Column<Guid>(type: "Uuid", nullable: false),
                    BranchId = table.Column<Guid>(type: "Uuid", nullable: false),
                    Description = table.Column<string>(type: "Varchar", maxLength: 200, nullable: false),
                    Status = table.Column<bool>(type: "Boolean", nullable: false),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppBankAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppBankAccounts_AppBankBranches_BankBranchId",
                        column: x => x.BankBranchId,
                        principalTable: "AppBankBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppBankAccounts_AppBranches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "AppBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppBankAccounts_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppBankAccounts_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppBillTransactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BillId = table.Column<Guid>(type: "Uuid", nullable: false),
                    BillTransactionType = table.Column<short>(type: "Smallint", nullable: false),
                    StockId = table.Column<Guid>(type: "Uuid", nullable: false),
                    LaborId = table.Column<Guid>(type: "Uuid", nullable: false),
                    ExpenseId = table.Column<Guid>(type: "Uuid", nullable: false),
                    WareHouseId = table.Column<Guid>(type: "Uuid", nullable: false),
                    Quantity = table.Column<decimal>(type: "Money", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "Money", nullable: false),
                    GrossPrice = table.Column<decimal>(type: "Money", nullable: false),
                    DiscountPrice = table.Column<decimal>(type: "Money", nullable: false),
                    VatRate = table.Column<int>(type: "Integer", nullable: false),
                    ExcludesVat = table.Column<decimal>(type: "Money", nullable: false),
                    VatPrice = table.Column<decimal>(type: "Money", nullable: false),
                    NetPrice = table.Column<decimal>(type: "Money", nullable: false),
                    Description = table.Column<string>(type: "Varchar", maxLength: 200, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppBillTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppBillTransactions_AppBills_BillId",
                        column: x => x.BillId,
                        principalTable: "AppBills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppBillTransactions_AppExpenses_ExpenseId",
                        column: x => x.ExpenseId,
                        principalTable: "AppExpenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppBillTransactions_AppLabors_LaborId",
                        column: x => x.LaborId,
                        principalTable: "AppLabors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppBillTransactions_AppStocks_StockId",
                        column: x => x.StockId,
                        principalTable: "AppStocks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppBillTransactions_AppWarehouses_WareHouseId",
                        column: x => x.WareHouseId,
                        principalTable: "AppWarehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppReceipts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ReceiptType = table.Column<short>(type: "Smallint", nullable: false),
                    ReceiptNo = table.Column<string>(type: "Varchar", maxLength: 16, nullable: false),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    CurrentId = table.Column<Guid>(type: "Uuid", nullable: false),
                    SafeId = table.Column<Guid>(type: "Uuid", nullable: false),
                    BankAccountId = table.Column<Guid>(type: "Uuid", nullable: false),
                    NumberOfMoves = table.Column<int>(type: "Integer", nullable: false),
                    CheckTotal = table.Column<decimal>(type: "Money", nullable: false),
                    BondTotal = table.Column<decimal>(type: "numeric", nullable: false),
                    PosTotal = table.Column<decimal>(type: "Money", nullable: false),
                    CashTotal = table.Column<decimal>(type: "Money", nullable: false),
                    BankTotal = table.Column<decimal>(type: "Money", nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "Uuid", nullable: false),
                    SpecialCode2Id = table.Column<Guid>(type: "Uuid", nullable: false),
                    BranchId = table.Column<Guid>(type: "Uuid", nullable: false),
                    PeriodId = table.Column<Guid>(type: "Uuid", nullable: false),
                    Description = table.Column<string>(type: "Varchar", maxLength: 200, nullable: false),
                    Status = table.Column<bool>(type: "Boolean", nullable: false),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppReceipts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppReceipts_AppBankAccounts_BankAccountId",
                        column: x => x.BankAccountId,
                        principalTable: "AppBankAccounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppReceipts_AppBranches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "AppBranches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppReceipts_AppCurrents_CurrentId",
                        column: x => x.CurrentId,
                        principalTable: "AppCurrents",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppReceipts_AppPeriods_PeriodId",
                        column: x => x.PeriodId,
                        principalTable: "AppPeriods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppReceipts_AppSafes_SafeId",
                        column: x => x.SafeId,
                        principalTable: "AppSafes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppReceipts_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppReceipts_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppReceiptTransactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ReceiptId = table.Column<Guid>(type: "Uuid", nullable: false),
                    PaymentType = table.Column<short>(type: "Smallint", nullable: false),
                    TrackingNo = table.Column<string>(type: "Varchar", maxLength: 20, nullable: false),
                    CheckBankId = table.Column<Guid>(type: "Uuid", nullable: false),
                    CheckBankBranchId = table.Column<Guid>(type: "Uuid", nullable: false),
                    CheckhAccountNo = table.Column<string>(type: "Varchar", maxLength: 20, nullable: false),
                    DocumentNo = table.Column<string>(type: "Varchar", maxLength: 20, nullable: false),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    PrincipalDebtor = table.Column<string>(type: "Varchar", maxLength: 20, nullable: false),
                    Endorser = table.Column<string>(type: "Varchar", maxLength: 20, nullable: false),
                    SafeId = table.Column<Guid>(type: "Uuid", nullable: false),
                    BankAccountId = table.Column<Guid>(type: "Uuid", nullable: false),
                    Price = table.Column<decimal>(type: "Money", nullable: false),
                    DocumentStatusType = table.Column<short>(type: "Smallint", nullable: false),
                    OurOwnCocument = table.Column<bool>(type: "Boolean", nullable: false),
                    Description = table.Column<string>(type: "Varchar", maxLength: 200, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppReceiptTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppReceiptTransactions_AppBankAccounts_BankAccountId",
                        column: x => x.BankAccountId,
                        principalTable: "AppBankAccounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppReceiptTransactions_AppBankBranches_CheckBankBranchId",
                        column: x => x.CheckBankBranchId,
                        principalTable: "AppBankBranches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppReceiptTransactions_AppBanks_CheckBankId",
                        column: x => x.CheckBankId,
                        principalTable: "AppBanks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppReceiptTransactions_AppReceipts_ReceiptId",
                        column: x => x.ReceiptId,
                        principalTable: "AppReceipts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppReceiptTransactions_AppSafes_SafeId",
                        column: x => x.SafeId,
                        principalTable: "AppSafes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppBankAccounts_BankBranchId",
                table: "AppBankAccounts",
                column: "BankBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppBankAccounts_BranchId",
                table: "AppBankAccounts",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppBankAccounts_Code",
                table: "AppBankAccounts",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppBankAccounts_SpecialCode1Id",
                table: "AppBankAccounts",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppBankAccounts_SpecialCode2Id",
                table: "AppBankAccounts",
                column: "SpecialCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppBankBranches_BankId",
                table: "AppBankBranches",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_AppBankBranches_Code",
                table: "AppBankBranches",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppBankBranches_SpecialCode1Id",
                table: "AppBankBranches",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppBankBranches_SpecialCode2Id",
                table: "AppBankBranches",
                column: "SpecialCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppBanks_Code",
                table: "AppBanks",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppBanks_SpecialCode1Id",
                table: "AppBanks",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppBanks_SpecialCode2Id",
                table: "AppBanks",
                column: "SpecialCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppBills_BillNo",
                table: "AppBills",
                column: "BillNo");

            migrationBuilder.CreateIndex(
                name: "IX_AppBills_BranchId",
                table: "AppBills",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppBills_CurrentId",
                table: "AppBills",
                column: "CurrentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppBills_PeriodId",
                table: "AppBills",
                column: "PeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_AppBills_SpecialCode1Id",
                table: "AppBills",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppBills_SpecialCode2Id",
                table: "AppBills",
                column: "SpecialCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppBillTransactions_BillId",
                table: "AppBillTransactions",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_AppBillTransactions_ExpenseId",
                table: "AppBillTransactions",
                column: "ExpenseId");

            migrationBuilder.CreateIndex(
                name: "IX_AppBillTransactions_LaborId",
                table: "AppBillTransactions",
                column: "LaborId");

            migrationBuilder.CreateIndex(
                name: "IX_AppBillTransactions_StockId",
                table: "AppBillTransactions",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_AppBillTransactions_WareHouseId",
                table: "AppBillTransactions",
                column: "WareHouseId");

            migrationBuilder.CreateIndex(
                name: "IX_AppBranches_Code",
                table: "AppBranches",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppCompanyParameters_BranchId",
                table: "AppCompanyParameters",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppCompanyParameters_PeriodId",
                table: "AppCompanyParameters",
                column: "PeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_AppCompanyParameters_UserId",
                table: "AppCompanyParameters",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppCompanyParameters_WarehouseId",
                table: "AppCompanyParameters",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_AppCurrents_Code",
                table: "AppCurrents",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppCurrents_SpecialCode1Id",
                table: "AppCurrents",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppCurrents_SpecialCode2Id",
                table: "AppCurrents",
                column: "SpecialCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppExpenses_Code",
                table: "AppExpenses",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppExpenses_SpecialCode1Id",
                table: "AppExpenses",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppExpenses_SpecialCode2Id",
                table: "AppExpenses",
                column: "SpecialCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppExpenses_UnitId",
                table: "AppExpenses",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_AppLabors_Code",
                table: "AppLabors",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppLabors_SpecialCode1Id",
                table: "AppLabors",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppLabors_SpecialCode2Id",
                table: "AppLabors",
                column: "SpecialCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppLabors_UnitId",
                table: "AppLabors",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_AppPeriods_Code",
                table: "AppPeriods",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceipts_BankAccountId",
                table: "AppReceipts",
                column: "BankAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceipts_BranchId",
                table: "AppReceipts",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceipts_CurrentId",
                table: "AppReceipts",
                column: "CurrentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceipts_PeriodId",
                table: "AppReceipts",
                column: "PeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceipts_ReceiptNo",
                table: "AppReceipts",
                column: "ReceiptNo");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceipts_SafeId",
                table: "AppReceipts",
                column: "SafeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceipts_SpecialCode1Id",
                table: "AppReceipts",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceipts_SpecialCode2Id",
                table: "AppReceipts",
                column: "SpecialCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceiptTransactions_BankAccountId",
                table: "AppReceiptTransactions",
                column: "BankAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceiptTransactions_CheckBankBranchId",
                table: "AppReceiptTransactions",
                column: "CheckBankBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceiptTransactions_CheckBankId",
                table: "AppReceiptTransactions",
                column: "CheckBankId");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceiptTransactions_ReceiptId",
                table: "AppReceiptTransactions",
                column: "ReceiptId");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceiptTransactions_SafeId",
                table: "AppReceiptTransactions",
                column: "SafeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceiptTransactions_TrackingNo",
                table: "AppReceiptTransactions",
                column: "TrackingNo");

            migrationBuilder.CreateIndex(
                name: "IX_AppSafes_BranchId",
                table: "AppSafes",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppSafes_Code",
                table: "AppSafes",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppSafes_SpecialCode1Id",
                table: "AppSafes",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppSafes_SpecialCode2Id",
                table: "AppSafes",
                column: "SpecialCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppSpecialCodes_Code",
                table: "AppSpecialCodes",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppStocks_Code",
                table: "AppStocks",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppStocks_SpecialCode1Id",
                table: "AppStocks",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppStocks_SpecialCode2Id",
                table: "AppStocks",
                column: "SpecialCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppStocks_UnitId",
                table: "AppStocks",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUnits_Code",
                table: "AppUnits",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppUnits_SpecialCode1Id",
                table: "AppUnits",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppUnits_SpecialCode2Id",
                table: "AppUnits",
                column: "SpecialCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppUnits_UnitId",
                table: "AppUnits",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_AppWarehouses_BranchId",
                table: "AppWarehouses",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppWarehouses_Code",
                table: "AppWarehouses",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppWarehouses_SpecialCode1Id",
                table: "AppWarehouses",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppWarehouses_SpecialCode2Id",
                table: "AppWarehouses",
                column: "SpecialCode2Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppBillTransactions");

            migrationBuilder.DropTable(
                name: "AppCompanyParameters");

            migrationBuilder.DropTable(
                name: "AppReceiptTransactions");

            migrationBuilder.DropTable(
                name: "AppBills");

            migrationBuilder.DropTable(
                name: "AppExpenses");

            migrationBuilder.DropTable(
                name: "AppLabors");

            migrationBuilder.DropTable(
                name: "AppStocks");

            migrationBuilder.DropTable(
                name: "AppWarehouses");

            migrationBuilder.DropTable(
                name: "AppReceipts");

            migrationBuilder.DropTable(
                name: "AppUnits");

            migrationBuilder.DropTable(
                name: "AppBankAccounts");

            migrationBuilder.DropTable(
                name: "AppCurrents");

            migrationBuilder.DropTable(
                name: "AppPeriods");

            migrationBuilder.DropTable(
                name: "AppSafes");

            migrationBuilder.DropTable(
                name: "AppBankBranches");

            migrationBuilder.DropTable(
                name: "AppBranches");

            migrationBuilder.DropTable(
                name: "AppBanks");

            migrationBuilder.DropTable(
                name: "AppSpecialCodes");
        }
    }
}
