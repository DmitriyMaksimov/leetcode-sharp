using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00451UnitTests
{
    [Test]
    public void Test1()
    {
        var sut = new S00451();
        sut.FrequencySort("tree").Should().BeOneOf("eert", "eetr");
    }
}