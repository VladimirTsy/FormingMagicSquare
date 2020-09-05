using NUnit.Framework;

namespace NUnitTestProject
{
    public class Tests
    {
        private int number { get; set; }

        [SetUp]
        public void Setup()
        {
            int[][] arr = new int[][] { 
                             new int[]{ 4, 5, 8 }, 
                             new int[]{ 2, 4, 1 }, 
                             new int[]{ 1, 9, 7 } 
            };

            number = Program.FormingMagicSquare(arr);
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(number, 14);
        }
    }
}