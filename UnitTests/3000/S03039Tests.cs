using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03039Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03039();
        sut.LastNonEmptyString("aabcbbca").Should().Be("ba");
    }

    [Test]
    public void T2()
    {
        var sut = new S03039();
        sut.LastNonEmptyString("abcd").Should().Be("abcd");
    }
}
