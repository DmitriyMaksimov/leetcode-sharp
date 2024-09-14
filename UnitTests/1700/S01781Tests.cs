using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01781Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01781();
        sut.BeautySum("aabcb").Should().Be(5);
    }

    [Test]
    public void T2()
    {
        var sut = new S01781();
        sut.BeautySum("aabcbaa").Should().Be(17);
    }
}
