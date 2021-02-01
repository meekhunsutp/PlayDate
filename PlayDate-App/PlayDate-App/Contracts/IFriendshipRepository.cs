﻿using PlayDate_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayDate_App.Contracts
{
    public interface IFriendshipRepository : IRepositoryBase<Friendship>
    {
        Friendship GetFriendship(int friendshipId);
    }

}
