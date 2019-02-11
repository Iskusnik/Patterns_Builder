using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Builder
{
    class Program
    {
        static void PrintServerInfo(BusinessServer businessServer)
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Memory:{0,-3} Connection:{1,-4} OS:{2, -5} Feature:{3}", 
                            businessServer.Memory,
                            businessServer.Connection,
                            businessServer.OS,
                            businessServer.Feature);
            for (int i = 0; i < businessServer.Purpose.Count; i++)
                Console.WriteLine(businessServer.Purpose[i]);
            Console.WriteLine("---------------");
        }
        static void PrintServerInfo(SchoolServer schoolServer)
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Memory:{0,-3} Connection:{1,-4} OS:{2, -5} Feature:{3}",
                            schoolServer.Memory,
                            schoolServer.Connection,
                            schoolServer.OS,
                            schoolServer.Feature);
            for (int i = 0; i < schoolServer.Purpose.Count; i++)
                Console.WriteLine(schoolServer.Purpose[i]);
            Console.WriteLine("---------------");
        }
        static void Main(string[] args)
        {
            ServerBuilderDirector director = new ServerBuilderDirector();

            PrintServerInfo(director.CreateBasicBusinessServer());
            PrintServerInfo(director.CreateBasicSchoolServer());
            PrintServerInfo(director.CreateLocalBusinessServer());
            PrintServerInfo(director.CreateOSBusinessServer("Special OS"));

        }
    }
}
