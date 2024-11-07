using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00692Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00692();
        sut.TopKFrequent(["i", "love", "leetcode", "i", "love", "coding"], 2).Should().Equal("i", "love");
    }

    [Test]
    public void T2()
    {
        var sut = new S00692();
        sut.TopKFrequent(["the", "day", "is", "sunny", "the", "the", "the", "sunny", "is", "is"], 4).Should().Equal("the", "is", "sunny", "day");
    }
}
