using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01370Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01370();
        sut.SortString("aaaabbbbcccc").Should().Be("abccbaabccba");
    }

    [Test]
    public void T2()
    {
        var sut = new S01370();
        sut.SortString("rat").Should().Be("art");
    }
}