using NUnit.Framework;
using _01_CI_CD_Pipes_Uebung;

namespace _01_CI_CD_Pipes_Uebung.Tests;

public class RechnerTests
{
    [Test]
    public void Test_Add()
    {
        Assert.AreEqual(9, Rechner.Addiere(4, 5));
    }

    [Test]
    public void Test_Subtract()
    {
        Assert.AreEqual(2, Rechner.Subtrahiere(5, 3));
    }

    [Test]
    public void Test_Multiply()
    {
        Assert.AreEqual(15, Rechner.Multipliziere(3, 5));
    }

    [Test]
    public void Test_Devide()
    {
        Assert.AreEqual(2, Rechner.Dividiere(10, 5));
    }

    [Test]
    public void Test_DevideByZeroExceptionThrow()
    {
        Assert.Throws<DivideByZeroException>(() => Rechner.Dividiere(10, 0));
    }
}