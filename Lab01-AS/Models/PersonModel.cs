using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab01_AS.Models
{
    public class PersonModel
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(11)]
        public int PhoneNumber { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }
    }
}
