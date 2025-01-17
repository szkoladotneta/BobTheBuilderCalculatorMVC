﻿using BuilderCalculatorMVC.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Infrastructure.EntityConfigurations
{
    class ClientTypeConfiguration : BaseEntityConfiguration<ClientType>
    {
        public override void Configure(EntityTypeBuilder<ClientType> builder)
        {
            base.Configure(builder);

            builder.HasMany(a => a.Clients)
                .WithOne(a => a.ClientType);
                
        }
    }
}
