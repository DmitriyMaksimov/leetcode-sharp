using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03300Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03300();
        Assert.That(sut.MinElement([10, 12, 13, 14]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S03300();
        Assert.That(sut.MinElement([1, 2, 3, 4]), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S03300();
        Assert.That(sut.MinElement([999, 19, 199]), Is.EqualTo(10));
    }
}
