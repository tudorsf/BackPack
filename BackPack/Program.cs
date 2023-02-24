using BackPack;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Configureaza ghiozdanul");  
        Console.WriteLine("NrTotalElemente:");
        var nrTotalElemente = Console.ReadLine();
        Console.WriteLine("Greutate Totala: ");
        var greutateTotala = Console.ReadLine();
        Console.WriteLine("Volum Total: ");
        var volumTotal = Console.ReadLine();

        var ghiozdan = new Ghiozdan(Convert.ToUInt16(nrTotalElemente), Convert.ToDouble(greutateTotala), Convert.ToDouble(volumTotal));
        ghiozdan.Articole = new List<ArticolInventar>();
        var arc = new Arc();
        var sageata = new Sageata();
        var franghie = new Franghie();
        var apa = new Apa();
        var mancare = new Mancare();
        var sabie = new Sabie();

        
        int elementeRamase()
        {
            int elementeRamase = Convert.ToUInt16(nrTotalElemente) - (ghiozdan.Articole.Count());
            return elementeRamase;
        }
        
        double greutateRamasa()
        {
            double greutateRamasa = Convert.ToDouble(greutateTotala) - (ghiozdan.Articole.Sum(x => x.Greutate));
            return greutateRamasa;
        }
       double volumRamas()
        {
            double volumRamas = Convert.ToDouble(volumTotal) - (ghiozdan.Articole.Sum(x => x.Volum));
            
            return volumRamas;
        }

       
        Console.WriteLine("Alegeti un Articol");

        Console.WriteLine("arc");
        Console.WriteLine("sageata");
        Console.WriteLine("franghie");
        Console.WriteLine("apa");
        Console.WriteLine("mancare");
        Console.WriteLine("sabie");
        Console.WriteLine("goliti ghiozdanul");
        var showMenu = true;
        while (showMenu)
        {
            var key = Console.ReadLine();
           
            switch (key)
            {
                case "arc":
                    if (ghiozdan.Adauga(arc))
                    {
                        Console.WriteLine("obiect adaugat");
                        Console.WriteLine("Elemente Ramase:");
                        Console.WriteLine(elementeRamase());
                        Console.WriteLine("Volum Ramas:");
                        Console.WriteLine(volumRamas());
                        Console.WriteLine("Greutate Ramasa:");
                        Console.WriteLine(greutateRamasa());
                    }
                    else
                    {
                        Console.WriteLine("obiect prea mare/ ghiozdan plin");
                        
                    }
                    break;
                case "sageata":
                    if (ghiozdan.Adauga(sageata))
                    {
                        Console.WriteLine("obiect adaugat");
                        Console.WriteLine("Elemente Ramase:");
                        Console.WriteLine(elementeRamase());
                        Console.WriteLine("Volum Ramas:");
                        Console.WriteLine(volumRamas());
                        Console.WriteLine("Greutate Ramasa:");
                        Console.WriteLine(greutateRamasa());
                    }
                    else
                    {
                        Console.WriteLine("obiect prea mare/ ghiozdan plin");
                    }
                    break;
                case "franghie":
                    if (ghiozdan.Adauga(sageata))
                    {
                        Console.WriteLine("obiect adaugat");
                        Console.WriteLine("Elemente Ramase:");
                        Console.WriteLine(elementeRamase());
                        Console.WriteLine("Volum Ramas:");
                        Console.WriteLine(volumRamas());
                        Console.WriteLine("Greutate Ramasa:");
                        Console.WriteLine(greutateRamasa());
                    }
                    else
                    {
                        Console.WriteLine("obiect prea mare/ghiozdan plin");
                    }
                    break;
                case "apa":
                    if (ghiozdan.Adauga(apa))
                    {
                        Console.WriteLine("obiect adaugat");
                        Console.WriteLine("Elemente Ramase:");
                        Console.WriteLine(elementeRamase());
                        Console.WriteLine("Volum Ramas:");
                        Console.WriteLine(volumRamas());
                        Console.WriteLine("Greutate Ramasa:");
                        Console.WriteLine(greutateRamasa());
                    }
                    else
                    {
                        Console.WriteLine("obiect prea mare/ ghiozdan plin");
                    }
                    break;
                case "mancare":
                    if (ghiozdan.Adauga(mancare))
                    {
                        Console.WriteLine("obiect adaugat");
                        Console.WriteLine("Elemente Ramase:");
                        Console.WriteLine(elementeRamase());
                        Console.WriteLine("Volum Ramas");
                        Console.WriteLine(volumRamas());
                        Console.WriteLine("Greutate Ramasa:");
                        Console.WriteLine(greutateRamasa());
                    }
                    else
                    {
                        Console.WriteLine("obiect prea mare/ ghiozdan plin");
                    }
                    break;
                case "sabie":
                    if (ghiozdan.Adauga(sabie))
                    {
                        Console.WriteLine("obiect adaugat");
                        Console.WriteLine("Elemente Ramase:");
                        Console.WriteLine(elementeRamase());
                        Console.WriteLine("Volum Ramas:");
                        Console.WriteLine(volumRamas());
                        Console.WriteLine("Greutate Ramasa:");
                        Console.WriteLine(greutateRamasa());
                    }
                    else
                    {
                        Console.WriteLine("obiect prea mare");
                    }
                    break;
                case "goliti ghiozdanul":
                    ghiozdan.Articole.Clear();
                    Console.WriteLine("Ghiozdan gol");
                    Console.WriteLine("Elemente Ramase:");
                    Console.WriteLine(elementeRamase());
                    Console.WriteLine("Volum Ramas");
                    Console.WriteLine(volumRamas());
                    Console.WriteLine("Greutate Ramasa:");
                    Console.WriteLine(greutateRamasa());
                    break;
                default:
                    Console.WriteLine("optiune invalida");
                    showMenu = false;
                    break;
            }
        }

    }
}