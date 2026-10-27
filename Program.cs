namespace falvak2011;

class Program
{
	static void Main(string[] args)
	{
		var dict = new Dictionary<int, List<(int szomszed, int hossz)>>();
		var legkisebb = long.MaxValue;
		
		
		Console.WriteLine("Ird be hany varos legyen osszesen es hany utca, spacel elvalasztva!");
		string[] bemenet1 = Console.ReadLine().Split(' ');

		Console.WriteLine("Most add meg melyik sorszamu varosok kozott mennyi egyseg az utca");
		for (int i = 1; i <= int.Parse(bemenet1[1]); i++){

			var utcabemenet = Console.ReadLine().Split(' ');
			int elso = int.Parse(utcabemenet[0]);
			int masodik = int.Parse(utcabemenet[1]);
			int hossz = int.Parse(utcabemenet[2]);

			if (!dict.ContainsKey(elso))
			{
				dict[elso] = new List<(int, int)>();
			}

			dict[elso].Add((masodik, hossz));


			//if (!dict.ContainsKey(masodik))
			//{
			//	dict[masodik] = new List<(int, int)>();
			//}

			//dict[masodik].Add((elso, hossz));
			
		}
		for (int i = 0; i < dict.Count; i++)
		{
			foreach (var pair in dict)
			{
				foreach (var elso in pair.Value)
			}
			
		}
	}
}