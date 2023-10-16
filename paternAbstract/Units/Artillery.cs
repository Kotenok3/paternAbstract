namespace paternAbstract;

public class Artillery : IUnit
{
    public string Attack()
    {
        return "Artillery attack";
    }

    public string Defender()
    {
        return "Artillery defender";
    }
}