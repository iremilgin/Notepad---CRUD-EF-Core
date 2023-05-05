using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErdincHocaCozumAss15.Models
{
    internal class Note: BaseClass
    {
        public string Title { get; set; }
        public string Content { get; set; }

        //Relations
        public int UserId { get; set; }
        public User User{ get; set; }

    }
}
