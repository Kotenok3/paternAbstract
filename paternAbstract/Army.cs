namespace paternAbstract;

public class Army
{
    public List<IUnit> Units = new List<IUnit>();

    public void AddCavalry()
    {
        var factory = new CavalryArmyFactory();
        Units.Add(factory.CreateUnit());
    }

    public void Add(IUnit unit)
    {
        var factory = 1;
    }
}