namespace designPatterns.behavioral.mediator.airTrafficControlSystem;

public static class Program 
{
    public static void Main(string[] args) 
    {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Welcome to the air traffic control system!");

        var communicationManagment = new CommunicationManagement();

        var airplane1 = new Airplane(communicationManagment, "Madrid");
        var airplane2 = new Airplane(communicationManagment, "Rome");

        communicationManagment.SendMessage("Hello Airplane 2! ", airplane1, airplane2);
    }
}