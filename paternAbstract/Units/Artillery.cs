namespace paternAbstract;

public class Artillery : IUnit
{
    public int Health { get; set; }
    public int Damage { get; set; }
    public string Attack()
    {
        return "Artillery attack";
    }

    public string Defender()
    {
        return "Artillery defender";
    }
}