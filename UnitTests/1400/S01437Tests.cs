using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01437Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01437();
        Assert.That(sut.KLengthApart([1, 0, 0, 0, 1, 0, 0, 1], 2), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01437();
        Assert.That(sut.KLengthApart([1, 0, 0, 1, 0, 1], 2), Is.False);
    }
}
