using System.Data.Common;
using designPatterns.behavioral.mediator.airTrafficControlSystem.contracts;

namespace designPatterns.behavioral.mediator.airTrafficControlSystem;

public class Airplane {

    public Airplane(ICommunicationMediator mediator, string destination) {
        Id = Guid.NewGuid();
        CurrentPosition = new Position(0,0);
        Destination = destination;
        var _mediator = mediator;
        _mediator.RegisterAirplane(this);
    }

    public void UpdateCurrentPosition(Position newPosition) {
        if(CurrentPosition.Equals(newPosition)) return;
        CurrentPosition = newPosition;
    }

    public Guid Id { get; private set; }

    public Position CurrentPosition { get; private set; }

    public decimal Altitude { get; private set; }

    public decimal Speed { get; private set; }

    public string Destination { get; private set; }
}

public class Position {

    public Position(float latitude, float longitude) {
        Latitude = latitude;
        Longitude = longitude;
    }

    public decimal Latitude { get; private set; }

    public decimal Longitude { get; private set; }

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

    public override int GetHashCode()
    {
        var hash = 13;
        hash = (hash*7) + Latitude.GetHashCode();
        hash = (hash*7) + Longitude.GetHashCode();
        return hash;
    }
}