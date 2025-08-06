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
                Assert.AreEqual(9, Rechner.Add(4, 5));
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
                Assert.AreEqual(2, Rechner.Subtract(5, 3));
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
                Assert.AreEqual(15, Rechner.Multiply(3, 5));
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
                Assert.AreEqual(2, Rechner.Divide(10, 5));
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