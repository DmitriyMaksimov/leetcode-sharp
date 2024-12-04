using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02182Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02182();
        sut.RepeatLimitedString("cczazcc", 3).Should().Be("zzcccac");
    }

    [Test]
    public void T2()
    {
        var sut = new S02182();
        sut.RepeatLimitedString("aababab", 2).Should().Be("bbabaa");
    }
}
