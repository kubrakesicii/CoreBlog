using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class About
    {
        public int Id { get; set; }
        public string Detail1 { get; set; }
        public string Detail2 { get; set; }
        public string ImagePath1 { get; set; }
        public string ImagePath2 { get; set; }
        public string MapLocation { get; set; }
        public int IsActive { get; set; }
    }
}
