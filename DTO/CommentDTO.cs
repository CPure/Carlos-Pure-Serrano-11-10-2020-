﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CommentDTO
    {
        public int postId { get; set; }
        public int id { get; set; }
        public String name { get; set; }
        public String email { get; set; }
        public String body { get; set; }
    }
}
