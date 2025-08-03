using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02558Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02558();
        Assert.That(sut.PickGifts([25, 64, 9, 4, 100], 4), Is.EqualTo(29));
    }

    [Test]
    public void T2()
    {
        var sut = new S02558();
        Assert.That(sut.PickGifts([1, 1, 1, 1], 4), Is.EqualTo(4));
    }
}