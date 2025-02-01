using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03217Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03217();
        Assert.That(sut.ModifiedList([1, 2, 3], ListNode.Parse("[1,2,3,4,5]")).AsString(), Is.EqualTo("[4,5]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03217();
        Assert.That(sut.ModifiedList([1], ListNode.Parse("[1,2,1,2,1,2]")).AsString(), Is.EqualTo("[2,2,2]"));
    }

    [Test]
    public void T3()
    {
        var sut = new S03217();
        Assert.That(sut.ModifiedList([5], ListNode.Parse("[1,2,3,4]")).AsString(), Is.EqualTo("[1,2,3,4]"));
    }
}
