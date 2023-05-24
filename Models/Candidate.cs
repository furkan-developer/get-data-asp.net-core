using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BtkCamp.Models
{
    public class Candidate
    {
        [Required(ErrorMessage ="Email alan� bo� b�rak�lamaz!")]
        public String? Email { get; set; } = String.Empty;

        [Required(ErrorMessage = "FirstName alan� bo� b�rak�lamaz!")]
        public String? FirstName { get; set; } = String.Empty;

        [Required(ErrorMessage = "LastName alan� bo� b�rak�lamaz!")]
        public String? LastName { get; set; } = String.Empty;

        public String? FullName => $"{FirstName} {LastName}";
        public int? Age { get; set; }
        public String? SelectedCourse { get; set; } = String.Empty;
        public DateTime ApplyAt { get; set; }

        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }
    }
}