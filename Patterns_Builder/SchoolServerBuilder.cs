using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Builder
{
    class SchoolServerBuilder : AbstractServerBuilder
    {
        SchoolServer schoolServer;

        public void Reset()
        {
            schoolServer = new SchoolServer();
            schoolServer.Purpose.Add("for teachers and students");
        }

        public void SetMemory(int memory)
        {
            schoolServer.Memory = memory;
        }
        public void SetConnection(string connection)
        {

            schoolServer.Connection = connection;
        }

        public void SetOS(string os)
        {
            schoolServer.OS = os + " Educational edition";
        }

        public void AddPurpose(string purpose)
        {
            schoolServer.Purpose.Add(purpose);
        }

        public ServerProduct GetProduct()
        {
            return schoolServer;
        }
    }
}
