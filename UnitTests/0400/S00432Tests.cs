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
        sut.GetMaxKey().Should().Be("hello");
        sut.GetMinKey().Should().Be("hello");
        sut.Inc("leet");
        sut.GetMaxKey().Should().Be("hello");
        sut.GetMinKey().Should().Be("leet");
    }
}
