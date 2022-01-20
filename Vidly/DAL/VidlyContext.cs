﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.DAL
{
    public class VidlyContext : DbContext
    {
        public VidlyContext()
            :base("VidlyContext")
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        //public DbSet<Genre> Genres { get; set; }
        //public DbSet<Rental> Rentals { get; set; }

        public static VidlyContext Create()
        {
            return new VidlyContext();
        }

    }
}