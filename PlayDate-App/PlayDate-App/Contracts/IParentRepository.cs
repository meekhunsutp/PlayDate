﻿using PlayDate_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayDate_App.Contracts
{
    public interface IParentRepository: IRepositoryBase<Parent>
    {
        Parent GetParent(string parentUserId);

        Parent GetParentDetails(int id);

    }
}
