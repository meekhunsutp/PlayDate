﻿using PlayDate_App.Contracts;
using PlayDate_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayDate_App.Data
{
    public class KidRepository : RepositoryBase<Kid>, IKidRepository
    {
        public KidRepository(ApplicationDbContext applicationDbContext)
            :base(applicationDbContext)
        {

        }
    }
}
