﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProiectMDS.DAL.Entities;
using ProiectMDS.DAL.Entities.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMDS.DAL.Configurations
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.FirstName)
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(x => x.LastName)
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.HasOne(x => x.Profile)
                .WithOne(x => x.User)
                .HasForeignKey<User>(x => x.ProfileId)
                .IsRequired(false);

            builder.HasMany(x => x.UserConnections)
                .WithOne(x => x.User);
        }
    }
}
