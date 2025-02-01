using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00451Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S00451();
        Assert.That(sut.FrequencySort("tree"), Is.AnyOf("eert", "eetr"));
    }
}