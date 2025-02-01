using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01704Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S01704();
        Assert.That(sut.HalvesAreAlike("book"), Is.True);
    }
}
