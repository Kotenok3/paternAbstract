namespace paternAbstract;

public class CavalryArmyFactory : AbstractArmyFactory
{
    public override IUnit CreateUnit()
    {
        Random rand = new Random();
        IUnit cavalryUnit = new Cavalry();
        cavalryUnit.Health = rand.Next(80, 100);
        cavalryUnit.Damage = rand.Next(10, 30);
        return cavalryUnit;
    }

    public override ICommander CreateCommander()
    {
        return new CavalryCommander();
    }
}