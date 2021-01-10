using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zo.Abp.Course.Options
{
    public class AppDbContext : DbContext
    {
        public AppDbContext([NotNull] DbContextOptions options) : base(options)
        {
        }

        protected AppDbContext()
        {
        }
    }
}
