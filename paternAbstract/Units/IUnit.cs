namespace paternAbstract;

public interface IUnit
{
    public int Health { get; set; }
    public int Damage { get; set; }
    string Attack();
    string Defender();
}