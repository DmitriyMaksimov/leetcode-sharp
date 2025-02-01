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
        Assert.That(minStack.GetMin(), Is.EqualTo(-3));
        minStack.Pop();
        Assert.That(minStack.Top(), Is.EqualTo(0));
        Assert.That(minStack.GetMin(), Is.EqualTo(-2));
    }
}