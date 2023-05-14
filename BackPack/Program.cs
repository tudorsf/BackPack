using BackPack;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Configure backpack");  
        Console.WriteLine("Total Elements:");
        var totalElements = Console.ReadLine();
        Console.WriteLine("Total Weight: ");
        var totalWeight = Console.ReadLine();
        Console.WriteLine("Total Volume: ");
        var totalVolume = Console.ReadLine();

        var backPack = new BackPack.BackPack(Convert.ToUInt16(totalElements), Convert.ToDouble(totalWeight), Convert.ToDouble(totalVolume));
        backPack.Articles = new List<Inventory>();
        var arc = new Arc();
        var spear = new Sageata();
        var rope = new Rope();
        var water = new Water();
        var food = new Food();
        var sword = new Sword();

        
        int remainedElements()
        {
            int remainedElements = Convert.ToUInt16(totalElements) - (backPack.Articles.Count());
            return remainedElements;
        }
        
        double remainedWeight()
        {
            double remainedWeight = Convert.ToDouble(totalWeight) - (backPack.Articles.Sum(x => x.Weight));
            return remainedWeight;
        }
       double remainedVolume()
        {
            double remainedVolume = Convert.ToDouble(totalVolume) - (backPack.Articles.Sum(x => x.Volume));
            
            return remainedVolume;
        }

       
        Console.WriteLine("Alegeti un Articol");

        Console.WriteLine("arc");
        Console.WriteLine("spear");
        Console.WriteLine("rope");
        Console.WriteLine("water");
        Console.WriteLine("food");
        Console.WriteLine("sword");
        Console.WriteLine("empty backpack");
        var showMenu = true;
        while (showMenu)
        {
            var key = Console.ReadLine();
           
            switch (key)
            {
                case "arc":
                    if (backPack.Add(arc))
                    {
                        Console.WriteLine("added object");
                        Console.WriteLine("Remained Elements:" + remainedElements());
                        Console.WriteLine("Remained volume:" + remainedVolume());
                        Console.WriteLine("Remained weight:" + remainedWeight());
                    }
                    else
                    {
                        Console.WriteLine("article too big/ full backpack");
                        
                    }
                    break;
                case "spear":
                    if (backPack.Add(spear))
                    {
                        Console.WriteLine("added object");
                        Console.WriteLine("Remained Elements:" + remainedElements());
                        Console.WriteLine("Remained volume:" + remainedVolume());
                        Console.WriteLine("Remained weight:" + remainedWeight());
                    }
                    else
                    {
                        Console.WriteLine("article too big/ full backpack");
                    }
                    break;
                case "rope":
                    if (backPack.Add(rope))
                    {
                        Console.WriteLine("added object");
                        Console.WriteLine("Remained Elements:" + remainedElements());
                        Console.WriteLine("Remained volume:" + remainedVolume());
                        Console.WriteLine("Remained weight:" + remainedWeight());
                    }
                    else
                    {
                        Console.WriteLine("article too big/ full backpack");
                    }
                    break;
                case "water":
                    if (backPack.Add(water))
                    {
                        Console.WriteLine("added object");
                        Console.WriteLine("Remained Elements:" + remainedElements());
                        Console.WriteLine("Remained volume:" + remainedVolume());
                        Console.WriteLine("Remained weight:" + remainedWeight());
                    }
                    else
                    {
                        Console.WriteLine("article too big/ full backpack");
                    }
                    break;
                case "food":
                    if (backPack.Add(food))
                    {
                        Console.WriteLine("added object");
                        Console.WriteLine("Remained Elements:" + remainedElements());
                        Console.WriteLine("Remained volume:" + remainedVolume());
                        Console.WriteLine("Remained weight:" + remainedWeight());
                    }
                    else
                    {
                        Console.WriteLine("article too big/ full back pack");
                    }
                    break;
                case "sword":
                    if (backPack.Add(sword))
                    {
                        Console.WriteLine("added object");
                        Console.WriteLine("Remained Elements:" + remainedElements());
                        Console.WriteLine("Remained volume:" + remainedVolume());
                        Console.WriteLine("Remained weight:" + remainedWeight());
                    }
                    else
                    {
                        Console.WriteLine("article too big/ full back pack");
                    }
                    break;
                case "empty backpack":
                    backPack.Articles.Clear();
                    Console.WriteLine("Empty backpack");
                    Console.WriteLine("Remained Elements:" + remainedElements());
                    Console.WriteLine("Remained volume:" + remainedVolume());
                    Console.WriteLine("Remained weight:" + remainedWeight());
                    break;
                default:
                    Console.WriteLine("invalid option");
                    showMenu = false;
                    break;
            }
        }

    }
}