using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02270Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02270();
        Assert.That(sut.WaysToSplitArray([10, 4, -8, 7]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02270();
        Assert.That(sut.WaysToSplitArray([2, 3, 1, 0]), Is.EqualTo(2));
    }
}
