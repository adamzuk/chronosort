using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChronoSortCore.Parameters;

namespace ChronoSortCoreUnitTests
{
    [TestClass]
    public class ParameterFactoryTests
    {
        [TestMethod]
        public void ParameterFactoryShortOptionPositive()
        {
            var command = @"-s C:\some\path\to\file";

            var parameter = ParameterFactory.GetParameter(command);

            Assert.IsTrue(parameter.GetType() == typeof(Source));
        }

        [TestMethod]
        public void ParameterFactoryShortOptionNegative()
        {
            var command = @"-ss C:\some\path\to\file";

            var parameter = ParameterFactory.GetParameter(command);

            Assert.IsNull(parameter);
        }

        [TestMethod]
        public void ParameterFactoryLongOptionPositive()
        {
            var command = @"-short C:\some\path\to\file";

            var parameter = ParameterFactory.GetParameter(command);

            Assert.IsTrue(parameter.GetType() == typeof(Source));
        }

        [TestMethod]
        public void ParameterFactoryLongOptionNegative()
        {
            var command = @"-shorts C:\some\path\to\file";

            var parameter = ParameterFactory.GetParameter(command);

            Assert.IsNull(parameter);
        }
    }
}
