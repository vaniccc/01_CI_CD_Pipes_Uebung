using NUnit.Framework;
using _01_CI_CD_Pipes_Uebung;
using Serilog;
using System;

namespace _01_CI_CD_Pipes_Uebung.Tests
{
    public class RechnerTests
    {
        private static ILogger _logger;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File("Test_Logs.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
        }

        [Test]
        public void Test_Add()
        {
            try
            {
                Assert.AreEqual(9, Rechner.Addiere(4, 5));
                _logger.Information("Test_Add erfolgreich.");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Fehler in Test_Add");
                throw;
            }
        }

        [Test]
        public void Test_Subtract()
        {
            try
            {
                Assert.AreEqual(2, Rechner.Subtrahiere(5, 3));
                _logger.Information("Test_Subtract erfolgreich.");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Fehler in Test_Subtract");
                throw;
            }
        }

        [Test]
        public void Test_Multiply()
        {
            try
            {
                Assert.AreEqual(15, Rechner.Multipliziere(3, 5));
                _logger.Information("Test_Multiply erfolgreich.");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Fehler in Test_Multiply");
                throw;
            }
        }

        [Test]
        public void Test_Devide()
        {
            try
            {
                Assert.AreEqual(2, Rechner.Dividiere(10, 5));
                _logger.Information("Test_Divide erfolgreich.");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Fehler in Test_Divide");
                throw;
            }
        }

        [Test]
        public void Test_DevideByZeroExceptionThrow()
        {
            Assert.Throws<DivideByZeroException>(() => Rechner.Dividiere(10, 0));
        }
    }
}