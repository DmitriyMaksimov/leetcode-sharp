using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02058Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02058();
        Assert.That(sut.NodesBetweenCriticalPoints(ListNode.Parse("[3,1]")), Is.EqualTo((int[]) [-1, -1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02058();
        Assert.That(sut.NodesBetweenCriticalPoints(ListNode.Parse("[5,3,1,2,5,1,2]")), Is.EqualTo((int[]) [1, 3]));
    }

    [Test]
    public void T3()
    {
        var sut = new S02058();
        Assert.That(sut.NodesBetweenCriticalPoints(ListNode.Parse("[1,3,2,2,3,2,2,2,7]")), Is.EqualTo((int[]) [3, 3]));
    }
}