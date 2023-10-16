namespace paternAbstract;

public class ArtilleryArmyFactory : AbstractArmyFactory
{
    public override IUnit CreateUnit()
    {
        return new Artillery();
    }
}