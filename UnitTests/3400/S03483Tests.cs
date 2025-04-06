using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03483Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03483();
        Assert.That(sut.TotalNumbers([1, 2, 3, 4]), Is.EqualTo(12));
    }

    [Test]
    public void T2()
    {
        var sut = new S03483();
        Assert.That(sut.TotalNumbers([0, 2, 2]), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S03483();
        Assert.That(sut.TotalNumbers([6, 6, 6]), Is.EqualTo(1));
    }
}
