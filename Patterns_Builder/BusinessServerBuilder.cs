using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Builder
{
    class BusinessServerBuilder : AbstractServerBuilder
    {
        BusinessServer businessServer;

        public void Reset()
        {
            businessServer = new BusinessServer();
            businessServer.Purpose.Add("for making profit");
        }

        public void SetMemory(int memory)
        {
            businessServer.Memory = memory;
        }
        public void SetConnection(string connection)
        {

            businessServer.Connection = connection;
        }

        public void SetOS(string os)
        {
            businessServer.OS = os + " Enterprise edition";
        }

        public void AddPurpose(string purpose)
        {
            businessServer.Purpose.Add(purpose);
        }

        public ServerProduct GetProduct()
        {
            return businessServer;
        }
    }
}
