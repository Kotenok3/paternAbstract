namespace paternAbstract;

public class CavalryArmyFactory : AbstractArmyFactory
{
    public override IUnit CreateUnit()
    {
        return new Cavalry();
    }
}