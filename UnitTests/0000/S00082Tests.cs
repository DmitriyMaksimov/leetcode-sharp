using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00082Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00082();
        Assert.That(sut.DeleteDuplicates(ListNode.Parse("[1,2,3,3,4,4,5]")).AsString(), Is.EqualTo("[1,2,5]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00082();
        Assert.That(sut.DeleteDuplicates(ListNode.Parse("[1,1,1,2,3]")).AsString(), Is.EqualTo("[2,3]"));
    }
}