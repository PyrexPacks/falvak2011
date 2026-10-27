namespace falvak2011;

internal class Program
{
    private static void Main(string[] args)
    {
        var dict = new Dictionary<int, List<(int szomszed, int hossz)>>();
        var legkisebb = long.MaxValue;
        long legnagyobb = 0;
        var legkisebbelso = 0;
        var legkisebmasodik = 0;
        var cfeladatkicsi = 0;
        var cfeladatszam = long.MaxValue;


        Console.WriteLine("Ird be hany varos legyen osszesen es hany utca, spacel elvalasztva!");
        var bemenet1 = Console.ReadLine().Split(' ');

        Console.WriteLine("Most add meg melyik sorszamu varosok kozott mennyi egyseg az utca");
        for (var i = 1; i <= int.Parse(bemenet1[1]); i++)
        {
            var utcabemenet = Console.ReadLine().Split(' ');
            var elso = int.Parse(utcabemenet[0]);
            var masodik = int.Parse(utcabemenet[1]);
            var hossz = int.Parse(utcabemenet[2]);

            if (!dict.ContainsKey(elso)) dict[elso] = new List<(int, int)>();

            dict[elso].Add((masodik, hossz));


            if (!dict.ContainsKey(masodik))
            {
            	dict[masodik] = new List<(int, int)>();
            }

            dict[masodik].Add((elso, hossz));
        }

        foreach (var pair in dict)
        {
            long minc = long.MaxValue;
            

            foreach (var (szomszed, hossz) in pair.Value)
            {
                if (hossz < legkisebb)
                {
                    legkisebb = hossz;
                    legkisebbelso = pair.Key;
                    legkisebmasodik = szomszed;
                }

                if (hossz > legnagyobb) legnagyobb = hossz;

                if (hossz < minc)
                {
                    minc = hossz;
                }
                
            }

            if (minc > cfeladatkicsi)
            {
                cfeladatkicsi = (int)minc;
                cfeladatszam = pair.Key;
            }

            
    }
        Console.WriteLine(
            $"legkisebb elso= {legkisebbelso}, legkisebb masodik= {legkisebmasodik}, legnagyobb = {legnagyobb}, legjobb hely: {cfeladatszam}");
    }
}