using System.Collections.Generic;
using NUnit.Framework;

namespace Gw2Calculator.Models.Tests
{
    [TestFixture]
    public class BackItemTests
    {
        [Test]
        public void BerserkersBack_HasExpectedValues()
        {
            // Arrange
            var attributes = new List<ItemStatAttribute>
            {
                new ItemStatAttribute("Power", .35m),
                new ItemStatAttribute("Precision", .25m),
                new ItemStatAttribute("Ferocity", .25m)
            };

            // Act
            var actual = new BackItem(attributes);

            // Assert
            const int expectedPower = 63;
            const int expectedPrecision = 40;
            const int expectedFerocity = 40;
            Assert.AreEqual(expectedPower, actual.Power);
            Assert.AreEqual(expectedPrecision, actual.Precision);
            Assert.AreEqual(expectedFerocity, actual.Ferocity);
        }

        [Test]
        public void VipersBack_HasExpectedValues()
        {
            // Arrange
            var attributes = new List<ItemStatAttribute>
            {
                new ItemStatAttribute("Power", .3m),
                new ItemStatAttribute("ConditionDamage", .3m),
                new ItemStatAttribute("Precision", .165m),
                new ItemStatAttribute("Expertise", .165m)
            };

            // Act
            var actual = new BackItem(attributes);

            // Assert
            const int expectedPower = 52;
            const int expectedConditionDamage = 52;
            const int expectedPrecision = 27;
            const int expectedExpertise = 27;
            Assert.AreEqual(expectedPower, actual.Power);
            Assert.AreEqual(expectedConditionDamage, actual.ConditionDamage);
            Assert.AreEqual(expectedPrecision, actual.Precision);
            Assert.AreEqual(expectedExpertise, actual.Expertise);
        }
    }
}
