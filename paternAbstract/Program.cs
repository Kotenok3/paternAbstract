using paternAbstract;

var factoryArtillery = new ArtilleryArmyFactory();
var factoryCavalry = new CavalryArmyFactory();
var factoryInfantry = new InfantryArmyFactory();

var army1 = new Army(factoryCavalry.CreateCommander());
army1.AddUnit(factoryCavalry.CreateUnit());
army1.AddUnit(factoryCavalry.CreateUnit());
army1.AddUnit(factoryArtillery.CreateUnit());

var army2 = new Army(factoryInfantry.CreateCommander());
army2.AddUnit(factoryInfantry.CreateUnit());
army2.AddUnit(factoryArtillery.CreateUnit());

Console.WriteLine("Первая армия " + army1);
Console.WriteLine("Вторая армия " + army2);

Army.Fight(army1,army2);

Console.WriteLine("Первая армия " + army1);
Console.WriteLine("Вторая армия " + army2);