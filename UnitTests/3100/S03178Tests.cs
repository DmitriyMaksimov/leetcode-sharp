using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03178Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03178();
        Assert.That(sut.NumberOfChild(2, 5), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S03178();
        Assert.That(sut.NumberOfChild(5, 6), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S03178();
        Assert.That(sut.NumberOfChild(4, 2), Is.EqualTo(2));
    }
}