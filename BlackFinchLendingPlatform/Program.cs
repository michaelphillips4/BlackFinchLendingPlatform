// See https://aka.ms/new-console-template for more information   start 17:50 end 19:00
using BlackFinchLendingPlatform;

Console.WriteLine("Black Finch Lender Calculator /n");

var engine = new LendingEngine();

var list = new List<LendingItem>() {
   new LendingItem(1500001,0,0),
    new LendingItem(99999,0,0), 
    new LendingItem(1000000,3000000,950),
    new LendingItem(200000,300000,999),
    new LendingItem(1000000,2000000,877)
};


foreach (var item in list)
{
  Console.WriteLine(engine.Summary(item));
}

Console.ReadLine();

