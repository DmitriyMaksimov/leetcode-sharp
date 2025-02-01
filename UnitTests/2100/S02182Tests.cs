using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02182Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02182();
        Assert.That(sut.RepeatLimitedString("cczazcc", 3), Is.EqualTo("zzcccac"));
    }

    [Test]
    public void T2()
    {
        var sut = new S02182();
        Assert.That(sut.RepeatLimitedString("aababab", 2), Is.EqualTo("bbabaa"));
    }
}
