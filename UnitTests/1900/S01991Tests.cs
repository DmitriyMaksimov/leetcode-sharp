using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01991Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01991();
        Assert.That(sut.FindMiddleIndex([2, 3, -1, 8, 4]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01991();
        Assert.That(sut.FindMiddleIndex([1, -1, 4]), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S01991();
        Assert.That(sut.FindMiddleIndex([2, 5]), Is.EqualTo(-1));
    }
}