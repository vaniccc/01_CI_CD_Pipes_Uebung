using NUnit.Framework;
using _01_CI_CD_Pipes_Uebung;
using Serilog;
using Serilog.Events;
using System;
using Serilog.Formatting.Json;

namespace _01_CI_CD_Pipes_Uebung.Tests
{
    public class RechnerTests
    {

        [OneTimeSetUp]
        public void SetupLogger() {

            string logDirectory = "/home/azubi/deploy/logs";

            Log.Logger = new LoggerConfiguration()
                        .WriteTo.File(new JsonFormatter(), Path.Combine(logDirectory, "logs.json"))
                        .WriteTo.File(Path.Combine(logDirectory, "all-.logs"), restrictedToMinimumLevel: LogEventLevel.Warning, rollingInterval: RollingInterval.Day)
                        .MinimumLevel.Debug()
                        .CreateLogger();
        }

        [Test]
        public void Test_Add()
        {
            try
            {
                Assert.That(Rechner.Add(4, 5), Is.EqualTo(9));
                Log.Information("Test_Add erfolgreich");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Fehler in Test_Add");
                throw;
            }
            
        }

        [Test]
        public void Test_Subtract()
        {
            try
            {
                Assert.That(Rechner.Subtract(5, 3), Is.EqualTo(2));
                Log.Information("Test_Subtract erfolgreich.");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Fehler in Test_Subtract");
                throw;
            }
        }

        [Test]
        public void Test_Multiply()
        {
            try
            {
                Assert.That(Rechner.Multiply(3, 5), Is.EqualTo(15));
                Log.Information("Test_Multiply erfolgreich.");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Fehler in Test_Multiply");
                throw;
            }
        }

        [Test]
        public void Test_Devide()
        {
            try
            {
                Assert.That(Rechner.Divide(10, 5), Is.EqualTo(2));
                Log.Information("Test_Divide erfolgreich.");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Fehler in Test_Divide");
                throw;
            }
        }

        [Test]
        public void Test_DevideByZeroExceptionThrow()
        {
            try
            {
                Assert.Throws<DivideByZeroException>(() => Rechner.Divide(10, 0));
                Log.Information("Test_DivideByZeroExceptionThrow erfolgreich.");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Fehler in Test_DivideByZeroExceptionThrow");
                throw;
            }
        }
    }
}