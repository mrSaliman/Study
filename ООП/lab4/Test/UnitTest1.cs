using lab4;
using System.Text;
using System.Xml.Linq;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WordCheck()
        {
            var test = "anime sal;11/11/2012 sal man;what the sal?sal man !sal ";
            var expected = "sal";
            var actual = Program.GetEverySentenceWord(test);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WordNDateCheck()
        {
            var test = "anime 12.11.15 sal;11/11/2012 sal man;what the sal?sal man 09.09.2003!sal 15.12.55";
            var word = "man";
            var expected = new List<StringBuilder>
            {
                new StringBuilder("anime 12.11.15 sal"),
                new StringBuilder("sal 12.15.55")
            };
            var actual = Program.GetSentencesWithoutWord(test, word);
            CollectionAssert.Equals(expected, actual);
        }
    }
}