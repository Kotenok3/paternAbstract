namespace paternAbstract;

public class Infantry : IUnit
{
    public int Health { get; set; }
    public int Damage { get; set; }
    public string Attack()
    {
        return "Infantry attack";
    }

    public string Defender()
    {
        return "Infantry defender";
    }
}