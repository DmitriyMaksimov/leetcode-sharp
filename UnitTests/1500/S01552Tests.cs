using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01552Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01552();
        Assert.That(sut.MaxDistance([1, 2, 3, 4, 7], 3), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01552();
        Assert.That(sut.MaxDistance([5, 4, 3, 2, 1, 1000000000], 2), Is.EqualTo(999999999));
    }
}