using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00190Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00190();
        Assert.That(sut.ReverseBits(43261596), Is.EqualTo(964176192));
    }

    [Test]
    public void T2()
    {
        var sut = new S00190();
        Assert.That(sut.ReverseBits(2147483644), Is.EqualTo(1073741822));
    }
}