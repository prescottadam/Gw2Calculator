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
            var attributes = new List<ItemStatAttribute>
            {
                new ItemStatAttribute("Power", .35m),
                new ItemStatAttribute("Precision", .25m),
                new ItemStatAttribute("Ferocity", .25m)
            };

            // Act
            var actual = new ChestArmor(attributes);

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
            var attributes = new List<ItemStatAttribute>
            {
                new ItemStatAttribute("Power", .3m),
                new ItemStatAttribute("ConditionDamage", .3m),
                new ItemStatAttribute("Precision", .165m),
                new ItemStatAttribute("Expertise", .165m)
            };

            // Act
            var actual = new ChestArmor(attributes);

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
