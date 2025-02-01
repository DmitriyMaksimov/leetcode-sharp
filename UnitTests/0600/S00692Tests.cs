using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00692Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00692();
        Assert.That(sut.TopKFrequent(["i", "love", "leetcode", "i", "love", "coding"], 2), Is.EqualTo((string[]) ["i", "love"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00692();
        Assert.That(sut.TopKFrequent(["the", "day", "is", "sunny", "the", "the", "the", "sunny", "is", "is"], 4), Is.EqualTo((string[]) ["the", "is", "sunny", "day"]));
    }
}
