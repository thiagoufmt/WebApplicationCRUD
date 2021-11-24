﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationCRUD.Models;

namespace WebApplicationCRUD.Data
{
    public class WebApplicationCRUDContext : DbContext
    {
        public WebApplicationCRUDContext (DbContextOptions<WebApplicationCRUDContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationCRUD.Models.Department> Department { get; set; }
    }
}
