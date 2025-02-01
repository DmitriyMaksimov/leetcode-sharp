using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00061Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00061();
        Assert.That(sut.RotateRight(ListNode.Parse("[1,2,3,4,5]"), 2).AsString(), Is.EqualTo("[4,5,1,2,3]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00061();
        Assert.That(sut.RotateRight(ListNode.Parse("[0,1,2]"), 4).AsString(), Is.EqualTo("[2,0,1]"));
    }
}