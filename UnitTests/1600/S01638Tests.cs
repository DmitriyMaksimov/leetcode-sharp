using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01638Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01638();
        sut.CountSubstrings("aba", "baba").Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S01638();
        sut.CountSubstrings("ab", "bb").Should().Be(3);
    }
}