namespace paternAbstract;

public class Army
{
    public List<IUnit> Units = new List<IUnit>();
    public ICommander Commander { get; private set; }

    public void AddUnit(IUnit unit)
    {
        Units.Add(unit);
    }

    public Army(ICommander commander)
    {
        Commander = commander;
        Commander.OnOrderToAttack += CommanderAttackOrderHandler;
        Commander.OnOrderToDefend += CommanderDefendOrderHandler;
    }

    public static void Fight(Army firstArmy, Army secondArmy)
    {
        int countKillFirstArmy = 0, countKillSecondArmy = 0, totalDamageFrsArmy = 0, totalDamageScnArmy = 0;

        for (int i = 0; i < Math.Min(firstArmy.Units.Count,secondArmy.Units.Count); i++)
        {
            firstArmy.Units[i].Health -= secondArmy.Units[i].Damage;
            secondArmy.Units[i].Health -= firstArmy.Units[i].Damage;

            if (firstArmy.Units[i].Health < 0) countKillSecondArmy++;
            if (secondArmy.Units[i].Health < 0) countKillFirstArmy++;

            totalDamageFrsArmy += firstArmy.Units[i].Damage;
            totalDamageScnArmy += secondArmy.Units[i].Damage;
        }

        Console.WriteLine($"Первая армия убила {countKillFirstArmy} бойцов второй армии и нанесла в сумме {totalDamageFrsArmy} урона");
        Console.WriteLine($"Первая армия убила {countKillSecondArmy} бойцов второй армии и нанесла в сумме {totalDamageScnArmy} урона");
    }

    private void CommanderAttackOrderHandler()
    {
        Units.Select(u => u.Attack());
    }
    
    private void CommanderDefendOrderHandler()
    {
        Units.Select(u => u.Defender());
    }

    public override string ToString()
    {
        return "Состав Армии: " + String.Join(",", Units.Select(u => $"{u.Health}hp {u.Damage} d"));
    }
}