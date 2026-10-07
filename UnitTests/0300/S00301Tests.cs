using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S00301))]
public class S00301Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00301();
        Assert.That(sut.RemoveInvalidParentheses("()())()"), Is.EqualTo(["(())()", "()()()"]
        ));
    }

    [Test]
    public void T2()
    {
        var sut = new S00301();
        Assert.That(sut.RemoveInvalidParentheses("(a)())()"), Is.EqualTo(["(a())()", "(a)()()"]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00301();
        Assert.That(sut.RemoveInvalidParentheses(")("), Is.EqualTo([""]));
    }
}