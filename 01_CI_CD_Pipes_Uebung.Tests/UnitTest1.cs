using NUnit.Framework;

namespace _01_CI_CD_Pipes_Uebung.Tests;

public class Tests
{
    public class RechnerTests
    {
        [Test]
        public void Ad_Zahlen_Addieren()
        {
            int testNumber1 = 4;
            int testNumber2 = 5;
            int expectedResult = 9;

            int Result = Rechner.Addiere(zahl1, zahl2);

            Assert.AreEqual(erwartetesErgebnis, ergebnis);
        }
    }

    public class Rechner
    {
        public static int Addiere(int a, int b) 
        { 
            return a + b; 
        }
    }
}
