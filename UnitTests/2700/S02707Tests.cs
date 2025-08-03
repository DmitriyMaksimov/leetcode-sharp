using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02707Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02707();
        Assert.That(sut.MinExtraChar("leetscode", ["leet", "code", "leetcode"]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S02707();
        Assert.That(sut.MinExtraChar("sayhelloworld", ["hello", "world"]), Is.EqualTo(3));
    }
}