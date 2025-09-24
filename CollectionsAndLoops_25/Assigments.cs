using System;
using System.Collections.Generic;
using System.Globalization;

namespace CollectionsAndLoops_25
{
    internal static class Assignments
    {
        /*
         ============================================================================
         Assignment 1: Collect numbers to list
         Tavoite:
           - Lue 'size' parametri ja lisää kokonaislukuja listaan konsolista käyttäen ReadInt-apufunktiota.
           - Tallenna luvut uuteen List<int>-listaan samassa järjestyksessä kuin käyttäjä antaa luvut
           - Käytä for-silmukkaa ja List.Add -metodia.
         Rajoitukset:
           - Ei LINQiä; käytä perussilmukoita ja List.Add.
         Esimerkki:
           Syöte (size = 5):  4 2 8 6 10
           Tuloslista:         [4, 2, 8, 6, 10]
         Linkit:
           For-loop:   https://github.com/xamk-ture/FundamentalsExamples/blob/master/ForExample/Program.cs
           List<T>:    https://github.com/xamk-ture/FundamentalsExamples/blob/master/ListExample/Program.cs
         Mitä tehdä (vaiheittain):
           1) Luo tyhjä lista: var numbers = new List<int>();
           2) Tee for-silmukka i = 0 .. size-1.
           3) Kutsu ReadInt esimerkiksi viestillä $"Syötä numero {i+1}/{size}: ".
           4) Lisää saatu luku listaan List.Add: numbers.Add(number);
           5) Palauta lista.
         ============================================================================
        */
        public static List<int> CollectNumbersToList(int size)
        {
            List<int> numbers = new();
            for (int i = 0; i < size; i++)
            {
                // ReadInt ottaa parametrina infoteksin, jonka se käyttäjälle näyttää
                // \n tarkoittaa uutta tyhjää riviä. Tämä siksi, että numero syötetään tyhjälle riville
                // joka on selkeämpi loppukäyttäjälle
                int number = ReadInt("Syötä numero \n");
                numbers.Add(number);
            }

            return numbers;
        }

        /*
         ============================================================================
         Assignment 2: Print list values
         Tavoite:
           - Tulosta jokainen listan numero omalle rivilleen annetussa järjestyksessä.
           - Käytä foreach-silmukkaa IEnumerable<int> -kokoelmalle.
         Linkit:
           Foreach-loop: https://github.com/xamk-ture/FundamentalsExamples/blob/master/ForEachExample/Program.cs
         Mitä tehdä:
           1) Tee foreach (var n in numbers).
           2) Tulosta jokainen n: Console.WriteLine(n);
         ============================================================================
        */
        public static void PrintList(IEnumerable<int> numbers)
        {
            // TODO: Poista poikkeus ja tulosta jokainen alkio omalle rivilleen.
            throw new NotImplementedException("Käytä foreachia ja tulosta jokainen luku.");
        }

        /// <summary>
        /// ============================================================================
        /// Assignment 3: Calculate average (no LINQ)
        /// Tavoite:
        ///   - Laske summa for- tai foreach-silmukalla ja jaa se alkioiden määrällä.
        /// Rajoitukset:
        ///   - Älä käytä LINQ:ia (Average/Min/Max).
        /// Linkit:
        ///   Foreach-loop: https://github.com/xamk-ture/FundamentalsExamples/blob/master/ForEachExample/Program.cs
        /// Mitä tehdä:
        ///   1) käy läpi kaikki luvut ja laske summa
        ///   2) Jaa summa käyttämällä List-size methodia, esim numbers.size()
        ///   3) Palauta summa double-tyyppisenä.
        /// ============================================================================
        /// </summary>
        public static double CalculateAverage(List<int> numbers)
        {
            // TODO: Poista poikkeus ja laske keskiarvo ohjeen mukaan.

            throw new NotImplementedException("Jos lista tyhjä -> 0.0, muuten summa/size.");
        }

        /*
         ============================================================================
         Assignment 4: Find min and max (no LINQ)
         Tavoite:
           - Etsi pienin (min) ja suurin (max) arvo yhdellä läpikäynnillä.
         Mitä tehdä:
           1) Alusta min ja max ensimmäisellä arvolla: min = numbers[0]; max = numbers[0];
           2) Käy läpi loput alkiot ja päivitä min/max vertailuilla. Käyttäen foreach
         ============================================================================
        */
        public static void FindMinAndMax(List<int> numbers, out int min, out int max)
        {
            // TODO: Poista alla oleva poikkeus ja toteuta min/max -haku ohjeen mukaan.

            throw new NotImplementedException("Tyhjä lista -> (0,0). Muuten alusta ensimmäiseen arvoon ja päivitä vertailuilla.");
        }

        /// <summary>
        /// ============================================================================
        /// Assignment 3 (part B): Filter values greater than a threshold
        /// Tavoite:
        ///   - Palauta UUSI lista, jossa ovat vain ne alkiot, jotka ovat suurempia kuin 'threshold' arvo, joka tulee parametrina.
        /// Rajoitukset:
        ///   - Käytä foreach + if + List.Add; ei LINQ:ia.
        /// Mitä tehdä:
        ///   1) Luo tyhjä lista result.
        ///   2) Lisää result listaan arvot, jotka ylittävät kynnysarvon
        ///   3) Palauta result.
        /// ============================================================================
        /// </summary>
        public static List<int> FindAboveThreshold(List<int> numbers, int threshold)
        {
            // TODO:

            throw new NotImplementedException("Rakenna uusi lista alkioista, jotka ovat suurempia kuin threshold.");
        }

        /// <summary>
        /// ============================================================================
        /// Assignment 4: Remove a number from the list
        /// Tavoite:
        ///   - Yritä poistaa 'number' listasta List.Remove-metodilla.
        ///   - Tulosta palaute onnistuiko poisto vai ei consoleen
        /// Linkit:
        ///   List.Remove example: https://github.com/xamk-ture/FundamentalsExamples/blob/master/ListExample/Program.cs
        /// Mitä tehdä:
        ///   1) bool ok = numbers.Remove(number);
        ///   2) Jos ok == true -> "Poistettiin {number}", muuten "Arvoa ei löytynyt".
        /// ============================================================================
        /// </summary>
        public static void RemoveNumberFromList(List<int> numbers, int number)
        {
            // TODO: Kokeile Remove ja tulosta palaute.

            throw new NotImplementedException("Käytä List.Remove ja tulosta onnistuiko vai ei.");
        }

        /// <summary>
        /// ============================================================================
        /// Assignment 5 : Add random numbers to the list (inclusive range)
        /// Tavoite:
        ///   - Lisää listaan size parametrin verran satunnaisia lukuja väliltä [min, max].
        /// Huom:
        ///   - Jos size <= 0, älä tee mitään.
        /// Linkit:
        ///   Random usage: https://github.com/xamk-ture/FundamentalsExamples/blob/master/RandomExample/Program.cs
        /// Mitä tehdä:
        ///   1) Jos size <= 0, return.
        ///   2) Luo Random rng = new();
        ///   3) Toista silmukka niin monta kertaa mitä size muuttujassa tulee parametrina.
        ///   Esim size=4, lisää 4 satunnaista. min ja max määrittävät, että miltä väliltä haetaan arvoja
        /// ============================================================================
        /// </summary>
        public static List<int> GenerateRandomNumbersList(int size, int min, int max)
        {
            // TODO: 
            throw new NotImplementedException("Jos size > 0, generoita luvut [min, max] ja lisää listaan.");
        }

        // -----------------------------------------------------------------
        // DICTIONARY-FUNKTIOT
        // -----------------------------------------------------------------

        /// <summary>
        /// ============================================================================
        /// Assignment 6: Collect (name, age) pairs to dictionary (unique keys)
        /// Tavoite:
        ///   - Lue n-kappaletta uusia arvoja uuteen dictionarryn. n määrittyy parametrina tulevan int size mukaan
        ///   - Tallenna Dictionaryyn, jossa nimi on avain (uniikki).
        ///   - Jos nimi on jo olemassa, pyydä uusi nimi.
        /// Linkit:
        ///   Dictionary basics: https://github.com/xamk-ture/FundamentalsExamples/blob/master/DictionaryExample/Program.cs
        /// Mitä tehdä:
        ///   1) Luo tyhjä Dictionary<string,int> 
        ///   2) Lisää henkilöidä size määrän verran:
        ///      - Kysy nimi (Console.ReadLine), jos null/tyhjä -> pyydä uudelleen.
        ///      - Jos dict.ContainsKey(nimi) -> ilmoita ja pyydä eri nimi.
        ///      - Lue ikä ReadInt:llä.
        ///      - dict.Add(nimi, ika).
        ///   3) Palauta dict.
        /// ============================================================================
        /// </summary>
        public static Dictionary<string, int> CollectDataToDictionary(int size)
        {
            // TODO: Täytä sanakirja uniikeilla (nimi, ikä) -pareilla ohjeen mukaan.

            throw new NotImplementedException("Kerää size kpl uniikkeja (nimi, ikä) -pareja sanakirjaan ja palauta se.");
        }

        /// <summary>
        /// ============================================================================
        /// Assignment 7: Print dictionary with foreach over KeyValuePair
        /// Tavoite:
        ///   - Tulosta jokainen alkio muodossa: "Key:{name} Value:{age}" (yksi per rivi).
        ///   - Jos sanakirja on tyhjä, tulosta "(Empty)".
        /// Linkit:
        ///   Dictionary foreach example: https://github.com/xamk-ture/FundamentalsExamples/blob/master/DictionaryExample/Program.cs
        /// Mitä tehdä:
        ///   1) Tulosta dictionaryn sisältö consoleen muodossa: "Key:{name} Value:{age}"
        /// ============================================================================
        /// </summary>
        public static void PrintDictionary(Dictionary<string, int> dict)
        {
            // TODO: Tulosta sisällöt tai "(Empty)".
            //Kannattaa käyttää dictionarya, jonka CollectDataToDictionary palauttaa

            throw new NotImplementedException("Käytä foreachia KeyValuePairille ja tulosta rivit.");
        }

        /// <summary>
        /// ============================================================================
        /// Assignment 8: Find value by key
        /// Tavoite:
        ///   - Tulosta arvo jos avain löytyy, muuten "Not found: {key}".
        /// Linkit:
        ///   Dictionary lookup example: https://github.com/xamk-ture/FundamentalsExamples/blob/master/DictionaryExample/Program.cs
        /// ============================================================================
        /// </summary>
        public static void FindValueByKey(Dictionary<string, int> dict, string key)
        {
            // TODO: Käytä TryGetValueä ja tulosta löytyikö vai ei.
            //Kannattaa käyttää dictionarya, jonka CollectDataToDictionary palauttaa

            throw new NotImplementedException("Tulosta löytynyt arvo tai Not found -viesti.");
        }

        /// <summary>
        /// ============================================================================
        /// Assignment 9: Remove key from dictionary
        /// Tavoite:
        ///   - Poista 'key' sanakirjasta ja tulosta palaute.
        /// Linkit:
        ///   Dictionary.Remove example: https://github.com/xamk-ture/FundamentalsExamples/blob/master/DictionaryExample/Program.cs
        /// Mitä tehdä:
        ///   1) Poista ja ilmoita käyttäjälle, että onnistuiko poisto vai ei.
        /// ============================================================================
        /// </summary>
        public static void RemoveKeyFromDictionary(Dictionary<string, int> dict, string key)
        {
            // TODO: Kokeile Remove ja tulosta palaute
            //Kannattaa käyttää dictionarya, jonka CollectDataToDictionary palauttaa.

            throw new NotImplementedException("Käytä Removea ja tulosta onnistuiko poisto vai ei.");
        }

        /*
        ============================================================================
        Assignment 10a: Collect numbers into an array
        Tavoite:
          - Kysy käyttäjältä n-kappaletta lukuja ja tallenna ne uuteen int[]-taulukkoon.
          - Tee samaan tapaan mitä Assigment1, mutta nyt taulukkoon.
          - Käytä for-silmukkaa ja ReadInt-apuria.
        Linkit:
          Array basics: https://github.com/xamk-ture/FundamentalsExamples/blob/master/ArrayExample/Program.cs
        ============================================================================
        */
        public static int[] CollectNumbersToArray(int size)
        {
            // TODO: Toteuta taulukon täyttö yllä olevan ohjeen mukaan.
            throw new NotImplementedException("Luo int[] kokoon 'size', täytä for-silmukalla ReadInt:ä käyttäen ja palauta.");
        }

        /*
         ============================================================================
         Assignment 10b: Print array values
         Tavoite:
           - Tulosta jokainen taulukon alkio omalle rivilleen.
           - Käytä foreach- tai for-silmukkaa. (foreach on helpompi)
         Linkit:
           Array print example: https://github.com/xamk-ture/FundamentalsExamples/blob/master/ArrayExample/Program.cs
         ============================================================================
        */
        public static void PrintArray(int[] numbers)
        {
            // TODO: Tulosta jokainen taulukon arvo omalle rivilleen.

            throw new NotImplementedException("Käytä foreachia tai foria ja tulosta kaikki arvot.");
        }

        // -----------------------------------------------------------------
        // HELPER (valmis, käytä sellaisenaan)
        // -----------------------------------------------------------------
        /// <summary>
        /// Helper: Lue kelvollinen kokonaisluku konsolista. Kysyy uudelleen, jos syöte ei ole numero.
        /// Jos <paramref name="prompt"/> on null tai tyhjä, viestiä ei näytetä.
        /// Käyttää int.TryParsea (InvariantCulture ei pakollinen perusintille).
        /// </summary>
        public static int ReadInt(string? prompt)
        {
            while (true)
            {
                if (!string.IsNullOrEmpty(prompt))
                    Console.Write(prompt);

                string input = Console.ReadLine();

                if (int.TryParse(input, out int n))
                    return n;

                Console.WriteLine("Anna kelvollinen kokonaisluku.");
            }
        }
    }
}
