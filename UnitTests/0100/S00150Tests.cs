using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00150Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00150();

        sut.EvalRPN(new[] {"2", "1", "+", "3", "*"}).Should().Be(9);
    }

    [Test]
    public void T2()
    {
        var sut = new S00150();

        sut.EvalRPN(new[] {"4", "13", "5", "/", "+"}).Should().Be(6);
    }

    [Test]
    public void T3()
    {
        var sut = new S00150();

        sut.EvalRPN(new[] {"10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+"}).Should().Be(22);
    }
}