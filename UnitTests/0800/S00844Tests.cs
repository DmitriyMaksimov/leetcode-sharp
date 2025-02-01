using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00844Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00844();
        Assert.That(sut.BackspaceCompare("ab#c", "ad#c"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00844();
        Assert.That(sut.BackspaceCompare("ab##", "c#d#"), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S00844();
        Assert.That(sut.BackspaceCompare("a#c", "b"), Is.False);
    }
}
