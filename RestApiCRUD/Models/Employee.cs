using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiCRUD.Models
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage ="Name Exceeds 50 characters")]
        public string Name { get; set; }
    }
}
