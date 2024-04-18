using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03110Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03110();
        sut.ScoreOfString("hello").Should().Be(13);
    }

    [Test]
    public void T2()
    {
        var sut = new S03110();
        sut.ScoreOfString("zaz").Should().Be(50);
    }
}