using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03660))]
public class S03660Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03660();
        Assert.That(sut.MaxValue([2, 1, 3]), Is.EqualTo([2, 2, 3]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03660();
        Assert.That(sut.MaxValue([2, 3, 1]), Is.EqualTo([3, 3, 3]));
    }
}