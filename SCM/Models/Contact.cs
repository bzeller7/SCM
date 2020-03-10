using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCM.Models
{
    public class Contact
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string PhoneNum { get; set; }

        //int is automatically required because
        //it is a value type
        [Key] //Mark this field as PK (Primary Key)
        public int MemberId { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }


}
