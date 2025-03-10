﻿using BookStore.Domain;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Mapping
{
    public class CategoriaMap : EntityTypeConfiguration<Categoria>
    {
        public CategoriaMap()
        {
            ToTable("Categoria");

            HasKey(x => x.Id);
            Property(x => x.Title).HasMaxLength(30).IsRequired();

            HasMany(x => x.Livros)
                .WithRequired(x => x.Categoria);
        }
    }
}