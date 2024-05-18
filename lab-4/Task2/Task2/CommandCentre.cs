using System;
using System.Collections.Generic;

namespace Task2
{
    public interface IMediator
    {
        void RequestLanding(Aircraft aircraft, Runway runway);
        void RequestTakeOff(Aircraft aircraft, Runway runway);
    }

    public class CommandCentre : IMediator
    {
        private List<Runway> _runways = new List<Runway>();
        private List<Aircraft> _aircrafts = new List<Aircraft>();

        public CommandCentre(Runway[] runways, Aircraft[] aircrafts)
        {
            this._runways.AddRange(runways);
            this._aircrafts.AddRange(aircrafts);
        }

        public void RequestLanding(Aircraft aircraft, Runway runway)
        {
            Console.WriteLine($"Aircraft {aircraft.Name} is requesting landing.");
            if (runway.IsBusyWithAircraft == null)
            {
                Console.WriteLine($"Checking runway.");
                Console.WriteLine($"Aircraft {aircraft.Name} has landed.");
                runway.IsBusyWithAircraft = aircraft;
                runway.HighLightRed();
                aircraft.CurrentRunway = runway;
            }
            else
            {
                Console.WriteLine($"Could not land, the runway is busy.");
            }
        }

        public void RequestTakeOff(Aircraft aircraft, Runway runway)
        {
            Console.WriteLine($"Aircraft {aircraft.Name} is requesting takeoff.");
            if (runway.CheckIsActive())
            {
                Console.WriteLine($"Runway {runway.Id} is currently active, cannot take off.");
            }
            else
            {
                Console.WriteLine($"Aircraft {aircraft.Name} has taken off.");
                runway.IsBusyWithAircraft = null;
                aircraft.CurrentRunway = null;
                runway.HighLightGreen();
            }
        }
    }
}
