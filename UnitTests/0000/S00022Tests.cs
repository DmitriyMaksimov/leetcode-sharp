using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00022Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00022();
        Assert.That(sut.GenerateParenthesis(3), Is.EquivalentTo((string[]) ["((()))", "(()())", "(())()", "()(())", "()()()"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00022();
        Assert.That(sut.GenerateParenthesis(1), Is.EquivalentTo((string[]) ["()"]));
    }
}
