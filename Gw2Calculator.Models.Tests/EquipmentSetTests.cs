using System.Collections.Generic;
using NUnit.Framework;

namespace Gw2Calculator.Models.Tests
{
    [TestFixture]
    public class EquipmentSetTests
    {
        [Test]
        public void BerserkersSet_HasExpectedValues()
        {
            // Arrange
            var attributes = new List<ItemStatAttribute>
            {
                new ItemStatAttribute("Power", .35m),
                new ItemStatAttribute("Precision", .25m),
                new ItemStatAttribute("Ferocity", .25m)
            };

            // Act
            var equipmentSet = new EquipmentSet
            {
                HeadSlot = new HeadArmor(attributes),
                ShoulderSlot = new ShoulderArmor(attributes),
                ChestSlot = new ChestArmor(attributes),
                HandSlot = new HandArmor(attributes),
                LegSlot = new LegArmor(attributes),
                FeetSlot = new FeetArmor(attributes),
                BackSlot = new BackItem(attributes),
                AccessorySlot1 = new Accessory(attributes),
                AccessorySlot2 = new Accessory(attributes),
                AmuletSlot = new Amulet(attributes),
                RingSlot1 = new Ring(attributes),
                RingSlot2 = new Ring(attributes)
            };

            // Assert
            const int expectedPower = 1131;
            const int expectedPrecision = 781;
            const int expectedFerocity = 781;
            Assert.AreEqual(expectedPower, equipmentSet.Power);
            Assert.AreEqual(expectedPrecision, equipmentSet.Precision);
            Assert.AreEqual(expectedFerocity, equipmentSet.Ferocity);
        }

        [Test]
        public void VipersSet_HasExpectedValues()
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
            var equipmentSet = new EquipmentSet
            {
                HeadSlot = new HeadArmor(attributes),
                ShoulderSlot = new ShoulderArmor(attributes),
                ChestSlot = new ChestArmor(attributes),
                HandSlot = new HandArmor(attributes),
                LegSlot = new LegArmor(attributes),
                FeetSlot = new FeetArmor(attributes),
                BackSlot = new BackItem(attributes),
                AccessorySlot1 = new Accessory(attributes),
                AccessorySlot2 = new Accessory(attributes),
                AmuletSlot = new Amulet(attributes),
                RingSlot1 = new Ring(attributes),
                RingSlot2 = new Ring(attributes)
            };

            // Assert
            const int expectedPower = 957;
            const int expectedConditionDamage = 957;
            const int expectedPrecision = 515;
            const int expectedExpertise = 515;
            Assert.AreEqual(expectedPower, equipmentSet.Power);
            Assert.AreEqual(expectedConditionDamage, equipmentSet.ConditionDamage);
            Assert.AreEqual(expectedPrecision, equipmentSet.Precision);
            Assert.AreEqual(expectedExpertise, equipmentSet.Expertise);
        }
    }
}
