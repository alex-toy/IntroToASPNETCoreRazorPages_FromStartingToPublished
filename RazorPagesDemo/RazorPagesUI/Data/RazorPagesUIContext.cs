using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesUI.Models;

namespace RazorPagesUI.Data
{
    public class RazorPagesUIContext : DbContext
    {
        public RazorPagesUIContext (DbContextOptions<RazorPagesUIContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesUI.Models.AddressModel> AddressModel { get; set; }
    }
}
