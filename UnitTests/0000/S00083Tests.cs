using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00083Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00083();
        Assert.That(sut.DeleteDuplicates(ListNode.Parse("[1,1,2]")).AsString(), Is.EqualTo("[1,2]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00083();
        Assert.That(sut.DeleteDuplicates(ListNode.Parse("[1,1,2,3,3]")).AsString(), Is.EqualTo("[1,2,3]"));
    }
}