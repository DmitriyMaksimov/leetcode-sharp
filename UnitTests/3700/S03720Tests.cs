using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03720))]
public class S03720Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03720();
        Assert.That(sut.LexGreaterPermutation("abc", "bba"), Is.EqualTo("bca"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03720();
        Assert.That(sut.LexGreaterPermutation("leet", "code"), Is.EqualTo("eelt"));
    }

    [Test]
    public void T3()
    {
        var sut = new S03720();
        Assert.That(sut.LexGreaterPermutation("baba", "bbaa"), Is.EqualTo(""));
    }
}