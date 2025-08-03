using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00150Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00150();

        Assert.That(sut.EvalRPN(["2", "1", "+", "3", "*"]), Is.EqualTo(9));
    }

    [Test]
    public void T2()
    {
        var sut = new S00150();

        Assert.That(sut.EvalRPN(["4", "13", "5", "/", "+"]), Is.EqualTo(6));
    }

    [Test]
    public void T3()
    {
        var sut = new S00150();

        Assert.That(sut.EvalRPN(["10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+"]), Is.EqualTo(22));
    }
}