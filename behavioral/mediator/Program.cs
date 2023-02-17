// See https://aka.ms/new-console-template for more information
using mediator;

Console.WriteLine("This is an example of the mediator pattern.");

Console.WriteLine(@"
The mediator pattern has 4 different components:
- Mediator: I define communication between colleagues.
- Concrete Mediator: I implement communication between colleagues.
- Colleague: I communicate only with the mediator.
- Concrete Colleague: I receive messages from the mediator.
");

var component1 = new Component1();
var component2 = new Component2();
var concreteMediate = new ConcreteMediator(component1, component2);

ConsoleKeyInfo readKey;
do 
{
    Console.WriteLine("Press A, B, C, D to execute a command or enter key to exit.");
    readKey = Console.ReadKey();
    Console.WriteLine();
    if(readKey.KeyChar == 'A') {
        component1.DoA();
    }
    else if(readKey.KeyChar == 'B') {
        component1.DoB();
    }
    else if(readKey.KeyChar == 'C') {
        component2.DoC();
    }
    else if(readKey.KeyChar == 'D') {
        component2.DoD();
    }
    Console.WriteLine();

}while (readKey.Key != ConsoleKey.Enter);