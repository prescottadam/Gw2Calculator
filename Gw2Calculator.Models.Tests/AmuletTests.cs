using System.Collections.Generic;
using NUnit.Framework;

namespace Gw2Calculator.Models.Tests
{
    [TestFixture]
    public class AmuletTests
    {
        [Test]
        public void BerserkersAmulet_HasExpectedValues()
        {
            // Arrange
            var multipliers = new List<AttributeMultiplier>
            {
                new AttributeMultiplier("Power", .35m),
                new AttributeMultiplier("Precision", .25m),
                new AttributeMultiplier("Ferocity", .25m)
            };

            // Act
            var actual = new Amulet(multipliers);

            // Assert
            const int expectedPower = 157;
            const int expectedPrecision = 108;
            const int expectedFerocity = 108;
            Assert.AreEqual(expectedPower, actual.Power);
            Assert.AreEqual(expectedPrecision, actual.Precision);
            Assert.AreEqual(expectedFerocity, actual.Ferocity);
        }

        [Test]
        public void VipersAmulet_HasExpectedValues()
        {
            // Arrange
            var multipliers = new List<AttributeMultiplier>
            {
                new AttributeMultiplier("Power", .3m),
                new AttributeMultiplier("ConditionDamage", .3m),
                new AttributeMultiplier("Precision", .165m),
                new AttributeMultiplier("Expertise", .165m)
            };

            // Act
            var actual = new Amulet(multipliers);

            // Assert
            const int expectedPower = 133;
            const int expectedConditionDamage = 133;
            const int expectedPrecision = 71;
            const int expectedExpertise = 71;
            Assert.AreEqual(expectedPower, actual.Power);
            Assert.AreEqual(expectedConditionDamage, actual.ConditionDamage);
            Assert.AreEqual(expectedPrecision, actual.Precision);
            Assert.AreEqual(expectedExpertise, actual.Expertise);
        }
    }
}
