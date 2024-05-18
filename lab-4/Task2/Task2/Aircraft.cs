using System;

namespace Task2
{
    public class Aircraft
    {
        public string Name { get; }
        public Runway? CurrentRunway { get; set; }
        public bool IsTakingOff { get; set; }
        private readonly IMediator _mediator;

        public Aircraft(string name, IMediator mediator)
        {
            this.Name = name;
            this._mediator = mediator;
        }

        public void RequestLanding(Runway runway)
        {
            _mediator.RequestLanding(this, runway);
        }

        public void RequestTakeOff(Runway runway)
        {
            _mediator.RequestTakeOff(this, runway);
        }
    }
}
