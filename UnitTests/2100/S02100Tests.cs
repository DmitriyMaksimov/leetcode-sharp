using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02100Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02100();
        Assert.That(sut.GoodDaysToRobBank([5, 3, 3, 3, 5, 6, 2], 2), Is.EqualTo([2, 3]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02100();
        Assert.That(sut.GoodDaysToRobBank([1, 1, 1, 1, 1], 0), Is.EqualTo([0, 1, 2, 3, 4]));
    }

    [Test]
    public void T3()
    {
        var sut = new S02100();
        Assert.That(sut.GoodDaysToRobBank([1, 2, 3, 4, 5, 6], 2), Is.Empty);
    }
}
