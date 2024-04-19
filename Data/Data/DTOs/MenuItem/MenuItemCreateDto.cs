﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTOs
{
    public class MenuItemCreateDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string? Image { get; set; }
        public string? ImagePath { get; set; }
        public int MenuId { get; set; }
    }
}
