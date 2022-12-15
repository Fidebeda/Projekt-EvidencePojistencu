namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--------------------");
            Console.WriteLine("Evidence pojištěných");
            Console.WriteLine("--------------------");

            // nastavení
            char volba = '0';
            Evidence evidence = new Evidence();

            // hlavní cyklus
            while (volba != '4')
            {
                // výpis možností
                Console.WriteLine("Vyberte si akci:");
                Console.WriteLine("1 - Přidat nového pojištěného");
                Console.WriteLine("2 - Vypsat všechny pojištěné");
                Console.WriteLine("3 - Vyhledat pojištěného");
                Console.WriteLine("4 - Konec");
                volba = Console.ReadKey().KeyChar;
                Console.WriteLine();
                // reakce na volbu
                switch (volba)
                {
                    case '1':
                        // načítání stringů a intů
                        Console.WriteLine("Zadejte jméno pojištěného:");
                        string jmeno;
                        while(string.IsNullOrWhiteSpace(jmeno = Console.ReadLine()))
                        {
                            Console.WriteLine("Zadej znovu.");
                        }
                        string prijmeni;
                        Console.WriteLine("Zadejte příjmení pojištěného:");
                        while(string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine()))
                        {
                            Console.WriteLine("Zadej znovu.");
                        }

                        // nebudeme pojišťovat příliš mladé a staré
                        Console.WriteLine("Zadej věk pojištěného:");
                        int vek;
                        while (!int.TryParse(Console.ReadLine(), out vek))
                        {
                            Console.WriteLine("Zadej prosím číslo.");
                        }
                        if (!(vek>15 && vek<99))
                        {
                            Console.WriteLine("Nemůžeme vás pojistit kvůli věku.");
                            Console.WriteLine("Pokračujte libovolnou klávesou ...");
                            Console.ReadKey();
                            Console.Clear();
                            goto case '1';
                        }
                        Console.WriteLine("Zadej telefonní číslo pojištěného:");
                        int telefon;
                        while (!int.TryParse(Console.ReadLine(), out telefon))
                        {
                            Console.WriteLine("Zadej prosím číslo.");
                        }
                        
                        // vytvoření objektu pojištěnec a přidání do evidence
                        Pojistenec pojistenec = new Pojistenec(jmeno,prijmeni,telefon,vek);
                        evidence.PridejPojistence(pojistenec);
                        Console.WriteLine("Data byla uložena. Pokračujte libovolnou klávesou ...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '2':
                        // výpis
                        Console.WriteLine("Výpis pojištěných");
                        Console.WriteLine("--------------------");
                        evidence.Vypis();
                        Console.WriteLine();
                        Console.WriteLine("Pokračujte libovolnou klávesou ...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '3':
                        // načítání stringů
                        Console.WriteLine("Zadejte jméno pojištěného:");
                        string jmenoSearch = Console.ReadLine();
                        Console.WriteLine("Zadejte příjmení pojištěného:");
                        string prijmeniSearch = Console.ReadLine();
                        Console.WriteLine("Evidence nalezených pojištěných:");
                        Console.WriteLine("--------------------");
                        // funkce vyhledání
                        evidence.Vyhledat(jmenoSearch, prijmeniSearch);
                        Console.WriteLine();
                        Console.WriteLine("Pokračujte libovolnou klávesou ...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '4':
                        Console.WriteLine("Děkuji za použití programu.");
                        Console.ReadKey();
                        break;   
                    default:
                        Console.WriteLine("Neplatná volba, zadejte prosím znovu.");
                        break;
                }
            }
        






        }
    }
}