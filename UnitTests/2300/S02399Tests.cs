using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02399Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02399();
        Assert.That(sut.CheckDistances("abaccb",
            new[] {1, 3, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S02399();
        Assert.That(sut.CheckDistances("aa",
            new[] {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}), Is.False);
    }
}
