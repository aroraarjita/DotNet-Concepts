﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EntityFrameworkDemo.Models;
using System.Data.Entity.Migrations;

namespace EntityFrameworkDemo.DBContext
{
    public class Context: DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
    }
}