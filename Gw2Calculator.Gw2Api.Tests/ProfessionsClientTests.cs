using System.Linq;
using System.Threading.Tasks;
using Gw2Calculator.Models;
using NUnit.Framework;

namespace Gw2Calculator.Gw2Api.Tests
{
    [TestFixture]
    public class ProfessionsClientTests
    {
        private ProfessionsClient _target;

        [SetUp]
        public void SetUp()
        {
            _target = new ProfessionsClient();
        }

        [Test]
        public async Task GetProfessionsAsync_ReturnsListOfProfessions()
        {
            // Arrange

            // Act
            var actual = await _target.GetProfessionsAsync();

            // Assert
            const int expected = 9;
            Assert.AreEqual(expected, actual.Count());
        }

        [Test]
        public async Task GetSkillsAsync_ReturnsListOfSkills()
        {
            // Arrange
            const string profession = "Ranger";

            // Act
            var actual = await _target.GetSkillsAsync(profession);

            // Assert
            Assert.IsTrue(actual.Any(x => x.Type == SkillTypeEnum.Heal));
            Assert.IsTrue(actual.Any(x => x.Type == SkillTypeEnum.Utility));
            Assert.IsTrue(actual.Any(x => x.Type == SkillTypeEnum.Elite));
        }
    }
}
