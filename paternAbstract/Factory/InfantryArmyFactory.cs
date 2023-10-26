namespace paternAbstract;

public class InfantryArmyFactory : AbstractArmyFactory
{
    public override IUnit CreateUnit()
    {
        Random rand = new Random();
        IUnit infantryUnit = new Infantry();
        infantryUnit.Health = rand.Next(80, 100);
        infantryUnit.Damage = rand.Next(10, 30);
        return infantryUnit;
    }

    public override ICommander CreateCommander()
    {
        return new InfantryCommander();
    }
}