﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int? CourseId { get; set; }
    }
}
