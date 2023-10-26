namespace paternAbstract;

public class Cavalry : IUnit
{
    public int Health { get; set; }
    public int Damage { get; set; }
    
    public string Attack()
    {
        return "Cavalry attack";
    }

    public string Defender()
    {
        return "Cavalry defender";
    }
}