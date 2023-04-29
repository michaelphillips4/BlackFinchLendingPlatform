
using BlackFinchLendingPlatform;

Console.WriteLine("Black Finch Lender Calculator \n");

var lendingEngine = new LendingEngine();

var dataSet = new List<LendingItem>() {
   new LendingItem(1500001,0,0),
    new LendingItem(99999,0,0), 
    new LendingItem(1000000,3000000,950),
    new LendingItem(200000,300000,999),
    new LendingItem(1000000,2000000,877)
};

lendingEngine.LendingItems = dataSet;

foreach (var item in lendingEngine.LendingItems)
{

    Console.WriteLine(item.ToString());
  
}

Console.WriteLine();

Console.WriteLine(lendingEngine.Summary());

Console.ReadLine();

