namespace paternAbstract;

public class Army
{
    public List<IUnit> Units = new List<IUnit>();

    public void AddCavalry()
    {
        var factory = new CavalryArmyFactory();
        Units.Add(factory.CreateUnit());
    }

    public void AddArtillery()
    {
        var factory = new ArtilleryArmyFactory();
        Units.Add(factory.CreateUnit());
    }
    public void AddInfantry()
    {
        var factory = new InfantryArmyFactory();
        Units.Add(factory.CreateUnit());
    }
}