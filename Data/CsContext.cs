using Data.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Core.Utilities;
using System.Data.Common;
using System.Data;
using Core.Domain;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Data
{
    public class CsContext : DbContext, IDbContext
    {
        #region Ctor

        public CsContext(DbContextOptions<CsContext> options) : base(options)
        {
            if (!(this.Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator).Exists())
                this.Database.Migrate();
        }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        #region Utilities

        /// <summary>
        /// Further configuration the model
        /// </summary>
        /// <param name="modelBuilder">The builder being used to construct the model for this context</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //dynamically load all entity and query type configurations
            var typeConfigurations = Assembly.GetExecutingAssembly().GetTypes().Where(type =>
                (type.BaseType?.IsGenericType ?? false)
                    && (type.BaseType.GetGenericTypeDefinition() == typeof(ProjectEntityTypeConfiguration<>)
                        || type.BaseType.GetGenericTypeDefinition() == typeof(ProjectQueryTypeConfiguration<>)));

            List<IMappingConfiguration> configurations = new List<IMappingConfiguration>();
            foreach (var typeConfiguration in typeConfigurations)
            {
                var configuration = (IMappingConfiguration)Activator.CreateInstance(typeConfiguration);
                configuration.ApplyConfiguration(modelBuilder);
            }

            seed(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private void seed(ModelBuilder modelBuilder)
        {
            var generator = new Generator();

            var brands = new List<Brand>()
            {
                new Brand()
                {
                    Id = generator.GetId<Brand>(),
                    Name = "Samsung"
                },
                new Brand()
                {
                    Id = generator.GetId<Brand>(),
                    Name = "Nokia"
                },
                new Brand()
                {
                    Id = generator.GetId<Brand>(),
                    Name = "Apple"
                },
                new Brand()
                {
                    Id = generator.GetId<Brand>(),
                    Name = "LG"
                },
                new Brand()
                {
                    Id = generator.GetId<Brand>(),
                    Name = "Huawei"
                },
                new Brand()
                {
                    Id = generator.GetId<Brand>(),
                    Name = "Xiaomi"
                },
                new Brand()
                {
                    Id = generator.GetId<Brand>(),
                    Name = "General Mobile"
                },
                new Brand()
                {
                    Id = generator.GetId<Brand>(),
                    Name = "Oppo"
                },
                new Brand()
                {
                    Id = generator.GetId<Brand>(),
                    Name = "Vivo"
                },
                new Brand()
                {
                    Id = generator.GetId<Brand>(),
                    Name = "HTC"
                },
                new Brand()
                {
                    Id = generator.GetId<Brand>(),
                    Name = "Unknown"
                }
            };
            modelBuilder.Entity<Brand>().HasData(brands.ToArray());

            var colors = new List<Color>()
            {
                new Color()
                {
                    Id = generator.GetId<Color>(),
                    Name = "Lacivert"
                },
                new Color()
                {
                    Id = generator.GetId<Color>(),
                    Name = "Sarı"
                },
                new Color()
                {
                    Id = generator.GetId<Color>(),
                    Name = "Siyah"
                },
                new Color()
                {
                    Id = generator.GetId<Color>(),
                    Name = "Beyaz"
                },
            };
            modelBuilder.Entity<Color>().HasData(colors.ToArray());

            var products = new List<Product>();

            products = new List<Product>()
            {
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "Apple iPhone 11 Pro Maxi Phone 11 Pro Max iPhone 11 (Max 2 Line)",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[2].Id,
                    ColorId = colors[3].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "Apple iPhone 11",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[2].Id,
                    ColorId = colors[1].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "iPhone 11 Kırmızı Kılıf",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[2].Id,
                    ColorId = colors[1].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "Samsung Telefon",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[0].Id,
                    ColorId = colors[1].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "Samsung Telefon 1",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[0].Id,
                    ColorId = colors[3].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "Huawei Telefon",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[4].Id,
                    ColorId = colors[1].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "Xiaomi Redmi Note 10S 128 GB 6 GB Ram",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[10].Id,
                    ColorId = colors[2].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "Oppo Reno Telefon",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[10].Id,
                    ColorId = colors[3].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "Xiomi Telefon",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[10].Id,
                    ColorId = colors[1].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "Oppo Reno 5 Lite 128 GB",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[10].Id,
                    ColorId = colors[2].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "Huawei Telefon",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[4].Id,
                    ColorId = colors[3].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "Apple Telefon",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[2].Id,
                    ColorId = colors[0].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "Huawei Telefon",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[4].Id,
                    ColorId = colors[1].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "Huawei Telefon",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[4].Id,
                    ColorId = colors[2].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "HTC Desire 20 Pro",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[10].Id,
                    ColorId = colors[3].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "Huawei Telefon",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[4].Id,
                    ColorId = colors[1].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "Apple Telefon",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[2].Id,
                    ColorId = colors[2].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "HTC Telefon",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[10].Id,
                    ColorId = colors[3].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "Oppo Reno Telefon",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[10].Id,
                    ColorId = colors[0].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "LG Telefon",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[3].Id,
                    ColorId = colors[1].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "Sonny Telefon",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[10].Id,
                    ColorId = colors[2].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "General Mobile",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[10].Id,
                    ColorId = colors[3].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "Tecno Spark Telefon",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[10].Id,
                    ColorId = colors[0].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "Samsung Telefon",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[0].Id,
                    ColorId = colors[1].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "Xiaomı Telefon",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[10].Id,
                    ColorId = colors[2].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "ViVo Telefon",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[10].Id,
                    ColorId = colors[3].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "Huawei Telefon",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[4].Id,
                    ColorId = colors[0].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "Apple Telefon",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[2].Id,
                    ColorId = colors[1].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "Samsung Telefon",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[0].Id,
                    ColorId = colors[2].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "LG Telefon",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[3].Id,
                    ColorId = colors[3].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "Oppo Reno Telefon",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[10].Id,
                    ColorId = colors[3].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "Samsung Telefon",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[0].Id,
                    ColorId = colors[3].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "HTC Telefon",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[10].Id,
                    ColorId = colors[3].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "HTC Telefon 2",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[10].Id,
                    ColorId = colors[3].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "HTC Phone 4",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[10].Id,
                    ColorId = colors[3].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "HTC teleFON 9",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[10].Id,
                    ColorId = colors[1].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "Samsung Telefon",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[10].Id,
                    ColorId = colors[3].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "HTC Telefon 50",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[10].Id,
                    ColorId = colors[3].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "HTC Telefon 98",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[10].Id,
                    ColorId = colors[3].Id
                },
                new Product()
                {
                    Id = generator.GetId<Product>(),
                    Name = "HTC Telefon 100",
                    DiscountRatio = 1,
                    Price = 1000,
                    BrandId = brands[10].Id,
                    ColorId = colors[3].Id
                }
            };
            modelBuilder.Entity<Product>().HasData(products.ToArray());

            var users = new List<User>()
            {
                new User()
                {
                    Id = generator.GetId<User>(),
                    Username = "CsUser"
                }
            };
            modelBuilder.Entity<User>().HasData(users.ToArray());
        }

        /// <summary>
        /// Modify the input SQL query by adding passed parameters
        /// </summary>
        /// <param name="sql">The raw SQL query</param>
        /// <param name="parameters">The values to be assigned to parameters</param>
        /// <returns>Modified raw SQL query</returns>
        protected virtual string CreateSqlWithParameters(string sql, params object[] parameters)
        {
            //add parameters to sql
            for (var i = 0; i <= (parameters?.Length ?? 0) - 1; i++)
            {
                if (!(parameters[i] is DbParameter parameter))
                    continue;

                sql = $"{sql}{(i > 0 ? "," : string.Empty)} @{parameter.ParameterName}";

                //whether parameter is output
                if (parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Output)
                    sql = $"{sql} output";
            }

            return sql;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Creates a DbSet that can be used to query and save instances of entity
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <returns>A set for the given entity type</returns>
        public new virtual DbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity
        {
            return base.Set<TEntity>();
        }

        public IDbContextTransaction BeginTransaction()
        {
            return this.Database.BeginTransaction();
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        #endregion
    }
}
