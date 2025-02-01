using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00237Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00237();
        var list = ListNode.Parse("[4,5,1,9]");
        sut.DeleteNode(list!.next!);
        Assert.That(list.AsString(), Is.EqualTo("[4,1,9]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00237();
        var list = ListNode.Parse("[4,5,1,9]");
        sut.DeleteNode(list!.next!.next!);
        Assert.That(list.AsString(), Is.EqualTo("[4,5,9]"));
    }
}