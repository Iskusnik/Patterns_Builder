using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Builder
{
    class BusinessServer: ServerProduct
    {
        public int Memory;
        public string Connection;
        public string OS;
        public List<string> Purpose;
        public string Feature;
        
        public BusinessServer()
        {
            Memory = 0;
            Connection = "local";
            OS = "none";
            Purpose = new List<string>();

            Feature = "for business";
        }
    }
}
