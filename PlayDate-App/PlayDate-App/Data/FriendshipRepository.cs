﻿using PlayDate_App.Contracts;
using PlayDate_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayDate_App.Data
{
    public class FriendshipRepository : RepositoryBase<Friendship>, IFriendshipRepository 
    {
        public FriendshipRepository(ApplicationDbContext applicationDbContext)
            : base(applicationDbContext)
        {
        }
        public Friendship GetFriendship(int friendshipId) => FindByCondition(f => f.FriendshipId == friendshipId).FirstOrDefault();



    }
}
