using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03536))]
public class S03536Test
{
    [Test]
    public void T1()
    {
        var sut = new S03536();
        Assert.That(sut.MaxProduct(31), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03536();
        Assert.That(sut.MaxProduct(22), Is.EqualTo(4));
    }

    [Test]
    public void T3()
    {
        var sut = new S03536();
        Assert.That(sut.MaxProduct(124), Is.EqualTo(8));
    }
}
