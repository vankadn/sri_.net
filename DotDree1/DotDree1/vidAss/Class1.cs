using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotDree1
{
    class product
    {
        public int proid { get; set; }
        public List<category> cli { get; set; }

    }
    class category
    {
        public int catid { get; set; }
        public string catName { get; set; }
    }

}
