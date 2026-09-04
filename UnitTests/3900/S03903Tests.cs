using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03903))]
public class S03903Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03903();
        Assert.That(sut.FirstStableIndex([5, 0, 1, 4], 3), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03903();
        Assert.That(sut.FirstStableIndex([3, 2, 1], 1), Is.EqualTo(-1));
    }

    [Test]
    public void T3()
    {
        var sut = new S03903();
        Assert.That(sut.FirstStableIndex([0], 0), Is.EqualTo(0));
    }
}