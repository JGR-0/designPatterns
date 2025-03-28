﻿namespace designPatterns.behavioral.mediator.structural;

public static class Program 
{
    public static void Main(string[] args) 
    {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("This is an example of the mediator pattern.");

        Console.WriteLine(@"
        The mediator pattern has 4 different components:
        - Mediator: I define communication between colleagues.
        - Concrete Mediator: I implement communication between colleagues.
        - Colleague: I communicate only with the mediator.
        - Concrete Colleague: I receive messages from the mediator.
        ");

        var concreteMediator = new ConcreteMediator();

        var component1 = concreteMediator.CreateComponent<Component1>();
        var component2 = concreteMediator.CreateComponent<Component2>();

        component1.Send("Hi there! (from component1)");
        component2.Send("Hey! How are you? (from component2)");

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}