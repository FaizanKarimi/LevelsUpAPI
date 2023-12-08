using System;
using System.Collections.Generic;
using System.IO;
using Identity.Models;
using Infrastructure.Common;
using Infrastructure.ExtensionMethods.Framework;
using Infrastructure.Helpers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;

namespace Identity
{
    /// Add-Migration MyMigration -Project Identity -StartupProject LevelsUpAPI for adding the migration
    /// Update-Database for simple update the migrations
    /// Remove-Migration
    /// Update-Database -migration MigrationName

    /// <summary>
    /// LevelsUpDbContext class
    /// </summary>
    /// <seealso cref="IdentityDbContext{LevelsUpUser}" />
    public class LevelsUpDbContext : IdentityDbContext<LevelsUpUser>
    {
        #region Public Properties
        /// <summary>
        /// Gets or sets the categories.
        /// </summary>
        /// <value>
        /// The categories.
        /// </value>
        public DbSet<Category> Categories { get; set; }

        /// <summary>
        /// Gets or sets the devices.
        /// </summary>
        /// <value>
        /// The devices.
        /// </value>
        public DbSet<Devices> Devices { get; set; }

        /// <summary>
        /// Gets or sets the refresh tokens.
        /// </summary>
        /// <value>
        /// The refresh tokens.
        /// </value>
        public DbSet<RefreshToken> RefreshTokens { get; set; }

        /// <summary>
        /// Gets or sets the sub categories.
        /// </summary>
        /// <value>
        /// The sub categories.
        /// </value>
        public DbSet<SubCategory> SubCategories { get; set; }

        /// <summary>
        /// Gets or sets the user categories.
        /// </summary>
        /// <value>
        /// The user categories.
        /// </value>
        public DbSet<UserCategory> UserCategories { get; set; }

        /// <summary>
        /// Gets or sets the user profiles.
        /// </summary>
        /// <value>
        /// The user profiles.
        /// </value>
        public DbSet<UserProfile> UserProfiles { get; set; }

        /// <summary>
        /// Gets or sets the user sub categories.
        /// </summary>
        /// <value>
        /// The user sub categories.
        /// </value>
        public DbSet<UserSubCategory> UserSubCategories { get; set; }
        #endregion

        #region Public Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="LevelsUpDbContext"/> class.
        /// </summary>
        public LevelsUpDbContext() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="LevelsUpDbContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public LevelsUpDbContext(DbContextOptions<LevelsUpDbContext> options) : base(options) { }
        #endregion

        #region Protected Methods
        /// <summary>
        /// <para>
        /// Override this method to configure the database (and other options) to be used for this context.
        /// This method is called for each instance of the context that is created.
        /// The base implementation does nothing.
        /// </para>
        /// <para>
        /// In situations where an instance of <see cref="T:Microsoft.EntityFrameworkCore.DbContextOptions" /> may or may not have been passed
        /// to the constructor, you can use <see cref="P:Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.IsConfigured" /> to determine if
        /// the options have already been set, and skip some or all of the logic in
        /// <see cref="M:Microsoft.EntityFrameworkCore.DbContext.OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder)" />.
        /// </para>
        /// </summary>
        /// <param name="optionsBuilder">A builder used to create or modify options for this context. Databases (and other extensions)
        /// typically define extension methods on this object that allow you to configure the context.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                                                       .SetBasePath(Directory.GetCurrentDirectory())
                                                       .AddJsonFile(Constants.AppSettingJsonFile)
                                                       .Build();

                string connectionString = configuration.GetConnectionString(Constants.ConnectionStringName);
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        /// <summary>Configures the schema needed for the identity framework.</summary>
        /// <param name="builder">The builder being used to construct the model for this context.</param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<LevelsUpUser>()
                   .HasMany(e => e.Categories)
                   .WithOne(e => e.CreatedBy)
                   .HasForeignKey(e => e.CreatedById)
                   .IsRequired();

            builder.Entity<LevelsUpUser>()
                    .HasMany(e => e.Devices)
                    .WithOne(e => e.User)
                    .HasForeignKey(e => e.UserId)
                    .IsRequired();

            builder.Entity<LevelsUpUser>()
                   .HasMany(e => e.Device)
                   .WithOne(e => e.CreatedBy)
                   .HasForeignKey(e => e.CreatedById)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<LevelsUpUser>()
                   .HasMany(e => e.RefreshTokens)
                   .WithOne(e => e.User)
                   .HasForeignKey(e => e.UserId)
                   .IsRequired();

            builder.Entity<LevelsUpUser>()
                   .HasMany(e => e.RefreshToken)
                   .WithOne(e => e.CreatedBy)
                   .HasForeignKey(e => e.CreatedById)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<LevelsUpUser>()
                   .HasOne(e => e.UserProfiles)
                   .WithOne(e => e.User)
                   .HasForeignKey<UserProfile>(e => e.UserId)
                   .IsRequired();

            builder.Entity<LevelsUpUser>()
                   .HasOne(e => e.UserProfile)
                   .WithOne(e => e.CreatedBy)
                   .HasForeignKey<UserProfile>(e => e.CreatedById)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<LevelsUpUser>()
                   .HasMany(e => e.SubCategories)
                   .WithOne(e => e.CreatedBy)
                   .HasForeignKey(e => e.CreatedById)
                   .IsRequired();

            builder.Entity<Category>()
                    .HasMany(e => e.SubCategories)
                    .WithOne(e => e.Category)
                    .HasForeignKey(e => e.CategoryId)
                    .IsRequired();

            builder.Entity<Category>()
                    .HasMany(e => e.UserCategories)
                    .WithOne(e => e.Category)
                    .HasForeignKey(e => e.CategoryId)
                    .IsRequired();

            builder.Entity<LevelsUpUser>()
                    .HasMany(e => e.UserCategories)
                    .WithOne(e => e.User)
                    .HasForeignKey(e => e.UserId)
                    .IsRequired();

            builder.Entity<LevelsUpUser>()
                    .HasMany(e => e.UserCategory)
                    .WithOne(e => e.CreatedBy)
                    .HasForeignKey(e => e.CreatedById)
                    .IsRequired().OnDelete(DeleteBehavior.Restrict);

            builder.Entity<LevelsUpUser>()
                    .HasMany(e => e.UserCategories)
                    .WithOne(e => e.User)
                    .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<UserCategory>()
                    .HasMany(e => e.UserSubCategory)
                    .WithOne(e => e.SubCategory)
                    .HasForeignKey(e => e.SubCategoryId)
                    .IsRequired();

            builder.Entity<UserCategory>()
                    .HasMany(e => e.UserSubCategory)
                    .WithOne(e => e.SubCategory)
                    .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<LevelsUpUser>()
                    .HasMany(e => e.SubCategories)
                    .WithOne(e => e.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<LevelsUpUser>()
                    .HasMany(e => e.UserSubCategories)
                    .WithOne(e => e.User)
                    .HasForeignKey(e => e.UserId)
                    .IsRequired();

            base.OnModelCreating(builder);

            this._SeedData(builder);
        }
        #endregion

        #region Public Methods
        /// <summary>Saves all changes made in this context to the database.</summary>
        /// <returns>The number of state entries written to the database.</returns>
        /// <remarks>
        /// This method will automatically call <see cref="M:Microsoft.EntityFrameworkCore.ChangeTracking.ChangeTracker.DetectChanges">DetectChanges</see> to discover any
        /// changes to entity instances before saving to the underlying database. This can be disabled via
        /// <see cref="P:Microsoft.EntityFrameworkCore.ChangeTracking.ChangeTracker.AutoDetectChangesEnabled">AutoDetectChangesEnabled</see>.
        /// </remarks>
        public override int SaveChanges()
        {
            this._AddAuditInformation();

            return base.SaveChanges();
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Adds the audit information.
        /// </summary>
        private void _AddAuditInformation()
        {
            ChangeTracker.DetectChanges();

            string userName = ServiceHelpers.GetHttpContextAccessor()?.GetCurrentUserName();

            IEnumerable<EntityEntry> entities = ChangeTracker.Entries();
            foreach (EntityEntry entity in entities)
            {
                if (entity.Entity is BaseModel)
                {
                    switch (entity.State)
                    {
                        case EntityState.Added:
                            entity.CurrentValues[nameof(BaseModel.CreatedOn)] = DateTime.Now;
                            entity.CurrentValues[nameof(BaseModel.CreatedById)] = userName;
                            break;
                        case EntityState.Modified:
                            entity.CurrentValues[nameof(BaseModel.UpdatedOn)] = DateTime.Now;
                            entity.CurrentValues[nameof(BaseModel.UpdatedById)] = userName;
                            break;
                        case EntityState.Deleted:
                            entity.CurrentValues[nameof(BaseModel)] = true;
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Seeds the data.
        /// </summary>
        /// <param name="modelBuilder">The model builder.</param>
        private void _SeedData(ModelBuilder modelBuilder)
        {
            LevelsUpUser adminUser = new LevelsUpUser()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "admin@levelsup.com",
                Email = "admin@levelsup.com",
                PhoneNumber = "03028417241",
                DateRegistration = DateTime.Now,
                LockoutEnabled = false,
                NormalizedEmail = "admin@levelsup.com".ToUpper(),
                NormalizedUserName = "admin@levelsup.com".ToUpper()
            };

            PasswordHasher<LevelsUpUser> passwordHasher = new PasswordHasher<LevelsUpUser>();
            adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, "P@kistan123");

            modelBuilder.Entity<LevelsUpUser>().HasData(adminUser);

            string adminRoleId = Guid.NewGuid().ToString();
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole() { Id = adminRoleId, Name = "Admin", NormalizedName = "ADMIN" });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>() { RoleId = adminRoleId, UserId = adminUser.Id });
        }
        #endregion
    }
}