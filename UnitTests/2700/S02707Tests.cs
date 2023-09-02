using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02707Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02707();
        sut.MinExtraChar("leetscode", new[] {"leet", "code", "leetcode"}).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S02707();
        sut.MinExtraChar("sayhelloworld", new[] {"hello", "world"}).Should().Be(3);
    }
}