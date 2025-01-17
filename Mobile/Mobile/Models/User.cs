﻿using System;

namespace Mobile.Models
{
    public class User
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
