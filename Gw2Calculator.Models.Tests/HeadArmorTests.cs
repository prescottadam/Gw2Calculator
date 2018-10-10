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
            var attributes = new List<ItemStatAttribute>
            {
                new ItemStatAttribute("Power", .35m),
                new ItemStatAttribute("Precision", .25m),
                new ItemStatAttribute("Ferocity", .25m)
            };

            // Act
            var actual = new HeadArmor(attributes);

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
            var attributes = new List<ItemStatAttribute>
            {
                new ItemStatAttribute("Power", .3m),
                new ItemStatAttribute("ConditionDamage", .3m),
                new ItemStatAttribute("Precision", .165m),
                new ItemStatAttribute("Expertise", .165m)
            };

            // Act
            var actual = new HeadArmor(attributes);

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
