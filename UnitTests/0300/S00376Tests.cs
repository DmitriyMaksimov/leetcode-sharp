using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00376Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00376();
        Assert.That(sut.WiggleMaxLength([1, 7, 4, 9, 2, 5]), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S00376();
        Assert.That(sut.WiggleMaxLength([1, 17, 5, 10, 13, 15, 10, 5, 16, 8]), Is.EqualTo(7));
    }

    [Test]
    public void T3()
    {
        var sut = new S00376();
        Assert.That(sut.WiggleMaxLength([1, 2, 3, 4, 5, 6, 7, 8, 9]), Is.EqualTo(2));
    }
}