﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bidding.Data
{
    public class BiddingContext : DbContext
    {
        public BiddingContext(string connectionString):base(connectionString)
        {

        }
        public DbSet<BiddingItem> BiddingItems { get; set; }
        public DbSet<BiddingConfig> BiddingConfigs { get; set; }

        public DbSet<BiddingAction> BiddingActions { get; set; }

    }
}