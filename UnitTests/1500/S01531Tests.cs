using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01531Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01531();
        sut.GetLengthOfOptimalCompression("aaabcccd", 2).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S01531();
        sut.GetLengthOfOptimalCompression("aabbaa", 2).Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S01531();
        sut.GetLengthOfOptimalCompression("aaaaaaaaaaa", 0).Should().Be(3);
    }
}