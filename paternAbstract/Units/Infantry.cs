namespace paternAbstract;

public class Infantry : IUnit
{
    public string Attack()
    {
        return "Infantry attack";
    }

    public string Defender()
    {
        return "Infantry defender";
    }
}