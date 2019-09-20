﻿using System;
using System.Collections.Generic;
using System.Text;
using CompanyName.MyMeetings.BuildingBlocks.Infrastructure.Outbox;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompanyName.MyMeetings.Modules.Administration.Infrastructure.Outbox
{
    internal class OutboxMessageEntityTypeConfiguration : IEntityTypeConfiguration<OutboxMessage>
    {
        public void Configure(EntityTypeBuilder<OutboxMessage> builder)
        {

            builder.ToTable("OutboxMessages", "administration");

            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).ValueGeneratedNever();
        }
    }
}
