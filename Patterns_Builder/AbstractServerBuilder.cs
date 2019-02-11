using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Builder
{
    interface AbstractServerBuilder
    {
        void Reset();

        void SetMemory(int memory);

        void SetConnection(string connection);   

        void SetOS(string os);

        void AddPurpose(string purpose);

        ServerProduct GetProduct();
    }
    
}
