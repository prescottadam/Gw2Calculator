using System.Collections.Generic;
using NUnit.Framework;

namespace Gw2Calculator.Models.Tests
{
    [TestFixture]
    public class HeadArmorTests
    {
        [Test]
        public void BerserkersHead_HasExpectedValues()
        {
            // Arrange
            var multipliers = new List<AttributeMultiplier>
            {
                new AttributeMultiplier("Power", .35m),
                new AttributeMultiplier("Precision", .25m),
                new AttributeMultiplier("Ferocity", .25m)
            };

            // Act
            var actual = new HeadArmor(multipliers);

            // Assert
            const int expectedPower = 63;
            const int expectedPrecision = 45;
            const int expectedFerocity = 45;
            Assert.AreEqual(expectedPower, actual.Power);
            Assert.AreEqual(expectedPrecision, actual.Precision);
            Assert.AreEqual(expectedFerocity, actual.Ferocity);
        }

        [Test]
        public void VipersHead_HasExpectedValues()
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
            var actual = new HeadArmor(multipliers);

            // Assert
            const int expectedPower = 54;
            const int expectedConditionDamage = 54;
            const int expectedPrecision = 30;
            const int expectedExpertise = 30;
            Assert.AreEqual(expectedPower, actual.Power);
            Assert.AreEqual(expectedConditionDamage, actual.ConditionDamage);
            Assert.AreEqual(expectedPrecision, actual.Precision);
            Assert.AreEqual(expectedExpertise, actual.Expertise);
        }
    }
}
