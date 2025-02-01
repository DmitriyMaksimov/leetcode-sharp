using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00856Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00856();
        Assert.That(sut.ScoreOfParentheses("()"), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S00856();
        Assert.That(sut.ScoreOfParentheses("(())"), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S00856();
        Assert.That(sut.ScoreOfParentheses("()()"), Is.EqualTo(2));
    }
}
