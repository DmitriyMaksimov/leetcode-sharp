using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00432Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00432.AllOne();
        sut.Inc("hello");
        sut.Inc("hello");
        Assert.That(sut.GetMaxKey(), Is.EqualTo("hello"));
        Assert.That(sut.GetMinKey(), Is.EqualTo("hello"));
        sut.Inc("leet");
        Assert.That(sut.GetMaxKey(), Is.EqualTo("hello"));
        Assert.That(sut.GetMinKey(), Is.EqualTo("leet"));
    }
}
