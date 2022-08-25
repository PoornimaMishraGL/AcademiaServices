using System;
using System.Collections.Generic;

namespace AcademiaServices.Models
{
    public partial class Cart
    {
        public int Id { get; set; }
        public string ImagePath { get; set; } = null!;
        public int StuId { get; set; }
        public int CourseId { get; set; }
        public string Coursename { get; set; } = null!;
        public string Price { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Duration { get; set; } = null!;
        public string MentorName { get; set; } = null!;

        public virtual Course Course { get; set; } = null!;
        public virtual Student Stu { get; set; } = null!;
    }
}
