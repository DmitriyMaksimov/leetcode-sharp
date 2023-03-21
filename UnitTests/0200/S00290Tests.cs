using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00290Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00290();
        sut.WordPattern("abba", "dog cat cat dog").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00290();
        sut.WordPattern("abba", "dog cat cat fish").Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S00290();
        sut.WordPattern("aaaa", "dog cat cat dog").Should().BeFalse();
    }

    [Test]
    public void T4()
    {
        var sut = new S00290();
        sut.WordPattern("abba", "dog dog dog dog").Should().BeFalse();
    }

    [Test]
    public void T5()
    {
        var sut = new S00290();
        sut.WordPattern("aaa", "aa aa aa aa").Should().BeFalse();
    }
}