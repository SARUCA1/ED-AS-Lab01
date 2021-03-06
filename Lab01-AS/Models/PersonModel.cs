using Lab01_AS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab01_AS.Models
{
    public class PersonModel
    {
        public int Id { get; internal set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(11)]
        public int PhoneNumber { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }
      
        public static void Save(PersonModel model)
        {
            DataManagement.Instance.personlist.Add(model);
        }

        public static bool Edit(PersonModel model)
        {
            throw new NotImplementedException();
        }
    }
}
