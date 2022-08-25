using System;
using System.Collections.Generic;

namespace AcademiaServices.Models
{
    public partial class Feedback
    {
        public int Id { get; set; }
        public string EmailId { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Suggestion { get; set; } = null!;
    }
}
