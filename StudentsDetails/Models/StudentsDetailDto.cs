using System;
using System.Collections.Generic;

namespace StudentsDetails.Models
{
    public partial class StudentsDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string FamilyName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public long ContactNumber { get; set; }
    }
}
