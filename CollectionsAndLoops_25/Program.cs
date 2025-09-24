// Program.cs
using System;
using System.Collections.Generic;

namespace CollectionsAndLoops_25
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                PrintMenu();
                Console.Write("\nValinta (0 lopettaa): ");
                string choice = (Console.ReadLine() ?? "").Trim();

                switch (choice)
                {
                    case "1":
                        // 1) Kerää luvut listaan + tulosta
                        Console.WriteLine("\n=== Tehtävä 1: Kerää luvut listaan ja tulosta ne ===");
                        int listsize = Assignments.ReadInt("Kuinka monta lukua kerätään listaan?: ");
                        List<int> list1 = Assignments.CollectNumbersToList(listsize);
                        Console.WriteLine("\nSyötetyt luvut:");
                        Assignments.PrintList(list1);
                        Pause();
                        break;

                    case "2":
                        // 2) Laske keskiarvo, min, max (kokoelma parametrina)
                        Console.WriteLine("\n=== Tehtävä 2: Keskiarvo, min ja max (ilman LINQ) ===");
                        int listsize2 = Assignments.ReadInt("Kuinka monta lukua kerätään listaan?: ");
                        List<int> numbersForStats = Assignments.CollectNumbersToList(listsize2);

                        double avg = Assignments.CalculateAverage(numbersForStats);
                        Assignments.FindMinAndMax(numbersForStats, out int min, out int max);
                        Console.WriteLine($"\nKeskiarvo: {avg}");
                        Console.WriteLine($"Pienin: {min}");
                        Console.WriteLine($"Suurin: {max}");
                        Pause();
                        break;

                    case "3":
                        // 3) Suodata > kynnysarvo (kokoelma parametrina, kynnys kysytään)
                        Console.WriteLine("\n=== Tehtävä 3: Suodata arvot, jotka ovat suurempia kuin kynnys ===");
                        int listsize3 = Assignments.ReadInt("Kuinka monta lukua kerätään listaan?: ");
                        List<int> numbersForFilter = Assignments.CollectNumbersToList(listsize3);
                        int threshold = Assignments.ReadInt("Anna kynnysarvo: ");
                        List<int> above = Assignments.FindAboveThreshold(numbersForFilter, threshold);

                        Console.WriteLine("\nKynnysarvoa suuremmat luvut:");
                        if (above.Count == 0) 
                            Console.WriteLine("(Ei arvoja)");
                        else 
                            Assignments.PrintList(above);

                        Pause();
                        break;

                    case "4":
                        // 4) Poista lukuja listasta (kokoelma parametrina, poisto toistetaan)
                        Console.WriteLine("\n=== Tehtävä 4: Poista lukuja listasta ===");
                        int listsize4 = Assignments.ReadInt("Kuinka monta lukua kerätään listaan aluksi?: ");
                        List<int> numbersForRemove = Assignments.CollectNumbersToList(listsize4);

                        while (true)
                        {
                            Console.Write("\nSyötä poistettava luku: ");
                            int toRemove = Assignments.ReadInt(null);
                            Assignments.RemoveNumberFromList(numbersForRemove, toRemove);

                            Console.WriteLine("Päivitetty lista:");
                            Assignments.PrintList(numbersForRemove);

                            Console.Write("Poistetaanko toinen luku? (y/n): ");
                            string again = (Console.ReadLine() ?? "").Trim().ToLowerInvariant();
                            if (again != "y") break;
                        }
                        Pause();
                        break;

                    case "5":
                        // 5) Lisää satunnaislukuja listaan (kokoelma parametrina; kysytään montako ja vaihteluväli)
                        Console.WriteLine("\n=== Tehtävä 5: Lisää satunnaislukuja listaan ===");

                        int addsize = Math.Max(0, Assignments.ReadInt("Kuinka monta satunnaislukua lisätään?: "));
                        int minRand = Assignments.ReadInt("Satunnaislukujen minimi (sisältyy): ");
                        int maxRand = Assignments.ReadInt("Satunnaislukujen maksimi (sisältyy): ");

                        List<int> randomNumbers = Assignments.GenerateRandomNumbersList(addsize, minRand, maxRand);
                        Console.WriteLine("\nLista satunnaislisäysten jälkeen:");
                        Assignments.PrintList(randomNumbers);
                        Pause();
                        break;

                    case "6":
                        // 6) Kerää (nimi, ikä) sanakirjaan (kokoelma parametrina)
                        Console.WriteLine("\n=== Tehtävä 6: Kerää (nimi, ikä) sanakirjaan ===");
                        int pairsize = Assignments.ReadInt("Kuinka monta paria (nimi, ikä) kerätään?: ");
                        Dictionary<string, int> people = Assignments.CollectDataToDictionary(pairsize);

                        Console.WriteLine("\nSyötetyt tiedot:");
                        Assignments.PrintDictionary(people);
                        Pause();
                        break;

                    case "7":
                        // 7) Tulosta sanakirja (sanakirja parametrina)
                        Console.WriteLine("\n=== Tehtävä 7: Tulosta sanakirja ===");
                        int pairsize2 = Assignments.ReadInt("Kuinka monta paria (nimi, ikä) kerätään ensin sanakirjaan?: ");
                        Dictionary<string, int> dictForPrint = Assignments.CollectDataToDictionary(pairsize2);

                        Console.WriteLine("\nSanakirjan sisältö:");
                        Assignments.PrintDictionary(dictForPrint);
                        Pause();
                        break;

                    case "8":
                        // 8) Hae arvo avaimella (sanakirja parametrina, avain kysytään)
                        Console.WriteLine("\n=== Tehtävä 8: Hae arvo avaimella ===");
                        int pairsize3 = Assignments.ReadInt("Kuinka monta paria (nimi, ikä) kerätään ensin sanakirjaan?: ");
                        Dictionary<string, int> dictForFind = Assignments.CollectDataToDictionary(pairsize3);

                        Console.Write("Anna haettava nimi: ");
                        string keyToFind = Console.ReadLine() ?? "";
                        Assignments.FindValueByKey(dictForFind, keyToFind);
                        Pause();
                        break;

                    case "9":
                        // 9) Poista avain sanakirjasta (sanakirja parametrina, avain kysytään; toistetaan)
                        Console.WriteLine("\n=== Tehtävä 9: Poista avain sanakirjasta ===");
                        int pairsize4 = Assignments.ReadInt("Kuinka monta paria (nimi, ikä) kerätään ensin sanakirjaan?: ");
                        Dictionary<string, int> dictForRemove = Assignments.CollectDataToDictionary(pairsize4);

                        while (true)
                        {
                            Console.Write("Anna poistettava nimi: ");
                            string keyToRemove = Console.ReadLine() ?? "";
                            Assignments.RemoveKeyFromDictionary(dictForRemove, keyToRemove);

                            Console.WriteLine("\nPäivitetty sanakirja:");
                            Assignments.PrintDictionary(dictForRemove);

                            Console.Write("Poistetaanko toinen? (y/n): ");
                            string again2 = (Console.ReadLine() ?? "").Trim().ToLowerInvariant();
                            if (again2 != "y") break;
                        }
                        Pause();
                        break;

                    case "10":
                        // 10) Taulukko: kerää luvut taulukkoon ja tulosta (taulukko parametrina)
                        Console.WriteLine("\n=== Tehtävä 10: Taulukko (array) ===");
                        int arraySize = Assignments.ReadInt("Kuinka monta lukua kerätään taulukkoon?: ");
                        int[] arr = Assignments.CollectNumbersToArray(arraySize);

                        Console.WriteLine("\nTaulukon luvut:");
                        Assignments.PrintArray(arr);
                        Pause();
                        break;

                    case "0":
                        Console.WriteLine("\nKiitos! Paina Enter lopettaaksesi.");
                        Console.ReadLine();
                        return;

                    default:
                        Console.WriteLine("Virheellinen valinta. Yritä uudelleen.");
                        Pause();
                        break;
                }
            }
        }

        private static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Loops & Collections – Practice ===\n");
            Console.WriteLine("Valitse tehtävä:");
            Console.WriteLine(" 1) Kerää luvut listaan ja tulosta");
            Console.WriteLine(" 2) Laske keskiarvo, min ja max (ilman LINQ)");
            Console.WriteLine(" 3) Suodata luvut, jotka ovat kynnysarvoa suurempia");
            Console.WriteLine(" 4) Poista lukuja listasta (toistuva)");
            Console.WriteLine(" 5) Lisää satunnaislukuja listaan");
            Console.WriteLine(" 6) Kerää (nimi, ikä) parit sanakirjaan");
            Console.WriteLine(" 7) Tulosta sanakirja");
            Console.WriteLine(" 8) Hae arvo avaimella (nimi)");
            Console.WriteLine(" 9) Poista avain sanakirjasta (toistuva)");
            Console.WriteLine("10) Taulukko: kerää luvut taulukkoon ja tulosta");
            Console.WriteLine(" 0) Lopeta");
        }

        private static void Pause()
        {
            Console.WriteLine("\nPaina Enter jatkaaksesi...");
            Console.ReadLine();
        }
    }
}
