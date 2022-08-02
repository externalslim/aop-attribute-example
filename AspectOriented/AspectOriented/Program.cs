// See https://aka.ms/new-console-template for more information
using AspectOriented;
using AspectOriented.CustomAttributes;

var executer = new Runner();
var operation = new Operation();
executer.Execute(operation.ExecuterTest);

Console.ReadLine();

