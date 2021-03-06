﻿using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Gw2Calculator.Gw2Api.Tests
{
    [TestFixture]
    public class ItemStatsClientTests
    {
        private ItemStatsClient _target;

        [SetUp]
        public void SetUp()
        {
            _target = new ItemStatsClient();
        }

        [Test]
        public async Task GetItemStatsAsync_ReturnsListOfItemStats()
        {
            // Arrange

            // Act
            var actual = await _target.GetItemStatsAsync();

            // Assert
            Assert.IsTrue(actual.Any(x => x.Name == "Berserker's"));
            Assert.IsTrue(actual.Any(x => x.Name == "Viper's"));
        }
    }
}
