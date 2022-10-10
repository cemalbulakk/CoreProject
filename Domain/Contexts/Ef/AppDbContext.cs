using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using File = Domain.Entities.File;

namespace Domain.Contexts.Ef;

public partial class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public virtual DbSet<AccidentType> AccidentTypes { get; set; } = null!;
    public virtual DbSet<Actor> Actors { get; set; } = null!;
    public virtual DbSet<Address> Addresses { get; set; } = null!;
    public virtual DbSet<AddressType> AddressTypes { get; set; } = null!;
    public virtual DbSet<AlternativeBrand> AlternativeBrands { get; set; } = null!;
    public virtual DbSet<Bank> Banks { get; set; } = null!;
    public virtual DbSet<BankBranch> BankBranches { get; set; } = null!;
    public virtual DbSet<Branch> Branches { get; set; } = null!;
    public virtual DbSet<BranchDocumentAssignment> BranchDocumentAssignments { get; set; } = null!;
    public virtual DbSet<Brand> Brands { get; set; } = null!;
    public virtual DbSet<City> Cities { get; set; } = null!;
    public virtual DbSet<Claim> Claims { get; set; } = null!;
    public virtual DbSet<ClaimLabor> ClaimLabors { get; set; } = null!;
    public virtual DbSet<ClaimSparePart> ClaimSpareParts { get; set; } = null!;
    public virtual DbSet<ClaimSparePartActor> ClaimSparePartActors { get; set; } = null!;
    public virtual DbSet<Color> Colors { get; set; } = null!;
    public virtual DbSet<Contract> Contracts { get; set; } = null!;
    public virtual DbSet<ContractDefinition> ContractDefinitions { get; set; } = null!;
    public virtual DbSet<ContractWorkTypeBrandAssignment> ContractWorkTypeBrandAssignments { get; set; } = null!;
    public virtual DbSet<ControlType> ControlTypes { get; set; } = null!;
    public virtual DbSet<Country> Countries { get; set; } = null!;
    public virtual DbSet<Customer> Customers { get; set; } = null!;
    public virtual DbSet<DamageCause> DamageCauses { get; set; } = null!;
    public virtual DbSet<DamageImageType> DamageImageTypes { get; set; } = null!;
    public virtual DbSet<DamageType> DamageTypes { get; set; } = null!;
    public virtual DbSet<DefinitionParameter> DefinitionParameters { get; set; } = null!;
    public virtual DbSet<District> Districts { get; set; } = null!;
    public virtual DbSet<Document> Documents { get; set; } = null!;
    public virtual DbSet<DocumentStatus> DocumentStatuses { get; set; } = null!;
    public virtual DbSet<DocumentType> DocumentTypes { get; set; } = null!;
    public virtual DbSet<Email> Emails { get; set; } = null!;
    public virtual DbSet<File> Files { get; set; } = null!;
    public virtual DbSet<FileDocumentAssignment> FileDocumentAssignments { get; set; } = null!;
    public virtual DbSet<FuelType> FuelTypes { get; set; } = null!;
    public virtual DbSet<IdentityType> IdentityTypes { get; set; } = null!;
    public virtual DbSet<Labor> Labors { get; set; } = null!;
    public virtual DbSet<LaborType> LaborTypes { get; set; } = null!;
    public virtual DbSet<MissingDocument> MissingDocuments { get; set; } = null!;
    public virtual DbSet<Model> Models { get; set; } = null!;
    public virtual DbSet<OperationType> OperationTypes { get; set; } = null!;
    public virtual DbSet<ParentType> ParentTypes { get; set; } = null!;
    public virtual DbSet<Payment> Payments { get; set; } = null!;
    public virtual DbSet<Person> People { get; set; } = null!;
    public virtual DbSet<Phone> Phones { get; set; } = null!;
    public virtual DbSet<PhoneType> PhoneTypes { get; set; } = null!;
    public virtual DbSet<Policy> Policies { get; set; } = null!;
    public virtual DbSet<ProductBrand> ProductBrands { get; set; } = null!;
    public virtual DbSet<ProductBrandType> ProductBrandTypes { get; set; } = null!;
    public virtual DbSet<RecordType> RecordTypes { get; set; } = null!;
    public virtual DbSet<Region> Regions { get; set; } = null!;
    public virtual DbSet<RegionCity> RegionCities { get; set; } = null!;
    public virtual DbSet<Report> Reports { get; set; } = null!;
    public virtual DbSet<ReturnStatusType> ReturnStatusTypes { get; set; } = null!;
    public virtual DbSet<Role> Roles { get; set; } = null!;
    public virtual DbSet<RoleGroup> RoleGroups { get; set; } = null!;
    public virtual DbSet<ServiceInspectorDocument> ServiceInspectorDocuments { get; set; } = null!;
    public virtual DbSet<SparePart> SpareParts { get; set; } = null!;
    public virtual DbSet<SparePartType> SparePartTypes { get; set; } = null!;
    public virtual DbSet<Supplier> Suppliers { get; set; } = null!;
    public virtual DbSet<SupplierLabor> SupplierLabors { get; set; } = null!;
    public virtual DbSet<SupplierSparePart> SupplierSpareParts { get; set; } = null!;
    public virtual DbSet<SupplierType> SupplierTypes { get; set; } = null!;
    public virtual DbSet<SupplierTypeContractDefinationAssignment> SupplierTypeContractDefinationAssignments { get; set; } = null!;
    public virtual DbSet<SupplierWorkType> SupplierWorkTypes { get; set; } = null!;
    public virtual DbSet<TaxOffice> TaxOffices { get; set; } = null!;
    public virtual DbSet<TaxRate> TaxRates { get; set; } = null!;
    public virtual DbSet<Tenant> Tenants { get; set; } = null!;
    public virtual DbSet<TenderPoolDocument> TenderPoolDocuments { get; set; } = null!;
    public virtual DbSet<User> Users { get; set; } = null!;
    public virtual DbSet<UserPasswordHistory> UserPasswordHistories { get; set; } = null!;
    public virtual DbSet<UserRole> UserRoles { get; set; } = null!;
    public virtual DbSet<UserType> UserTypes { get; set; } = null!;
    public virtual DbSet<Vehicle> Vehicles { get; set; } = null!;
    public virtual DbSet<VehicleClass> VehicleClasses { get; set; } = null!;
    public virtual DbSet<VehicleType> VehicleTypes { get; set; } = null!;
    public virtual DbSet<VehicleTypeBrandAssignment> VehicleTypeBrandAssignments { get; set; } = null!;
    public virtual DbSet<VehicleUsageType> VehicleUsageTypes { get; set; } = null!;
    public virtual DbSet<VehicleVariant> VehicleVariants { get; set; } = null!;
}

