using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00024Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00024();
        Assert.That(sut.SwapPairs(ListNode.Parse("[1,2,3,4]")).AsString(), Is.EqualTo("[2,1,4,3]"));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00024();
        Assert.That(sut.SwapPairs(ListNode.Parse("[1]")).AsString(), Is.EqualTo("[1]"));
    }

    [Test]
    public void T3()
    {
        var sut = new S00024();
        Assert.That(sut.SwapPairs(null).AsString(), Is.EqualTo("[]"));
    }
}