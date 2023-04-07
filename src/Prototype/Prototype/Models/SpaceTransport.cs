using Prototype.Interfaces;

namespace Prototype.Models
{
    public class SpaceTransport : IMyCloneable<SpaceTransport>, ICloneable
    {
        private const int FullFuelTank = 0;
        public string Name { get; set; }
        public int Speed { get; }
        protected int Fuel;

        public SpaceTransport(string name, int speed)
        {
            Name = name;
            Speed = speed;
            Fuel = FullFuelTank;
        }

        private SpaceTransport(SpaceTransport spaceTransport)
            : this(spaceTransport.Name, spaceTransport.Speed)
        {
            Fuel = spaceTransport.Fuel;
        }

        public virtual SpaceTransport MyClone()
        {
            return new SpaceTransport(this);
        }

        public override string ToString()
        {
            return $"SpaceTransport Name: {Name}, Speed: {Speed}, Fuel: {Fuel}";
        }

        public object Clone()
        {
            return MyClone();
        }
    }
}
