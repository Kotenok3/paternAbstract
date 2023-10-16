namespace paternAbstract;

public class InfantryArmyFactory : AbstractArmyFactory
{
    public override IUnit CreateUnit()
    {
        return new Infantry();
    }
}