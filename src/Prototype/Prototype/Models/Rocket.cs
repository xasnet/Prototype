using Prototype.Interfaces;

namespace Prototype.Models
{
    public class Rocket : RocketStage, IMyCloneable<Rocket>
    {
        private const int RocketFuelTank = 1500;
        protected bool HasAstronaut;

        public Rocket(string name, int speed) : base(name, speed)
        {
            HasFuel = true;
            HasAstronaut = true;
            Fuel = RocketFuelTank;
        }

        private Rocket(Rocket rocket)
            : this(rocket.Name, rocket.Speed)
        {
        }

        public override Rocket MyClone()
        {
            return new Rocket(this);
        }

        public override string ToString()
        {
            return $"Rocket Name: {Name}, Speed: {Speed}, Fuel: {Fuel}, HasFuel: {HasFuel}, HasAstronaut: {HasAstronaut}";
        }
    }
}
