using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    internal class LicenseProgram
    {
        public static int License(string me, int AgentCount, string peoplesNames)
        {
            List<string> peopleList = peoplesNames.Split(" ").ToList();
            peopleList.Add(me);
            peopleList.Sort();
            int myIdx = peopleList.IndexOf(me);
            if(myIdx>=AgentCount)
            {
                int waitingTime = myIdx/AgentCount *20;
                return waitingTime+20;
            }else
            {
                return 20;
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(License("Eric", 2, "Adam Caroline Rebecca Frank"));
            Console.WriteLine(License("Zebediah", 1, "Bob Jim Becky Pat"));
            Console.WriteLine(License("Aaron", 3, "Jane Max Olivia Sam"));
        }
    }
}
