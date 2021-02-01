using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEcommerce.Data
{
    public class BecUser : IdentityUser
    {
        [Required]
        [MaxLength(20, ErrorMessage = "First name is too long")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Last name is too long")]
        public string LastName { get; set; }

        public string FullName { get => FirstName + " " + LastName; }

        public virtual ICollection<TodoItem> TodoItems { get; set; } = new HashSet<TodoItem>();
    }
}
