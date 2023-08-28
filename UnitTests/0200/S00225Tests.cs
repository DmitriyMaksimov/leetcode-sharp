using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00225Tests
{
    [Test]
    public void T1()
    {
        var myStack = new S00225.MyStack();
        myStack.Push(1);
        myStack.Push(2);
        myStack.Top().Should().Be(2);
        myStack.Pop().Should().Be(2);
        myStack.Empty().Should().BeFalse();
    }
}