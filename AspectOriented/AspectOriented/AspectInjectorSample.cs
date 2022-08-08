using AspectOriented.CustomAttributes;

namespace AspectOriented
{
    
    public class AspectInjectorSample
    {
        [TraceAspect]
        public void Method1()
        {
            Console.WriteLine("method1");
        }

        //[TraceAspect]
        public void Method2()
        {
            Console.WriteLine("method2");
        }

    }
}
