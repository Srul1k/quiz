﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teams.Models
{
    public class SingleSelectionQuestionModel
    {
        public string Question { get; set; }
        public ICollection<string> Answers { get; set; }
        public int IndexOfTrueAnswer { get; set; }
        public Guid Id { get; set; }
    }
}
