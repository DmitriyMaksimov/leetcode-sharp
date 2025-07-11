using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03440))]
public class S03440Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03440();
        Assert.That(sut.MaxFreeTime(5, [1, 3], [2, 5]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03440();
        Assert.That(sut.MaxFreeTime(10, [0, 7, 9], [1, 8, 10]), Is.EqualTo(7));
    }

    [Test]
    public void T3()
    {
        var sut = new S03440();
        Assert.That(sut.MaxFreeTime(10, [0, 3, 7, 9], [1, 4, 8, 10]), Is.EqualTo(6));
    }
}