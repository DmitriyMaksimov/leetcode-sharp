using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01531Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01531();
        Assert.That(sut.GetLengthOfOptimalCompression("aaabcccd", 2), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S01531();
        Assert.That(sut.GetLengthOfOptimalCompression("aabbaa", 2), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S01531();
        Assert.That(sut.GetLengthOfOptimalCompression("aaaaaaaaaaa", 0), Is.EqualTo(3));
    }
}