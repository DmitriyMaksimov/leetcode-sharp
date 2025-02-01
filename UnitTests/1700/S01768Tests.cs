using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01768Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01768();
        Assert.That(sut.MergeAlternately("abc", "pqr"), Is.EqualTo("apbqcr"));
    }
    [Test]
    public void T2()
    {
        var sut = new S01768();
        Assert.That(sut.MergeAlternately("ab", "pqrs"), Is.EqualTo("apbqrs"));
    }

    [Test]
    public void T3()
    {
        var sut = new S01768();
        Assert.That(sut.MergeAlternately("abcd", "pq"), Is.EqualTo("apbqcd"));
    }
}