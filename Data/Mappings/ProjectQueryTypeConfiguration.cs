using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mappings
{
    /// <summary>
    /// Represents base query type mapping configuration
    /// </summary>
    /// <typeparam name="TQuery">Query type type</typeparam>
    public partial class ProjectQueryTypeConfiguration<TQuery> : IMappingConfiguration, IEntityTypeConfiguration<TQuery> where TQuery : class
    {
        #region Methods

        public void Configure(EntityTypeBuilder<TQuery> builder)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Apply this mapping configuration
        /// </summary>
        /// <param name="modelBuilder">The builder being used to construct the model for the database context</param>
        public virtual void ApplyConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(this);
        }

        #endregion
    }
}
