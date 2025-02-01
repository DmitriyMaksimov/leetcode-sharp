using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01784Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01784();
        Assert.That(sut.CheckOnesSegment("1001"), Is.False);
    }

    [Test]
    public void T2()
    {
        var sut = new S01784();
        Assert.That(sut.CheckOnesSegment("110"), Is.True);
    }
}
