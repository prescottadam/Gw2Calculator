using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Gw2Calculator.Gw2Api.Tests
{
    [TestFixture]
    public class ProfessionsClientTests
    {
        private const string _apiKey = "";
        private ProfessionsClient _target;

        [SetUp]
        public void SetUp()
        {
            _target = new ProfessionsClient(_apiKey);
        }

        [Test]
        public async Task GetProfessions_ReturnsListOfProfessions()
        {
            // Arrange

            // Act
            var actual = await _target.GetProfessionsAsync();

            // Assert
            const int expected = 9;
            Assert.AreEqual(expected, actual.Count());
        }

        [Test]
        public async Task GetSkills_ReturnsListOfSkills()
        {
            // Arrange
            const string profession = "Ranger";

            // Act
            var actual = await _target.GetSkillsAsync(profession);

            // Assert
            Assert.IsTrue(actual.Any(x => x.Type == "Heal"));
            Assert.IsTrue(actual.Any(x => x.Type == "Utility"));
            Assert.IsTrue(actual.Any(x => x.Type == "Elite"));
        }
    }
}
