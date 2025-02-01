using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03370Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03370();
        Assert.That(sut.SmallestNumber(5), Is.EqualTo(7));
    }

    [Test]
    public void T2()
    {
        var sut = new S03370();
        Assert.That(sut.SmallestNumber(10), Is.EqualTo(15));
    }

    [Test]
    public void T3()
    {
        var sut = new S03370();
        Assert.That(sut.SmallestNumber(3), Is.EqualTo(3));
    }

    [Test]
    public void T4()
    {
        var sut = new S03370();
        Assert.That(sut.SmallestNumber(4), Is.EqualTo(7));
    }
}
