﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedResources.Interfaces
{
    public interface IUsersBLL
    {
        IUserMapper Insert(IUserMapper user);
        IUserMapper Get_User_by_User_Name(IUserMapper user);
        bool authenticate_user(IUserMapper user);
    }
}