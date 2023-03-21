using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00997Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00997();
        sut.FindJudge(2, new[] {new[] {1, 2}}).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00997();
        sut.FindJudge(3, new[] {new[] {1, 3}, new[] {2, 3}}).Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S00997();
        sut.FindJudge(3, new[] {new[] {1, 3}, new[] {2, 3}, new[] {3, 1}}).Should().Be(-1);
    }
}