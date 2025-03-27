using designPatterns.behavioral.mediator.airTrafficControlSystem.contracts;

namespace designPatterns.behavioral.mediator.airTrafficControlSystem;

public class Airplane {

    private ICommunicationMediator Mediator;
    
    public Airplane(ICommunicationMediator mediator, string destination) {
        Id = Guid.NewGuid();
        CurrentPosition = new Position(0,0);
        Destination = destination;
        Mediator = mediator;
        Mediator.RegisterAirplane(this);
    }

    public void UpdateCurrentPosition(Position newPosition) {
        if(CurrentPosition.Equals(newPosition)) return;
        CurrentPosition = newPosition;
    }

    public Guid Id { get; private set; }

    public Position CurrentPosition { get; private set; }

    public float Altitude { get; private set; }

    public float Speed { get; private set; }

    public string Destination { get; private set; }
}

public class Position {

    public Position(float latitude, float longitude) {
        Latitude = Latitude;
        Longitude = longitude;
    }

    public float Latitude { get; private set; }

    public float Longitude { get; private set; }

    // override object.Equals
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        
        var objPosition = (Position)obj;

        return this.Longitude == objPosition.Longitude
            && this.Latitude == objPosition.Latitude;
    }
}