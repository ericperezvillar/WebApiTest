using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTest.Models
{
    public class Product
    {
        /// <summary>
        /// Product code
        /// </summary>
        [Required(ErrorMessage = "Required!")]
        [StringLength(10, ErrorMessage = "Maximum {2} characters exceeded")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Required!")]
        [MaxLength(100)]
        public string Description { get; set; }
        public string Um { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = ("Please enter only digits for CodStat"))]
        public string CodStat { get; set; }
        public int PcCart { get; set; }
        public double NetWeight { get; set; }
        public string State { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public double Price { get; set; }
    }
}
