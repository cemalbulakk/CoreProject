using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccidentTypes",
                columns: table => new
                {
                    AccidentTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccidentTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sbmcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccidentTypes", x => x.AccidentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "ActorType",
                columns: table => new
                {
                    ActorTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActorTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorType", x => x.ActorTypeId);
                });

            migrationBuilder.CreateTable(
                name: "AddressTypes",
                columns: table => new
                {
                    AddressTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressTypes", x => x.AddressTypeId);
                });

            migrationBuilder.CreateTable(
                name: "AlternativeBrands",
                columns: table => new
                {
                    AlternativeBrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlternativeBrandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlternativeBrands", x => x.AlternativeBrandId);
                });

            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    BankId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.BankId);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sbmcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.BranchId);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "ClaimLabors",
                columns: table => new
                {
                    ClaimLaborId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimId = table.Column<int>(type: "int", nullable: true),
                    SparePartId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MechanicalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ElectricityPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BodyworkPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FloorPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GlassPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PaintPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    RepairPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PaintType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaintScale = table.Column<int>(type: "int", nullable: true),
                    RepairScale = table.Column<int>(type: "int", nullable: true),
                    DiscountRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DiscountPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TaxRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TaxPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TaxTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TaxFreeTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportId = table.Column<int>(type: "int", nullable: true),
                    LaborCostId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClaimLabors", x => x.ClaimLaborId);
                });

            migrationBuilder.CreateTable(
                name: "ClaimSparePartActors",
                columns: table => new
                {
                    ClaimSparePartActorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SparePartId = table.Column<int>(type: "int", nullable: true),
                    ClaimId = table.Column<int>(type: "int", nullable: true),
                    ActorTypeId = table.Column<int>(type: "int", nullable: true),
                    ActorId = table.Column<int>(type: "int", nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClaimSparePartActors", x => x.ClaimSparePartActorId);
                });

            migrationBuilder.CreateTable(
                name: "ClaimSpareParts",
                columns: table => new
                {
                    ClaimSparePartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SparePartId = table.Column<int>(type: "int", nullable: true),
                    ClaimSparePartActorId = table.Column<int>(type: "int", nullable: true),
                    ClaimId = table.Column<int>(type: "int", nullable: true),
                    SupplierOutReasonId = table.Column<int>(type: "int", nullable: true),
                    SparePartCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CupiCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SparePartName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DamageNo = table.Column<int>(type: "int", nullable: true),
                    Piece = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    InvoicePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SystemPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DiscountRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DiscountPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TaxRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TaxPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TaxTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TaxFreeTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    KktRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OperationType = table.Column<int>(type: "int", nullable: true),
                    SparePartType = table.Column<int>(type: "int", nullable: true),
                    Supply = table.Column<bool>(type: "bit", nullable: true),
                    Return = table.Column<bool>(type: "bit", nullable: true),
                    MobileRepair = table.Column<bool>(type: "bit", nullable: true),
                    Flag = table.Column<bool>(type: "bit", nullable: true),
                    SparePartEntryType = table.Column<int>(type: "int", nullable: true),
                    TedCamSparePartCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataProvider = table.Column<int>(type: "int", nullable: true),
                    ReportId = table.Column<int>(type: "int", nullable: true),
                    EquivalentBrand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartFitType = table.Column<int>(type: "int", nullable: true),
                    AlternativeSparePartId = table.Column<int>(type: "int", nullable: true),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquivalentReasonTypeId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClaimSpareParts", x => x.ClaimSparePartId);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    ColorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.ColorId);
                });

            migrationBuilder.CreateTable(
                name: "ContractDefinitions",
                columns: table => new
                {
                    ContractDefinitionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Definition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractDefinitions", x => x.ContractDefinitionId);
                });

            migrationBuilder.CreateTable(
                name: "ControlTypes",
                columns: table => new
                {
                    ControlTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ControlTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlTypes", x => x.ControlTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "DamageCauses",
                columns: table => new
                {
                    DamageCauseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DamageCauseCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchId = table.Column<int>(type: "int", nullable: true),
                    Sbmcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DamageCauseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuaranteeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DamageCauses", x => x.DamageCauseId);
                });

            migrationBuilder.CreateTable(
                name: "DamageImageTypes",
                columns: table => new
                {
                    DamageImageTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DamageImageTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DamageImageTypes", x => x.DamageImageTypeId);
                });

            migrationBuilder.CreateTable(
                name: "DamageTypes",
                columns: table => new
                {
                    DamageTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DamageTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sbmcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DamageTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DamageTypes", x => x.DamageTypeId);
                });

            migrationBuilder.CreateTable(
                name: "DocumentStatuses",
                columns: table => new
                {
                    DocumentStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentStatusName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentStatuses", x => x.DocumentStatusId);
                });

            migrationBuilder.CreateTable(
                name: "DocumentTypes",
                columns: table => new
                {
                    DocumentTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypes", x => x.DocumentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    FileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileType = table.Column<int>(type: "int", nullable: true),
                    PolicyId = table.Column<int>(type: "int", nullable: true),
                    DamageDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DamageTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DamageCountryId = table.Column<int>(type: "int", nullable: true),
                    DamageCityId = table.Column<int>(type: "int", nullable: true),
                    DamageRegionId = table.Column<int>(type: "int", nullable: true),
                    DamageDistrictId = table.Column<int>(type: "int", nullable: true),
                    DamageTownId = table.Column<int>(type: "int", nullable: true),
                    DamagePlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DamageForm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccidentDetectionRecordNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.FileId);
                });

            migrationBuilder.CreateTable(
                name: "FuelTypes",
                columns: table => new
                {
                    FuelTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuelTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelTypes", x => x.FuelTypeId);
                });

            migrationBuilder.CreateTable(
                name: "IdentityTypes",
                columns: table => new
                {
                    IdentityTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sbmcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentityTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityTypes", x => x.IdentityTypeId);
                });

            migrationBuilder.CreateTable(
                name: "LaborTypes",
                columns: table => new
                {
                    LaborTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LaborTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaborTypes", x => x.LaborTypeId);
                });

            migrationBuilder.CreateTable(
                name: "OperationTypes",
                columns: table => new
                {
                    OperationTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationTypes", x => x.OperationTypeId);
                });

            migrationBuilder.CreateTable(
                name: "ParentTypes",
                columns: table => new
                {
                    ParentTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentTypes", x => x.ParentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimId = table.Column<int>(type: "int", nullable: true),
                    PaymentTypeId = table.Column<int>(type: "int", nullable: true),
                    DetailNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuaranteeNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActorTypeId = table.Column<int>(type: "int", nullable: true),
                    CreditorTypeId = table.Column<int>(type: "int", nullable: true),
                    CreditorIdentityTypeId = table.Column<int>(type: "int", nullable: true),
                    CreditorIdentityNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditorSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditorIbanNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditorBirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActorFirmId = table.Column<int>(type: "int", nullable: true),
                    ActorCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchOfficeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvioceDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InvoiceUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SparePartsTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LabourTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SparePartsKdvamount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LabourKdvamount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SubTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ExemptionAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PaymentConfirm = table.Column<bool>(type: "bit", nullable: true),
                    ConfirmDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PaymentStatusId = table.Column<int>(type: "int", nullable: true),
                    PaymentSubStatusId = table.Column<int>(type: "int", nullable: true),
                    ExpertAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ExpertCostAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CashFreeDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DefectDiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SubGuaranteeTypeId = table.Column<int>(type: "int", nullable: true),
                    TevkifatTypeId = table.Column<int>(type: "int", nullable: true),
                    TevkifatCalculate = table.Column<bool>(type: "bit", nullable: true),
                    SparePartTevkifatRateId = table.Column<int>(type: "int", nullable: true),
                    SparePartTevkifatAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LabourTevkifatRateId = table.Column<int>(type: "int", nullable: true),
                    LabourTevkifatAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentId);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonTypeId = table.Column<int>(type: "int", nullable: true),
                    ClaimId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentityNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentityType = table.Column<int>(type: "int", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PhoneNumber1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobilePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Iban = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    DistrictId = table.Column<int>(type: "int", nullable: true),
                    TownId = table.Column<int>(type: "int", nullable: true),
                    BankId = table.Column<int>(type: "int", nullable: true),
                    BankBranchId = table.Column<int>(type: "int", nullable: true),
                    TaxCityId = table.Column<int>(type: "int", nullable: true),
                    TaxOfficeId = table.Column<int>(type: "int", nullable: true),
                    LicenseNo = table.Column<int>(type: "int", nullable: true),
                    LicenseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LicenseCityId = table.Column<int>(type: "int", nullable: true),
                    LicenseDistrictId = table.Column<int>(type: "int", nullable: true),
                    LicenseClass = table.Column<int>(type: "int", nullable: true),
                    LicenseEnough = table.Column<bool>(type: "bit", nullable: true),
                    AlcoholStatus = table.Column<bool>(type: "bit", nullable: true),
                    AlcoholPromile = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "PhoneTypes",
                columns: table => new
                {
                    PhoneTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneTypes", x => x.PhoneTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Policies",
                columns: table => new
                {
                    PolicyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileId = table.Column<int>(type: "int", nullable: true),
                    PolicyNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PolicyAddNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RenewalNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PolicyStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PolicyEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PolicyArrangementDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TariffCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdendumNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdendumDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AgencyId = table.Column<int>(type: "int", nullable: true),
                    ProfessionDiscountCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfessionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SparePartType = table.Column<int>(type: "int", nullable: true),
                    Pledge = table.Column<bool>(type: "bit", nullable: true),
                    PledgeOwner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PledgeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommodityPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AccidentMaterial = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MaterialPerVehicle = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AccidentPerMaterial = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TreatmentPerPerson = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    InjuryDeathPerPerson = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    InjuryDeathsPerAccident = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Insurer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExemptionRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    RepairPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InflationKloz = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DiscretionaryLiability = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    YearlyGuaranteeLimit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Exemption = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ExemptionAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalInsuranceFee = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AdditionalHardwareFee = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VehicleCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VehicleBodyFee = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policies", x => x.PolicyId);
                });

            migrationBuilder.CreateTable(
                name: "ProductBrandTypes",
                columns: table => new
                {
                    ProductBrandTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductBrandTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBrandTypes", x => x.ProductBrandTypeId);
                });

            migrationBuilder.CreateTable(
                name: "RecordTypes",
                columns: table => new
                {
                    RecordTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecordTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecordTypes", x => x.RecordTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    ReportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimId = table.Column<int>(type: "int", nullable: true),
                    ActorFirmId = table.Column<int>(type: "int", nullable: true),
                    ReportNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportType = table.Column<int>(type: "int", nullable: true),
                    ClosedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReportUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportCancel = table.Column<bool>(type: "bit", nullable: true),
                    TramerTrackingNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TramerApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TramerReportNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.ReportId);
                });

            migrationBuilder.CreateTable(
                name: "ReturnStatusTypes",
                columns: table => new
                {
                    ReturnStatusTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReturnStatusTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnStatusTypes", x => x.ReturnStatusTypeId);
                });

            migrationBuilder.CreateTable(
                name: "SparePartTypes",
                columns: table => new
                {
                    SparePartTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SparePartTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SparePartTypes", x => x.SparePartTypeId);
                });

            migrationBuilder.CreateTable(
                name: "SupplierTypes",
                columns: table => new
                {
                    SupplierTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierTypes", x => x.SupplierTypeId);
                });

            migrationBuilder.CreateTable(
                name: "SupplierWorkTypes",
                columns: table => new
                {
                    SupplierWorkTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierWorkTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierWorkTypes", x => x.SupplierWorkTypeId);
                });

            migrationBuilder.CreateTable(
                name: "TaxRates",
                columns: table => new
                {
                    TaxRateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxRates", x => x.TaxRateId);
                });

            migrationBuilder.CreateTable(
                name: "Tenants",
                columns: table => new
                {
                    TenantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenantTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenantWeb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenants", x => x.TenantId);
                });

            migrationBuilder.CreateTable(
                name: "UserPasswordHistories",
                columns: table => new
                {
                    UserPasswordHistoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserPasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPasswordHistories", x => x.UserPasswordHistoryId);
                    table.ForeignKey(
                        name: "FK_UserPasswordHistories_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTypes",
                columns: table => new
                {
                    UserTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTypes", x => x.UserTypeId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleClasses",
                columns: table => new
                {
                    VehicleClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleClassName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleClassCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleClasses", x => x.VehicleClassId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleTypes",
                columns: table => new
                {
                    VehicleTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleTypes", x => x.VehicleTypeId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleUsageTypes",
                columns: table => new
                {
                    VehicleUsageTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OtherCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleUsageTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleUsageTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleUsageTypes", x => x.VehicleUsageTypeId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleVariants",
                columns: table => new
                {
                    VehicleVariantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VariantNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VariantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleVariants", x => x.VehicleVariantId);
                });

            migrationBuilder.CreateTable(
                name: "BankBranches",
                columns: table => new
                {
                    BankBranchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankBranchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankBranches", x => x.BankBranchId);
                    table.ForeignKey(
                        name: "FK_BankBranches_Banks_BankId",
                        column: x => x.BankId,
                        principalTable: "Banks",
                        principalColumn: "BankId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    ModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    ModelYear = table.Column<int>(type: "int", nullable: false),
                    MarketPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.ModelId);
                    table.ForeignKey(
                        name: "FK_Models_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    RegionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegionCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.RegionId);
                    table.ForeignKey(
                        name: "FK_Regions_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Claims",
                columns: table => new
                {
                    ClaimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileId = table.Column<int>(type: "int", nullable: true),
                    ClaimStatusId = table.Column<int>(type: "int", nullable: true),
                    SubClaimStatusId = table.Column<int>(type: "int", nullable: true),
                    ExternalSystemId = table.Column<int>(type: "int", nullable: true),
                    ClaimOrderNo = table.Column<int>(type: "int", nullable: true),
                    BranchId = table.Column<int>(type: "int", nullable: true),
                    DamageCauseId = table.Column<int>(type: "int", nullable: false),
                    FormOfDamageId = table.Column<int>(type: "int", nullable: true),
                    DamageTypeId = table.Column<int>(type: "int", nullable: true),
                    ClaimDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClaimTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuaranteeOrderNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompensationClaimTypeId = table.Column<int>(type: "int", nullable: true),
                    OutstandingDamage = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AbuseStatusId = table.Column<int>(type: "int", nullable: true),
                    ClaimEntryType = table.Column<int>(type: "int", nullable: true),
                    Suspect = table.Column<bool>(type: "bit", nullable: true),
                    SuspectCause = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubGuaranteeType = table.Column<int>(type: "int", nullable: true),
                    GuaranteeCodeId = table.Column<int>(type: "int", nullable: true),
                    DepreciationAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Depreciation = table.Column<bool>(type: "bit", nullable: true),
                    PayImmediately = table.Column<bool>(type: "bit", nullable: true),
                    PhysicalFile = table.Column<bool>(type: "bit", nullable: true),
                    PhysicalFileAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SbmtransactionRefNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SbmexpertAssignmentStatusId = table.Column<int>(type: "int", nullable: true),
                    InformantType = table.Column<int>(type: "int", nullable: true),
                    Research = table.Column<bool>(type: "bit", nullable: true),
                    RemoteDamage = table.Column<bool>(type: "bit", nullable: true),
                    ExpertiseRequestDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpertiseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claims", x => x.ClaimId);
                    table.ForeignKey(
                        name: "FK_Claims_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId");
                    table.ForeignKey(
                        name: "FK_Claims_DamageCauses_DamageCauseId",
                        column: x => x.DamageCauseId,
                        principalTable: "DamageCauses",
                        principalColumn: "DamageCauseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Claims_DamageTypes_DamageTypeId",
                        column: x => x.DamageTypeId,
                        principalTable: "DamageTypes",
                        principalColumn: "DamageTypeId");
                    table.ForeignKey(
                        name: "FK_Claims_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "FileId");
                });

            migrationBuilder.CreateTable(
                name: "Labors",
                columns: table => new
                {
                    LaborId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LaborName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LaborTypeId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Labors", x => x.LaborId);
                    table.ForeignKey(
                        name: "FK_Labors_LaborTypes_LaborTypeId",
                        column: x => x.LaborTypeId,
                        principalTable: "LaborTypes",
                        principalColumn: "LaborTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DefinitionParameters",
                columns: table => new
                {
                    DefinitionParameterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    ParentTypeId = table.Column<int>(type: "int", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefinitionParameters", x => x.DefinitionParameterId);
                    table.ForeignKey(
                        name: "FK_DefinitionParameters_ParentTypes_ParentTypeId",
                        column: x => x.ParentTypeId,
                        principalTable: "ParentTypes",
                        principalColumn: "ParentTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    EmailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailParentId = table.Column<int>(type: "int", nullable: false),
                    ParentTypeId = table.Column<int>(type: "int", nullable: false),
                    EmailValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.EmailId);
                    table.ForeignKey(
                        name: "FK_Emails_ParentTypes_ParentTypeId",
                        column: x => x.ParentTypeId,
                        principalTable: "ParentTypes",
                        principalColumn: "ParentTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    PhoneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneTypeId = table.Column<int>(type: "int", nullable: false),
                    ParentTypeId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.PhoneId);
                    table.ForeignKey(
                        name: "FK_Phones_ParentTypes_ParentTypeId",
                        column: x => x.ParentTypeId,
                        principalTable: "ParentTypes",
                        principalColumn: "ParentTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductBrands",
                columns: table => new
                {
                    ProductBrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductBrandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductBrandTypeId = table.Column<int>(type: "int", nullable: false),
                    CertificateUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBrands", x => x.ProductBrandId);
                    table.ForeignKey(
                        name: "FK_ProductBrands_ProductBrandTypes_ProductBrandTypeId",
                        column: x => x.ProductBrandTypeId,
                        principalTable: "ProductBrandTypes",
                        principalColumn: "ProductBrandTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    DocumentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentStatusId = table.Column<int>(type: "int", nullable: false),
                    DocumentTypeId = table.Column<int>(type: "int", nullable: false),
                    RecordTypeId = table.Column<int>(type: "int", nullable: false),
                    OrderNumber = table.Column<int>(type: "int", nullable: false),
                    SbmrevocationCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RevocationOrderNumber = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.DocumentId);
                    table.ForeignKey(
                        name: "FK_Documents_DocumentStatuses_DocumentStatusId",
                        column: x => x.DocumentStatusId,
                        principalTable: "DocumentStatuses",
                        principalColumn: "DocumentStatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Documents_DocumentTypes_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentTypes",
                        principalColumn: "DocumentTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Documents_RecordTypes_RecordTypeId",
                        column: x => x.RecordTypeId,
                        principalTable: "RecordTypes",
                        principalColumn: "RecordTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpareParts",
                columns: table => new
                {
                    SparePartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SparePartCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SparePartName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SparePartTypeId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpareParts", x => x.SparePartId);
                    table.ForeignKey(
                        name: "FK_SpareParts_SparePartTypes_SparePartTypeId",
                        column: x => x.SparePartTypeId,
                        principalTable: "SparePartTypes",
                        principalColumn: "SparePartTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    ContractId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: false),
                    ContractParentId = table.Column<int>(type: "int", nullable: false),
                    ParentTypeId = table.Column<int>(type: "int", nullable: false),
                    ContractParentCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SourceCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContractStatue = table.Column<bool>(type: "bit", nullable: false),
                    OriginalContractUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContractBeginDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContractEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContractLimit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.ContractId);
                    table.ForeignKey(
                        name: "FK_Contracts_ParentTypes_ParentTypeId",
                        column: x => x.ParentTypeId,
                        principalTable: "ParentTypes",
                        principalColumn: "ParentTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contracts_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenantId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customers_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupplierTypeContractDefinationAssignments",
                columns: table => new
                {
                    SupplierTypeContractDefinationAssignmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: false),
                    ContractDefinitionId = table.Column<int>(type: "int", nullable: false),
                    SupplierTypeId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierTypeContractDefinationAssignments", x => x.SupplierTypeContractDefinationAssignmentId);
                    table.ForeignKey(
                        name: "FK_SupplierTypeContractDefinationAssignments_ContractDefinitions_ContractDefinitionId",
                        column: x => x.ContractDefinitionId,
                        principalTable: "ContractDefinitions",
                        principalColumn: "ContractDefinitionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierTypeContractDefinationAssignments_SupplierTypes_SupplierTypeId",
                        column: x => x.SupplierTypeId,
                        principalTable: "SupplierTypes",
                        principalColumn: "SupplierTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierTypeContractDefinationAssignments_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehicleTypeBrandAssignments",
                columns: table => new
                {
                    VehicleTypeBrandAssignmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    VehicleTypeId = table.Column<int>(type: "int", nullable: false),
                    Sbmcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleTypeBrandAssignments", x => x.VehicleTypeBrandAssignmentId);
                    table.ForeignKey(
                        name: "FK_VehicleTypeBrandAssignments_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VehicleTypeBrandAssignments_VehicleTypes_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleTypes",
                        principalColumn: "VehicleTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    DistrictId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.DistrictId);
                    table.ForeignKey(
                        name: "FK_Districts_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaxOffices",
                columns: table => new
                {
                    TaxOfficeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxOfficeCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxOfficeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxOffices", x => x.TaxOfficeId);
                    table.ForeignKey(
                        name: "FK_TaxOffices_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegionCities",
                columns: table => new
                {
                    RegionCityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegionCities", x => x.RegionCityId);
                    table.ForeignKey(
                        name: "FK_RegionCities_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegionCities_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "RegionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    ActorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimId = table.Column<int>(type: "int", nullable: true),
                    ActorTypeId = table.Column<int>(type: "int", nullable: true),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    ActorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssignmentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.ActorId);
                    table.ForeignKey(
                        name: "FK_Actors_ActorType_ActorTypeId",
                        column: x => x.ActorTypeId,
                        principalTable: "ActorType",
                        principalColumn: "ActorTypeId");
                    table.ForeignKey(
                        name: "FK_Actors_Claims_ClaimId",
                        column: x => x.ClaimId,
                        principalTable: "Claims",
                        principalColumn: "ClaimId");
                    table.ForeignKey(
                        name: "FK_Actors_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "TenantId");
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehicleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonTypeId = table.Column<int>(type: "int", nullable: true),
                    ClaimId = table.Column<int>(type: "int", nullable: true),
                    PersonId = table.Column<int>(type: "int", nullable: true),
                    VehicleTypeId = table.Column<int>(type: "int", nullable: true),
                    VehicleUsageTypeId = table.Column<int>(type: "int", nullable: true),
                    VehicleBrandId = table.Column<int>(type: "int", nullable: true),
                    VehicleBrandTypeId = table.Column<int>(type: "int", nullable: true),
                    VehicleVariantId = table.Column<int>(type: "int", nullable: true),
                    VehicleModelYear = table.Column<int>(type: "int", nullable: true),
                    VehiclePlateCityId = table.Column<int>(type: "int", nullable: true),
                    VehicleForeignPlate = table.Column<bool>(type: "bit", nullable: true),
                    VehiclePlateNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleChassisNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleMotorNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleRegistrationSerialNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleKm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleTrafficReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VehicleLoadLimit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VehicleWeight = table.Column<int>(type: "int", nullable: true),
                    ColourId = table.Column<int>(type: "int", nullable: true),
                    UmcCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GtbrandId = table.Column<int>(type: "int", nullable: true),
                    GtmodelId = table.Column<int>(type: "int", nullable: true),
                    GtmotorId = table.Column<int>(type: "int", nullable: true),
                    GtgearBoxId = table.Column<int>(type: "int", nullable: true),
                    GtbodyId = table.Column<int>(type: "int", nullable: true),
                    GtestimateNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChassisSolutionControl = table.Column<bool>(type: "bit", nullable: true),
                    VehicleRegistrationSerialCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleClassId = table.Column<int>(type: "int", nullable: true),
                    SalvagePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MarketPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VehicleRegistrationCertificate = table.Column<bool>(type: "bit", nullable: true),
                    GraphicalInterfaceLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraphicalInterfaceId = table.Column<int>(type: "int", nullable: true),
                    GtlabourGraphicUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GtlabourEstimateNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vinquery = table.Column<bool>(type: "bit", nullable: true),
                    VinqueryBrand = table.Column<bool>(type: "bit", nullable: true),
                    GtmodelLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicensedTemporaryStorage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicensedTemporaryStorageDeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LicensedProcessingFacilityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicensedProcessingFacilityDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CertificateOfWithdrawalFromTraffic = table.Column<bool>(type: "bit", nullable: true),
                    TrafficPullDocumentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrafficPullDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RepairTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Scrap = table.Column<bool>(type: "bit", nullable: true),
                    FileManagerScrap = table.Column<bool>(type: "bit", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehicleId);
                    table.ForeignKey(
                        name: "FK_Vehicles_Claims_ClaimId",
                        column: x => x.ClaimId,
                        principalTable: "Claims",
                        principalColumn: "ClaimId");
                    table.ForeignKey(
                        name: "FK_Vehicles_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "PersonId");
                    table.ForeignKey(
                        name: "FK_Vehicles_VehicleTypes_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleTypes",
                        principalColumn: "VehicleTypeId");
                    table.ForeignKey(
                        name: "FK_Vehicles_VehicleUsageTypes_VehicleUsageTypeId",
                        column: x => x.VehicleUsageTypeId,
                        principalTable: "VehicleUsageTypes",
                        principalColumn: "VehicleUsageTypeId");
                });

            migrationBuilder.CreateTable(
                name: "BranchDocumentAssignments",
                columns: table => new
                {
                    BranchDocumentAssignmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    DocumentId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchDocumentAssignments", x => x.BranchDocumentAssignmentId);
                    table.ForeignKey(
                        name: "FK_BranchDocumentAssignments_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchDocumentAssignments_Documents_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Documents",
                        principalColumn: "DocumentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FileDocumentAssignments",
                columns: table => new
                {
                    FileDocumentAssignmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentId = table.Column<int>(type: "int", nullable: false),
                    FileId = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileDocumentAssignments", x => x.FileDocumentAssignmentId);
                    table.ForeignKey(
                        name: "FK_FileDocumentAssignments_Documents_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Documents",
                        principalColumn: "DocumentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FileDocumentAssignments_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "FileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MissingDocuments",
                columns: table => new
                {
                    MissingDocumentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileId = table.Column<int>(type: "int", nullable: false),
                    DocumentId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailId = table.Column<int>(type: "int", nullable: false),
                    MissingDocumentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MissingDocuments", x => x.MissingDocumentId);
                    table.ForeignKey(
                        name: "FK_MissingDocuments_Documents_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Documents",
                        principalColumn: "DocumentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MissingDocuments_Emails_EmailId",
                        column: x => x.EmailId,
                        principalTable: "Emails",
                        principalColumn: "EmailId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MissingDocuments_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "FileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceInspectorDocuments",
                columns: table => new
                {
                    ServiceInspectorDocumentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileId = table.Column<int>(type: "int", nullable: false),
                    DocumentId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceInspectorDocuments", x => x.ServiceInspectorDocumentId);
                    table.ForeignKey(
                        name: "FK_ServiceInspectorDocuments_Documents_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Documents",
                        principalColumn: "DocumentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceInspectorDocuments_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "FileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TenderPoolDocuments",
                columns: table => new
                {
                    TenderPoolDocumentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileId = table.Column<int>(type: "int", nullable: false),
                    DocumentId = table.Column<int>(type: "int", nullable: false),
                    Transferred = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TenderPoolDocuments", x => x.TenderPoolDocumentId);
                    table.ForeignKey(
                        name: "FK_TenderPoolDocuments_Documents_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Documents",
                        principalColumn: "DocumentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TenderPoolDocuments_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "FileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContractWorkTypeBrandAssignments",
                columns: table => new
                {
                    ContractWorkTypeBrandAssignmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    ContractId = table.Column<int>(type: "int", nullable: false),
                    VehicleTypeId = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: false),
                    WorkTypeId = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SparePartDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RepairDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractWorkTypeBrandAssignments", x => x.ContractWorkTypeBrandAssignmentId);
                    table.ForeignKey(
                        name: "FK_ContractWorkTypeBrandAssignments_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContractWorkTypeBrandAssignments_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContractWorkTypeBrandAssignments_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContractWorkTypeBrandAssignments_Contracts_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contracts",
                        principalColumn: "ContractId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContractWorkTypeBrandAssignments_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "DistrictId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContractWorkTypeBrandAssignments_VehicleTypes_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleTypes",
                        principalColumn: "VehicleTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Town",
                columns: table => new
                {
                    TownId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TownName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Town", x => x.TownId);
                    table.ForeignKey(
                        name: "FK_Town_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "DistrictId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierTypeId = table.Column<int>(type: "int", nullable: false),
                    TenantId = table.Column<int>(type: "int", nullable: false),
                    SupplierTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierInvoiceTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Web = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessEnterprise = table.Column<bool>(type: "bit", nullable: false),
                    TaxOfficeId = table.Column<int>(type: "int", nullable: false),
                    TaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentityId = table.Column<int>(type: "int", nullable: false),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CertificateNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentSupplierId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierId);
                    table.ForeignKey(
                        name: "FK_Suppliers_SupplierTypes_SupplierTypeId",
                        column: x => x.SupplierTypeId,
                        principalTable: "SupplierTypes",
                        principalColumn: "SupplierTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Suppliers_TaxOffices_TaxOfficeId",
                        column: x => x.TaxOfficeId,
                        principalTable: "TaxOffices",
                        principalColumn: "TaxOfficeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Suppliers_Tenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "Tenants",
                        principalColumn: "TenantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressTypeId = table.Column<int>(type: "int", nullable: false),
                    AddressParentId = table.Column<int>(type: "int", nullable: false),
                    ParentTypeId = table.Column<int>(type: "int", nullable: false),
                    AddressLine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: false),
                    TownId = table.Column<int>(type: "int", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Addresses_AddressTypes_AddressTypeId",
                        column: x => x.AddressTypeId,
                        principalTable: "AddressTypes",
                        principalColumn: "AddressTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addresses_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addresses_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addresses_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "DistrictId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addresses_ParentTypes_ParentTypeId",
                        column: x => x.ParentTypeId,
                        principalTable: "ParentTypes",
                        principalColumn: "ParentTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addresses_Town_TownId",
                        column: x => x.TownId,
                        principalTable: "Town",
                        principalColumn: "TownId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupplierLabors",
                columns: table => new
                {
                    SupplierLaborId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    LaborId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierLabors", x => x.SupplierLaborId);
                    table.ForeignKey(
                        name: "FK_SupplierLabors_Labors_LaborId",
                        column: x => x.LaborId,
                        principalTable: "Labors",
                        principalColumn: "LaborId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierLabors_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupplierSpareParts",
                columns: table => new
                {
                    SupplierSparePartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    SparePartId = table.Column<int>(type: "int", nullable: false),
                    SupplierPartCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FollowMainNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductBrandId = table.Column<int>(type: "int", nullable: false),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    CertificationInstitutionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandQualityDocumentNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductEquivalentCertificateNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentIssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DocumentEndDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierSpareParts", x => x.SupplierSparePartId);
                    table.ForeignKey(
                        name: "FK_SupplierSpareParts_ProductBrands_ProductBrandId",
                        column: x => x.ProductBrandId,
                        principalTable: "ProductBrands",
                        principalColumn: "ProductBrandId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierSpareParts_SpareParts_SparePartId",
                        column: x => x.SparePartId,
                        principalTable: "SpareParts",
                        principalColumn: "SparePartId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierSpareParts_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actors_ActorTypeId",
                table: "Actors",
                column: "ActorTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Actors_ClaimId",
                table: "Actors",
                column: "ClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_Actors_TenantId",
                table: "Actors",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_AddressTypeId",
                table: "Addresses",
                column: "AddressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CityId",
                table: "Addresses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CountryId",
                table: "Addresses",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_DistrictId",
                table: "Addresses",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ParentTypeId",
                table: "Addresses",
                column: "ParentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_TownId",
                table: "Addresses",
                column: "TownId");

            migrationBuilder.CreateIndex(
                name: "IX_BankBranches_BankId",
                table: "BankBranches",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchDocumentAssignments_BranchId",
                table: "BranchDocumentAssignments",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchDocumentAssignments_DocumentId",
                table: "BranchDocumentAssignments",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Claims_BranchId",
                table: "Claims",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Claims_DamageCauseId",
                table: "Claims",
                column: "DamageCauseId");

            migrationBuilder.CreateIndex(
                name: "IX_Claims_DamageTypeId",
                table: "Claims",
                column: "DamageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Claims_FileId",
                table: "Claims",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ParentTypeId",
                table: "Contracts",
                column: "ParentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_TenantId",
                table: "Contracts",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractWorkTypeBrandAssignments_BranchId",
                table: "ContractWorkTypeBrandAssignments",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractWorkTypeBrandAssignments_BrandId",
                table: "ContractWorkTypeBrandAssignments",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractWorkTypeBrandAssignments_CityId",
                table: "ContractWorkTypeBrandAssignments",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractWorkTypeBrandAssignments_ContractId",
                table: "ContractWorkTypeBrandAssignments",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractWorkTypeBrandAssignments_DistrictId",
                table: "ContractWorkTypeBrandAssignments",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractWorkTypeBrandAssignments_VehicleTypeId",
                table: "ContractWorkTypeBrandAssignments",
                column: "VehicleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_TenantId",
                table: "Customers",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_DefinitionParameters_ParentTypeId",
                table: "DefinitionParameters",
                column: "ParentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_CityId",
                table: "Districts",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_DocumentStatusId",
                table: "Documents",
                column: "DocumentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_DocumentTypeId",
                table: "Documents",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_RecordTypeId",
                table: "Documents",
                column: "RecordTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_ParentTypeId",
                table: "Emails",
                column: "ParentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FileDocumentAssignments_DocumentId",
                table: "FileDocumentAssignments",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_FileDocumentAssignments_FileId",
                table: "FileDocumentAssignments",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_Labors_LaborTypeId",
                table: "Labors",
                column: "LaborTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MissingDocuments_DocumentId",
                table: "MissingDocuments",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_MissingDocuments_EmailId",
                table: "MissingDocuments",
                column: "EmailId");

            migrationBuilder.CreateIndex(
                name: "IX_MissingDocuments_FileId",
                table: "MissingDocuments",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_BrandId",
                table: "Models",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_ParentTypeId",
                table: "Phones",
                column: "ParentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductBrands_ProductBrandTypeId",
                table: "ProductBrands",
                column: "ProductBrandTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RegionCities_CityId",
                table: "RegionCities",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_RegionCities_RegionId",
                table: "RegionCities",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Regions_CountryId",
                table: "Regions",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceInspectorDocuments_DocumentId",
                table: "ServiceInspectorDocuments",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceInspectorDocuments_FileId",
                table: "ServiceInspectorDocuments",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_SpareParts_SparePartTypeId",
                table: "SpareParts",
                column: "SparePartTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierLabors_LaborId",
                table: "SupplierLabors",
                column: "LaborId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierLabors_SupplierId",
                table: "SupplierLabors",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_SupplierTypeId",
                table: "Suppliers",
                column: "SupplierTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_TaxOfficeId",
                table: "Suppliers",
                column: "TaxOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_TenantId",
                table: "Suppliers",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierSpareParts_ProductBrandId",
                table: "SupplierSpareParts",
                column: "ProductBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierSpareParts_SparePartId",
                table: "SupplierSpareParts",
                column: "SparePartId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierSpareParts_SupplierId",
                table: "SupplierSpareParts",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierTypeContractDefinationAssignments_ContractDefinitionId",
                table: "SupplierTypeContractDefinationAssignments",
                column: "ContractDefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierTypeContractDefinationAssignments_SupplierTypeId",
                table: "SupplierTypeContractDefinationAssignments",
                column: "SupplierTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierTypeContractDefinationAssignments_TenantId",
                table: "SupplierTypeContractDefinationAssignments",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxOffices_CityId",
                table: "TaxOffices",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_TenderPoolDocuments_DocumentId",
                table: "TenderPoolDocuments",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_TenderPoolDocuments_FileId",
                table: "TenderPoolDocuments",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_Town_DistrictId",
                table: "Town",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPasswordHistories_UserId",
                table: "UserPasswordHistories",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_ClaimId",
                table: "Vehicles",
                column: "ClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_PersonId",
                table: "Vehicles",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleTypeId",
                table: "Vehicles",
                column: "VehicleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleUsageTypeId",
                table: "Vehicles",
                column: "VehicleUsageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleTypeBrandAssignments_BrandId",
                table: "VehicleTypeBrandAssignments",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleTypeBrandAssignments_VehicleTypeId",
                table: "VehicleTypeBrandAssignments",
                column: "VehicleTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccidentTypes");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "AlternativeBrands");

            migrationBuilder.DropTable(
                name: "BankBranches");

            migrationBuilder.DropTable(
                name: "BranchDocumentAssignments");

            migrationBuilder.DropTable(
                name: "ClaimLabors");

            migrationBuilder.DropTable(
                name: "ClaimSparePartActors");

            migrationBuilder.DropTable(
                name: "ClaimSpareParts");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "ContractWorkTypeBrandAssignments");

            migrationBuilder.DropTable(
                name: "ControlTypes");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "DamageImageTypes");

            migrationBuilder.DropTable(
                name: "DefinitionParameters");

            migrationBuilder.DropTable(
                name: "FileDocumentAssignments");

            migrationBuilder.DropTable(
                name: "FuelTypes");

            migrationBuilder.DropTable(
                name: "IdentityTypes");

            migrationBuilder.DropTable(
                name: "MissingDocuments");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "OperationTypes");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Phones");

            migrationBuilder.DropTable(
                name: "PhoneTypes");

            migrationBuilder.DropTable(
                name: "Policies");

            migrationBuilder.DropTable(
                name: "RegionCities");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "ReturnStatusTypes");

            migrationBuilder.DropTable(
                name: "ServiceInspectorDocuments");

            migrationBuilder.DropTable(
                name: "SupplierLabors");

            migrationBuilder.DropTable(
                name: "SupplierSpareParts");

            migrationBuilder.DropTable(
                name: "SupplierTypeContractDefinationAssignments");

            migrationBuilder.DropTable(
                name: "SupplierWorkTypes");

            migrationBuilder.DropTable(
                name: "TaxRates");

            migrationBuilder.DropTable(
                name: "TenderPoolDocuments");

            migrationBuilder.DropTable(
                name: "UserPasswordHistories");

            migrationBuilder.DropTable(
                name: "UserTypes");

            migrationBuilder.DropTable(
                name: "VehicleClasses");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "VehicleTypeBrandAssignments");

            migrationBuilder.DropTable(
                name: "VehicleVariants");

            migrationBuilder.DropTable(
                name: "ActorType");

            migrationBuilder.DropTable(
                name: "AddressTypes");

            migrationBuilder.DropTable(
                name: "Town");

            migrationBuilder.DropTable(
                name: "Banks");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "Labors");

            migrationBuilder.DropTable(
                name: "ProductBrands");

            migrationBuilder.DropTable(
                name: "SpareParts");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "ContractDefinitions");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Claims");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "VehicleUsageTypes");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "VehicleTypes");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "ParentTypes");

            migrationBuilder.DropTable(
                name: "LaborTypes");

            migrationBuilder.DropTable(
                name: "ProductBrandTypes");

            migrationBuilder.DropTable(
                name: "SparePartTypes");

            migrationBuilder.DropTable(
                name: "SupplierTypes");

            migrationBuilder.DropTable(
                name: "TaxOffices");

            migrationBuilder.DropTable(
                name: "Tenants");

            migrationBuilder.DropTable(
                name: "DocumentStatuses");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.DropTable(
                name: "RecordTypes");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "DamageCauses");

            migrationBuilder.DropTable(
                name: "DamageTypes");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
