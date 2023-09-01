using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00541Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00541();
        sut.ReverseStr("abcdefg", 2).Should().Be("bacdfeg");
    }

    [Test]
    public void T2()
    {
        var sut = new S00541();
        sut.ReverseStr("abcd", 2).Should().Be("bacd");
    }

    [Test]
    public void T3()
    {
        var sut = new S00541();
        sut.ReverseStr("abcd", 4).Should().Be("dcba");
    }
}