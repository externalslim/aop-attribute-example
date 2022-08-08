using Aspect.Domain.Models;
using AspectOriented;
using Newtonsoft.Json;

/******************** first way ********************/

//var executer = new Runner();
//var operation = new Operation();
//executer.Execute(operation.ExecuterTest);

//Console.ReadLine();

/******************** first way ********************/


/******************** second way ********************/

Console.WriteLine("init");

Person person = new();
person.Id = 1;
person.FirstName = "Joe";
person.LastName = "Doe";
person.Email = "JoeDoe@emailtest.com";

Person personTwo = new();
personTwo.Id = 10;
personTwo.FirstName = "AnotherJoe";
personTwo.LastName = "AnotherDoe";
personTwo.Email = "AnotherJoeDoe@emailtest.com";
try
{

    AspectInjectorSample sample = new AspectInjectorSample();

    var response = sample.Method1(person);

    Console.WriteLine(JsonConvert.SerializeObject(response));

    var responseAnother = sample.Method2(personTwo);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine("out");

Console.ReadLine();

/******************** second way ********************/