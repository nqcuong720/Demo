// <copyright file="YoutubeEntitesContext.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Youtube.Data.YoutubeContext
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.EntityFrameworkCore;
    using Youtube.Data.EntitiesModel;

    /// <summary>
    /// Context.
    /// </summary>
    public class YoutubeEntitesContext : DbContext
    {
        public DbSet<Student> Student { get; set; }

        public DbSet<Class> CLass { get; set; }

        public YoutubeEntitesContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Student").HasKey(s => s.StudentId);
            modelBuilder.Entity<Class>().ToTable("Class").HasKey(c => c.ClassId);
        }
    }
}
