using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01781Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01781();
        Assert.That(sut.BeautySum("aabcb"), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S01781();
        Assert.That(sut.BeautySum("aabcbaa"), Is.EqualTo(17));
    }
}
