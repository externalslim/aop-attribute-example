using Aspect.Domain.Models.IdentityApi;
using AspectInjector.Broker;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Phoenix.Core.Common;
using System;
using System.Dynamic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace Aspect.Library.CustomAttributes
{

    [AspectInjector.Broker.Aspect(Scope.Global)]
    [Injection(typeof(IdentityAspectAttribute))]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public sealed class IdentityAspectAttribute : Attribute
    {
        public string Name { get; set; }

        [Advice(Kind.Around, Targets = Target.Method)]
        public object Around(
            [Argument(Source.Arguments)] object[] args,
            [Argument(Source.Target)] Func<object[], object> target,
            [Argument(Source.Triggers)] Attribute[] instance)
        {
            try
            {
                Name = "test";
                GenerateUserTokenRequest request = new();

                request = JsonConvert.DeserializeObject<GenerateUserTokenRequest>
                            (JsonConvert.SerializeObject(args[0]));

                if (request.Channel == Channel.ATM)
                {
                    throw new Exception();
                }
                else
                {
                    var result = target(args);
                    return result;
                }
            }
            catch (Exception)
            {
                ServiceResponse<GenerateUserTokenResponse> response = new();

                var demo = new Demo();
                demo.Message = "demo dynamic object";                

                var error = new ServiceError { Code = "799", Message = "test" };
                response.Status.Errors.Add(error);

                return target(args);
            }
            
        }
    }
}
