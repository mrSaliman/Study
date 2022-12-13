using lab5;
using System.Text;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetIndexesTest()
        {
            var adresses = new List<StringBuilder>
            {
                new StringBuilder("ahsjfgdsghk 234453 sdjkfh 3 jkwghj gr4jhg etgeyug 7firhg uegr"),
                new StringBuilder("ahsjfgdsghk 234453 sdjkfh 3 jkwghj gr4jhg 654321 7firhg uegr"),
                new StringBuilder("ahsjfgdsghk sdjkfh 3 jkwghj gr4jhg etgeyug 123456 uegr"),
                new StringBuilder("859593  sdjkfh 3 jkwghj gr4jhg etgeyug 7firhg uegr"),
                new StringBuilder("ahsjfgdsghk  sdjkfh 3 jkwghj 658364 etgeyug 7firhg uegr"),
                new StringBuilder("ahsjfgdsghk  sd559634jkfh 3 jkwghj gr4jhg etgeyug 7firhg uegr"),
                new StringBuilder("ahsjfgdsghk  sdjkfh 3 jkwghj gr4jhg etgeyug 7firhg 659332"),
                new StringBuilder("ahsjfgdsghk  sdjkfh 3 jkwghj gr4jhg etgeyug 13425 uegr")
            };
            var expected = new List<int> {
                123456,
                234453,
                234453,
                559634,
                658364,
                659332,
                859593
            };
            var actual = Program.GetIndexes(adresses);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}