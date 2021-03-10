﻿using BobTheBuilderCalculatorMVC.Web.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Infrastructure.EntityConfigurations
{
    public class AddressConfiguration : BaseEntityConfiguration<Address>
    {

        public override void Configure(EntityTypeBuilder<Address> builder)
        {
            base.Configure(builder);

            builder.Property(a => a.City)
                .IsRequired();

            builder.HasOne(a => a.Client)
                .WithMany(a => a.Addresses)
                .HasForeignKey(a => a.ClientId);
        }
    }
}
