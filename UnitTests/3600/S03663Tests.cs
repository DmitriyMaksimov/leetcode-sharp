using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03663))]
public class S03663Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03663();
        Assert.That(sut.GetLeastFrequentDigit(1553322), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S03663();
        Assert.That(sut.GetLeastFrequentDigit(723344511), Is.EqualTo(2));
    }
}