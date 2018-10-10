using System.Collections.Generic;
using NUnit.Framework;

namespace Gw2Calculator.Models.Tests
{
    [TestFixture]
    public class RingTests
    {
        [Test]
        public void BerserkersRing_HasExpectedValues()
        {
            // Arrange
            var attributes = new List<ItemStatAttribute>
            {
                new ItemStatAttribute("Power", .35m),
                new ItemStatAttribute("Precision", .25m),
                new ItemStatAttribute("Ferocity", .25m)
            };

            // Act
            var actual = new Ring(attributes);

            // Assert
            const int expectedPower = 126;
            const int expectedPrecision = 85;
            const int expectedFerocity = 85;
            Assert.AreEqual(expectedPower, actual.Power);
            Assert.AreEqual(expectedPrecision, actual.Precision);
            Assert.AreEqual(expectedFerocity, actual.Ferocity);
        }

        [Test]
        public void VipersRing_HasExpectedValues()
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
            var actual = new Ring(attributes);

            // Assert
            const int expectedPower = 106;
            const int expectedConditionDamage = 106;
            const int expectedPrecision = 56;
            const int expectedExpertise = 56;
            Assert.AreEqual(expectedPower, actual.Power);
            Assert.AreEqual(expectedConditionDamage, actual.ConditionDamage);
            Assert.AreEqual(expectedPrecision, actual.Precision);
            Assert.AreEqual(expectedExpertise, actual.Expertise);
        }
    }
}
