using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01021Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01021();
        sut.RemoveOuterParentheses("(()())(())").Should().Be("()()()");
    }
    
    [Test]
    public void T2()
    {
        var sut = new S01021();
        sut.RemoveOuterParentheses("(()())(())(()(()))").Should().Be("()()()()(())");
    }

    [Test]
    public void T3()
    {
        var sut = new S01021();
        sut.RemoveOuterParentheses("()()").Should().Be("");
    }
}