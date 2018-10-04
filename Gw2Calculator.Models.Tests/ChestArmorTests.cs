using System.Collections.Generic;
using NUnit.Framework;

namespace Gw2Calculator.Models.Tests
{
    [TestFixture]
    public class ChestArmorTests
    {
        [Test]
        public void BerserkersChest_HasExpectedValues()
        {
            // Arrange
            var multipliers = new List<AttributeMultiplier>
            {
                new AttributeMultiplier("Power", .35m),
                new AttributeMultiplier("Precision", .25m),
                new AttributeMultiplier("Ferocity", .25m)
            };

            // Act
            var actual = new ChestArmor(multipliers);

            // Assert
            const int expectedPower = 141;
            const int expectedPrecision = 101;
            const int expectedFerocity = 101;
            Assert.AreEqual(expectedPower, actual.Power);
            Assert.AreEqual(expectedPrecision, actual.Precision);
            Assert.AreEqual(expectedFerocity, actual.Ferocity);
        }

        [Test]
        public void VipersChest_HasExpectedValues()
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
            var actual = new ChestArmor(multipliers);

            // Assert
            const int expectedPower = 121;
            const int expectedConditionDamage = 121;
            const int expectedPrecision = 67;
            const int expectedExpertise = 67;
            Assert.AreEqual(expectedPower, actual.Power);
            Assert.AreEqual(expectedConditionDamage, actual.ConditionDamage);
            Assert.AreEqual(expectedPrecision, actual.Precision);
            Assert.AreEqual(expectedExpertise, actual.Expertise);
        }
    }
}
