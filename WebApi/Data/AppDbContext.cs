using DigiCore.Common.DbConnection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Data
{
    public class AppDbContext : Context
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<Context> options)
            : base(options)
        {
        }
    }
}
