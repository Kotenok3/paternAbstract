namespace paternAbstract;

public class Cavalry : IUnit
{
    public string Attack()
    {
        return "Cavalry attack";
    }

    public string Defender()
    {
        return "Cavalry defender";
    }
}