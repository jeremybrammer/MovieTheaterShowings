﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedResources.Interfaces
{
    public interface IShowTimesMapper
    {
        int Id { get; set; }
        DateTime ShowingDateTime { get; set; }
        int MovieId { get; set; }
    }
}