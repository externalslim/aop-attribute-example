using Aspect.Domain.Models;
using Aspect.Library.CustomAttributes;

namespace AspectOriented
{
    
    public class AspectInjectorSample
    {
        [TraceAspect]
        public Response Method1(Person person)
        {
            Console.WriteLine("method1");

            return new Response()
            {
                Code = 200,
                Message = "method 1 success"
            };
        }

        [TraceAspect]
        public Response Method2(Person person)
        {
            Console.WriteLine("method2");

            return new Response()
            {
                Code = 200,
                Message = "method 2 success"
            };
        }

    }
}
