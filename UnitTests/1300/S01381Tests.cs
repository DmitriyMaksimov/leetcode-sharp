using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01381Tests
{
    [Test]
    public void T1()
    {
        var stk = new S01381.CustomStack(3);
        stk.Push(1); // stack becomes [1]
        stk.Push(2); // stack becomes [1, 2]
        Assert.That(stk.Pop(), Is.EqualTo(2)); // return 2 --> Return top of the stack 2, stack becomes [1]
        stk.Push(2); // stack becomes [1, 2]
        stk.Push(3); // stack becomes [1, 2, 3]
        stk.Push(4); // stack still [1, 2, 3], Do not add another elements as size is 4
        stk.Increment(5, 100); // stack becomes [101, 102, 103]
        stk.Increment(2, 100); // stack becomes [201, 202, 103]
        Assert.That(stk.Pop(), Is.EqualTo(103)); // return 103 --> Return top of the stack 103, stack becomes [201, 202]
        Assert.That(stk.Pop(), Is.EqualTo(202)); // return 202 --> Return top of the stack 202, stack becomes [201]
        Assert.That(stk.Pop(), Is.EqualTo(201)); // return 201 --> Return top of the stack 201, stack becomes []
        Assert.That(stk.Pop(), Is.EqualTo(-1)); // return -1 --> Stack is empty return -1.
    }
}