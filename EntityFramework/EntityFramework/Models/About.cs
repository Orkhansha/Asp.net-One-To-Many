using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class About: BaseEntity
    {
        public string Image { get; set; }
        public string Header { get; set; }
        public string Title { get; set; }

        public string Desc1 { get; set; }
        public string Desc2 { get; set; }
        public string Desc3 { get; set; }
    }
}
