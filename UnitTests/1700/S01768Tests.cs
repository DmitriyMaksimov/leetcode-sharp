using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01768Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01768();
        sut.MergeAlternately("abc", "pqr").Should().Be("apbqcr");
    }
    [Test]
    public void T2()
    {
        var sut = new S01768();
        sut.MergeAlternately("ab", "pqrs").Should().Be("apbqrs");
    }

    [Test]
    public void T3()
    {
        var sut = new S01768();
        sut.MergeAlternately("abcd", "pq").Should().Be("apbqcd");
    }
}