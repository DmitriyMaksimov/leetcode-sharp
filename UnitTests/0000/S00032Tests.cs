using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00032Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00032();
        Assert.That(sut.LongestValidParentheses("(()"), Is.EqualTo(2));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00032();
        Assert.That(sut.LongestValidParentheses(")()())"), Is.EqualTo(4));
    }

    [Test]
    public void T3()
    {
        var sut = new S00032();
        Assert.That(sut.LongestValidParentheses(""), Is.EqualTo(0));
    }

}