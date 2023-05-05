using ErdincHocaCozumAss15.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErdincHocaCozumAss15.Models
{
    internal class User: BaseClass
    {
        public User()
        {
            Notes = new List<Note>();   
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }

        //Relations
        public ICollection<Note> Notes { get; set; }


    }
}
