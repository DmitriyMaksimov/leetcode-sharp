using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00583Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00583();
        Assert.That(sut.MinDistance("sea", "eat"), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00583();
        Assert.That(sut.MinDistance("leetcode", "etco"), Is.EqualTo(4));
    }
}
