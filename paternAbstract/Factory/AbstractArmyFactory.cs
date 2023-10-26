namespace paternAbstract;

public abstract class AbstractArmyFactory
{
   public abstract IUnit CreateUnit();
   
   public abstract ICommander CreateCommander();
}
