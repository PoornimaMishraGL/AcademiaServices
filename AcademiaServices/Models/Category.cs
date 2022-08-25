using System;
using System.Collections.Generic;

namespace AcademiaServices.Models
{
    public partial class Category
    {
        public Category()
        {
            Courses = new HashSet<Course>();
        }

        public int CategId { get; set; }
        public string CategoryName { get; set; } = null!;

        public virtual ICollection<Course> Courses { get; set; }
    }
}
