using AspectInjector.Broker;

namespace AspectOriented.CustomAttributes
{
    [Aspect(Scope.Global)]
    [Injection(typeof(TraceAspectAttribute))]
    public sealed class TraceAspectAttribute : Attribute
    {
        [Advice(Kind.Before, Targets = Target.Method)]
        public void TraceStart()
        {
            Console.WriteLine("trace start");
        }

        [Advice(Kind.After, Targets = Target.Method)]
        public void TraceFinish()
        {
            Console.WriteLine("trace finish");
        }
    }
}
