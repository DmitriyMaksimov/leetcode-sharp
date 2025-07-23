using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03295))]
public class S03295Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03295();
        Assert.That(sut.ReportSpam(["hello", "world", "leetcode"], ["world", "hello"]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S03295();
        Assert.That(sut.ReportSpam(["hello", "programming", "fun"], ["world", "programming", "leetcode"]), Is.False);
    }
}