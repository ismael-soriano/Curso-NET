﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Comment : EntityBaseWithDescription
    {
        public User User { get; set; }
    }
}
