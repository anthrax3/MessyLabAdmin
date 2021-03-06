﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using MessyLabAdmin.Models;

namespace MessyLabAdmin.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Solution> Solutions { get; set; }
        public DbSet<Action> Actions { get; set; }
        public DbSet<StudentAssignment> StudentAssignments { get; set; }
        public DbSet<AssignmentVariant> AssignmentVariants { get; set; }
        public DbSet<PasswordReset> PasswordResets { get; set; }
        public DbSet<AssignmentTest> AssignmentTests { get; set; }
        public DbSet<AssignmentTestResult> AssignmentTestResults { get; set; }
    }
}
