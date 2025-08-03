using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00414Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00414();
        Assert.That(sut.ThirdMax([3, 2, 1]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S00414();
        Assert.That(sut.ThirdMax([1, 2]), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S00414();
        Assert.That(sut.ThirdMax([2, 2, 3, 1]), Is.EqualTo(1));
    }

    [Test]
    public void T4()
    {
        var sut = new S00414();
        Assert.That(sut.ThirdMax([1, 2, 2, 5, 3, 5]), Is.EqualTo(2));
    }
}