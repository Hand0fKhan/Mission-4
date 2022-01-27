using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        public string Rating { get; set; }
        public bool Edit { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Director { get; set; }
    }
}
