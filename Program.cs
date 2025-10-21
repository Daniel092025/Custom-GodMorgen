
class Program
{
    static void Main()
    {
        Console.WriteLine("Hei! Hva er navnet ditt?");
        String? navn = Console.ReadLine();

        while (navn?.Length < 3)
        {
            Console.WriteLine("Beklager, navnet må være lengre enn 2 karakterer. Prøv igjen!");
            navn = Console.ReadLine();
        }

        Console.WriteLine("Vennligst skriv hvor gammel du er: ");
        int alder;
        while (!int.TryParse(Console.ReadLine(), out alder) || alder <= 0)
        {
            Console.WriteLine("Vennlingst skriv et gyldig tall for alder:");
        }



        int time = DateTime.Now.Hour;

        string dag = DateTime.Now.DayOfWeek.ToString();
        string tidspunkt = DateTime.Now.ToString("HH:mm");


        Dictionary<string, string> hilsener = new Dictionary<string, string>()
        {
            {"morgen", "God Morgen"},
            {"dag", "God Dag" },
            {"kveld", "God Kveld"},
            {"natt", "God Natt"}
        };

       Dictionary<string, string> aldersbeskjeder = new Dictionary<string, string>()
        {
            {"For ung", "Du er for ung, gå bort"},
            {"Best years", "Du lever ditt beste liv!"},
            {"Feil vei", "Det går bare nedover dessverre!"},
            {"Cruise", "Nå er det bare å cruise til pensjon"},
            {"Pensjonist", "Er bare å nyte livet å visne bort"},
            {"Error", "Super error, du er innenfor parameterene"},
        };


        Dictionary<string, string> ukedager = new Dictionary<string, string>
        {
            {"Monday", "Mandag" },
            {"Tuesday", "Tirsdag"},
            {"Wednesday", "Onsdag"},
            {"Thursday", "Torsdag"},
            {"Friday", "Fredag"},
            {"Saturday", "Lørdag"},
            {"Sunday", "Søndag"}
        };

        Dictionary<string, string> motivasjon = new Dictionary<string, string>

        {
            {"Monday", "Uff da"},
            {"Tuesday", "Det går rette veien!"},
            {"Wednesday", "Det går rette veien!"},
            {"Thursday", "Det går rette veien!"},
            {"Friday", "Woo! Helg!"},
            {"Saturday", "Woo! Helg!"},
            {"Sunday", "Faen, helgen er over snart!"}
        };

        string hilsen;

        if (time >= 5 && time < 12)
            hilsen = hilsener["morgen"];
        else if (time >= 12 && time < 18)
            hilsen = hilsener["dag"];
        else if (time >= 18 && time < 23)
            hilsen = hilsener["kveld"];
        else
            hilsen = hilsener["natt"];

        string aldersbeskjed;

        if (alder < 0)
            aldersbeskjed = "Error";
        else if (alder < 20)
            aldersbeskjed = "For ung";
        else if (alder < 30)
            aldersbeskjed = "Best years";
        else if (alder < 40)
            aldersbeskjed = "Feil vei";
        else if (alder < 50)
            aldersbeskjed = "Cruise";
        else
            aldersbeskjed = "Pensjonist";


        Console.WriteLine($"{hilsen}, {navn}! klokken er nå {tidspunkt}.");
        Console.WriteLine($"\nHusk at det er {ukedager[dag]}. {motivasjon[dag]}.");
        Console.WriteLine($"\nHusk at du er {alder}! Og da er dette din spådom: {aldersbeskjeder[aldersbeskjed]}.");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(@"
.-.-. .-.-. .-.-.      .-.-. .-.-. .-.-. .-.-. 
'. S )'. e )'. e ).-.-.'. y )'. o )'. u )'. ! )
  ).'   ).'   ).' '._.'  ).'   ).'   ).'   ).' ");

  Console.ResetColor();
        
    }
}