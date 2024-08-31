using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03271Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03271();
        sut.StringHash("abcd", 2).Should().Be("bf");
    }

    [Test]
    public void T2()
    {
        var sut = new S03271();
        sut.StringHash("mxz", 3).Should().Be("i");
    }
}
