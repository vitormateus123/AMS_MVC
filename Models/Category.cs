using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMST5_Task11_Interface01.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}