using Core;
using Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data
{
    public class ProjectEntityTypeConfiguration<TEntity> : IMappingConfiguration, IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        public ProjectEntityTypeConfiguration()
        {

        }

        protected virtual void PostConfigure(EntityTypeBuilder<TEntity> builder)
        {
        }

        public void ApplyConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(this);
        }

        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            this.PostConfigure(builder);
        }
    }
}

