using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00712Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00712();
        Assert.That(sut.MinimumDeleteSum("sea", "eat"), Is.EqualTo(231));
    }

    [Test]
    public void T2()
    {
        var sut = new S00712();
        Assert.That(sut.MinimumDeleteSum("delete", "leet"), Is.EqualTo(403));
    }
}