using System;
using System.Collections.Generic;

namespace AcademiaServices.Models
{
    public partial class ContactU
    {
        public string GmailId { get; set; } = null!;
        public int StuId { get; set; }
        public string Name { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Message { get; set; } = null!;

        public virtual Student Stu { get; set; } = null!;
    }
}
