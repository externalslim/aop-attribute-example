using AspectInjector.Broker;
using AspectOriented.Models;

namespace AspectOriented.CustomAttributes
{
    [Aspect(Scope.Global)]
    [Injection(typeof(TraceAspectAttribute))]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public sealed class TraceAspectAttribute : Attribute
    {
        [Advice(Kind.Around, Targets = Target.Method)]
        public object Around(
            [Argument(Source.Arguments)] object[] args,
            [Argument(Source.Target)] Func<object[], object> target)
        {
            Console.WriteLine("around worked");
            
            var id = args[0].GetType().GetProperty("Id").GetValue(args[0], null);

            if (Convert.ToInt32(id) == 10)
            {
                return new Response()
                {
                    Code = 500,
                    Message = "demo"
                };
            } 
            else
            {
                var result = target(args);
                return result;
            }

            
        }
    }
}
