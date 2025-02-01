using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01941Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01941();
        Assert.That(sut.AreOccurrencesEqual("abacbc"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01941();
        Assert.That(sut.AreOccurrencesEqual("aaabb"), Is.False);
    }
}
