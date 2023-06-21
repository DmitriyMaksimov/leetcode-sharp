using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01941Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01941();
        sut.AreOccurrencesEqual("abacbc").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S01941();
        sut.AreOccurrencesEqual("aaabb").Should().BeFalse();
    }
}