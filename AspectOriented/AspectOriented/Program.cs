using System.Text;
using Aspect.Domain.Models;
using Aspect.Domain.Models.IdentityApi;
using AspectOriented;
using Newtonsoft.Json;

//Console.WriteLine("init");
int workerThreads = 0;
int completionPortThreads = 0;
ThreadPool.GetMaxThreads(out workerThreads, out completionPortThreads);
Console.WriteLine("workerThreads " + workerThreads);
Console.WriteLine("completionPortThreads " + completionPortThreads);

ThreadPool.SetMaxThreads(500, 8);
int afterSetworkerThreads = 0;
int afterSetcompletionPortThreads = 0;
ThreadPool.GetMaxThreads(out afterSetworkerThreads, out afterSetcompletionPortThreads);
Console.WriteLine("afterSetworkerThreads " + afterSetworkerThreads);
Console.WriteLine("afterSetcompletionPortThreads " + afterSetcompletionPortThreads);

int minworkerThreads = 0;
int mincompletionPortThreads = 0;
ThreadPool.GetMinThreads(out minworkerThreads, out mincompletionPortThreads);
Console.WriteLine("minworkerThreads " + minworkerThreads);
Console.WriteLine("mincompletionPortThreads " + mincompletionPortThreads);

//GenerateUserTokenRequest request = new();
//request.Channel = Phoenix.Core.Common.Channel.Mobile;

//try
//{

//    AspectInjectorSample sample = new AspectInjectorSample();
//    var response = sample.Test();
//    Console.WriteLine(JsonConvert.SerializeObject(response));
//    //var response = sample.Method1(person);
//    //Console.WriteLine(JsonConvert.SerializeObject(response));

//    //var responseAnother = sample.Method2(personTwo);
//    //Console.WriteLine(JsonConvert.SerializeObject(responseAnother));

//    //var responseDemoRequest = sample.Method3(request);
//    //Console.WriteLine(JsonConvert.SerializeObject(responseDemoRequest));

//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
Console.WriteLine("out");

Console.ReadLine();

/******************** second way ********************/