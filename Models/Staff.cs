using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AvondaleTyres.Models
{
    public class Staff
    {

        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public String Name { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
        ErrorMessage = "Invalid email format")]
        [Display(Name = "Work Email")]
        public String Email { get; set; }

        [Required]
        public int Experience { get; set; }

        [Required]
        public String Department { get; set; }


        [Required]
        public String Occupation { get; set; }

        [Required]
        [Display(Name = "Image")]
        public string ProfilePicture { get; set; }
        //Requirements when creating a staff
    }
}
