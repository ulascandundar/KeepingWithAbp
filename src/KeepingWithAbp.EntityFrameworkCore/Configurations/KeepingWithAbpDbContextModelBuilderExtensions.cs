using KeepingWithAbp.BankBranches;
using KeepingWithAbp.Banks;
using KeepingWithAbp.Consts;
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
        public static void Configure(this ModelBuilder builder)
        {
            builder.Entity<Bank>(b =>
            {
                b.ToTable(KeepingWithAbpConsts.DbTablePrefix + "Banks", KeepingWithAbpConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                                           //properties
                                           //indexs
                                           //relations
            });
        }
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
    }
}
