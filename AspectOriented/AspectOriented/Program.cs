using AspectOriented;
using AspectOriented.CustomAttributes;

/******************** first way ********************/

//var executer = new Runner();
//var operation = new Operation();
//executer.Execute(operation.ExecuterTest);

//Console.ReadLine();

/******************** first way ********************/


/******************** second way ********************/

Console.WriteLine("init");

AspectInjectorSample sample = new AspectInjectorSample();
sample.Method1();
sample.Method2();

Console.WriteLine("out");

Console.ReadLine();





/******************** second way ********************/