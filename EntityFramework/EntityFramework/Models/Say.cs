using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class Say: BaseEntity
    {
        public string Image { get; set; }
        public string Sitat { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
    }
}
