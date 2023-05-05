using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErdincHocaCozumAss15.Models
{
    internal abstract class BaseClass
    {
        public BaseClass()
        {
            CreationDate = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsActive { get; set; }

    }
}
