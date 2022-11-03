using System.Text;
using System.Text.RegularExpressions;

namespace lab5
{
	public class Program
	{
		static void Main()
		{
			var adresses = new List<StringBuilder>();
			adresses.Add(new StringBuilder("ahsjfgdsghk 234453 sdjkfh 3 jkwghj gr4jhg etgeyug 7firhg uegr"));
            adresses.Add(new StringBuilder("ahsjfgdsghk 234453 sdjkfh 3 jkwghj gr4jhg 654321 7firhg uegr"));
            adresses.Add(new StringBuilder("ahsjfgdsghk sdjkfh 3 jkwghj gr4jhg etgeyug 123456 uegr"));
            adresses.Add(new StringBuilder("859593  sdjkfh 3 jkwghj gr4jhg etgeyug 7firhg uegr"));
            adresses.Add(new StringBuilder("ahsjfgdsghk  sdjkfh 3 jkwghj 658364 etgeyug 7firhg uegr"));
            adresses.Add(new StringBuilder("ahsjfgdsghk  sd559634jkfh 3 jkwghj gr4jhg etgeyug 7firhg uegr"));
            adresses.Add(new StringBuilder("ahsjfgdsghk  sdjkfh 3 jkwghj gr4jhg etgeyug 7firhg 659332"));
            adresses.Add(new StringBuilder("ahsjfgdsghk  sdjkfh 3 jkwghj gr4jhg etgeyug 13425 uegr"));
			foreach (int index in GetIndexes(adresses)) Console.WriteLine(index); 
        }

		public static List<int> GetIndexes(List<StringBuilder> adresses)
		{
			string pattern = @"\d\d\d\d\d\d";
			List<int> indexes = new List<int>();
			var match = new StringBuilder();
			foreach (StringBuilder adress in adresses)
			{
				match.Append(Regex.Match(adress.ToString(), pattern).ToString());
				if (match.Length != 0)
					indexes.Add(int.Parse(match.ToString()));
				match.Clear();
			}
			indexes.Sort();
			return indexes;
		}
	}
}