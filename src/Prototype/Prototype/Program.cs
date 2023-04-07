using Prototype.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        var spaceTransport = new SpaceTransport("Космический транспорт", 0);
        var rocketStage = new RocketStage("Ступень ракеты", 7900);
        var rocket = new Rocket("Ракета Восток", 7900);

        Console.WriteLine(spaceTransport);
        Console.WriteLine(rocketStage);
        Console.WriteLine(rocket);
        Console.WriteLine();

        var spaceTransportClone_1 = (SpaceTransport)spaceTransport.Clone();
        spaceTransportClone_1.Name += "_1";
        var rocketStageClone_1 = (RocketStage)rocketStage.Clone();
        rocketStageClone_1.Name += "_1";
        var rocketClone_1 = (Rocket)rocket.Clone();
        rocketClone_1.Name += "_1";

        Console.WriteLine(spaceTransportClone_1);
        Console.WriteLine(rocketStageClone_1);
        Console.WriteLine(rocketClone_1);
        Console.WriteLine();

        var spaceTransportClone_2 = (SpaceTransport)spaceTransportClone_1.MyClone();
        spaceTransportClone_2.Name += "_2";
        var rocketStageClone_2 = (RocketStage)rocketStageClone_1.MyClone();
        rocketStageClone_2.Name += "_2";
        var rocketClone_2 = (Rocket)rocketClone_1.MyClone();
        rocketClone_2.Name += "_2";

        Console.WriteLine(spaceTransportClone_2);
        Console.WriteLine(rocketStageClone_2);
        Console.WriteLine(rocketClone_2);

        Console.ReadKey();
    }
}