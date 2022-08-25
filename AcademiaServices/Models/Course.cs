using System;
using System.Collections.Generic;

namespace AcademiaServices.Models
{
    public partial class Course
    {
        public Course()
        {
            Carts = new HashSet<Cart>();
        }

        public int CourseId { get; set; }
        public int CategId { get; set; }
        public string Coursename { get; set; } = null!;
        public string ImagePath { get; set; } = null!;
        public string Price { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Duration { get; set; } = null!;
        public string MentorName { get; set; } = null!;

       public virtual Category Categ { get; set; } = null!;
       public virtual ICollection<Cart> Carts { get; set; }
    }
}
