using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Models
{
    public partial class Question
    {
        public int IdQuestion { get; set; }
        public string Question1 { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
