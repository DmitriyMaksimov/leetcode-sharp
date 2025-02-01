using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02849Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02849();
        Assert.That(sut.IsReachableAtTime(2, 4, 7, 7, 6), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S02849();
        Assert.That(sut.IsReachableAtTime(3, 1, 7, 3, 3), Is.False);
    }
}
