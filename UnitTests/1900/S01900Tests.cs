using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01900))]
public class S01900Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01900();
        Assert.That(sut.EarliestAndLatest(11, 2, 4), Is.EqualTo([3, 4]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01900();
        Assert.That(sut.EarliestAndLatest(5, 1, 5), Is.EqualTo([1, 1]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01900();
        Assert.That(sut.EarliestAndLatest(5, 1, 4), Is.EqualTo([2, 2]));
    }
}