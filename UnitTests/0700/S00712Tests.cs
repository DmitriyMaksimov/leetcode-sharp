using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00712Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00712();
        sut.MinimumDeleteSum("sea", "eat").Should().Be(231);
    }

    [Test]
    public void T2()
    {
        var sut = new S00712();
        sut.MinimumDeleteSum("delete", "leet").Should().Be(403);
    }
}