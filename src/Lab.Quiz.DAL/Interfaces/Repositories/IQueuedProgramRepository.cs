﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab.Quiz.DAL.Entities;

namespace Lab.Quiz.DAL.Interfaces
{
    public interface IQueuedProgramRepository
    {
        void Add(Guid id, string text);
    }
}
