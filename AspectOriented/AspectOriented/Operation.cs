using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspectOriented.CustomAttributes;

namespace AspectOriented
{
    public class Operation
    {
        [WorkLoad(preAction = "PreMethodTest", postAction = "PostMethodTest")]
        public void ExecuterTest()
        {
            Console.WriteLine("Main Executer Test Method");
        }

        public static void PreMethodTest()
        {
            Console.WriteLine("PreMethod Executer");
        }

        public static void PostMethodTest()
        {
            Console.WriteLine("PostMethod Executer");
        }
    }
}
