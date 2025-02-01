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
        Assert.That(myStack.Top(), Is.EqualTo(2));
        Assert.That(myStack.Pop(), Is.EqualTo(2));
        Assert.That(myStack.Empty(), Is.False);
    }
}
