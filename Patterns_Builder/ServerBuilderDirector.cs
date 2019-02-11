using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Builder
{
    class ServerBuilderDirector
    {
        AbstractServerBuilder serverBuilder;

        public void SetSchoolServerBuilder()
        {
            serverBuilder = new SchoolServerBuilder();
        }

        public void SetBusinessServerBuilder()
        {
            serverBuilder = new BusinessServerBuilder();
        }

        public BusinessServer CreateLocalBusinessServer()
        {
            SetBusinessServerBuilder();
            serverBuilder.Reset();

            serverBuilder.SetMemory(128);
            serverBuilder.SetOS("Windows");
            serverBuilder.AddPurpose("for money calculating things");
            
            return (BusinessServer)serverBuilder.GetProduct();
        }

        public SchoolServer CreateBasicSchoolServer()
        {
            SetSchoolServerBuilder();
            serverBuilder.Reset();

            serverBuilder.SetConnection("basic");
            serverBuilder.SetMemory(1024);
            serverBuilder.SetOS("Windows");
            serverBuilder.AddPurpose("for contests");

            return (SchoolServer)serverBuilder.GetProduct();
        }

        public BusinessServer CreateBasicBusinessServer()
        {
            SetBusinessServerBuilder();
            serverBuilder.Reset();

            serverBuilder.SetConnection("basic");
            serverBuilder.SetMemory(1024);
            serverBuilder.SetOS("Windows");
            serverBuilder.AddPurpose("for contests");
            
            return (BusinessServer)serverBuilder.GetProduct();
        }

        public BusinessServer CreateOSBusinessServer(string OS)
        {
            SetBusinessServerBuilder();
            serverBuilder.Reset();

            serverBuilder.SetConnection("basic");
            serverBuilder.SetMemory(1024);
            serverBuilder.SetOS(OS);
            serverBuilder.AddPurpose("for business");
            
            return (BusinessServer)serverBuilder.GetProduct();
        }
    }
}
