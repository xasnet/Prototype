using Prototype.Interfaces;

namespace Prototype.Models
{
    public class RocketStage : SpaceTransport, IMyCloneable<RocketStage>
    {
        private const int RocketStageFuelTank = 500;
        protected bool HasFuel;

        public RocketStage(string name, int speed) : base(name, speed)
        {
            Fuel = RocketStageFuelTank;
            HasFuel = true;
        }

        private RocketStage(RocketStage rocketStage)
            : this(rocketStage.Name, rocketStage.Speed)
        {
        }

        public override RocketStage MyClone()
        {
            return new RocketStage(this);
        }

        public override string ToString()
        {
            return $"RocketStage Name: {Name}, Speed: {Speed}, Fuel: {Fuel}, HasFuel: {HasFuel}";
        }
    }
}
