using KeepingWithAbp.BankAccounts;
using KeepingWithAbp.BankBranches;
using KeepingWithAbp.Banks;
using KeepingWithAbp.Bills;
using KeepingWithAbp.Branches;
using KeepingWithAbp.Consts;
using KeepingWithAbp.Currents;
using KeepingWithAbp.Expenses;
using KeepingWithAbp.Labors;
using KeepingWithAbp.Parameters;
using KeepingWithAbp.Periods;
using KeepingWithAbp.Receipts;
using KeepingWithAbp.ReceiptTransactions;
using KeepingWithAbp.Safes;
using KeepingWithAbp.SpecialCodes;
using KeepingWithAbp.Stocks;
using KeepingWithAbp.Units;
using KeepingWithAbp.Warehouses;
using Microsoft.EntityFrameworkCore;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace KeepingWithAbp.Configurations
{
    public static class KeepingWithAbpDbContextModelBuilderExtensions
    {
       
        public static void ConfigureBank(this ModelBuilder builder)
        {
            builder.Entity<Bank>(b =>
            {
                b.ToTable(KeepingWithAbpConsts.DbTablePrefix + "Banks", KeepingWithAbpConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                //properties
                b.Property(o => o.Code)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(EntityConsts.MaxCodeLength);
                b.Property(o => o.Name)
                    .IsRequired()
                    .HasColumnName(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(EntityConsts.MaxNameLength);
                b.Property(o => o.SpecialCode1Id)
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());
                b.Property(o => o.SpecialCode2Id)
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());
                b.Property(o => o.Description)
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(EntityConsts.MaxDescriptionLength);
                b.Property(o => o.Status)
                    .HasColumnType(NpgsqlDbType.Boolean.ToString());

                //indexs
                b.HasIndex(o => o.Code);

                //relations
                b.HasOne(o => o.SpecialCode1)
                    .WithMany(o => o.SpecialCode1Banks)
                    .OnDelete(DeleteBehavior.NoAction);
                b.HasOne(o => o.SpecialCode2)
                   .WithMany(o => o.SpecialCode2Banks)
                   .OnDelete(DeleteBehavior.NoAction);
            });
        }
        public static void ConfigureBankBranches(this ModelBuilder builder)
        {
            builder.Entity<BankBranch>(b =>
            {
                b.ToTable(KeepingWithAbpConsts.DbTablePrefix + "BankBranches", KeepingWithAbpConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                                           //properties
                b.Property(o=>o.Code)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(EntityConsts.MaxCodeLength);

                b.Property(o => o.Name)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(EntityConsts.MaxNameLength);

                b.Property(o => o.BankId)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.SpecialCode1Id)
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.SpecialCode2Id)
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o=>o.Description)
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(EntityConsts.MaxDescriptionLength);

                b.Property(o => o.Status)
                    .HasColumnType(NpgsqlDbType.Boolean.ToString());
                //indexs

                b.HasIndex(o => o.Code);

                //relations

                b.HasOne(o => o.Bank)
                    .WithMany(o=>o.BankBranches)
                    .OnDelete(DeleteBehavior.Cascade);

                b.HasOne(o=>o.SpecialCode1)
                    .WithMany(o=>o.SpecialCode1BankBranches) 
                    .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o => o.SpecialCode2)
                    .WithMany(o => o.SpecialCode2BankBranches)
                    .OnDelete(DeleteBehavior.NoAction);
            });
        }
        public static void ConfigureBankAccounts(this ModelBuilder builder)
        {
            builder.Entity<BankAccount>(b =>
            {
                b.ToTable(KeepingWithAbpConsts.DbTablePrefix + "BankAccounts", KeepingWithAbpConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                                           //properties
                b.Property(o => o.Code)
                   .IsRequired()
                   .HasColumnType(NpgsqlDbType.Varchar.ToString())
                   .HasMaxLength(EntityConsts.MaxCodeLength);

                b.Property(o => o.Name)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(EntityConsts.MaxNameLength);

                b.Property(o => o.BankAccountType)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Smallint.ToString());

                b.Property(o => o.AccountNo)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Varchar.ToString());

                b.Property(o=> o.AccountNo)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(BankAccountConsts.MaxAccountNoLength);

                b.Property(o=>o.IbanNo)
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(BankAccountConsts.MaxIbanNoLength);

                b.Property(o => o.BankBranchId)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.SpecialCode1Id)
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.SpecialCode2Id)
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o=>o.BranchId)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.Description)
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(EntityConsts.MaxDescriptionLength);

                b.Property(o => o.Status)
                    .HasColumnType(NpgsqlDbType.Boolean.ToString());


                //indexs

                b.HasIndex(o => o.Code);

                //relations

                b.HasOne(o => o.BankBranch)
                    .WithMany(o => o.BankAccounts)
                    .OnDelete(DeleteBehavior.Cascade);

                b.HasOne(o => o.SpecialCode1)
                   .WithMany(o => o.SpecialCode1BankAccounts)
                   .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o => o.SpecialCode2)
                    .WithMany(o => o.SpecialCode2BankAccounts)
                    .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o=>o.Branch)
                    .WithMany(o=>o.BankAccounts)
                    .OnDelete(DeleteBehavior.Cascade);

            });
        }

        public static void ConfigureUnit(this ModelBuilder builder)
        {
            builder.Entity<Unit>(b =>
            {
                b.ToTable(KeepingWithAbpConsts.DbTablePrefix + "Units", KeepingWithAbpConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                                           //properties
                b.Property(o => o.Code)
                   .IsRequired()
                   .HasColumnType(NpgsqlDbType.Varchar.ToString())
                   .HasMaxLength(EntityConsts.MaxCodeLength);

                b.Property(o => o.Name)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(EntityConsts.MaxNameLength);

                b.Property(o => o.SpecialCode1Id)
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.SpecialCode2Id)
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.Description)
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(EntityConsts.MaxDescriptionLength);

                b.Property(o => o.Status)
                   .HasColumnType(NpgsqlDbType.Boolean.ToString());
                //indexs

                b.HasIndex(o => o.Code);

                //relations

                b.HasOne(o => o.SpecialCode1)
                   .WithMany(o => o.SpecialCode1Units)
                   .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o => o.SpecialCode2)
                    .WithMany(o => o.SpecialCode2Units)
                    .OnDelete(DeleteBehavior.NoAction);
            });
        }

        public static void ConfigureCurrent(this ModelBuilder builder)
        {
            builder.Entity<Current>(b =>
            {
                b.ToTable(KeepingWithAbpConsts.DbTablePrefix + "Currents", KeepingWithAbpConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                                           //properties

                b.Property(o => o.Code)
                   .IsRequired()
                   .HasColumnType(NpgsqlDbType.Varchar.ToString())
                   .HasMaxLength(EntityConsts.MaxCodeLength);

                b.Property(o => o.Name)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(EntityConsts.MaxNameLength);

                b.Property(o => o.TaxAdministration)
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(CurrentConsts.MaxTaxAdministrationLength);

                b.Property(o=>o.TaxNo)
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(CurrentConsts.MaxTaxNoLength);

                b.Property(o => o.Telephone)
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(EntityConsts.MaxTelephoneLength);

                b.Property(o => o.Telephone)
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(EntityConsts.MaxAdressLength);

                b.Property(o => o.SpecialCode1Id)
                   .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.SpecialCode2Id)
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.Description)
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(EntityConsts.MaxDescriptionLength);

                b.Property(o => o.Status)
                   .HasColumnType(NpgsqlDbType.Boolean.ToString());

                //indexs

                b.HasIndex(o => o.Code);

                //relations

                b.HasOne(o => o.SpecialCode1)
                   .WithMany(o => o.SpecialCode1Currents)
                   .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o => o.SpecialCode2)
                    .WithMany(o => o.SpecialCode2Currents)
                    .OnDelete(DeleteBehavior.NoAction);
            });
        }

        public static void ConfigureWareHouse(this ModelBuilder builder)
        {
            builder.Entity<Warehouse>(b =>
            {
                b.ToTable(KeepingWithAbpConsts.DbTablePrefix + "Warehouses", KeepingWithAbpConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                                           //properties

                b.Property(o => o.Code)
                   .IsRequired()
                   .HasColumnType(NpgsqlDbType.Varchar.ToString())
                   .HasMaxLength(EntityConsts.MaxCodeLength);

                b.Property(o => o.Name)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(EntityConsts.MaxNameLength);

                b.Property(o => o.SpecialCode1Id)
                   .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.SpecialCode2Id)
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.BranchId)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.Description)
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(EntityConsts.MaxDescriptionLength);

                b.Property(o => o.Status)
                   .HasColumnType(NpgsqlDbType.Boolean.ToString());

                //indexs

                b.HasIndex(o => o.Code);

                //relations

                b.HasOne(o => o.SpecialCode1)
                   .WithMany(o => o.SpecialCode1Warehouses)
                   .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o => o.SpecialCode2)
                    .WithMany(o => o.SpecialCode2Warehouses)
                    .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o => o.Branch)
                    .WithMany(o => o.Warehouses)
                    .OnDelete(DeleteBehavior.NoAction);
            });
        }

        public static void ConfigurePeriod(this ModelBuilder builder)
        {
            builder.Entity<Period>(b =>
            {
                b.ToTable(KeepingWithAbpConsts.DbTablePrefix + "Periods", KeepingWithAbpConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                                           //properties

                b.Property(o => o.Code)
                   .IsRequired()
                   .HasColumnType(NpgsqlDbType.Varchar.ToString())
                   .HasMaxLength(EntityConsts.MaxCodeLength);

                b.Property(o => o.Name)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(EntityConsts.MaxNameLength);

                b.Property(o => o.Description)
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(EntityConsts.MaxDescriptionLength);

                b.Property(o => o.Status)
                   .HasColumnType(NpgsqlDbType.Boolean.ToString());

                //indexs

                b.HasIndex(o => o.Code);

                //relations
            });
        }

        public static void ConfigureBill(this ModelBuilder builder)
        {
            builder.Entity<Bill>(b =>
            {
                b.ToTable(KeepingWithAbpConsts.DbTablePrefix + "Bills", KeepingWithAbpConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                                           //properties

                b.Property(o => o.BillType)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Smallint.ToString());

                b.Property(o => o.BillNo)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(BillConsts.MaxBillNoLength);

                b.Property(o=>o.Date)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Date.ToString());

                b.Property(o=>o.GrossAmount)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Money.ToString().ToString());

                b.Property(o => o.DiscountAmount)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Money.ToString().ToString());

                b.Property(o => o.ExcludesVat)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Money.ToString().ToString());

                b.Property(o => o.VatAmount)
                   .IsRequired()
                   .HasColumnType(NpgsqlDbType.Money.ToString().ToString());

                b.Property(o => o.NetAmount)
                   .IsRequired()
                   .HasColumnType(NpgsqlDbType.Money.ToString().ToString());

                b.Property(o => o.NumberOfMoves)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Integer.ToString());

                b.Property(o => o.CurrentId)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.SpecialCode1Id)
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.SpecialCode2Id)
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.BranchId)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o=>o.PeriodId)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.Description)
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(EntityConsts.MaxDescriptionLength);

                b.Property(o => o.Status)
                   .HasColumnType(NpgsqlDbType.Boolean.ToString());

                //indexs

                b.HasIndex(o => o.BillNo);

                //relations

                b.HasOne(o => o.Current)
                    .WithMany(o => o.Bills)
                    .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o => o.SpecialCode1)
                   .WithMany(o => o.SpecialCode1Bills)
                   .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o => o.SpecialCode2)
                    .WithMany(o => o.SpecialCode2Bills)
                    .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o => o.Branch)
                    .WithMany(o => o.Bills)
                    .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o => o.Period)
                    .WithMany(o => o.Bills)
                    .OnDelete(DeleteBehavior.NoAction);
            });
        }

        public static void ConfigureBillTransaction(this ModelBuilder builder)
        {
            builder.Entity<BillTransaction>(b =>
            {
                b.ToTable(KeepingWithAbpConsts.DbTablePrefix + "BillTransactions", KeepingWithAbpConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                                           //properties

                b.Property(o => o.BillId)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.BillTransactionType)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Smallint.ToString());

                b.Property(o => o.StockId)
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.LaborId)
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.ExpenseId)
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.WareHouseId)
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o=>o.Quantity)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Money.ToString());

                b.Property(o => o.UnitPrice)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Money.ToString());

                b.Property(o => o.GrossPrice)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Money.ToString());

                b.Property(o => o.DiscountPrice)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Money.ToString());

                b.Property(o => o.VatRate)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Integer.ToString());

                b.Property(o => o.ExcludesVat)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Money.ToString());

                b.Property(o => o.VatPrice)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Money.ToString());

                b.Property(o => o.NetPrice)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Money.ToString());

                b.Property(o => o.Description)
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(EntityConsts.MaxDescriptionLength);

                //indexs

                //relations

                b.HasOne(o => o.Bill)
                    .WithMany(o => o.BillTransactions)
                    .OnDelete(DeleteBehavior.Cascade);

                b.HasOne(o => o.Stock)
                    .WithMany(o => o.BillTransactions)
                    .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o => o.Labor)
                    .WithMany(o => o.BillTransactions)
                    .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o => o.Expense)
                    .WithMany(o => o.BillTransactions)
                    .OnDelete(DeleteBehavior.Cascade);

                b.HasOne(o => o.Warehouse)
                    .WithMany(o => o.BillTransactions)
                    .OnDelete(DeleteBehavior.Cascade);

            });
        }

        public static void ConfigureCompanyParameter(this ModelBuilder builder)
        {
            builder.Entity<CompanyParameter>(b =>
            {
                b.ToTable(KeepingWithAbpConsts.DbTablePrefix + "CompanyParameters", KeepingWithAbpConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                                           //properties

                b.Property(o => o.UserId)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.BranchId)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.PeriodId)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.WarehouseId)
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());
                //indexs

                //relations

                b.HasOne(o => o.User)
                    .WithOne()
                    .HasForeignKey<CompanyParameter>(o => o.UserId);

                b.HasOne(o => o.Branch)
                    .WithMany(o => o.CompanyParameters)
                    .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o => o.Period)
                    .WithMany(o => o.CompanyParameters)
                    .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o => o.Warehouse)
                    .WithMany(o => o.CompanyParameters)
                    .OnDelete(DeleteBehavior.NoAction);
            });
        }

        public static void ConfigureLabor(this ModelBuilder builder)
        {
            builder.Entity<Labor>(b =>
            {
                b.ToTable(KeepingWithAbpConsts.DbTablePrefix + "Labors", KeepingWithAbpConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                                           //properties

                b.Property(o => o.Code)
                   .IsRequired()
                   .HasColumnType(NpgsqlDbType.Varchar.ToString())
                   .HasMaxLength(EntityConsts.MaxCodeLength);

                b.Property(o => o.Name)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(EntityConsts.MaxNameLength);

                b.Property(o => o.VatRate)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Integer.ToString());

                b.Property(o => o.UnitPrice)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Money.ToString());

                b.Property(o => o.Barcode)
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(EntityConsts.MaxBarcodeLength);

                b.Property(o => o.UnitId)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.SpecialCode1Id)
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.SpecialCode2Id)
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.Description)
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(EntityConsts.MaxDescriptionLength);

                b.Property(o => o.Status)
                   .HasColumnType(NpgsqlDbType.Boolean.ToString());

                //indexs

                b.HasIndex(o => o.Code);

                //relations

                b.HasOne(o=>o.Unit)
                    .WithMany(o=>o.Labors)
                    .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o => o.SpecialCode1)
                   .WithMany(o => o.SpecialCode1Labors)
                   .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o => o.SpecialCode2)
                    .WithMany(o => o.SpecialCode2Labors)
                    .OnDelete(DeleteBehavior.NoAction); 

            });
        }

        public static void ConfigureSafe(this ModelBuilder builder)
        {
            builder.Entity<Safe>(b =>
            {
                b.ToTable(KeepingWithAbpConsts.DbTablePrefix + "Safes", KeepingWithAbpConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                                           //properties

                b.Property(o => o.Code)
                   .IsRequired()
                   .HasColumnType(NpgsqlDbType.Varchar.ToString())
                   .HasMaxLength(EntityConsts.MaxCodeLength);

                b.Property(o => o.Name)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(EntityConsts.MaxNameLength);

                b.Property(o => o.SpecialCode1Id)
                   .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.SpecialCode2Id)
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.BranchId)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.Description)
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(EntityConsts.MaxDescriptionLength);

                b.Property(o => o.Status)
                   .HasColumnType(NpgsqlDbType.Boolean.ToString());

                //indexs

                b.HasIndex(o => o.Code);

                //relations

                b.HasOne(o => o.SpecialCode1)
                   .WithMany(o => o.SpecialCode1Safes)
                   .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o => o.SpecialCode2)
                    .WithMany(o => o.SpecialCode2Safes)
                    .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o => o.Branch)
                    .WithMany(o => o.Safes)
                    .OnDelete(DeleteBehavior.NoAction);

            });
        }

        public static void ConfigureReceipt(this ModelBuilder builder)
        {
            builder.Entity<Receipt>(b =>
            {
                b.ToTable(KeepingWithAbpConsts.DbTablePrefix + "Receipts", KeepingWithAbpConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                                           //properties

                b.Property(o => o.ReceiptType)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Smallint.ToString());

                b.Property(o => o.ReceiptNo)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(ReceiptConsts.MaxReceiptLength);

                b.Property(o => o.Date)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Date.ToString());

                b.Property(o => o.CurrentId)
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.SafeId)
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.BankAccountId)
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.NumberOfMoves)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Integer.ToString());

                b.Property(o => o.CheckTotal)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Money.ToString());

                b.Property(o => o.PosTotal)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Money.ToString());

                b.Property(o => o.CashTotal)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Money.ToString());

                b.Property(o => o.BankTotal)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Money.ToString());

                b.Property(o => o.SpecialCode1Id)
                   .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.SpecialCode2Id)
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.BranchId)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.PeriodId)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.Description)
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(EntityConsts.MaxDescriptionLength);

                b.Property(o => o.Status)
                   .HasColumnType(NpgsqlDbType.Boolean.ToString());

                //indexs

                b.HasIndex(o => o.ReceiptNo);

                //relations

                b.HasOne(o => o.Current)
                   .WithMany(o => o.Receipts)
                   .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o => o.Safe)
                   .WithMany(o => o.Receipts)
                   .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o => o.BankAccount)
                  .WithMany(o => o.Receipts)
                  .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o => o.SpecialCode1)
                   .WithMany(o => o.SpecialCode1Receipts)
                   .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o => o.SpecialCode2)
                    .WithMany(o => o.SpecialCode2Receipts)
                    .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o => o.Branch)
                    .WithMany(o => o.Receipts)
                    .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o => o.Period)
                    .WithMany(o => o.Receipts)
                    .OnDelete(DeleteBehavior.NoAction);
            });
        }

        public static void ConfigureReceiptTransaction(this ModelBuilder builder)
        {
            builder.Entity<ReceiptTransaction>(b =>
            {
                b.ToTable(KeepingWithAbpConsts.DbTablePrefix + "ReceiptTransactions", KeepingWithAbpConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                                           //properties

                b.Property(o => o.ReceiptId)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.PaymentType)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Smallint.ToString());

                b.Property(o => o.TrackingNo)
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(ReceiptTransactionConsts.MaxTrackingNumberLength);

                b.Property(o => o.CheckBankId)
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.CheckBankBranchId)
                     .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.CheckhAccountNo)
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(ReceiptTransactionConsts.MaxCheckAccountNoLength);

                b.Property(o=>o.DocumentNo)
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(ReceiptTransactionConsts.MaxDocumentNoLength);

                b.Property(o => o.Date)
                    .HasColumnType(NpgsqlDbType.Date.ToString())
                    .IsRequired();

                b.Property(o => o.PrincipalDebtor)
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(ReceiptTransactionConsts.MaxPrincipalDebtorLength);

                b.Property(o => o.Endorser)
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(ReceiptTransactionConsts.MaxEndorserLength);

                b.Property(o=>o.SafeId)
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.BankAccountId)
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o=>o.Price)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Money.ToString());

                b.Property(o => o.DocumentStatusType)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Smallint.ToString());

                b.Property(o=>o.OurOwnCocument)
                    .HasColumnType(NpgsqlDbType.Boolean.ToString());

                b.Property(o => o.Description)
                   .HasColumnType(NpgsqlDbType.Varchar.ToString())
                   .HasMaxLength(EntityConsts.MaxDescriptionLength);
                //indexs

                b.HasIndex(o => o.TrackingNo);

                //relations

                b.HasOne(o => o.Receipt)
                    .WithMany(o => o.ReceiptTransactions)
                    .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o => o.CheckBank)
                    .WithMany(o => o.ReceiptTransactions)
                    .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o => o.CheckBankBranch)
                    .WithMany(o => o.ReceiptTransactions)
                    .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o => o.Safe)
                    .WithMany(o => o.ReceiptTransactions)
                    .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o => o.BankAccount)
                    .WithMany(o => o.ReceiptTransactions)
                    .OnDelete(DeleteBehavior.NoAction);


            });
        }

        public static void ConfigureExpense(this ModelBuilder builder)
        {
            builder.Entity<Expense>(b =>
            {
                b.ToTable(KeepingWithAbpConsts.DbTablePrefix + "Expenses", KeepingWithAbpConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                                           //properties

                b.Property(o => o.Code)
                   .IsRequired()
                   .HasColumnType(NpgsqlDbType.Varchar.ToString())
                   .HasMaxLength(EntityConsts.MaxCodeLength);

                b.Property(o => o.Name)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(EntityConsts.MaxNameLength);

                b.Property(o => o.VatRate)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Integer.ToString());

                b.Property(o => o.UnitPrice)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Money.ToString());

                b.Property(o => o.Barcode)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(EntityConsts.MaxBarcodeLength);

                b.Property(o => o.UnitId)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.SpecialCode1Id)
                   .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.SpecialCode2Id)
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.Description)
                   .HasColumnType(NpgsqlDbType.Varchar.ToString())
                   .HasMaxLength(EntityConsts.MaxDescriptionLength);

                b.Property(o=>o.Status)
                    .HasColumnType(NpgsqlDbType.Boolean.ToString());
                //indexs

                b.HasIndex(o => o.Code);

                //relations

                b.HasOne(o => o.Unit)
                   .WithMany(o => o.Expenses)
                   .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o => o.SpecialCode1)
                   .WithMany(o => o.SpecialCode1Expenses)
                   .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o => o.SpecialCode2)
                    .WithMany(o => o.SpecialCode2Expenses)
                    .OnDelete(DeleteBehavior.NoAction);
            });
        }

        public static void ConfigureSpecialCode(this ModelBuilder builder)
        {
            builder.Entity<SpecialCode>(b =>
            {
                b.ToTable(KeepingWithAbpConsts.DbTablePrefix + "SpecialCodes", KeepingWithAbpConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                                           //properties

                b.Property(o => o.Code)
                  .IsRequired()
                  .HasColumnType(NpgsqlDbType.Varchar.ToString())
                  .HasMaxLength(EntityConsts.MaxCodeLength);

                b.Property(o => o.Name)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(EntityConsts.MaxNameLength);

                b.Property(o => o.SpecialCodeType)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Smallint.ToString());

                b.Property(o => o.CardType)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Smallint.ToString());

                b.Property(o => o.Description)
                   .HasColumnType(NpgsqlDbType.Varchar.ToString())
                   .HasMaxLength(EntityConsts.MaxDescriptionLength);

                b.Property(o => o.Status)
                    .HasColumnType(NpgsqlDbType.Boolean.ToString());
                //indexs

                b.HasIndex(o => o.Code);

                //relations
            });
        }

        public static void ConfigureStock(this ModelBuilder builder)
        {
            builder.Entity<Stock>(b =>
            {
                b.ToTable(KeepingWithAbpConsts.DbTablePrefix + "Stocks", KeepingWithAbpConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                                           //properties

                b.Property(o => o.Code)
                  .IsRequired()
                  .HasColumnType(NpgsqlDbType.Varchar.ToString())
                  .HasMaxLength(EntityConsts.MaxCodeLength);

                b.Property(o => o.Name)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(EntityConsts.MaxNameLength);

                b.Property(o => o.VatRate)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Integer.ToString());

                b.Property(o => o.UnitPrice)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Money.ToString());

                b.Property(o => o.SpecialCode1Id)
                   .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.SpecialCode2Id)
                    .HasColumnType(NpgsqlDbType.Uuid.ToString());

                b.Property(o => o.Description)
                   .HasColumnType(NpgsqlDbType.Varchar.ToString())
                   .HasMaxLength(EntityConsts.MaxDescriptionLength);

                b.Property(o => o.Status)
                    .HasColumnType(NpgsqlDbType.Boolean.ToString());
                //indexs

                b.HasIndex(o => o.Code);

                //relations

                b.HasOne(o => o.Unit)
                    .WithMany(o => o.Stocks)
                    .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o => o.SpecialCode1)
                   .WithMany(o => o.SpecialCode1Stocks)
                   .OnDelete(DeleteBehavior.NoAction);

                b.HasOne(o => o.SpecialCode2)
                    .WithMany(o => o.SpecialCode2Stocks)
                    .OnDelete(DeleteBehavior.NoAction); 
            });
        }

        public static void ConfigureBranch(this ModelBuilder builder)
        {
            builder.Entity<Branch>(b =>
            {
                b.ToTable(KeepingWithAbpConsts.DbTablePrefix + "Branches", KeepingWithAbpConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                                           //properties

                b.Property(o => o.Code)
                  .IsRequired()
                  .HasColumnType(NpgsqlDbType.Varchar.ToString())
                  .HasMaxLength(EntityConsts.MaxCodeLength);

                b.Property(o => o.Name)
                    .IsRequired()
                    .HasColumnType(NpgsqlDbType.Varchar.ToString())
                    .HasMaxLength(EntityConsts.MaxNameLength);

                b.Property(o => o.Description)
                   .HasColumnType(NpgsqlDbType.Varchar.ToString())
                   .HasMaxLength(EntityConsts.MaxDescriptionLength);

                b.Property(o => o.Status)
                    .HasColumnType(NpgsqlDbType.Boolean.ToString());

                //indexs

                b.HasIndex(o => o.Code);

                //relations
            });
        }

    }
}
