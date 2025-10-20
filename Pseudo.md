#Custom Godmorgen
##En seriøs prøve på Pseudokode

##//Start//

###//Spørsmål på navn og alder. Men en liten sjekk på at alder ikke kan være lavere eller lik 0//
``` csharp
console.writeline["Oppgi navn"];

 int alder;
        while (!int.TryParse(Console.ReadLine(), out alder) || alder <= 0)
        {
            Console.WriteLine("Vennlingst skriv et gyldig tall for alder:");
        }
```
###//Sjekk på lengde på navn, for å eliminere noe falske navn//
```csharp
while (navn?.Length < 2)
```


###//En rask omgjøring av dato til dag//
```csharp
string dag = DateTime.Now.DayOfWeek.ToString();
```
###//Rask "cleanup" av dato og tid//
```csharp
string tidspunkt = DateTime.Now.ToString("HH:mm");
```
###//Henter lookup via Dictionary//
```csharp
Dictionary<string, string> hilsener
+ motivasjon
Dictionary<string, string> ukedager // For å oversette ukedagene fra engelsk til norsk
var aldersbeskjeder = new Dictionary<string, string>() // for å ha hilsener for aldersjekk

```

###//Sjekker i forhold til tid man skriver. Hva klokken er med if statement og sjekk på lik eller mindre//
```csharp
string hilsen;

        if (time >= 5 && time < 12)
            hilsen = hilsener["morgen"];
```

###//Oppgir tid og dato, med en hilsen//
```csharp
Console.WriteLine($"{hilsen}, {navn}! klokken er nå {tidspunkt}.");
```
###//Henter beskjed i forhold til dag man skriver.//
```csharp
Console.WriteLine($"\nHusk at det er {ukedager[dag]}. {motivasjon[dag]}.");
```
###//Henter beskjed i forhold til alder man er.//
```csharp
Console.WriteLine($"\nHusk at du er {alder}! Og da er dette din spådom: {aldersbeskjeder[aldersbeskjed]}.");
```
###/Litt ACII med farge for avsluttning.//
```csharp
Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(@"");
```