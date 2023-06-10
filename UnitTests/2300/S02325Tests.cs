using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02325Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02325();
        sut.DecodeMessage("the quick brown fox jumps over the lazy dog", "vkbs bs t suepuv").Should().Be("this is a secret");
    }

    [Test]
    public void T2()
    {
        var sut = new S02325();
        sut.DecodeMessage("eljuxhpwnyrdgtqkviszcfmabo", "zwx hnfx lqantp mnoeius ycgk vcnjrdb").Should().Be("the five boxing wizards jump quickly");
    }
}