using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00155Tests
{
    [Test]
    public void T1()
    {
        var minStack = new S00155.MinStack();
        minStack.Push(-2);
        minStack.Push(0);
        minStack.Push(-3);
        minStack.GetMin().Should().Be(-3);
        minStack.Pop();
        minStack.Top().Should().Be(0);
        minStack.GetMin().Should().Be(-2);
    }
}