using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class BlogCard: BaseEntity
    {
        public string Image { get; set; }
        public string Date { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
    }
}
