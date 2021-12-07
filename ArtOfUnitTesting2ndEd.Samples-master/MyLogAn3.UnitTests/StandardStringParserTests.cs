using NUnit.Framework;

namespace MyLogAn3.UnitTests
{
    [TestFixture]
    public class StandardStringParserTests : TemplateStringParserTests
    {
        private IStringParser GetParser(string input)
        {
            return new StandardStringParser(input);
        }

        [Test]
        public override void TestGetStringVersionFromHeader_SingleDigit_Found()
        {
            var parser = GetParser("header;version=1;\n");

            var versionFromHeader = parser.GetStringVersionFromHeader();

            Assert.AreEqual("1", versionFromHeader);
        }

        [Test]
        public override void TestGetStringVersionFromHeader_WithMinorVersion_Found()
        {
            var parser = GetParser("header;version=1.1;\n");

            var versionFromHeader = parser.GetStringVersionFromHeader();

            Assert.AreEqual("1.1", versionFromHeader);
        }

        [Test]
        public override void TestGetStringVersionFromHeader_WithRevision_Found()
        {
            var parser = GetParser("header;version=1.1.1;\n");

            var versionFromHeader = parser.GetStringVersionFromHeader();

            Assert.AreEqual("1.1.1", versionFromHeader);
        }
    }
}
