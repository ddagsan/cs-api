using Core.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mappings
{
    public class BrandMapping : ProjectEntityTypeConfiguration<Brand>
    {
        public override void Configure(EntityTypeBuilder<Brand> builder)
        {
            base.Configure(builder);
        }
    }
}
