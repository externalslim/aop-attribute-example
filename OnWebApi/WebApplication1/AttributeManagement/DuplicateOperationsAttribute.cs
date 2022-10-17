using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using WebApplication1.Contracts;
using WebApplication1.Models;

namespace WebApplication1.AttributeManagement
{
    public class DuplicateOperationsAttribute : IAsyncActionFilter
    {

        private ITransportService _transporService;

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            _transporService = (ITransportService)context.HttpContext.RequestServices.GetService(typeof(ITransportService));

            var k = _transporService.TestList;


            if (k.First().Name != "cihan")
            {

                Test resp = new Test()
                {
                    Name = "resp",
                    Surname = "another resp"
                };

                context.Result = new ContentResult()
                {
                    StatusCode = (int)System.Net.HttpStatusCode.BadRequest,
                    ContentType = "application/json",
                    Content = JsonConvert.SerializeObject(resp)
                };

                await Task.CompletedTask;
            }
            else
            {
                var result = await next();
                
                Test resp = new Test()
                {
                    Name = "another fail resp after next observ",
                    Surname = "another fail resp after next observ"
                };

                if (k.First().Age > 10)
                {
                    result.Result = new ContentResult()
                    {
                        StatusCode = (int)System.Net.HttpStatusCode.OK,
                        ContentType = "application/json",
                        Content = JsonConvert.SerializeObject(resp)
                    };

                    await Task.CompletedTask;
                }
            }

        }
    }
}
