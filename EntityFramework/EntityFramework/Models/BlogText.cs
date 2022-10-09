using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class BlogText: BaseEntity
    {
        public string Header { get; set; }
        public string Description { get; set; }
    }
}
