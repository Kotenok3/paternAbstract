namespace paternAbstract;

public class ArtilleryArmyFactory : AbstractArmyFactory
{
    public override IUnit CreateUnit()
    {
        Random rand = new Random();
        IUnit artilleryUnit = new Artillery();
        artilleryUnit.Health = rand.Next(80, 100);
        artilleryUnit.Damage = rand.Next(10, 30);
        return artilleryUnit;
    }

    public override ICommander CreateCommander()
    {
        return new ArtilleryCommander();
    }
}