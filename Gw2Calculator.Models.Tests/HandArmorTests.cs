using System.Collections.Generic;
using NUnit.Framework;

namespace Gw2Calculator.Models.Tests
{
    [TestFixture]
    public class HandArmorTests
    {
        [Test]
        public void BerserkersHands_HasExpectedValues()
        {
            // Arrange
            var multipliers = new List<AttributeMultiplier>
            {
                new AttributeMultiplier("Power", .35m),
                new AttributeMultiplier("Precision", .25m),
                new AttributeMultiplier("Ferocity", .25m)
            };

            // Act
            var actual = new HandArmor(multipliers);

            // Assert
            const int expectedPower = 47;
            const int expectedPrecision = 34;
            const int expectedFerocity = 34;
            Assert.AreEqual(expectedPower, actual.Power);
            Assert.AreEqual(expectedPrecision, actual.Precision);
            Assert.AreEqual(expectedFerocity, actual.Ferocity);
        }

        [Test]
        public void VipersHands_HasExpectedValues()
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
            var actual = new HandArmor(multipliers);

            // Assert
            const int expectedPower = 40;
            const int expectedConditionDamage = 40;
            const int expectedPrecision = 22;
            const int expectedExpertise = 22;
            Assert.AreEqual(expectedPower, actual.Power);
            Assert.AreEqual(expectedConditionDamage, actual.ConditionDamage);
            Assert.AreEqual(expectedPrecision, actual.Precision);
            Assert.AreEqual(expectedExpertise, actual.Expertise);
        }
    }
}
