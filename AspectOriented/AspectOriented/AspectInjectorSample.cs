using Aspect.Domain.Models;
using Aspect.Domain.Models.IdentityApi;
using Aspect.Library.CustomAttributes;
using Phoenix.Core.Common;

namespace AspectOriented
{
    
    public class AspectInjectorSample
    {
        [IdentityAspect]
        public ServiceResponse<GenerateUserTokenResponse> Test()
        {
            return new ServiceResponse<GenerateUserTokenResponse>();
        }
        //[TraceAspect]
        //public Response Method1(Person person)
        //{
        //    Console.WriteLine("method1");

        //    return new Response()
        //    {
        //        Code = 200,
        //        Message = "method 1 success"
        //    };
        //}

        ////[TraceAspect]
        //public Response Method2(Person person)
        //{
        //    Console.WriteLine("method2");

        //    return new Response()
        //    {
        //        Code = 200,
        //        Message = "method 2 success"
        //    };
        //}

        //[TraceAspect]
        //public Response Method3(DemoRequest demoRequest)
        //{
        //    Console.WriteLine("method3");

        //    return new Response()
        //    {
        //        Code = 200,
        //        Message = "method 3 success"
        //    };
        //}

    }
}
