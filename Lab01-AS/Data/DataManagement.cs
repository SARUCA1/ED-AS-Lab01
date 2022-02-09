using Lab01_AS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab01_AS.Data
{
    public class DataManagement
    {
        private static DataManagement _instance = null;

        public static DataManagement Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataManagement();
                }
                return _instance;
            }
        }

        public List<PersonModel> personlist = new List<PersonModel>
        {
            new PersonModel
            {
                ID = 1,
                Name = "Alejandro",
                LastName = "Gil",
                PhoneNumber = 12345678,
                Description = "Persona"
            }
        };

    }
}
