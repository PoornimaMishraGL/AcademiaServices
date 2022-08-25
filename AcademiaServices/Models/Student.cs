using System;
using System.Collections.Generic;

namespace AcademiaServices.Models
{
    public partial class Student
    {
        public Student()
        {
            Carts = new HashSet<Cart>();
            ContactUs = new HashSet<ContactU>();
        }

        public int StuId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string ImagePath { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Country { get; set; } = null!;

        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<ContactU> ContactUs { get; set; }
    }
}
