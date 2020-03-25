using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTest.Models
{
    public class Person
    {
        [JsonIgnore]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "User name is required.")]
        [StringLength(50, MinimumLength = 3)]
        [RegularExpression(@"[a-zA-Z\\s]*", ErrorMessage = "User name should not have whitespaces")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Name is Required")]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Email ID is Required")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect Email Format")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Confirm Email is Required")]
        [DataType(DataType.EmailAddress)]
        [System.ComponentModel.DataAnnotations.Compare("Email", ErrorMessage = "Email Not Matched")]
        public string ConfirmEmail { get; set; } = string.Empty;

        [Required(ErrorMessage = "Age is Required")]
        [Range(1, 120, ErrorMessage = "Age must be between 1-120 in years.")]
        public int Age { get; set; } = -1;
    }
}
